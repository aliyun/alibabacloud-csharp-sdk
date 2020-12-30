// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeExposedInstanceDetailResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ExposedChains")]
        [Validation(Required=false)]
        public List<DescribeExposedInstanceDetailResponseBodyExposedChains> ExposedChains { get; set; }
        public class DescribeExposedInstanceDetailResponseBodyExposedChains : TeaModel {
            [NameInMap("ExposureIp")]
            [Validation(Required=false)]
            public string ExposureIp { get; set; }

            [NameInMap("InternetIp")]
            [Validation(Required=false)]
            public string InternetIp { get; set; }

            [NameInMap("NntfVulCount")]
            [Validation(Required=false)]
            public int? NntfVulCount { get; set; }

            [NameInMap("AllVulList")]
            [Validation(Required=false)]
            public List<DescribeExposedInstanceDetailResponseBodyExposedChainsAllVulList> AllVulList { get; set; }
            public class DescribeExposedInstanceDetailResponseBodyExposedChainsAllVulList : TeaModel {
                [NameInMap("Type")]
                [Validation(Required=false)]
                public int? Type { get; set; }

                [NameInMap("Necessity")]
                [Validation(Required=false)]
                public string Necessity { get; set; }

                [NameInMap("Uuid")]
                [Validation(Required=false)]
                public int? Uuid { get; set; }

                [NameInMap("AliasName")]
                [Validation(Required=false)]
                public string AliasName { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            [NameInMap("ExposureType")]
            [Validation(Required=false)]
            public string ExposureType { get; set; }

            [NameInMap("IntranetIp")]
            [Validation(Required=false)]
            public string IntranetIp { get; set; }

            [NameInMap("ExposureTypeId")]
            [Validation(Required=false)]
            public string ExposureTypeId { get; set; }

            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            [NameInMap("AsapVulCount")]
            [Validation(Required=false)]
            public int? AsapVulCount { get; set; }

            [NameInMap("Uuid")]
            [Validation(Required=false)]
            public string Uuid { get; set; }

            [NameInMap("RealVulList")]
            [Validation(Required=false)]
            public List<DescribeExposedInstanceDetailResponseBodyExposedChainsRealVulList> RealVulList { get; set; }
            public class DescribeExposedInstanceDetailResponseBodyExposedChainsRealVulList : TeaModel {
                [NameInMap("Type")]
                [Validation(Required=false)]
                public int? Type { get; set; }

                [NameInMap("Necessity")]
                [Validation(Required=false)]
                public string Necessity { get; set; }

                [NameInMap("Uuid")]
                [Validation(Required=false)]
                public int? Uuid { get; set; }

                [NameInMap("AliasName")]
                [Validation(Required=false)]
                public string AliasName { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

            [NameInMap("ExposurePort")]
            [Validation(Required=false)]
            public string ExposurePort { get; set; }

            [NameInMap("InstanceName")]
            [Validation(Required=false)]
            public string InstanceName { get; set; }

            [NameInMap("LaterVulCount")]
            [Validation(Required=false)]
            public int? LaterVulCount { get; set; }

            [NameInMap("ExposureComponent")]
            [Validation(Required=false)]
            public string ExposureComponent { get; set; }

        }

    }

}
