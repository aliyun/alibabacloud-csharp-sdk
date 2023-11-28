// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class ListLogstashPluginsResponseBody : TeaModel {
        /// <summary>
        /// The address of the documentation for the plug-in.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The status of the plug-in. Valid values:
        /// 
        /// *   INSTALLED: Installed
        /// *   UNINSTALLED: Not installed
        /// *   INSTALLING: The instance is being installed.
        /// *   UNINSTALLING: The instance is being uninstalled.
        /// *   UPGRADING: The backup gateway is being upgraded.
        /// *   FAILED: Installation failed
        /// *   UNKNOWN: The cluster is lost and cannot be created.
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public List<ListLogstashPluginsResponseBodyResult> Result { get; set; }
        public class ListLogstashPluginsResponseBodyResult : TeaModel {
            /// <summary>
            /// The source of the plug-in.
            /// </summary>
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("source")]
            [Validation(Required=false)]
            public string Source { get; set; }

            /// <summary>
            /// The name of the plug-in.
            /// </summary>
            [NameInMap("specificationUrl")]
            [Validation(Required=false)]
            public string SpecificationUrl { get; set; }

            [NameInMap("state")]
            [Validation(Required=false)]
            public string State { get; set; }

        }

    }

}
