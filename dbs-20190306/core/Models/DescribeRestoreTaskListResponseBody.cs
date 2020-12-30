// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dbs20190306.Models
{
    public class DescribeRestoreTaskListResponseBody : TeaModel {
        [NameInMap("PageNum")]
        [Validation(Required=false)]
        public int? PageNum { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        [NameInMap("TotalElements")]
        [Validation(Required=false)]
        public int? TotalElements { get; set; }

        [NameInMap("TotalPages")]
        [Validation(Required=false)]
        public int? TotalPages { get; set; }

        [NameInMap("Items")]
        [Validation(Required=false)]
        public DescribeRestoreTaskListResponseBodyItems Items { get; set; }
        public class DescribeRestoreTaskListResponseBodyItems : TeaModel {
            [NameInMap("RestoreTaskDetail")]
            [Validation(Required=false)]
            public List<DescribeRestoreTaskListResponseBodyItemsRestoreTaskDetail> RestoreTaskDetail { get; set; }
            public class DescribeRestoreTaskListResponseBodyItemsRestoreTaskDetail : TeaModel {
                public string RestoreStatus { get; set; }
                public int? FullStruAfterRestoreProgress { get; set; }
                public string CrossRoleName { get; set; }
                public string RestoreDir { get; set; }
                public string CrossAliyunId { get; set; }
                public string RestoreObjects { get; set; }
                public string BackupPlanId { get; set; }
                public string DestinationEndpointRegion { get; set; }
                public long? RestoreTaskCreateTime { get; set; }
                public string DestinationEndpointUserName { get; set; }
                public long? RestoreTaskFinishTime { get; set; }
                public string DestinationEndpointIpPort { get; set; }
                public string DestinationEndpointDatabaseName { get; set; }
                public string DestinationEndpointOracleSID { get; set; }
                public string DestinationEndpointInstanceType { get; set; }
                public int? FullStruforeRestoreProgress { get; set; }
                public string ErrMessage { get; set; }
                public string RestoreTaskId { get; set; }
                public int? FullDataRestoreProgress { get; set; }
                public int? ContinuousRestoreProgress { get; set; }
                public string DestinationEndpointInstanceID { get; set; }
                public string BackupSetId { get; set; }
                public string RestoreTaskName { get; set; }
                public long? BackupGatewayId { get; set; }
                public long? RestoreTime { get; set; }
            }
        };

        [NameInMap("ErrMessage")]
        [Validation(Required=false)]
        public string ErrMessage { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("ErrCode")]
        [Validation(Required=false)]
        public string ErrCode { get; set; }

    }

}
