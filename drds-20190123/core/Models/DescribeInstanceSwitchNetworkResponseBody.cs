// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Drds20190123.Models
{
    public class DescribeInstanceSwitchNetworkResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("VpcInfos")]
        [Validation(Required=false)]
        public DescribeInstanceSwitchNetworkResponseBodyVpcInfos VpcInfos { get; set; }
        public class DescribeInstanceSwitchNetworkResponseBodyVpcInfos : TeaModel {
            [NameInMap("VpcInfo")]
            [Validation(Required=false)]
            public List<DescribeInstanceSwitchNetworkResponseBodyVpcInfosVpcInfo> VpcInfo { get; set; }
            public class DescribeInstanceSwitchNetworkResponseBodyVpcInfosVpcInfo : TeaModel {
                public string VpcId { get; set; }
                public string VpcName { get; set; }
                public DescribeInstanceSwitchNetworkResponseBodyVpcInfosVpcInfoVswitchInfos VswitchInfos { get; set; }
                public class DescribeInstanceSwitchNetworkResponseBodyVpcInfosVpcInfoVswitchInfos : TeaModel {
                    [NameInMap("VswitchInfo")]
                    [Validation(Required=false)]
                    public List<DescribeInstanceSwitchNetworkResponseBodyVpcInfosVpcInfoVswitchInfosVswitchInfo> VswitchInfo { get; set; }
                    public class DescribeInstanceSwitchNetworkResponseBodyVpcInfosVpcInfoVswitchInfosVswitchInfo : TeaModel {
                        [NameInMap("VpcId")]
                        [Validation(Required=false)]
                        public string VpcId { get; set; }

                        [NameInMap("DrdsSupported")]
                        [Validation(Required=false)]
                        public bool? DrdsSupported { get; set; }

                        [NameInMap("VswitchId")]
                        [Validation(Required=false)]
                        public string VswitchId { get; set; }

                        [NameInMap("VswitchName")]
                        [Validation(Required=false)]
                        public string VswitchName { get; set; }

                        [NameInMap("AzoneId")]
                        [Validation(Required=false)]
                        public string AzoneId { get; set; }

                    }

                }
                public string RegionId { get; set; }
            }
        };

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
