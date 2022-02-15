// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.GEMP20210413.Models
{
    public class GetProblemPreviewResponseBody : TeaModel {
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
                /// <summary>
                /// 数量
                /// </summary>
                [NameInMap("count")]
                [Validation(Required=false)]
                public long? Count { get; set; }

                [NameInMap("users")]
                [Validation(Required=false)]
                public List<GetProblemPreviewResponseBodyDataMailUsers> Users { get; set; }
                public class GetProblemPreviewResponseBodyDataMailUsers : TeaModel {
                    /// <summary>
                    /// 用户名称
                    /// </summary>
                    [NameInMap("username")]
                    [Validation(Required=false)]
                    public string Username { get; set; }

                }

            }
            [NameInMap("problem")]
            [Validation(Required=false)]
            public GetProblemPreviewResponseBodyDataProblem Problem { get; set; }
            public class GetProblemPreviewResponseBodyDataProblem : TeaModel {
                /// <summary>
                /// 应急协同组
                /// </summary>
                [NameInMap("coordinationGroups")]
                [Validation(Required=false)]
                public List<GetProblemPreviewResponseBodyDataProblemCoordinationGroups> CoordinationGroups { get; set; }
                public class GetProblemPreviewResponseBodyDataProblemCoordinationGroups : TeaModel {
                    /// <summary>
                    /// 服务组Maison
                    /// </summary>
                    [NameInMap("serviceGroupDescription")]
                    [Validation(Required=false)]
                    public string ServiceGroupDescription { get; set; }

                    /// <summary>
                    /// 服务Id
                    /// </summary>
                    [NameInMap("serviceGroupId")]
                    [Validation(Required=false)]
                    public long? ServiceGroupId { get; set; }

                    /// <summary>
                    /// 服务组名称
                    /// </summary>
                    [NameInMap("serviceGroupName")]
                    [Validation(Required=false)]
                    public string ServiceGroupName { get; set; }

                }

                /// <summary>
                /// 创建时间
                /// </summary>
                [NameInMap("createTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// 发现时间
                /// </summary>
                [NameInMap("discoverTime")]
                [Validation(Required=false)]
                public string DiscoverTime { get; set; }

                /// <summary>
                /// 影响服务
                /// </summary>
                [NameInMap("effectionServices")]
                [Validation(Required=false)]
                public List<GetProblemPreviewResponseBodyDataProblemEffectionServices> EffectionServices { get; set; }
                public class GetProblemPreviewResponseBodyDataProblemEffectionServices : TeaModel {
                    /// <summary>
                    /// 影响服务Id
                    /// </summary>
                    [NameInMap("serviceId")]
                    [Validation(Required=false)]
                    public long? ServiceId { get; set; }

                    /// <summary>
                    /// 影响服务名称
                    /// </summary>
                    [NameInMap("serviceName")]
                    [Validation(Required=false)]
                    public string ServiceName { get; set; }

                }

                /// <summary>
                /// 是否手动
                /// </summary>
                [NameInMap("isManual")]
                [Validation(Required=false)]
                public bool? IsManual { get; set; }

                /// <summary>
                /// 是否升级
                /// </summary>
                [NameInMap("isUpgrade")]
                [Validation(Required=false)]
                public bool? IsUpgrade { get; set; }

                /// <summary>
                /// 主要处理人Id
                /// </summary>
                [NameInMap("mainHandlerId")]
                [Validation(Required=false)]
                public string MainHandlerId { get; set; }

                /// <summary>
                /// 主要处理人
                /// </summary>
                [NameInMap("mainHandlerName")]
                [Validation(Required=false)]
                public string MainHandlerName { get; set; }

                /// <summary>
                /// 初步原因
                /// </summary>
                [NameInMap("preliminaryReason")]
                [Validation(Required=false)]
                public string PreliminaryReason { get; set; }

                /// <summary>
                /// 故障Id
                /// </summary>
                [NameInMap("problemId")]
                [Validation(Required=false)]
                public long? ProblemId { get; set; }

                /// <summary>
                /// 故障等级 1=P1 2=P2 3=P3 4=P4
                /// </summary>
                [NameInMap("problemLevel")]
                [Validation(Required=false)]
                public string ProblemLevel { get; set; }

                /// <summary>
                /// 故障名称
                /// </summary>
                [NameInMap("problemName")]
                [Validation(Required=false)]
                public string ProblemName { get; set; }

                /// <summary>
                /// 故障状态 1 处理中 2已恢复 3复盘中 4已复盘 5已取消
                /// </summary>
                [NameInMap("problemStatus")]
                [Validation(Required=false)]
                public string ProblemStatus { get; set; }

                /// <summary>
                /// 进展摘要
                /// </summary>
                [NameInMap("progressSummary")]
                [Validation(Required=false)]
                public string ProgressSummary { get; set; }

                /// <summary>
                /// 富文本id
                /// </summary>
                [NameInMap("progressSummaryRichTextId")]
                [Validation(Required=false)]
                public long? ProgressSummaryRichTextId { get; set; }

                /// <summary>
                /// 恢复时间
                /// </summary>
                [NameInMap("recoveryTime")]
                [Validation(Required=false)]
                public string RecoveryTime { get; set; }

                /// <summary>
                /// 关联服务ID
                /// </summary>
                [NameInMap("relatedServiceId")]
                [Validation(Required=false)]
                public long? RelatedServiceId { get; set; }

                /// <summary>
                /// 关联服务 名称
                /// </summary>
                [NameInMap("serviceName")]
                [Validation(Required=false)]
                public string ServiceName { get; set; }

            }
            [NameInMap("sms")]
            [Validation(Required=false)]
            public GetProblemPreviewResponseBodyDataSms Sms { get; set; }
            public class GetProblemPreviewResponseBodyDataSms : TeaModel {
                /// <summary>
                /// 数量
                /// </summary>
                [NameInMap("count")]
                [Validation(Required=false)]
                public long? Count { get; set; }

                [NameInMap("users")]
                [Validation(Required=false)]
                public List<GetProblemPreviewResponseBodyDataSmsUsers> Users { get; set; }
                public class GetProblemPreviewResponseBodyDataSmsUsers : TeaModel {
                    /// <summary>
                    /// 用户名称
                    /// </summary>
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
                /// <summary>
                /// 数量
                /// </summary>
                [NameInMap("count")]
                [Validation(Required=false)]
                public long? Count { get; set; }

                [NameInMap("users")]
                [Validation(Required=false)]
                public List<GetProblemPreviewResponseBodyDataVoiceUsers> Users { get; set; }
                public class GetProblemPreviewResponseBodyDataVoiceUsers : TeaModel {
                    /// <summary>
                    /// 用户
                    /// </summary>
                    [NameInMap("username")]
                    [Validation(Required=false)]
                    public string Username { get; set; }

                }

            }
            [NameInMap("webhook")]
            [Validation(Required=false)]
            public GetProblemPreviewResponseBodyDataWebhook Webhook { get; set; }
            public class GetProblemPreviewResponseBodyDataWebhook : TeaModel {
                /// <summary>
                /// 数量
                /// </summary>
                [NameInMap("count")]
                [Validation(Required=false)]
                public long? Count { get; set; }

                [NameInMap("serviceGroups")]
                [Validation(Required=false)]
                public List<GetProblemPreviewResponseBodyDataWebhookServiceGroups> ServiceGroups { get; set; }
                public class GetProblemPreviewResponseBodyDataWebhookServiceGroups : TeaModel {
                    /// <summary>
                    /// 服务名称
                    /// </summary>
                    [NameInMap("serviceName")]
                    [Validation(Required=false)]
                    public string ServiceName { get; set; }

                }

            }
        };

        /// <summary>
        /// requestId
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
