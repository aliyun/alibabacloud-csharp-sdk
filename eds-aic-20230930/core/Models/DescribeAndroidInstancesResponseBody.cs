// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eds_aic20230930.Models
{
    public class DescribeAndroidInstancesResponseBody : TeaModel {
        [NameInMap("InstanceModel")]
        [Validation(Required=false)]
        public List<DescribeAndroidInstancesResponseBodyInstanceModel> InstanceModel { get; set; }
        public class DescribeAndroidInstancesResponseBodyInstanceModel : TeaModel {
            [NameInMap("AndroidInstanceGroupId")]
            [Validation(Required=false)]
            public string AndroidInstanceGroupId { get; set; }

            [NameInMap("AndroidInstanceId")]
            [Validation(Required=false)]
            public string AndroidInstanceId { get; set; }

            [NameInMap("AndroidInstanceName")]
            [Validation(Required=false)]
            public string AndroidInstanceName { get; set; }

            [NameInMap("AndroidInstanceStatus")]
            [Validation(Required=false)]
            public string AndroidInstanceStatus { get; set; }

            [NameInMap("AppInstanceGroupId")]
            [Validation(Required=false)]
            public string AppInstanceGroupId { get; set; }

            [NameInMap("AppInstanceId")]
            [Validation(Required=false)]
            public string AppInstanceId { get; set; }

            [NameInMap("AuthorizedUserId")]
            [Validation(Required=false)]
            public string AuthorizedUserId { get; set; }

            [NameInMap("BindUserId")]
            [Validation(Required=false)]
            public string BindUserId { get; set; }

            [NameInMap("ErrorCode")]
            [Validation(Required=false)]
            public string ErrorCode { get; set; }

            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            [NameInMap("KeyPairId")]
            [Validation(Required=false)]
            public string KeyPairId { get; set; }

            [NameInMap("NetworkInterfaceIp")]
            [Validation(Required=false)]
            public string NetworkInterfaceIp { get; set; }

            [NameInMap("PersistentAppInstanceId")]
            [Validation(Required=false)]
            public string PersistentAppInstanceId { get; set; }

            [NameInMap("Rate")]
            [Validation(Required=false)]
            public int? Rate { get; set; }

            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

        }

        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
