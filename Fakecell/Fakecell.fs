namespace Fakecell

type CellContent = string
type CellPosition = int * int

type Worksheet = {
    Name: string
    Cells: Map<CellPosition, CellContent>
}

type Workbook = {
    Worksheet: Map<string, Worksheet>
}
