// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aliding20230426.Models
{
    public class CreateTodoTaskResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>isv_dingtalkTodo</para>
        /// </summary>
        [NameInMap("bizTag")]
        [Validation(Required=false)]
        public string BizTag { get; set; }

        [NameInMap("contentFieldList")]
        [Validation(Required=false)]
        public List<CreateTodoTaskResponseBodyContentFieldList> ContentFieldList { get; set; }
        public class CreateTodoTaskResponseBodyContentFieldList : TeaModel {
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
        /// <para>1617675200000</para>
        /// </summary>
        [NameInMap("createdTime")]
        [Validation(Required=false)]
        public long? CreatedTime { get; set; }

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
        public CreateTodoTaskResponseBodyDetailUrl DetailUrl { get; set; }
        public class CreateTodoTaskResponseBodyDetailUrl : TeaModel {
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
        /// <para>false</para>
        /// </summary>
        [NameInMap("done")]
        [Validation(Required=false)]
        public bool? Done { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1617675100000</para>
        /// </summary>
        [NameInMap("dueTime")]
        [Validation(Required=false)]
        public long? DueTime { get; set; }

        [NameInMap("executorIds")]
        [Validation(Required=false)]
        public List<string> ExecutorIds { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1617675200000</para>
        /// </summary>
        [NameInMap("finishTime")]
        [Validation(Required=false)]
        public long? FinishTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>OPJpwtwPVNGIFKURjrzd</para>
        /// </summary>
        [NameInMap("id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("isOnlyShowExecutor")]
        [Validation(Required=false)]
        public bool? IsOnlyShowExecutor { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1617675200000</para>
        /// </summary>
        [NameInMap("modifiedTime")]
        [Validation(Required=false)]
        public long? ModifiedTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>PUoiinWIpa2yH2ymhiiGiP6g</para>
        /// </summary>
        [NameInMap("modifierId")]
        [Validation(Required=false)]
        public string ModifierId { get; set; }

        [NameInMap("notifyConfigs")]
        [Validation(Required=false)]
        public CreateTodoTaskResponseBodyNotifyConfigs NotifyConfigs { get; set; }
        public class CreateTodoTaskResponseBodyNotifyConfigs : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("dingNotify")]
            [Validation(Required=false)]
            public string DingNotify { get; set; }

        }

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

        /// <summary>
        /// <para>requestId</para>
        /// 
        /// <b>Example:</b>
        /// <para>0FAAEC9C-C6C8-5C87-AF8E-1195889BBXXX</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>isv_dingtalkTodo</para>
        /// </summary>
        [NameInMap("source")]
        [Validation(Required=false)]
        public string Source { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>isv_dingtalkTodo1</para>
        /// </summary>
        [NameInMap("sourceId")]
        [Validation(Required=false)]
        public string SourceId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1617675000000</para>
        /// </summary>
        [NameInMap("startTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>接入钉钉待办</para>
        /// </summary>
        [NameInMap("subject")]
        [Validation(Required=false)]
        public string Subject { get; set; }

    }

}
