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
            /// <summary>
            /// <b>Example:</b>
            /// <para>cn-zhangjiakou</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>629755508</para>
            /// </summary>
            [NameInMap("SecurityEventId")]
            [Validation(Required=false)]
            public long? SecurityEventId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>default</para>
            /// </summary>
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

            /// <summary>
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

        }

        [NameInMap("DescribeSecurityEventOperationStatusRequest")]
        [Validation(Required=false)]
        public GetAliYunSafeCenterResultRequestDescribeSecurityEventOperationStatusRequest DescribeSecurityEventOperationStatusRequest { get; set; }
        public class GetAliYunSafeCenterResultRequestDescribeSecurityEventOperationStatusRequest : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>cn-zhangjiakou</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            [NameInMap("SecurityEventIds")]
            [Validation(Required=false)]
            public List<string> SecurityEventIds { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0BC3B4E600002A9F000048BCDCE7E710</para>
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public long? TaskId { get; set; }

        }

        [NameInMap("DescribeSimilarSecurityEventsRequest")]
        [Validation(Required=false)]
        public GetAliYunSafeCenterResultRequestDescribeSimilarSecurityEventsRequest DescribeSimilarSecurityEventsRequest { get; set; }
        public class GetAliYunSafeCenterResultRequestDescribeSimilarSecurityEventsRequest : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>cn-zhangjiakou</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1689135</para>
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public long? TaskId { get; set; }

        }

        [NameInMap("GetAssetDetailByUuidRequest")]
        [Validation(Required=false)]
        public GetAliYunSafeCenterResultRequestGetAssetDetailByUuidRequest GetAssetDetailByUuidRequest { get; set; }
        public class GetAliYunSafeCenterResultRequestGetAssetDetailByUuidRequest : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>cn-shanghai</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>9A75F21D3993C0A2B094A4AB132890B2</para>
            /// </summary>
            [NameInMap("Uuid")]
            [Validation(Required=false)]
            public string Uuid { get; set; }

        }

        [NameInMap("HandleSecurityEventsRequest")]
        [Validation(Required=false)]
        public GetAliYunSafeCenterResultRequestHandleSecurityEventsRequest HandleSecurityEventsRequest { get; set; }
        public class GetAliYunSafeCenterResultRequestHandleSecurityEventsRequest : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>default</para>
            /// </summary>
            [NameInMap("AlertType")]
            [Validation(Required=false)]
            public string AlertType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>fbbb90731fbb6df57c933173182d01a5</para>
            /// </summary>
            [NameInMap("FileMd5")]
            [Validation(Required=false)]
            public string FileMd5 { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>flyfish-lfp-wy.release</para>
            /// </summary>
            [NameInMap("FilePath")]
            [Validation(Required=false)]
            public string FilePath { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>api-shared-vpc-002</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>123.56.127.180</para>
            /// </summary>
            [NameInMap("Ip")]
            [Validation(Required=false)]
            public string Ip { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("MarkBatch")]
            [Validation(Required=false)]
            public string MarkBatch { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>[{&quot;uuid&quot;:&quot;part&quot;,&quot;field&quot;:&quot;gmtModified&quot;,&quot;operate&quot;:&quot;contains&quot;,&quot;fieldValue&quot;:&quot;asd&quot;},{&quot;uuid&quot;:&quot;part&quot;,&quot;field&quot;:&quot;loginUser&quot;,&quot;operate&quot;:&quot;contains&quot;,&quot;fieldValue&quot;:&quot;vff&quot;}]</para>
            /// </summary>
            [NameInMap("MarkMissParam")]
            [Validation(Required=false)]
            public string MarkMissParam { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>block_ip</para>
            /// </summary>
            [NameInMap("OperationCode")]
            [Validation(Required=false)]
            public string OperationCode { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>{\&quot;expireTime\&quot;:1719588943551,\&quot;subOperation\&quot;:\&quot;killAndQuaraFileByMd5andPath\&quot;}</para>
            /// </summary>
            [NameInMap("OperationParams")]
            [Validation(Required=false)]
            public string OperationParams { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>11</para>
            /// </summary>
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
            /// <summary>
            /// <b>Example:</b>
            /// <para>default</para>
            /// </summary>
            [NameInMap("AlertType")]
            [Validation(Required=false)]
            public string AlertType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>cfw_elasticity_public_cn-g4t3nkh3i00b</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>203.10*.44.71</para>
            /// </summary>
            [NameInMap("Ip")]
            [Validation(Required=false)]
            public string Ip { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>offline_handled</para>
            /// </summary>
            [NameInMap("OperationCode")]
            [Validation(Required=false)]
            public string OperationCode { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>{\&quot;expireTime\&quot;:1767687685917}</para>
            /// </summary>
            [NameInMap("OperationParams")]
            [Validation(Required=false)]
            public string OperationParams { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>cn-beijing</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>220.2*3.155.93</para>
            /// </summary>
            [NameInMap("SourceIp")]
            [Validation(Required=false)]
            public string SourceIp { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>12221</para>
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public long? TaskId { get; set; }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ListInstanceStatus</para>
        /// </summary>
        [NameInMap("InterfaceCode")]
        [Validation(Required=false)]
        public string InterfaceCode { get; set; }

        [NameInMap("ListInstancesRequest")]
        [Validation(Required=false)]
        public GetAliYunSafeCenterResultRequestListInstancesRequest ListInstancesRequest { get; set; }
        public class GetAliYunSafeCenterResultRequestListInstancesRequest : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>[&quot;2ad1ae67295445f598017499dc****&quot;, &quot;2ad1ae67295445f598017123dc****&quot;]</para>
            /// </summary>
            [NameInMap("InstanceIds")]
            [Validation(Required=false)]
            public string InstanceIds { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>cn-wulanchabu</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>cn-guangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
