// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeWhiteListAssetResponseBody : TeaModel {
        /// <summary>
        /// The information about the servers.
        /// </summary>
        [NameInMap("Assets")]
        [Validation(Required=false)]
        public List<DescribeWhiteListAssetResponseBodyAssets> Assets { get; set; }
        public class DescribeWhiteListAssetResponseBodyAssets : TeaModel {
            /// <summary>
            /// Indicates whether the server can be selected. Valid values:
            /// 
            /// *   **0**: no
            /// *   **1**: yes
            /// </summary>
            [NameInMap("AllowSelected")]
            [Validation(Required=false)]
            public int? AllowSelected { get; set; }

            /// <summary>
            /// The group ID of the server.
            /// </summary>
            [NameInMap("GroupId")]
            [Validation(Required=false)]
            public long? GroupId { get; set; }

            /// <summary>
            /// The ID of the server.
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// The IP address of the server.
            /// </summary>
            [NameInMap("MachineIp")]
            [Validation(Required=false)]
            public string MachineIp { get; set; }

            /// <summary>
            /// The name of the server.
            /// </summary>
            [NameInMap("MachineName")]
            [Validation(Required=false)]
            public string MachineName { get; set; }

            /// <summary>
            /// Indicates whether the server is selected. Valid values:
            /// 
            /// *   **0**: no
            /// *   **1**: yes
            /// </summary>
            [NameInMap("Selected")]
            [Validation(Required=false)]
            public int? Selected { get; set; }

            /// <summary>
            /// The UUID of the server.
            /// </summary>
            [NameInMap("Uuid")]
            [Validation(Required=false)]
            public string Uuid { get; set; }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
