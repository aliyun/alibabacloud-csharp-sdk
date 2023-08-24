// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.R_kvstore20150101.Models
{
    public class ModifyInstanceNetExpireTimeResponseBody : TeaModel {
        /// <summary>
        /// The ID of the instance.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// Details of the extension period for which the classic network endpoint of the instance is retained.
        /// </summary>
        [NameInMap("NetInfoItems")]
        [Validation(Required=false)]
        public ModifyInstanceNetExpireTimeResponseBodyNetInfoItems NetInfoItems { get; set; }
        public class ModifyInstanceNetExpireTimeResponseBodyNetInfoItems : TeaModel {
            [NameInMap("NetInfoItem")]
            [Validation(Required=false)]
            public List<ModifyInstanceNetExpireTimeResponseBodyNetInfoItemsNetInfoItem> NetInfoItem { get; set; }
            public class ModifyInstanceNetExpireTimeResponseBodyNetInfoItemsNetInfoItem : TeaModel {
                /// <summary>
                /// The endpoint of the classic network.
                /// </summary>
                [NameInMap("ConnectionString")]
                [Validation(Required=false)]
                public string ConnectionString { get; set; }

                /// <summary>
                /// The network type of the instance. The returned value is **Classic**.
                /// </summary>
                [NameInMap("DBInstanceNetType")]
                [Validation(Required=false)]
                public string DBInstanceNetType { get; set; }

                /// <summary>
                /// The expiration time of the classic network endpoint.
                /// </summary>
                [NameInMap("ExpiredTime")]
                [Validation(Required=false)]
                public string ExpiredTime { get; set; }

                /// <summary>
                /// The IP address of the instance in the classic network.
                /// </summary>
                [NameInMap("IPAddress")]
                [Validation(Required=false)]
                public string IPAddress { get; set; }

                /// <summary>
                /// The port number that is used to connect to the instance.
                /// </summary>
                [NameInMap("Port")]
                [Validation(Required=false)]
                public string Port { get; set; }

            }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
