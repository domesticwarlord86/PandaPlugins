# [PandaPlugins][0]

[![Download][1]][2]
[![Discord][3]][4]
[![](https://img.shields.io/static/v1?label=Sponsor&message=%E2%9D%A4&logo=GitHub&color=%23fe8e86)](https://github.com/sponsors/domesticwarlord86)
[![Donate][5]][6]

**PandaPlugins** is a collection of various plugins for [RebornBuddy][7]. Check each plugin's ReadMe for a discription of what they do.

## Installation

### Prerequisites

- [RebornBuddy][7] with active license (paid)
- [ExBuddy][8] (free)
- [Lisbeth][9] with active license (paid)
- [LlamaLibrary][10] (free)
- Better combat routine, such as [Magitek][11] (free)

### Automatic Setup (recommended)

Want **automatic installation and updates**, including prerequisites?

Install the [RepoBuddy][12] plugin

#### Adding `PandaPlugins` to RepoBuddy

In case your repoBuddy config is too old or otherwise missing `PandaPlugins`, you can add it via repoBuddy's settings menu:

- **Name:** PandaPlugins
- **Type:** Plugin
- **URL:** `https://github.com/domesticwarlord86/PandaPlugins.git/trunk`

![repBuddy Settings](https://i.imgur.com/KJhwxtw.png)

OR by closing the bot and editing `RebornBuddy\Plugins\repoBuddy\repoBuddyRepos.xml`:

```xml
<Repo>
  <Name>PandaPlugins</Name>
  <Type>Plugin</Type>
  <URL>https://github.com/domesticwarlord86/PandaPlugins.git/trunk</URL>
</Repo>
```

### Manual Setup

If you prefer manual setup instead of automatic,

1. Download the [latest version][2].
2. On the `.zip` file, right click > `Properties` > `Unblock` > `Apply`.
3. Unzip all contents into `RebornBuddy\Plugins\` so it looks like this:

```
RebornBuddy
└── Plugins
    └── Osiris
    └── Vulcan
    └── ...    
```

4. Start RebornBuddy as normal.

## Troubleshooting

For live volunteer support, join the [Project BR Discord][4] channel `#domesticwarlord86-profile-help`.

When asking for help, always include:

- which script you loaded,
- what you tried to do,
- what went wrong,
- relevant logs from the `RebornBuddy\Logs\` folder.

No need to ask if anyone's around or for permission to ask -- just go for it!

<!-- ## Looking to Donate? ❤️

[![Donate via Ko-Fi](https://i.imgur.com/bXUIjNA.png)][6] -->

[0]: https://github.com/domesticwarlord86/PandaPlugins "PandaPlugins on GitHub"
[1]: https://img.shields.io/badge/-Download-brightgreen
[2]: https://github.com/domesticwarlord86/PandaPlugins/archive/refs/heads/main.zip "Download"
[3]: https://img.shields.io/badge/Discord-7389D8?logo=discord&logoColor=ffffff&labelColor=6A7EC2
[4]: https://discord.gg/CucSWEhJSZ "Discord"
[5]: https://shields.io/badge/-Buy%20me%20a%20coffee-FF5E5B?logo=kofi&logoColor=ffffff&labelColor=FF5E5B
[6]: https://ko-fi.com/domesticwarlord86 "Donate via Ko-Fi"
[7]: https://www.rebornbuddy.com/ "RebornBuddy"
[8]: https://github.com/Entrax643/ExBuddy "ExBuddy"
[9]: https://www.siune.io/ "Lisbeth"
[10]: https://github.com/nt153133/__LlamaLibrary "LlamaLibrary"
[11]: https://discord.gg/rDsFbKr "Magitek Discord"
[12]: https://github.com/Zimgineering/repoBuddy "RepoBuddy"
