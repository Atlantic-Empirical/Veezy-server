'Copyright (c) 2008, Jonathan Allen

<Flags()> _
Public Enum TitleExpansions
    None = 0
    Synopsis = CInt(2 ^ 0)
    Formats = CInt(2 ^ 1)
    ScreenFormats = CInt(2 ^ 2)
    Cast = CInt(2 ^ 3)
    Directors = CInt(2 ^ 4)
    LanguagesAndAudio = CInt(2 ^ 5)
    Seasons = CInt(2 ^ 6)
    Episodes = CInt(2 ^ 7)
    Discs = CInt(2 ^ 8)
    Similars = CInt(2 ^ 9)
    Filmography = CInt(2 ^ 10)
    All = -1
End Enum
