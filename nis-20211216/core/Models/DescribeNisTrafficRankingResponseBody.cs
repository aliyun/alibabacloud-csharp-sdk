// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Nis20211216.Models
{
    public class DescribeNisTrafficRankingResponseBody : TeaModel {
        [NameInMap("FlowRankingList")]
        [Validation(Required=false)]
        public List<DescribeNisTrafficRankingResponseBodyFlowRankingList> FlowRankingList { get; set; }
        public class DescribeNisTrafficRankingResponseBodyFlowRankingList : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>ngw-ufwerthgvc*****</para>
            /// </summary>
            [NameInMap("BindingResourceId")]
            [Validation(Required=false)]
            public string BindingResourceId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>EIP_NAT</para>
            /// </summary>
            [NameInMap("BindingResourceType")]
            [Validation(Required=false)]
            public string BindingResourceType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("Bytes")]
            [Validation(Required=false)]
            public double? Bytes { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0.2</para>
            /// </summary>
            [NameInMap("BytesRate")]
            [Validation(Required=false)]
            public double? BytesRate { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>45102</para>
            /// </summary>
            [NameInMap("ClientAsn")]
            [Validation(Required=false)]
            public string ClientAsn { get; set; }

            [NameInMap("ClientCity")]
            [Validation(Required=false)]
            public string ClientCity { get; set; }

            [NameInMap("ClientCountry")]
            [Validation(Required=false)]
            public string ClientCountry { get; set; }

            [NameInMap("ClientIsp")]
            [Validation(Required=false)]
            public string ClientIsp { get; set; }

            [NameInMap("ClientProvince")]
            [Validation(Required=false)]
            public string ClientProvince { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>192.168.***.0</para>
            /// </summary>
            [NameInMap("DestinationIp")]
            [Validation(Required=false)]
            public string DestinationIp { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>23</para>
            /// </summary>
            [NameInMap("DestinationPort")]
            [Validation(Required=false)]
            public string DestinationPort { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("DestinationRegionNo")]
            [Validation(Required=false)]
            public string DestinationRegionNo { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>in</para>
            /// </summary>
            [NameInMap("Direction")]
            [Validation(Required=false)]
            public string Direction { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Dscp")]
            [Validation(Required=false)]
            public string Dscp { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>i-uf6i1zi6yhq7h***</para>
            /// </summary>
            [NameInMap("EcsId")]
            [Validation(Required=false)]
            public string EcsId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>eip-fb6wzjl9hm****</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>eni-8vbf2jxul***</para>
            /// </summary>
            [NameInMap("NetworkInterfaceId")]
            [Validation(Required=false)]
            public string NetworkInterfaceId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("Packets")]
            [Validation(Required=false)]
            public double? Packets { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>4</para>
            /// </summary>
            [NameInMap("PacketsLostBlackhole")]
            [Validation(Required=false)]
            public double? PacketsLostBlackhole { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("PacketsLostNoRoute")]
            [Validation(Required=false)]
            public double? PacketsLostNoRoute { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>7</para>
            /// </summary>
            [NameInMap("PacketsLostTTLExpired")]
            [Validation(Required=false)]
            public double? PacketsLostTTLExpired { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>TCP</para>
            /// </summary>
            [NameInMap("Protocol")]
            [Validation(Required=false)]
            public string Protocol { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>118.31.***.86</para>
            /// </summary>
            [NameInMap("PublicIpAddress")]
            [Validation(Required=false)]
            public string PublicIpAddress { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("RoundTripTime")]
            [Validation(Required=false)]
            public double? RoundTripTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>47.92.245.***</para>
            /// </summary>
            [NameInMap("SourceIp")]
            [Validation(Required=false)]
            public string SourceIp { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>5432</para>
            /// </summary>
            [NameInMap("SourcePort")]
            [Validation(Required=false)]
            public string SourcePort { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("SourceRegionNo")]
            [Validation(Required=false)]
            public string SourceRegionNo { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>all</para>
            /// </summary>
            [NameInMap("TrafficPath")]
            [Validation(Required=false)]
            public string TrafficPath { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>tr-attach-bfde1cd4cj***</para>
            /// </summary>
            [NameInMap("TransitRouterAttachmentId")]
            [Validation(Required=false)]
            public string TransitRouterAttachmentId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1906814138****</para>
            /// </summary>
            [NameInMap("TransitRouterDestinationAccountId")]
            [Validation(Required=false)]
            public string TransitRouterDestinationAccountId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>cn-hangzhou-j</para>
            /// </summary>
            [NameInMap("TransitRouterDestinationAvailableZone")]
            [Validation(Required=false)]
            public string TransitRouterDestinationAvailableZone { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>eni-fdbf2jxulm***</para>
            /// </summary>
            [NameInMap("TransitRouterDestinationNetworkInterface")]
            [Validation(Required=false)]
            public string TransitRouterDestinationNetworkInterface { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>tr-attach-bfve1cd4cjp****</para>
            /// </summary>
            [NameInMap("TransitRouterDestinationResourceId")]
            [Validation(Required=false)]
            public string TransitRouterDestinationResourceId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>vsw-2zeekevlhxpqxu****</para>
            /// </summary>
            [NameInMap("TransitRouterDestinationVSwitchId")]
            [Validation(Required=false)]
            public string TransitRouterDestinationVSwitchId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>tr-2zefvwy2fz3444***</para>
            /// </summary>
            [NameInMap("TransitRouterId")]
            [Validation(Required=false)]
            public string TransitRouterId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>tr-attach-okvj1cd4cjp***</para>
            /// </summary>
            [NameInMap("TransitRouterPairAttachmentId")]
            [Validation(Required=false)]
            public string TransitRouterPairAttachmentId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1906814138***</para>
            /// </summary>
            [NameInMap("TransitRouterSourceAccountId")]
            [Validation(Required=false)]
            public string TransitRouterSourceAccountId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>cn-hangzhou-j</para>
            /// </summary>
            [NameInMap("TransitRouterSourceAvailableZone")]
            [Validation(Required=false)]
            public string TransitRouterSourceAvailableZone { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>eni-8vbf2jxulma***</para>
            /// </summary>
            [NameInMap("TransitRouterSourceNetworkInterface")]
            [Validation(Required=false)]
            public string TransitRouterSourceNetworkInterface { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>tr-attach-hvve1cd4cjpj***</para>
            /// </summary>
            [NameInMap("TransitRouterSourceResourceId")]
            [Validation(Required=false)]
            public string TransitRouterSourceResourceId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>vsw-ikfdkevlhxpqxuz****</para>
            /// </summary>
            [NameInMap("TransitRouterSourceVSwitchId")]
            [Validation(Required=false)]
            public string TransitRouterSourceVSwitchId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>vsw-2zeekevlh****</para>
            /// </summary>
            [NameInMap("VSwitchId")]
            [Validation(Required=false)]
            public string VSwitchId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>vpc-m5ec6i0h5xss***</para>
            /// </summary>
            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>LoeJLhK0fsDqYoXkXieZUqB2vWnccJtVnsyKu9KxFFOMQxtV8XckOg5lk7F2bhC+</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>task-7619ecb1db9148bab9f4</para>
        /// </summary>
        [NameInMap("NisTrafficRankingId")]
        [Validation(Required=false)]
        public string NisTrafficRankingId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>4DAC4BE1-BEEA-5D84-BE06-E1B796F3B941</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Complete</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>72</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
