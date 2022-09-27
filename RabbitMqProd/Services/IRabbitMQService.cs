namespace RabbitMqProd_.Services
{
    public interface IRabbitMQService
    {
        void SendNameToQueue(string name);
    }
}
