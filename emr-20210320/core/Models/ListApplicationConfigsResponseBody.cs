// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20210320.Models
{
    public class ListApplicationConfigsResponseBody : TeaModel {
        /// <summary>
        /// The application configurations.
        /// </summary>
        [NameInMap("ApplicationConfigs")]
        [Validation(Required=false)]
        public List<ListApplicationConfigsResponseBodyApplicationConfigs> ApplicationConfigs { get; set; }
        public class ListApplicationConfigsResponseBodyApplicationConfigs : TeaModel {
            /// <summary>
            /// The name of the application.
            /// </summary>
            [NameInMap("ApplicationName")]
            [Validation(Required=false)]
            public string ApplicationName { get; set; }

            /// <summary>
            /// The status of the configuration value.
            /// </summary>
            [NameInMap("ConfigEffectState")]
            [Validation(Required=false)]
            public string ConfigEffectState { get; set; }

            /// <summary>
            /// The name of the configuration file.
            /// </summary>
            [NameInMap("ConfigFileName")]
            [Validation(Required=false)]
            public string ConfigFileName { get; set; }

            /// <summary>
            /// The key of the configuration item.
            /// </summary>
            [NameInMap("ConfigItemKey")]
            [Validation(Required=false)]
            public string ConfigItemKey { get; set; }

            /// <summary>
            /// The value of the configuration item.
            /// </summary>
            [NameInMap("ConfigItemValue")]
            [Validation(Required=false)]
            public string ConfigItemValue { get; set; }

            /// <summary>
            /// The creation time.
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            /// <summary>
            /// Indicates whether the configurations are custom.
            /// </summary>
            [NameInMap("Custom")]
            [Validation(Required=false)]
            public bool? Custom { get; set; }

            /// <summary>
            /// The description.
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// The initial value.
            /// </summary>
            [NameInMap("InitValue")]
            [Validation(Required=false)]
            public string InitValue { get; set; }

            /// <summary>
            /// The person who modified the configurations.
            /// </summary>
            [NameInMap("Modifier")]
            [Validation(Required=false)]
            public string Modifier { get; set; }

            /// <summary>
            /// The node group ID.
            /// </summary>
            [NameInMap("NodeGroupId")]
            [Validation(Required=false)]
            public string NodeGroupId { get; set; }

            /// <summary>
            /// The node ID.
            /// </summary>
            [NameInMap("NodeId")]
            [Validation(Required=false)]
            public string NodeId { get; set; }

            /// <summary>
            /// The update time.
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public long? UpdateTime { get; set; }

        }

        /// <summary>
        /// The number of entries per page.
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// The page number of the next page returned.
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total number of pages returned.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
