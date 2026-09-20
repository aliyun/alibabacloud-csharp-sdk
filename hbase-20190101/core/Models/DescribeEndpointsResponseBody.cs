// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.HBase20190101.Models
{
    public class DescribeEndpointsResponseBody : TeaModel {
        [NameInMap("ConnAddrs")]
        [Validation(Required=false)]
        public DescribeEndpointsResponseBodyConnAddrs ConnAddrs { get; set; }
        public class DescribeEndpointsResponseBodyConnAddrs : TeaModel {
            [NameInMap("ConnAddrInfo")]
            [Validation(Required=false)]
            public List<DescribeEndpointsResponseBodyConnAddrsConnAddrInfo> ConnAddrInfo { get; set; }
            public class DescribeEndpointsResponseBodyConnAddrsConnAddrInfo : TeaModel {
                [NameInMap("ConnAddr")]
                [Validation(Required=false)]
                public string ConnAddr { get; set; }

                [NameInMap("ConnAddrPort")]
                [Validation(Required=false)]
                public string ConnAddrPort { get; set; }

                [NameInMap("ConnType")]
                [Validation(Required=false)]
                public string ConnType { get; set; }

                [NameInMap("NetType")]
                [Validation(Required=false)]
                public string NetType { get; set; }

            }

        }

        /// <summary>
        /// <para>The engine type of the instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>hbaseue</b></description></item>
        /// <item><description><b>hbase</b></description></item>
        /// <item><description><b>spark</b></description></item>
        /// <item><description><b>geomesa</b>.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>hbaseue</para>
        /// </summary>
        [NameInMap("Engine")]
        [Validation(Required=false)]
        public string Engine { get; set; }

        /// <summary>
        /// <para>The network type of the instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>VPC</b>: virtual private cloud.</description></item>
        /// <item><description><b>CLASSIC</b>: classic network.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>VPC</para>
        /// </summary>
        [NameInMap("NetType")]
        [Validation(Required=false)]
        public string NetType { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>F072593C-5234-5B56-9F63-3C7A3AD85D66</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The vSwitch ID. This parameter is returned only when NetType is set to <b>VPC</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vsw-bp1foll427ze3d4ps****</para>
        /// </summary>
        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

        /// <summary>
        /// <para>The VPC ID. This parameter is returned only when NetType is set to <b>VPC</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-bp15s22y1a7sff5gj****</para>
        /// </summary>
        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

    }

}
