// Создаем интерфейс "Drawing" (Рисунок)
public interface IDrawing
{
    // Метод для рисования линии
    void DrawLine(int x1, int y1, int x2, int y2);

    // Метод для рисования окружности
    void DrawCircle(int x, int y, int radius);

    // Метод для рисования прямоугольника
    void DrawRectangle(int x, int y, int width, int height);
}