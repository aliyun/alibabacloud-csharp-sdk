// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appstream_center20210901.Models
{
    public class ListSessionPackagesResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListSessionPackagesResponseBodyData> Data { get; set; }
        public class ListSessionPackagesResponseBodyData : TeaModel {
            [NameInMap("AvailableHours")]
            [Validation(Required=false)]
            public long? AvailableHours { get; set; }

            [NameInMap("ChargeType")]
            [Validation(Required=false)]
            public string ChargeType { get; set; }

            [NameInMap("DeleteStatus")]
            [Validation(Required=false)]
            public int? DeleteStatus { get; set; }

            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            [NameInMap("GmtModifiedTime")]
            [Validation(Required=false)]
            public string GmtModifiedTime { get; set; }

            [NameInMap("InstanceObject")]
            [Validation(Required=false)]
            public ListSessionPackagesResponseBodyDataInstanceObject InstanceObject { get; set; }
            public class ListSessionPackagesResponseBodyDataInstanceObject : TeaModel {
                [NameInMap("ExpiredTime")]
                [Validation(Required=false)]
                public string ExpiredTime { get; set; }

                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                [NameInMap("InstanceType")]
                [Validation(Required=false)]
                public string InstanceType { get; set; }

                [NameInMap("ResourceId")]
                [Validation(Required=false)]
                public string ResourceId { get; set; }

                [NameInMap("ResourceType")]
                [Validation(Required=false)]
                public string ResourceType { get; set; }

                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public string StartTime { get; set; }

                [NameInMap("TotalTime")]
                [Validation(Required=false)]
                public long? TotalTime { get; set; }

                [NameInMap("UsedTime")]
                [Validation(Required=false)]
                public long? UsedTime { get; set; }

            }

            [NameInMap("MaxHours")]
            [Validation(Required=false)]
            public long? MaxHours { get; set; }

            [NameInMap("MaxSessions")]
            [Validation(Required=false)]
            public long? MaxSessions { get; set; }

            [NameInMap("ProjectId")]
            [Validation(Required=false)]
            public string ProjectId { get; set; }

            [NameInMap("ProjectName")]
            [Validation(Required=false)]
            public string ProjectName { get; set; }

            [NameInMap("Region")]
            [Validation(Required=false)]
            public string Region { get; set; }

            [NameInMap("SessionPackageId")]
            [Validation(Required=false)]
            public string SessionPackageId { get; set; }

            [NameInMap("SessionPackageName")]
            [Validation(Required=false)]
            public string SessionPackageName { get; set; }

            [NameInMap("SessionPackageTypeId")]
            [Validation(Required=false)]
            public string SessionPackageTypeId { get; set; }

            [NameInMap("SessionSpec")]
            [Validation(Required=false)]
            public string SessionSpec { get; set; }

            [NameInMap("SessionUsageRate")]
            [Validation(Required=false)]
            public long? SessionUsageRate { get; set; }

            [NameInMap("State")]
            [Validation(Required=false)]
            public int? State { get; set; }

            [NameInMap("UserIdentification")]
            [Validation(Required=false)]
            public long? UserIdentification { get; set; }

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
        public long? TotalCount { get; set; }

    }

}
