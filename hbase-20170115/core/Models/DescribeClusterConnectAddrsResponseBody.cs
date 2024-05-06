// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.HBase20170115.Models
{
    public class DescribeClusterConnectAddrsResponseBody : TeaModel {
        [NameInMap("DbType")]
        [Validation(Required=false)]
        public string DbType { get; set; }

        [NameInMap("IsMultimod")]
        [Validation(Required=false)]
        public string IsMultimod { get; set; }

        [NameInMap("NetType")]
        [Validation(Required=false)]
        public string NetType { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ServiceConnAddrs")]
        [Validation(Required=false)]
        public DescribeClusterConnectAddrsResponseBodyServiceConnAddrs ServiceConnAddrs { get; set; }
        public class DescribeClusterConnectAddrsResponseBodyServiceConnAddrs : TeaModel {
            [NameInMap("ServiceConnAddr")]
            [Validation(Required=false)]
            public List<DescribeClusterConnectAddrsResponseBodyServiceConnAddrsServiceConnAddr> ServiceConnAddr { get; set; }
            public class DescribeClusterConnectAddrsResponseBodyServiceConnAddrsServiceConnAddr : TeaModel {
                [NameInMap("ConnAddrInfo")]
                [Validation(Required=false)]
                public DescribeClusterConnectAddrsResponseBodyServiceConnAddrsServiceConnAddrConnAddrInfo ConnAddrInfo { get; set; }
                public class DescribeClusterConnectAddrsResponseBodyServiceConnAddrsServiceConnAddrConnAddrInfo : TeaModel {
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
        public DescribeClusterConnectAddrsResponseBodySlbConnAddrs SlbConnAddrs { get; set; }
        public class DescribeClusterConnectAddrsResponseBodySlbConnAddrs : TeaModel {
            [NameInMap("SlbConnAddr")]
            [Validation(Required=false)]
            public List<DescribeClusterConnectAddrsResponseBodySlbConnAddrsSlbConnAddr> SlbConnAddr { get; set; }
            public class DescribeClusterConnectAddrsResponseBodySlbConnAddrsSlbConnAddr : TeaModel {
                [NameInMap("ConnAddrInfo")]
                [Validation(Required=false)]
                public DescribeClusterConnectAddrsResponseBodySlbConnAddrsSlbConnAddrConnAddrInfo ConnAddrInfo { get; set; }
                public class DescribeClusterConnectAddrsResponseBodySlbConnAddrsSlbConnAddrConnAddrInfo : TeaModel {
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

        [NameInMap("ThriftConn")]
        [Validation(Required=false)]
        public DescribeClusterConnectAddrsResponseBodyThriftConn ThriftConn { get; set; }
        public class DescribeClusterConnectAddrsResponseBodyThriftConn : TeaModel {
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

        [NameInMap("UiProxyConnAddrInfo")]
        [Validation(Required=false)]
        public DescribeClusterConnectAddrsResponseBodyUiProxyConnAddrInfo UiProxyConnAddrInfo { get; set; }
        public class DescribeClusterConnectAddrsResponseBodyUiProxyConnAddrInfo : TeaModel {
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

        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

        [NameInMap("ZkConnAddrs")]
        [Validation(Required=false)]
        public DescribeClusterConnectAddrsResponseBodyZkConnAddrs ZkConnAddrs { get; set; }
        public class DescribeClusterConnectAddrsResponseBodyZkConnAddrs : TeaModel {
            [NameInMap("ZkConnAddr")]
            [Validation(Required=false)]
            public List<DescribeClusterConnectAddrsResponseBodyZkConnAddrsZkConnAddr> ZkConnAddr { get; set; }
            public class DescribeClusterConnectAddrsResponseBodyZkConnAddrsZkConnAddr : TeaModel {
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
