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
                /// <summary>
                /// <b>Example:</b>
                /// <hr>
                /// </summary>
                [NameInMap("ConnAddr")]
                [Validation(Required=false)]
                public string ConnAddr { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <hr>
                /// </summary>
                [NameInMap("ConnAddrPort")]
                [Validation(Required=false)]
                public string ConnAddrPort { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>zkConn</para>
                /// </summary>
                [NameInMap("ConnType")]
                [Validation(Required=false)]
                public string ConnType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("NetType")]
                [Validation(Required=false)]
                public string NetType { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>hbaseue</para>
        /// </summary>
        [NameInMap("Engine")]
        [Validation(Required=false)]
        public string Engine { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>VPC</para>
        /// </summary>
        [NameInMap("NetType")]
        [Validation(Required=false)]
        public string NetType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>F072593C-5234-5B56-9F63-3C7A3AD85D66</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>vsw-bp1foll427ze3d4ps****</para>
        /// </summary>
        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>vpc-bp15s22y1a7sff5gj****</para>
        /// </summary>
        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

    }

}
