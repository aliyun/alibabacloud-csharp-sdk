// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eais20190624.Models
{
    public class DescribeEaisResponseBody : TeaModel {
        [NameInMap("Instances")]
        [Validation(Required=false)]
        public DescribeEaisResponseBodyInstances Instances { get; set; }
        public class DescribeEaisResponseBodyInstances : TeaModel {
            [NameInMap("Instance")]
            [Validation(Required=false)]
            public List<DescribeEaisResponseBodyInstancesInstance> Instance { get; set; }
            public class DescribeEaisResponseBodyInstancesInstance : TeaModel {
                public string Status { get; set; }
                public string CreationTime { get; set; }
                public string ClientInstanceType { get; set; }
                public string ClientInstanceId { get; set; }
                public DescribeEaisResponseBodyInstancesInstanceTags Tags { get; set; }
                public class DescribeEaisResponseBodyInstancesInstanceTags : TeaModel {
                    [NameInMap("Tag")]
                    [Validation(Required=false)]
                    public List<DescribeEaisResponseBodyInstancesInstanceTagsTag> Tag { get; set; }
                    public class DescribeEaisResponseBodyInstancesInstanceTagsTag : TeaModel {
                        [NameInMap("TagValue")]
                        [Validation(Required=false)]
                        public string TagValue { get; set; }

                        [NameInMap("TagKey")]
                        [Validation(Required=false)]
                        public string TagKey { get; set; }

                    }

                }
                public string InstanceType { get; set; }
                public string RegionId { get; set; }
                public string ClientInstanceName { get; set; }
                public string Description { get; set; }
                public string ElasticAcceleratedInstanceId { get; set; }
                public string InstanceName { get; set; }
                public string ZoneId { get; set; }
            }
        };

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

    }

}
