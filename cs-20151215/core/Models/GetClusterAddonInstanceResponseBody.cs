// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class GetClusterAddonInstanceResponseBody : TeaModel {
        /// <summary>
        /// The custom configurations of the component.
        /// </summary>
        [NameInMap("config")]
        [Validation(Required=false)]
        public string Config { get; set; }

        /// <summary>
        /// The status of Simple Log Service.
        /// </summary>
        [NameInMap("logging")]
        [Validation(Required=false)]
        public GetClusterAddonInstanceResponseBodyLogging Logging { get; set; }
        public class GetClusterAddonInstanceResponseBodyLogging : TeaModel {
            /// <summary>
            /// Indicates whether Simple Log Service is supported by the component.
            /// </summary>
            [NameInMap("capable")]
            [Validation(Required=false)]
            public bool? Capable { get; set; }

            /// <summary>
            /// Indicates whether Simple Log Service is enabled for the component.
            /// </summary>
            [NameInMap("enabled")]
            [Validation(Required=false)]
            public bool? Enabled { get; set; }

            /// <summary>
            /// The Simple Log Service project that is used to collect logs for the component.
            /// </summary>
            [NameInMap("log_project")]
            [Validation(Required=false)]
            public string LogProject { get; set; }

            /// <summary>
            /// The Simple Log Service Logstore that is used to collect logs for the component.
            /// </summary>
            [NameInMap("logstore")]
            [Validation(Required=false)]
            public string Logstore { get; set; }

        }

        /// <summary>
        /// The name of the component instance.
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// The status of the component. Valid values:
        /// 
        /// *   active: The component is installed.
        /// *   updating: The component is being modified.
        /// *   upgrading: The component is being updated.
        /// *   deleting: The component is being uninstalled.
        /// </summary>
        [NameInMap("state")]
        [Validation(Required=false)]
        public string State { get; set; }

        /// <summary>
        /// The version of the component instance.
        /// </summary>
        [NameInMap("version")]
        [Validation(Required=false)]
        public string Version { get; set; }

    }

}
