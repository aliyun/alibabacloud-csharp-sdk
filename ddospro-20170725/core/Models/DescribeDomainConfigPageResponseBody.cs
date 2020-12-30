// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DDoSPro20170725.Models
{
    public class DescribeDomainConfigPageResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

        [NameInMap("ConfigList")]
        [Validation(Required=false)]
        public List<DescribeDomainConfigPageResponseBodyConfigList> ConfigList { get; set; }
        public class DescribeDomainConfigPageResponseBodyConfigList : TeaModel {
            [NameInMap("Domain")]
            [Validation(Required=false)]
            public string Domain { get; set; }

            [NameInMap("Cname")]
            [Validation(Required=false)]
            public string Cname { get; set; }

            [NameInMap("Instances")]
            [Validation(Required=false)]
            public List<DescribeDomainConfigPageResponseBodyConfigListInstances> Instances { get; set; }
            public class DescribeDomainConfigPageResponseBodyConfigListInstances : TeaModel {
                [NameInMap("InstanceRemark")]
                [Validation(Required=false)]
                public string InstanceRemark { get; set; }

                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                [NameInMap("Rules")]
                [Validation(Required=false)]
                public List<DescribeDomainConfigPageResponseBodyConfigListInstancesRules> Rules { get; set; }
                public class DescribeDomainConfigPageResponseBodyConfigListInstancesRules : TeaModel {
                    [NameInMap("ProxyTypeList")]
                    [Validation(Required=false)]
                    public List<string> ProxyTypeList { get; set; }

                    [NameInMap("Line")]
                    [Validation(Required=false)]
                    public string Line { get; set; }

                    [NameInMap("RealServers")]
                    [Validation(Required=false)]
                    public List<string> RealServers { get; set; }

                    [NameInMap("Ip")]
                    [Validation(Required=false)]
                    public string Ip { get; set; }

                }

            }

        }

    }

}
