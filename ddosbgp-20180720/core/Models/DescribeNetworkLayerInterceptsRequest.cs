// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddosbgp20180720.Models
{
    public class DescribeNetworkLayerInterceptsRequest : TeaModel {
        /// <summary>
        /// <para>The destination IP address.</para>
        /// 
        /// <b>Example:</b>
        /// <para>47.118.170.18</para>
        /// </summary>
        [NameInMap("DestinationIp")]
        [Validation(Required=false)]
        public string DestinationIp { get; set; }

        /// <summary>
        /// <para>The destination port.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8080</para>
        /// </summary>
        [NameInMap("DestinationPort")]
        [Validation(Required=false)]
        public long? DestinationPort { get; set; }

        /// <summary>
        /// <para>The end time of the DDoS attack event to query. The value is a UNIX timestamp. Unit: seconds.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1563445054</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        /// <summary>
        /// <para>The instance ID of the Anti-DDoS Origin instance to query.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ddosbgp-cn-z2q1qzxb****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The network protocol.</para>
        /// 
        /// <b>Example:</b>
        /// <para>tcp</para>
        /// </summary>
        [NameInMap("NetworkProtocol")]
        [Validation(Required=false)]
        public string NetworkProtocol { get; set; }

        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Page")]
        [Validation(Required=false)]
        public long? Page { get; set; }

        /// <summary>
        /// <para>Settings for the number of interception logs to return on each page when you perform a paged query. Paging is used to return results.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// <para>The network protocol number. This is a standard network protocol number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6</para>
        /// </summary>
        [NameInMap("ProtocolNumber")]
        [Validation(Required=false)]
        public long? ProtocolNumber { get; set; }

        /// <summary>
        /// <para>The source port.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5432</para>
        /// </summary>
        [NameInMap("SourcePort")]
        [Validation(Required=false)]
        public long? SourcePort { get; set; }

        /// <summary>
        /// <para>The source IP address.</para>
        /// 
        /// <b>Example:</b>
        /// <para>37.60.241.154</para>
        /// </summary>
        [NameInMap("SrcIp")]
        [Validation(Required=false)]
        public string SrcIp { get; set; }

        /// <summary>
        /// <para>The start time of the DDoS attack event to query. The value is a UNIX timestamp. Unit: seconds.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1557305044</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

    }

}
