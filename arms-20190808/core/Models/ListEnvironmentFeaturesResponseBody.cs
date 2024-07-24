// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class ListEnvironmentFeaturesResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// The returned struct.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListEnvironmentFeaturesResponseBodyData> Data { get; set; }
        public class ListEnvironmentFeaturesResponseBodyData : TeaModel {
            /// <summary>
            /// The alias of the feature.
            /// </summary>
            [NameInMap("Alias")]
            [Validation(Required=false)]
            public string Alias { get; set; }

            /// <summary>
            /// The feature configuration.
            /// </summary>
            [NameInMap("Config")]
            [Validation(Required=false)]
            public Dictionary<string, string> Config { get; set; }

            /// <summary>
            /// The description of the feature.
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// The ID of the environment instance.
            /// </summary>
            [NameInMap("EnvironmentId")]
            [Validation(Required=false)]
            public string EnvironmentId { get; set; }

            /// <summary>
            /// The URL of the icon.
            /// </summary>
            [NameInMap("Icon")]
            [Validation(Required=false)]
            public string Icon { get; set; }

            /// <summary>
            /// The language. Valid values:
            /// 
            /// *   zh: Chinese
            /// *   en: English
            /// </summary>
            [NameInMap("Language")]
            [Validation(Required=false)]
            public string Language { get; set; }

            /// <summary>
            /// The latest version number.
            /// </summary>
            [NameInMap("LatestVersion")]
            [Validation(Required=false)]
            public string LatestVersion { get; set; }

            [NameInMap("Managed")]
            [Validation(Required=false)]
            public bool? Managed { get; set; }

            /// <summary>
            /// The name of the feature.
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// The status of the feature. Valid values:
            /// 
            /// *   Installing: The agent is being installed.
            /// *   Success: The agent is installed.
            /// *   Failed: The agent failed to be installed.
            /// *   UnInstall: The agent is uninstalled.
            /// *   Uninstalling: The agent is being uninstalled.
            /// *   UnInstallFailed: The agent failed to be uninstalled.
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// The version of the feature.
            /// </summary>
            [NameInMap("Version")]
            [Validation(Required=false)]
            public string Version { get; set; }

        }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
