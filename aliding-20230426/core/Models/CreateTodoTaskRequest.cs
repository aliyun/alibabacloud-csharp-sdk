// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aliding20230426.Models
{
    public class CreateTodoTaskRequest : TeaModel {
        [NameInMap("TenantContext")]
        [Validation(Required=false)]
        public CreateTodoTaskRequestTenantContext TenantContext { get; set; }
        public class CreateTodoTaskRequestTenantContext : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("tenantId")]
            [Validation(Required=false)]
            public string TenantId { get; set; }

        }

        [NameInMap("actionList")]
        [Validation(Required=false)]
        public List<CreateTodoTaskRequestActionList> ActionList { get; set; }
        public class CreateTodoTaskRequestActionList : TeaModel {
            [NameInMap("actionKey")]
            [Validation(Required=false)]
            public string ActionKey { get; set; }

            [NameInMap("actionType")]
            [Validation(Required=false)]
            public int? ActionType { get; set; }

            [NameInMap("buttonStyleType")]
            [Validation(Required=false)]
            public int? ButtonStyleType { get; set; }

            [NameInMap("param")]
            [Validation(Required=false)]
            public CreateTodoTaskRequestActionListParam Param { get; set; }
            public class CreateTodoTaskRequestActionListParam : TeaModel {
                [NameInMap("body")]
                [Validation(Required=false)]
                public string Body { get; set; }

                [NameInMap("header")]
                [Validation(Required=false)]
                public Dictionary<string, string> Header { get; set; }

            }

            [NameInMap("pcUrl")]
            [Validation(Required=false)]
            public string PcUrl { get; set; }

            [NameInMap("title")]
            [Validation(Required=false)]
            public string Title { get; set; }

            [NameInMap("url")]
            [Validation(Required=false)]
            public string Url { get; set; }

        }

        [NameInMap("contentFieldList")]
        [Validation(Required=false)]
        public List<CreateTodoTaskRequestContentFieldList> ContentFieldList { get; set; }
        public class CreateTodoTaskRequestContentFieldList : TeaModel {
            /// <summary>
            /// <para>fieldKey</para>
            /// 
            /// <b>Example:</b>
            /// <para>fieldKey</para>
            /// </summary>
            [NameInMap("fieldKey")]
            [Validation(Required=false)]
            public string FieldKey { get; set; }

            /// <summary>
            /// <para>fieldValue</para>
            /// 
            /// <b>Example:</b>
            /// <para>fieldValue</para>
            /// </summary>
            [NameInMap("fieldValue")]
            [Validation(Required=false)]
            public string FieldValue { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>PUoiinWIpa2yH2ymhiiGiP6g</para>
        /// </summary>
        [NameInMap("creatorId")]
        [Validation(Required=false)]
        public string CreatorId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>应用可以调用该接口发起一个钉钉待办任务，该待办事项会出现在钉钉客户端“待办”页面，需要注意的是，通过开放接口发起的待办，目前仅支持直接跳转ISV应用详情页（ISV在调该接口时需传入自身应用详情页链接）。</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("detailUrl")]
        [Validation(Required=false)]
        public CreateTodoTaskRequestDetailUrl DetailUrl { get; set; }
        public class CreateTodoTaskRequestDetailUrl : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="https://www.dingtalk.com">https://www.dingtalk.com</a></para>
            /// </summary>
            [NameInMap("appUrl")]
            [Validation(Required=false)]
            public string AppUrl { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="https://www.dingtalk.com">https://www.dingtalk.com</a></para>
            /// </summary>
            [NameInMap("pcUrl")]
            [Validation(Required=false)]
            public string PcUrl { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1617675000000</para>
        /// </summary>
        [NameInMap("dueTime")]
        [Validation(Required=false)]
        public long? DueTime { get; set; }

        [NameInMap("executorIds")]
        [Validation(Required=false)]
        public List<string> ExecutorIds { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("isOnlyShowExecutor")]
        [Validation(Required=false)]
        public bool? IsOnlyShowExecutor { get; set; }

        [NameInMap("notifyConfigs")]
        [Validation(Required=false)]
        public CreateTodoTaskRequestNotifyConfigs NotifyConfigs { get; set; }
        public class CreateTodoTaskRequestNotifyConfigs : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("dingNotify")]
            [Validation(Required=false)]
            public string DingNotify { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("sendAssistantChat")]
            [Validation(Required=false)]
            public string SendAssistantChat { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("sendTodoApn")]
            [Validation(Required=false)]
            public string SendTodoApn { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>12345</para>
        /// </summary>
        [NameInMap("operatorId")]
        [Validation(Required=false)]
        public string OperatorId { get; set; }

        [NameInMap("participantIds")]
        [Validation(Required=false)]
        public List<string> ParticipantIds { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("priority")]
        [Validation(Required=false)]
        public int? Priority { get; set; }

        [NameInMap("remindNotifyConfigs")]
        [Validation(Required=false)]
        public CreateTodoTaskRequestRemindNotifyConfigs RemindNotifyConfigs { get; set; }
        public class CreateTodoTaskRequestRemindNotifyConfigs : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("dingNotify")]
            [Validation(Required=false)]
            public string DingNotify { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("sendTodoApn")]
            [Validation(Required=false)]
            public string SendTodoApn { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1754364432000</para>
        /// </summary>
        [NameInMap("reminderTimeStamp")]
        [Validation(Required=false)]
        public long? ReminderTimeStamp { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>isv_dingtalkTodo1</para>
        /// </summary>
        [NameInMap("sourceId")]
        [Validation(Required=false)]
        public string SourceId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>接入钉钉待办</para>
        /// </summary>
        [NameInMap("subject")]
        [Validation(Required=false)]
        public string Subject { get; set; }

    }

}
