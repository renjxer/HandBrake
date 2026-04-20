// --------------------------------------------------------------------------------------------------------------------
// <copyright file="VideoPresetFactory.cs" company="HandBrake Project (http://handbrake.fr)">
//   This file is part of the HandBrake source code - It may be used under the terms of the GNU General Public License.
// </copyright>
// <summary>
//   The video preset factory.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace HandBrakeWPF.Services.Encode.Factories
{
    /// <summary>
    /// The video tune factory.
    /// </summary>
    using HandBrakeWPF.Properties;
    public class VideoPresetFactory
    {
        /// <summary>
        /// The get display name for a given short name.
        /// LibHB doesn't currently support this.
        /// </summary>
        /// <param name="shortName">
        /// The short name.
        /// </param>
        /// <returns>
        /// The <see cref="string"/>.
        /// </returns>
        public static string GetDisplayName(string shortName)
        {
            string presetName = GetNvencPresetName(shortName);
            if (presetName != shortName)
            {
                return presetName;
            }

            switch (shortName)
            {
                case "ultrafast":
                    return Resources.VideoPresetFactory_Ultrafast;
                case "superfast":
                    return Resources.VideoPresetFactory_Superfast;
                case "veryfast":
                    return Resources.VideoPresetFactory_Veryfast;
                case "faster":
                    return Resources.VideoPresetFactory_Faster;
                case "fast":
                    return Resources.VideoPresetFactory_Fast;
                case "medium":
                    return Resources.VideoPresetFactory_Medium;
                case "slow":
                    return Resources.VideoPresetFactory_Slow;
                case "slower":
                    return Resources.VideoPresetFactory_Slower;
                case "veryslow":
                    return Resources.VideoPresetFactory_VerySlow;
                case "placebo":
                    return Resources.VideoPresetFactory_Placebo;

                case "balanced":
                    return Resources.VideoPresetFactory_Balanced;
                case "speed":
                    return Resources.VideoPresetFactory_Speed;
                case "quality":
                    return Resources.VideoPresetFactory_Quality;
            }

            return shortName;
        }

        public static string GetNvencPresetName(string shortName)
        {
            switch (shortName)
            {
                case "fastest":
                    return Resources.VideoPresetFactory_Fastest;
                case "faster":
                    return Resources.VideoPresetFactory_Faster;
                case "fast":
                    return Resources.VideoPresetFactory_Fast;
                case "medium":
                    return Resources.VideoPresetFactory_Medium;
                case "slow":
                    return Resources.VideoPresetFactory_Slow;
                case "slower":
                    return Resources.VideoPresetFactory_Slower;
                case "slowest":
                    return Resources.VideoPresetFactory_Slowest;
                case null:
                    return Resources.VideoPresetFactory_Medium;
            }

            return shortName;
        }
    }
}
