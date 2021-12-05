// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class ListFullNatEntriesResponseBody : TeaModel {
        [NameInMap("FullNatEntries")]
        [Validation(Required=false)]
        public List<ListFullNatEntriesResponseBodyFullNatEntries> FullNatEntries { get; set; }
        public class ListFullNatEntriesResponseBodyFullNatEntries : TeaModel {
            /// <summary>
            /// 通过DNAT条目进行公网通信的ECS实例的私网IP地址。
            /// </summary>
            [NameInMap("AccessIp")]
            [Validation(Required=false)]
            public string AccessIp { get; set; }

            /// <summary>
            /// DNAT条目中进行端口转发的内部端口，取值范围：1-65535。
            /// </summary>
            [NameInMap("AccessPort")]
            [Validation(Required=false)]
            public string AccessPort { get; set; }

            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            [NameInMap("FullNatEntryDescription")]
            [Validation(Required=false)]
            public string FullNatEntryDescription { get; set; }

            [NameInMap("FullNatEntryId")]
            [Validation(Required=false)]
            public string FullNatEntryId { get; set; }

            /// <summary>
            /// FULLNAT规则的名称。 长度为2~128个字符，必须以大小写字母或中文开头，但不能以http://或https://开头。
            /// </summary>
            [NameInMap("FullNatEntryName")]
            [Validation(Required=false)]
            public string FullNatEntryName { get; set; }

            [NameInMap("FullNatEntryStatus")]
            [Validation(Required=false)]
            public string FullNatEntryStatus { get; set; }

            /// <summary>
            /// 协议类型，取值： • TCP：转发TCP协议的报文。 • UDP：转发UDP协议的报文。
            /// </summary>
            [NameInMap("IpProtocol")]
            [Validation(Required=false)]
            public string IpProtocol { get; set; }

            /// <summary>
            /// DNAT条目中提供公网访问的公网IP地址。
            /// </summary>
            [NameInMap("NatIp")]
            [Validation(Required=false)]
            public string NatIp { get; set; }

            /// <summary>
            /// DNAT条目中进行端口转发的外部端口，取值范围：1~65535。
            /// </summary>
            [NameInMap("NatIpPort")]
            [Validation(Required=false)]
            public string NatIpPort { get; set; }

            /// <summary>
            /// 当前VpcNat作为服务资源所加入的eni
            /// </summary>
            [NameInMap("NetworkInterfaceId")]
            [Validation(Required=false)]
            public string NetworkInterfaceId { get; set; }

            /// <summary>
            /// ENI类型，目前仅支持Endpoint
            /// </summary>
            [NameInMap("NetworkInterfaceType")]
            [Validation(Required=false)]
            public string NetworkInterfaceType { get; set; }

        }

        [NameInMap("FullNatTableId")]
        [Validation(Required=false)]
        public string FullNatTableId { get; set; }

        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public long? MaxResults { get; set; }

        [NameInMap("NatGatewayId")]
        [Validation(Required=false)]
        public string NatGatewayId { get; set; }

        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
