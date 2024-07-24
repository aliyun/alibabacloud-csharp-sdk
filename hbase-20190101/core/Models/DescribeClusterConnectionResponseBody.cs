// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.HBase20190101.Models
{
    public class DescribeClusterConnectionResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>hbaseue</para>
        /// </summary>
        [NameInMap("DbType")]
        [Validation(Required=false)]
        public string DbType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("IsMultimod")]
        [Validation(Required=false)]
        public string IsMultimod { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>VPC</para>
        /// </summary>
        [NameInMap("NetType")]
        [Validation(Required=false)]
        public string NetType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>70220050-A465-5DCC-8C0C-C38C6E3DB24D</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ServiceConnAddrs")]
        [Validation(Required=false)]
        public DescribeClusterConnectionResponseBodyServiceConnAddrs ServiceConnAddrs { get; set; }
        public class DescribeClusterConnectionResponseBodyServiceConnAddrs : TeaModel {
            [NameInMap("ServiceConnAddr")]
            [Validation(Required=false)]
            public List<DescribeClusterConnectionResponseBodyServiceConnAddrsServiceConnAddr> ServiceConnAddr { get; set; }
            public class DescribeClusterConnectionResponseBodyServiceConnAddrsServiceConnAddr : TeaModel {
                [NameInMap("ConnAddrInfo")]
                [Validation(Required=false)]
                public DescribeClusterConnectionResponseBodyServiceConnAddrsServiceConnAddrConnAddrInfo ConnAddrInfo { get; set; }
                public class DescribeClusterConnectionResponseBodyServiceConnAddrsServiceConnAddrConnAddrInfo : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>hb-****-proxy-phoenix.hbase.rds.aliyuncs.com</para>
                    /// </summary>
                    [NameInMap("ConnAddr")]
                    [Validation(Required=false)]
                    public string ConnAddr { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>8765</para>
                    /// </summary>
                    [NameInMap("ConnAddrPort")]
                    [Validation(Required=false)]
                    public string ConnAddrPort { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>2</para>
                    /// </summary>
                    [NameInMap("NetType")]
                    [Validation(Required=false)]
                    public string NetType { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>PhoenixConnAddr</para>
                /// </summary>
                [NameInMap("ConnType")]
                [Validation(Required=false)]
                public string ConnType { get; set; }

            }

        }

        [NameInMap("SlbConnAddrs")]
        [Validation(Required=false)]
        public DescribeClusterConnectionResponseBodySlbConnAddrs SlbConnAddrs { get; set; }
        public class DescribeClusterConnectionResponseBodySlbConnAddrs : TeaModel {
            [NameInMap("SlbConnAddr")]
            [Validation(Required=false)]
            public List<DescribeClusterConnectionResponseBodySlbConnAddrsSlbConnAddr> SlbConnAddr { get; set; }
            public class DescribeClusterConnectionResponseBodySlbConnAddrsSlbConnAddr : TeaModel {
                [NameInMap("ConnAddrInfo")]
                [Validation(Required=false)]
                public DescribeClusterConnectionResponseBodySlbConnAddrsSlbConnAddrConnAddrInfo ConnAddrInfo { get; set; }
                public class DescribeClusterConnectionResponseBodySlbConnAddrsSlbConnAddrConnAddrInfo : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>ld-bp150tns0sjxs****-proxy-hbaseue-pub.hbaseue.rds.aliyuncs.com</para>
                    /// </summary>
                    [NameInMap("ConnAddr")]
                    [Validation(Required=false)]
                    public string ConnAddr { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>9190</para>
                    /// </summary>
                    [NameInMap("ConnAddrPort")]
                    [Validation(Required=false)]
                    public string ConnAddrPort { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("NetType")]
                    [Validation(Required=false)]
                    public string NetType { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>hbaseue</para>
                /// </summary>
                [NameInMap("SlbType")]
                [Validation(Required=false)]
                public string SlbType { get; set; }

            }

        }

        [NameInMap("ThriftConn")]
        [Validation(Required=false)]
        public DescribeClusterConnectionResponseBodyThriftConn ThriftConn { get; set; }
        public class DescribeClusterConnectionResponseBodyThriftConn : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>hb-bp1u0639js2h7****-proxy-thrift.hbase.rds.aliyuncs.com</para>
            /// </summary>
            [NameInMap("ConnAddr")]
            [Validation(Required=false)]
            public string ConnAddr { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>9099</para>
            /// </summary>
            [NameInMap("ConnAddrPort")]
            [Validation(Required=false)]
            public string ConnAddrPort { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("NetType")]
            [Validation(Required=false)]
            public string NetType { get; set; }

        }

        [NameInMap("UiProxyConnAddrInfo")]
        [Validation(Required=false)]
        public DescribeClusterConnectionResponseBodyUiProxyConnAddrInfo UiProxyConnAddrInfo { get; set; }
        public class DescribeClusterConnectionResponseBodyUiProxyConnAddrInfo : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>ld-bp150tns0sjxs****-master1-001.hbaseue.rds.aliyuncs.com</para>
            /// </summary>
            [NameInMap("ConnAddr")]
            [Validation(Required=false)]
            public string ConnAddr { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>443</para>
            /// </summary>
            [NameInMap("ConnAddrPort")]
            [Validation(Required=false)]
            public string ConnAddrPort { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>PUBLIC</para>
            /// </summary>
            [NameInMap("NetType")]
            [Validation(Required=false)]
            public string NetType { get; set; }

        }

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

        [NameInMap("ZkConnAddrs")]
        [Validation(Required=false)]
        public DescribeClusterConnectionResponseBodyZkConnAddrs ZkConnAddrs { get; set; }
        public class DescribeClusterConnectionResponseBodyZkConnAddrs : TeaModel {
            [NameInMap("ZkConnAddr")]
            [Validation(Required=false)]
            public List<DescribeClusterConnectionResponseBodyZkConnAddrsZkConnAddr> ZkConnAddr { get; set; }
            public class DescribeClusterConnectionResponseBodyZkConnAddrsZkConnAddr : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>ld-bp150tns0sjxs****-master1-001.hbaseue.rds.aliyuncs.com</para>
                /// </summary>
                [NameInMap("ConnAddr")]
                [Validation(Required=false)]
                public string ConnAddr { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2181</para>
                /// </summary>
                [NameInMap("ConnAddrPort")]
                [Validation(Required=false)]
                public string ConnAddrPort { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("NetType")]
                [Validation(Required=false)]
                public string NetType { get; set; }

            }

        }

    }

}
