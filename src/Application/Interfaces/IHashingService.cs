namespace Application.Interfaces;

public interface IHashingService
{
    string Hash(string password);
    bool Verify(string password, string hashedPassword);
}