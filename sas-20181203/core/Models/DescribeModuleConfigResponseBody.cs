// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeModuleConfigResponseBody : TeaModel {
        /// <summary>
        /// The number of configurations for the module.
        /// </summary>
        [NameInMap("Count")]
        [Validation(Required=false)]
        public int? Count { get; set; }

        /// <summary>
        /// The HTTP status code returned.
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// An array that consists of the configurations.
        /// </summary>
        [NameInMap("ModuleConfigList")]
        [Validation(Required=false)]
        public List<DescribeModuleConfigResponseBodyModuleConfigList> ModuleConfigList { get; set; }
        public class DescribeModuleConfigResponseBodyModuleConfigList : TeaModel {
            /// <summary>
            /// The name of the configuration.
            /// </summary>
            [NameInMap("ConfigName")]
            [Validation(Required=false)]
            public string ConfigName { get; set; }

            /// <summary>
            /// An array that consists of the configuration items.
            /// </summary>
            [NameInMap("Items")]
            [Validation(Required=false)]
            public List<DescribeModuleConfigResponseBodyModuleConfigListItems> Items { get; set; }
            public class DescribeModuleConfigResponseBodyModuleConfigListItems : TeaModel {
                /// <summary>
                /// The ID of the server group to which the server belongs.
                /// </summary>
                [NameInMap("GroupId")]
                [Validation(Required=false)]
                public int? GroupId { get; set; }

                /// <summary>
                /// The ID of the server.
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// The name of the server.
                /// </summary>
                [NameInMap("InstanceName")]
                [Validation(Required=false)]
                public string InstanceName { get; set; }

                /// <summary>
                /// The IP address of the server.
                /// </summary>
                [NameInMap("Ip")]
                [Validation(Required=false)]
                public string Ip { get; set; }

                /// <summary>
                /// The region in which the server resides.
                /// </summary>
                [NameInMap("Region")]
                [Validation(Required=false)]
                public string Region { get; set; }

                /// <summary>
                /// The UUID of the server.
                /// </summary>
                [NameInMap("Uuid")]
                [Validation(Required=false)]
                public string Uuid { get; set; }

            }

            /// <summary>
            /// The name of the module.
            /// </summary>
            [NameInMap("ModuleName")]
            [Validation(Required=false)]
            public string ModuleName { get; set; }

        }

        /// <summary>
        /// The ID of the request, which is used to locate and troubleshoot issues.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the request was successful. Valid values:
        /// 
        /// *   **true**: The request was successful.
        /// *   **false**: The request failed.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
