// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aliding20230426.Models
{
    public class GetTodoTaskResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>isv_dingtalkTodo</para>
        /// </summary>
        [NameInMap("bizTag")]
        [Validation(Required=false)]
        public string BizTag { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>此参数禁止发布</para>
        /// </summary>
        [NameInMap("cardTypeId")]
        [Validation(Required=false)]
        public string CardTypeId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1617675000000</para>
        /// </summary>
        [NameInMap("createdTime")]
        [Validation(Required=false)]
        public long? CreatedTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>012345</para>
        /// </summary>
        [NameInMap("creatorId")]
        [Validation(Required=false)]
        public string CreatorId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>应用可以调用该接口获取钉钉待办任务详情信息及状态。</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("detailUrl")]
        [Validation(Required=false)]
        public GetTodoTaskResponseBodyDetailUrl DetailUrl { get; set; }
        public class GetTodoTaskResponseBodyDetailUrl : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>dingtalk://dingtalkclient/action/open_mini_app?miniAppId={0}&amp;ddMode=push&amp;page=pages%2ftask-detail%2ftask-detail%3ftaskId%3d{1}</para>
            /// </summary>
            [NameInMap("AppUrl")]
            [Validation(Required=false)]
            public string AppUrl { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="https://todo.dingtalk.com/ding-portal/detail/task/%7B0%7D">https://todo.dingtalk.com/ding-portal/detail/task/{0}</a></para>
            /// </summary>
            [NameInMap("PcUrl")]
            [Validation(Required=false)]
            public string PcUrl { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("done")]
        [Validation(Required=false)]
        public bool? Done { get; set; }

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
        /// <para>1617675000000</para>
        /// </summary>
        [NameInMap("finishTime")]
        [Validation(Required=false)]
        public long? FinishTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>OPJpwtxxxx</para>
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
        /// <para>1617675000000</para>
        /// </summary>
        [NameInMap("modifiedTime")]
        [Validation(Required=false)]
        public long? ModifiedTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>012345</para>
        /// </summary>
        [NameInMap("modifierId")]
        [Validation(Required=false)]
        public string ModifierId { get; set; }

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
        /// <b>Example:</b>
        /// <para>PUoiinWIxxx</para>
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
        /// <para>isv_dingxxx</para>
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

        /// <summary>
        /// <b>Example:</b>
        /// <para>orgId1</para>
        /// </summary>
        [NameInMap("tenantId")]
        [Validation(Required=false)]
        public string TenantId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>org</para>
        /// </summary>
        [NameInMap("tenantType")]
        [Validation(Required=false)]
        public string TenantType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0FAAEC9C-C6C8-5C87-AF8E-1195889BBXXX</para>
        /// </summary>
        [NameInMap("vendorRequestId")]
        [Validation(Required=false)]
        public string VendorRequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>dingtalk</para>
        /// </summary>
        [NameInMap("vendorType")]
        [Validation(Required=false)]
        public string VendorType { get; set; }

    }

}
