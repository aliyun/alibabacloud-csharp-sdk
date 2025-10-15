// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam20211201.Models
{
    public class ListNetworkZonesResponseBody : TeaModel {
        [NameInMap("NetworkZones")]
        [Validation(Required=false)]
        public List<ListNetworkZonesResponseBodyNetworkZones> NetworkZones { get; set; }
        public class ListNetworkZonesResponseBodyNetworkZones : TeaModel {
            /// <summary>
            /// <para>IDaaS EIAM 网络区域描述</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>实例ID。</para>
            /// 
            /// <b>Example:</b>
            /// <para>idaas_ue2jvisn35ea5lmthk267xxxxx</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            [NameInMap("Ipv4Cidrs")]
            [Validation(Required=false)]
            public List<string> Ipv4Cidrs { get; set; }

            [NameInMap("Ipv6Cidrs")]
            [Validation(Required=false)]
            public List<string> Ipv6Cidrs { get; set; }

            /// <summary>
            /// <para>IDaaS EIAM 网络区域Id</para>
            /// 
            /// <b>Example:</b>
            /// <para>network_m223wbvc3sn3uakfnxvhbxxxxx</para>
            /// </summary>
            [NameInMap("NetworkZoneId")]
            [Validation(Required=false)]
            public string NetworkZoneId { get; set; }

            /// <summary>
            /// <para>IDaaS EIAM 网络区域名称</para>
            /// 
            /// <b>Example:</b>
            /// <para>test_name</para>
            /// </summary>
            [NameInMap("NetworkZoneName")]
            [Validation(Required=false)]
            public string NetworkZoneName { get; set; }

            /// <summary>
            /// <para>IDaaS EIAM 网络区域类型</para>
            /// 
            /// <b>Example:</b>
            /// <para>arn:alibaba:idaas:network:zone:classic</para>
            /// </summary>
            [NameInMap("NetworkZoneType")]
            [Validation(Required=false)]
            public string NetworkZoneType { get; set; }

            /// <summary>
            /// <para>IDaaS EIAM 专有网络VpcId</para>
            /// 
            /// <b>Example:</b>
            /// <para>vpc-bp1usdmfqcgoy5ebxxxxx</para>
            /// </summary>
            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

        }

        /// <summary>
        /// <para>本次调用返回的查询凭证（Token）值，用于下一次翻页查询。</para>
        /// 
        /// <b>Example:</b>
        /// <para>NTxxxexample</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>PTxxxxxexample</para>
        /// </summary>
        [NameInMap("PreviousToken")]
        [Validation(Required=false)]
        public string PreviousToken { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0441BD79-92F3-53AA-8657-F8CE4A2B912A</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
