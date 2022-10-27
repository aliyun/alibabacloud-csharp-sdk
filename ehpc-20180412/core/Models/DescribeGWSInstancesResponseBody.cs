// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20180412.Models
{
    public class DescribeGWSInstancesResponseBody : TeaModel {
        [NameInMap("Instances")]
        [Validation(Required=false)]
        public DescribeGWSInstancesResponseBodyInstances Instances { get; set; }
        public class DescribeGWSInstancesResponseBodyInstances : TeaModel {
            [NameInMap("InstanceInfo")]
            [Validation(Required=false)]
            public List<DescribeGWSInstancesResponseBodyInstancesInstanceInfo> InstanceInfo { get; set; }
            public class DescribeGWSInstancesResponseBodyInstancesInstanceInfo : TeaModel {
                [NameInMap("AppList")]
                [Validation(Required=false)]
                public DescribeGWSInstancesResponseBodyInstancesInstanceInfoAppList AppList { get; set; }
                public class DescribeGWSInstancesResponseBodyInstancesInstanceInfoAppList : TeaModel {
                    [NameInMap("AppInfo")]
                    [Validation(Required=false)]
                    public List<DescribeGWSInstancesResponseBodyInstancesInstanceInfoAppListAppInfo> AppInfo { get; set; }
                    public class DescribeGWSInstancesResponseBodyInstancesInstanceInfoAppListAppInfo : TeaModel {
                        [NameInMap("AppArgs")]
                        [Validation(Required=false)]
                        public string AppArgs { get; set; }

                        [NameInMap("AppName")]
                        [Validation(Required=false)]
                        public string AppName { get; set; }

                        [NameInMap("AppPath")]
                        [Validation(Required=false)]
                        public string AppPath { get; set; }

                    }

                }

                [NameInMap("ClusterId")]
                [Validation(Required=false)]
                public string ClusterId { get; set; }

                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                [NameInMap("ExpireTime")]
                [Validation(Required=false)]
                public string ExpireTime { get; set; }

                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                [NameInMap("InstanceType")]
                [Validation(Required=false)]
                public string InstanceType { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                [NameInMap("UserName")]
                [Validation(Required=false)]
                public string UserName { get; set; }

                [NameInMap("WorkMode")]
                [Validation(Required=false)]
                public string WorkMode { get; set; }

            }

        }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
