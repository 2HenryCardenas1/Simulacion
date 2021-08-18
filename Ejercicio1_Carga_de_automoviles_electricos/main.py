import simpy


class Car(object):
    def __init__(self, env):
        self.env = env
        # Inicia el proceso de ejecución cada vez que se crea una instancia.
        self.action = env.process(self.run())

    def run(self):
        while True:
            print('Start parking and charging at %d' % env.now)  # aca simulamos el tiempo total de la simulacion
            charge_duration = 5  # tiempo de duracion
            # yield env.timeout(charge_duration)  # yeild es como un return

            # Interrumpir cuando la bateria este cargada
            try:
                yield self.env.process(self.charge(charge_duration))
            except simpy.Interrupt:
                print("Ha sido enterumpida la carga, la bateria esta al 100")

            print('Start driving at %d' % env.now)  # tiempo que se conduce
            trip_duration = 2  # tiempo de duracion
            yield env.timeout(trip_duration)

    def charge(self, duration):
        yield self.env.timeout(duration)

#Metodo que interrumpe a los tres minutos de iniciada la simulacion
def driver(env, car):
    yield env.timeout(3)
    car.action.interrupt()


env = simpy.Environment()  # Creamos el entorno(Inicializamos)
car = Car(env)  # cargamos el entorno
env.process(driver(env, car))
env.run(until=25)  # Corremos la simulacion, simulando 15min
