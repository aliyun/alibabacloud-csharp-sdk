// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.GEMP20210413.Models
{
    public class GetProblemPreviewResponseBody : TeaModel {
        /// <summary>
        /// data
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public GetProblemPreviewResponseBodyData Data { get; set; }
        public class GetProblemPreviewResponseBodyData : TeaModel {
            [NameInMap("deAfterData")]
            [Validation(Required=false)]
            public string DeAfterData { get; set; }

            [NameInMap("deBeforeData")]
            [Validation(Required=false)]
            public string DeBeforeData { get; set; }

            [NameInMap("mail")]
            [Validation(Required=false)]
            public GetProblemPreviewResponseBodyDataMail Mail { get; set; }
            public class GetProblemPreviewResponseBodyDataMail : TeaModel {
                [NameInMap("count")]
                [Validation(Required=false)]
                public long? Count { get; set; }

                [NameInMap("users")]
                [Validation(Required=false)]
                public List<GetProblemPreviewResponseBodyDataMailUsers> Users { get; set; }
                public class GetProblemPreviewResponseBodyDataMailUsers : TeaModel {
                    [NameInMap("username")]
                    [Validation(Required=false)]
                    public string Username { get; set; }

                }

            }

            /// <summary>
            /// object
            /// </summary>
            [NameInMap("problem")]
            [Validation(Required=false)]
            public GetProblemPreviewResponseBodyDataProblem Problem { get; set; }
            public class GetProblemPreviewResponseBodyDataProblem : TeaModel {
                [NameInMap("coordinationGroups")]
                [Validation(Required=false)]
                public List<GetProblemPreviewResponseBodyDataProblemCoordinationGroups> CoordinationGroups { get; set; }
                public class GetProblemPreviewResponseBodyDataProblemCoordinationGroups : TeaModel {
                    [NameInMap("serviceGroupDescription")]
                    [Validation(Required=false)]
                    public string ServiceGroupDescription { get; set; }

                    [NameInMap("serviceGroupId")]
                    [Validation(Required=false)]
                    public long? ServiceGroupId { get; set; }

                    [NameInMap("serviceGroupName")]
                    [Validation(Required=false)]
                    public string ServiceGroupName { get; set; }

                }

                [NameInMap("createTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                [NameInMap("discoverTime")]
                [Validation(Required=false)]
                public string DiscoverTime { get; set; }

                [NameInMap("effectionServices")]
                [Validation(Required=false)]
                public List<GetProblemPreviewResponseBodyDataProblemEffectionServices> EffectionServices { get; set; }
                public class GetProblemPreviewResponseBodyDataProblemEffectionServices : TeaModel {
                    [NameInMap("serviceId")]
                    [Validation(Required=false)]
                    public long? ServiceId { get; set; }

                    [NameInMap("serviceName")]
                    [Validation(Required=false)]
                    public string ServiceName { get; set; }

                }

                [NameInMap("isManual")]
                [Validation(Required=false)]
                public bool? IsManual { get; set; }

                [NameInMap("isUpgrade")]
                [Validation(Required=false)]
                public bool? IsUpgrade { get; set; }

                [NameInMap("mainHandlerId")]
                [Validation(Required=false)]
                public string MainHandlerId { get; set; }

                [NameInMap("mainHandlerName")]
                [Validation(Required=false)]
                public string MainHandlerName { get; set; }

                [NameInMap("preliminaryReason")]
                [Validation(Required=false)]
                public string PreliminaryReason { get; set; }

                [NameInMap("problemId")]
                [Validation(Required=false)]
                public long? ProblemId { get; set; }

                [NameInMap("problemLevel")]
                [Validation(Required=false)]
                public string ProblemLevel { get; set; }

                [NameInMap("problemName")]
                [Validation(Required=false)]
                public string ProblemName { get; set; }

                [NameInMap("problemStatus")]
                [Validation(Required=false)]
                public string ProblemStatus { get; set; }

                [NameInMap("progressSummary")]
                [Validation(Required=false)]
                public string ProgressSummary { get; set; }

                [NameInMap("progressSummaryRichTextId")]
                [Validation(Required=false)]
                public long? ProgressSummaryRichTextId { get; set; }

                [NameInMap("recoveryTime")]
                [Validation(Required=false)]
                public string RecoveryTime { get; set; }

                [NameInMap("relatedServiceId")]
                [Validation(Required=false)]
                public long? RelatedServiceId { get; set; }

                [NameInMap("serviceName")]
                [Validation(Required=false)]
                public string ServiceName { get; set; }

            }

            [NameInMap("sms")]
            [Validation(Required=false)]
            public GetProblemPreviewResponseBodyDataSms Sms { get; set; }
            public class GetProblemPreviewResponseBodyDataSms : TeaModel {
                [NameInMap("count")]
                [Validation(Required=false)]
                public long? Count { get; set; }

                [NameInMap("users")]
                [Validation(Required=false)]
                public List<GetProblemPreviewResponseBodyDataSmsUsers> Users { get; set; }
                public class GetProblemPreviewResponseBodyDataSmsUsers : TeaModel {
                    [NameInMap("username")]
                    [Validation(Required=false)]
                    public string Username { get; set; }

                }

            }

            [NameInMap("upAfterData")]
            [Validation(Required=false)]
            public string UpAfterData { get; set; }

            [NameInMap("upBeforeData")]
            [Validation(Required=false)]
            public string UpBeforeData { get; set; }

            [NameInMap("voice")]
            [Validation(Required=false)]
            public GetProblemPreviewResponseBodyDataVoice Voice { get; set; }
            public class GetProblemPreviewResponseBodyDataVoice : TeaModel {
                [NameInMap("count")]
                [Validation(Required=false)]
                public long? Count { get; set; }

                [NameInMap("users")]
                [Validation(Required=false)]
                public List<GetProblemPreviewResponseBodyDataVoiceUsers> Users { get; set; }
                public class GetProblemPreviewResponseBodyDataVoiceUsers : TeaModel {
                    [NameInMap("username")]
                    [Validation(Required=false)]
                    public string Username { get; set; }

                }

            }

            /// <summary>
            /// webhook
            /// </summary>
            [NameInMap("webhook")]
            [Validation(Required=false)]
            public GetProblemPreviewResponseBodyDataWebhook Webhook { get; set; }
            public class GetProblemPreviewResponseBodyDataWebhook : TeaModel {
                [NameInMap("count")]
                [Validation(Required=false)]
                public long? Count { get; set; }

                [NameInMap("serviceGroups")]
                [Validation(Required=false)]
                public List<GetProblemPreviewResponseBodyDataWebhookServiceGroups> ServiceGroups { get; set; }
                public class GetProblemPreviewResponseBodyDataWebhookServiceGroups : TeaModel {
                    [NameInMap("serviceName")]
                    [Validation(Required=false)]
                    public string ServiceName { get; set; }

                }

            }

        }

        /// <summary>
        /// requestId
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
