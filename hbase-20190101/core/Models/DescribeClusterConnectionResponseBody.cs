// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.HBase20190101.Models
{
    public class DescribeClusterConnectionResponseBody : TeaModel {
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
        public DescribeClusterConnectionResponseBodyServiceConnAddrs ServiceConnAddrs { get; set; }
        public class DescribeClusterConnectionResponseBodyServiceConnAddrs : TeaModel {
            [NameInMap("ServiceConnAddr")]
            [Validation(Required=false)]
            public List<DescribeClusterConnectionResponseBodyServiceConnAddrsServiceConnAddr> ServiceConnAddr { get; set; }
            public class DescribeClusterConnectionResponseBodyServiceConnAddrsServiceConnAddr : TeaModel {
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
                public string ConnType { get; set; }
            }
        };

        [NameInMap("SlbConnAddrs")]
        [Validation(Required=false)]
        public DescribeClusterConnectionResponseBodySlbConnAddrs SlbConnAddrs { get; set; }
        public class DescribeClusterConnectionResponseBodySlbConnAddrs : TeaModel {
            [NameInMap("SlbConnAddr")]
            [Validation(Required=false)]
            public List<DescribeClusterConnectionResponseBodySlbConnAddrsSlbConnAddr> SlbConnAddr { get; set; }
            public class DescribeClusterConnectionResponseBodySlbConnAddrsSlbConnAddr : TeaModel {
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
                public string SlbType { get; set; }
            }
        };

        [NameInMap("ThriftConn")]
        [Validation(Required=false)]
        public DescribeClusterConnectionResponseBodyThriftConn ThriftConn { get; set; }
        public class DescribeClusterConnectionResponseBodyThriftConn : TeaModel {
            [NameInMap("ConnAddr")]
            [Validation(Required=false)]
            public string ConnAddr { get; set; }
            [NameInMap("ConnAddrPort")]
            [Validation(Required=false)]
            public string ConnAddrPort { get; set; }
            [NameInMap("NetType")]
            [Validation(Required=false)]
            public string NetType { get; set; }
        };

        [NameInMap("UiProxyConnAddrInfo")]
        [Validation(Required=false)]
        public DescribeClusterConnectionResponseBodyUiProxyConnAddrInfo UiProxyConnAddrInfo { get; set; }
        public class DescribeClusterConnectionResponseBodyUiProxyConnAddrInfo : TeaModel {
            [NameInMap("ConnAddr")]
            [Validation(Required=false)]
            public string ConnAddr { get; set; }
            [NameInMap("ConnAddrPort")]
            [Validation(Required=false)]
            public string ConnAddrPort { get; set; }
            [NameInMap("NetType")]
            [Validation(Required=false)]
            public string NetType { get; set; }
        };

        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

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
                public string ConnAddr { get; set; }
                public string ConnAddrPort { get; set; }
                public string NetType { get; set; }
            }
        };

    }

}
