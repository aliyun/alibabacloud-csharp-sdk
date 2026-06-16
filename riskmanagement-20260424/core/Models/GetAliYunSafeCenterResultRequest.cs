// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RiskManagement20260424.Models
{
    public class GetAliYunSafeCenterResultRequest : TeaModel {
        [NameInMap("CreateSimilarSecurityEventsQueryTaskRequest")]
        [Validation(Required=false)]
        public GetAliYunSafeCenterResultRequestCreateSimilarSecurityEventsQueryTaskRequest CreateSimilarSecurityEventsQueryTaskRequest { get; set; }
        public class GetAliYunSafeCenterResultRequestCreateSimilarSecurityEventsQueryTaskRequest : TeaModel {
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            [NameInMap("SecurityEventId")]
            [Validation(Required=false)]
            public long? SecurityEventId { get; set; }

            [NameInMap("SimilarEventScenarioCode")]
            [Validation(Required=false)]
            public string SimilarEventScenarioCode { get; set; }

        }

        [NameInMap("DescribeInstancesFullStatusRequest")]
        [Validation(Required=false)]
        public GetAliYunSafeCenterResultRequestDescribeInstancesFullStatusRequest DescribeInstancesFullStatusRequest { get; set; }
        public class GetAliYunSafeCenterResultRequestDescribeInstancesFullStatusRequest : TeaModel {
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public List<string> InstanceId { get; set; }

            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

        }

        [NameInMap("DescribeSecurityEventOperationStatusRequest")]
        [Validation(Required=false)]
        public GetAliYunSafeCenterResultRequestDescribeSecurityEventOperationStatusRequest DescribeSecurityEventOperationStatusRequest { get; set; }
        public class GetAliYunSafeCenterResultRequestDescribeSecurityEventOperationStatusRequest : TeaModel {
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            [NameInMap("SecurityEventIds")]
            [Validation(Required=false)]
            public List<string> SecurityEventIds { get; set; }

            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public long? TaskId { get; set; }

        }

        [NameInMap("DescribeSimilarSecurityEventsRequest")]
        [Validation(Required=false)]
        public GetAliYunSafeCenterResultRequestDescribeSimilarSecurityEventsRequest DescribeSimilarSecurityEventsRequest { get; set; }
        public class GetAliYunSafeCenterResultRequestDescribeSimilarSecurityEventsRequest : TeaModel {
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public long? TaskId { get; set; }

        }

        [NameInMap("GetAssetDetailByUuidRequest")]
        [Validation(Required=false)]
        public GetAliYunSafeCenterResultRequestGetAssetDetailByUuidRequest GetAssetDetailByUuidRequest { get; set; }
        public class GetAliYunSafeCenterResultRequestGetAssetDetailByUuidRequest : TeaModel {
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            [NameInMap("Uuid")]
            [Validation(Required=false)]
            public string Uuid { get; set; }

        }

        [NameInMap("HandleSecurityEventsRequest")]
        [Validation(Required=false)]
        public GetAliYunSafeCenterResultRequestHandleSecurityEventsRequest HandleSecurityEventsRequest { get; set; }
        public class GetAliYunSafeCenterResultRequestHandleSecurityEventsRequest : TeaModel {
            [NameInMap("AlertType")]
            [Validation(Required=false)]
            public string AlertType { get; set; }

            [NameInMap("FileMd5")]
            [Validation(Required=false)]
            public string FileMd5 { get; set; }

            [NameInMap("FilePath")]
            [Validation(Required=false)]
            public string FilePath { get; set; }

            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            [NameInMap("Ip")]
            [Validation(Required=false)]
            public string Ip { get; set; }

            [NameInMap("MarkBatch")]
            [Validation(Required=false)]
            public string MarkBatch { get; set; }

            [NameInMap("MarkMissParam")]
            [Validation(Required=false)]
            public string MarkMissParam { get; set; }

            [NameInMap("OperationCode")]
            [Validation(Required=false)]
            public string OperationCode { get; set; }

            [NameInMap("OperationParams")]
            [Validation(Required=false)]
            public string OperationParams { get; set; }

            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            [NameInMap("Remark")]
            [Validation(Required=false)]
            public string Remark { get; set; }

            [NameInMap("SecurityEventIds")]
            [Validation(Required=false)]
            public List<string> SecurityEventIds { get; set; }

        }

        [NameInMap("HandleSimilarSecurityEventsRequest")]
        [Validation(Required=false)]
        public GetAliYunSafeCenterResultRequestHandleSimilarSecurityEventsRequest HandleSimilarSecurityEventsRequest { get; set; }
        public class GetAliYunSafeCenterResultRequestHandleSimilarSecurityEventsRequest : TeaModel {
            [NameInMap("AlertType")]
            [Validation(Required=false)]
            public string AlertType { get; set; }

            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            [NameInMap("Ip")]
            [Validation(Required=false)]
            public string Ip { get; set; }

            [NameInMap("OperationCode")]
            [Validation(Required=false)]
            public string OperationCode { get; set; }

            [NameInMap("OperationParams")]
            [Validation(Required=false)]
            public string OperationParams { get; set; }

            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            [NameInMap("SourceIp")]
            [Validation(Required=false)]
            public string SourceIp { get; set; }

            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public long? TaskId { get; set; }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("InterfaceCode")]
        [Validation(Required=false)]
        public string InterfaceCode { get; set; }

        [NameInMap("ListInstancesRequest")]
        [Validation(Required=false)]
        public GetAliYunSafeCenterResultRequestListInstancesRequest ListInstancesRequest { get; set; }
        public class GetAliYunSafeCenterResultRequestListInstancesRequest : TeaModel {
            [NameInMap("InstanceIds")]
            [Validation(Required=false)]
            public string InstanceIds { get; set; }

            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

        }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
