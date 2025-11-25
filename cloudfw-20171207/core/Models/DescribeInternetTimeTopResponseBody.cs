// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribeInternetTimeTopResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>19</para>
        /// </summary>
        [NameInMap("DataCount")]
        [Validation(Required=false)]
        public int? DataCount { get; set; }

        [NameInMap("DataList")]
        [Validation(Required=false)]
        public List<DescribeInternetTimeTopResponseBodyDataList> DataList { get; set; }
        public class DescribeInternetTimeTopResponseBodyDataList : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>183.60.164.XXX</para>
            /// </summary>
            [NameInMap("IP")]
            [Validation(Required=false)]
            public string IP { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>187</para>
            /// </summary>
            [NameInMap("InBps")]
            [Validation(Required=false)]
            public long? InBps { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("InPps")]
            [Validation(Required=false)]
            public long? InPps { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ngw-wz98eedr5l5hkb8****e7</para>
            /// </summary>
            [NameInMap("NatGatewayId")]
            [Validation(Required=false)]
            public string NatGatewayId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ngw-test</para>
            /// </summary>
            [NameInMap("NatGatewayName")]
            [Validation(Required=false)]
            public string NatGatewayName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>47.97.66.XXX</para>
            /// </summary>
            [NameInMap("NatIP")]
            [Validation(Required=false)]
            public string NatIP { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>27</para>
            /// </summary>
            [NameInMap("NewConn")]
            [Validation(Required=false)]
            public long? NewConn { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>45</para>
            /// </summary>
            [NameInMap("OutBps")]
            [Validation(Required=false)]
            public long? OutBps { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("OutPps")]
            [Validation(Required=false)]
            public long? OutPps { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>10.21.186.XXX</para>
            /// </summary>
            [NameInMap("PrivateIP")]
            [Validation(Required=false)]
            public string PrivateIP { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>cn-shenzhen</para>
            /// </summary>
            [NameInMap("RegionNo")]
            [Validation(Required=false)]
            public string RegionNo { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>lb-bp14ue2rgktunncq****</para>
            /// </summary>
            [NameInMap("ResourceInstanceId")]
            [Validation(Required=false)]
            public string ResourceInstanceId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("ResourceInstanceName")]
            [Validation(Required=false)]
            public string ResourceInstanceName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>EcsPublicIP</para>
            /// </summary>
            [NameInMap("ResourceType")]
            [Validation(Required=false)]
            public string ResourceType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>27</para>
            /// </summary>
            [NameInMap("SessionCount")]
            [Validation(Required=false)]
            public long? SessionCount { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>232</para>
            /// </summary>
            [NameInMap("TotalBps")]
            [Validation(Required=false)]
            public long? TotalBps { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>88</para>
            /// </summary>
            [NameInMap("TotalPps")]
            [Validation(Required=false)]
            public long? TotalPps { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>vpc-wz9o0uzfjuj81fx7m****</para>
            /// </summary>
            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>7F2D5C04-731F-50B0-ADE1-01637B3C****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1734399660</para>
        /// </summary>
        [NameInMap("TrafficTime")]
        [Validation(Required=false)]
        public int? TrafficTime { get; set; }

    }

}
