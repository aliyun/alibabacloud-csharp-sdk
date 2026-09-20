// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.HBase20190101.Models
{
    public class DescribeClusterConnectionResponseBody : TeaModel {
        /// <summary>
        /// <para>The database engine type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>hbaseue</b>: ApsaraDB for HBase Performance-enhanced Edition.</description></item>
        /// <item><description><b>hbase</b>: ApsaraDB for HBase Standard Edition or ApsaraDB for HBase single-node edition.</description></item>
        /// <item><description><b>bds</b>: a BDS instance.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>hbaseue</para>
        /// </summary>
        [NameInMap("DbType")]
        [Validation(Required=false)]
        public string DbType { get; set; }

        /// <summary>
        /// <para>Indicates whether multi-model management is enabled. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: Multi-model management is enabled.</description></item>
        /// <item><description><b>false</b>: Multi-model management is not enabled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("IsMultimod")]
        [Validation(Required=false)]
        public string IsMultimod { get; set; }

        /// <summary>
        /// <para>The network type of the instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>VPC</b>: Virtual Private Cloud (VPC).</description></item>
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
                    [NameInMap("ConnAddr")]
                    [Validation(Required=false)]
                    public string ConnAddr { get; set; }

                    [NameInMap("ConnAddrPort")]
                    [Validation(Required=false)]
                    public string ConnAddrPort { get; set; }

                    [NameInMap("NetType")]
                    [Validation(Required=false)]
                    public string NetType { get; set; }

                }

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
                    [NameInMap("ConnAddr")]
                    [Validation(Required=false)]
                    public string ConnAddr { get; set; }

                    [NameInMap("ConnAddrPort")]
                    [Validation(Required=false)]
                    public string ConnAddrPort { get; set; }

                    [NameInMap("NetType")]
                    [Validation(Required=false)]
                    public string NetType { get; set; }

                }

                [NameInMap("SlbType")]
                [Validation(Required=false)]
                public string SlbType { get; set; }

            }

        }

        /// <summary>
        /// <para>The Thrift endpoint information list.</para>
        /// <remarks>
        /// <para>This parameter list is returned only when the database DPI engine type is <b>hbase</b>.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("ThriftConn")]
        [Validation(Required=false)]
        public DescribeClusterConnectionResponseBodyThriftConn ThriftConn { get; set; }
        public class DescribeClusterConnectionResponseBodyThriftConn : TeaModel {
            /// <summary>
            /// <para>The endpoint.</para>
            /// 
            /// <b>Example:</b>
            /// <para>hb-bp1u0639js2h7****-proxy-thrift.hbase.rds.aliyuncs.com</para>
            /// </summary>
            [NameInMap("ConnAddr")]
            [Validation(Required=false)]
            public string ConnAddr { get; set; }

            /// <summary>
            /// <para>The connection port.</para>
            /// 
            /// <b>Example:</b>
            /// <para>9099</para>
            /// </summary>
            [NameInMap("ConnAddrPort")]
            [Validation(Required=false)]
            public string ConnAddrPort { get; set; }

            /// <summary>
            /// <para>The access type of the endpoint. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>2</b>: internal network access.</description></item>
            /// <item><description><b>0</b>: public network access.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("NetType")]
            [Validation(Required=false)]
            public string NetType { get; set; }

        }

        /// <summary>
        /// <para>The WebUI connection information list.</para>
        /// </summary>
        [NameInMap("UiProxyConnAddrInfo")]
        [Validation(Required=false)]
        public DescribeClusterConnectionResponseBodyUiProxyConnAddrInfo UiProxyConnAddrInfo { get; set; }
        public class DescribeClusterConnectionResponseBodyUiProxyConnAddrInfo : TeaModel {
            /// <summary>
            /// <para>The endpoint.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ld-bp150tns0sjxs****-master1-001.hbaseue.rds.aliyuncs.com</para>
            /// </summary>
            [NameInMap("ConnAddr")]
            [Validation(Required=false)]
            public string ConnAddr { get; set; }

            /// <summary>
            /// <para>The connection port.</para>
            /// 
            /// <b>Example:</b>
            /// <para>443</para>
            /// </summary>
            [NameInMap("ConnAddrPort")]
            [Validation(Required=false)]
            public string ConnAddrPort { get; set; }

            /// <summary>
            /// <para>The access type of the endpoint, which is public network access.</para>
            /// 
            /// <b>Example:</b>
            /// <para>PUBLIC</para>
            /// </summary>
            [NameInMap("NetType")]
            [Validation(Required=false)]
            public string NetType { get; set; }

        }

        /// <summary>
        /// <para>The vSwitch ID in the VPC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vsw-bp1foll427ze3d4ps****</para>
        /// </summary>
        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

        /// <summary>
        /// <para>The VPC ID.</para>
        /// 
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
                [NameInMap("ConnAddr")]
                [Validation(Required=false)]
                public string ConnAddr { get; set; }

                [NameInMap("ConnAddrPort")]
                [Validation(Required=false)]
                public string ConnAddrPort { get; set; }

                [NameInMap("NetType")]
                [Validation(Required=false)]
                public string NetType { get; set; }

            }

        }

    }

}
