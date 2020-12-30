// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cityvisual20181030.Models
{
    public class DescribeResourceProfilesResponseBody : TeaModel {
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("ResourceProfiles")]
        [Validation(Required=false)]
        public DescribeResourceProfilesResponseBodyResourceProfiles ResourceProfiles { get; set; }
        public class DescribeResourceProfilesResponseBodyResourceProfiles : TeaModel {
            [NameInMap("ResourceProfile")]
            [Validation(Required=false)]
            public List<DescribeResourceProfilesResponseBodyResourceProfilesResourceProfile> ResourceProfile { get; set; }
            public class DescribeResourceProfilesResponseBodyResourceProfilesResourceProfile : TeaModel {
                public string ResourceProfileName { get; set; }
                public string ResourceProfileId { get; set; }
                public DescribeResourceProfilesResponseBodyResourceProfilesResourceProfileResourceProfileParams ResourceProfileParams { get; set; }
                public class DescribeResourceProfilesResponseBodyResourceProfilesResourceProfileResourceProfileParams : TeaModel {
                    [NameInMap("ResourceProfileParam")]
                    [Validation(Required=false)]
                    public List<DescribeResourceProfilesResponseBodyResourceProfilesResourceProfileResourceProfileParamsResourceProfileParam> ResourceProfileParam { get; set; }
                    public class DescribeResourceProfilesResponseBodyResourceProfilesResourceProfileResourceProfileParamsResourceProfileParam : TeaModel {
                        [NameInMap("Key")]
                        [Validation(Required=false)]
                        public string Key { get; set; }

                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                }
            }
        };

    }

}
