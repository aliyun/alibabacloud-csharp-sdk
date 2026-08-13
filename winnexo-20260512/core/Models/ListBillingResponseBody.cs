// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WinNexo20260512.Models
{
    public class ListBillingResponseBody : TeaModel {
        /// <summary>
        /// <para>业务状态码：成功为 200，失败为后端错误码（ERR.* / InvalidParameter.*）</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("list")]
        [Validation(Required=false)]
        public List<ListBillingResponseBodyList> List { get; set; }
        public class ListBillingResponseBodyList : TeaModel {
            /// <summary>
            /// <para>账单业务ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>exampleBillingId</para>
            /// </summary>
            [NameInMap("billingId")]
            [Validation(Required=false)]
            public string BillingId { get; set; }

            /// <summary>
            /// <para>业务来源ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>exampleBizId</para>
            /// </summary>
            [NameInMap("bizId")]
            [Validation(Required=false)]
            public string BizId { get; set; }

            /// <summary>
            /// <para>业务来源类型</para>
            /// 
            /// <b>Example:</b>
            /// <para>string_value</para>
            /// </summary>
            [NameInMap("bizType")]
            [Validation(Required=false)]
            public string BizType { get; set; }

            /// <summary>
            /// <para>costSource</para>
            /// 
            /// <b>Example:</b>
            /// <para>string_value</para>
            /// </summary>
            [NameInMap("costSource")]
            [Validation(Required=false)]
            public List<string> CostSource { get; set; }

            /// <summary>
            /// <para>costSourceDisplayName</para>
            /// 
            /// <b>Example:</b>
            /// <para>string_value</para>
            /// </summary>
            [NameInMap("costSourceDisplayName")]
            [Validation(Required=false)]
            public List<string> CostSourceDisplayName { get; set; }

            /// <summary>
            /// <para>结束时间</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-10-01T12:00:00Z</para>
            /// </summary>
            [NameInMap("endTime")]
            [Validation(Required=false)]
            public string EndTime { get; set; }

            /// <summary>
            /// <para>入口对象ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>exampleEntryObjectId</para>
            /// </summary>
            [NameInMap("entryObjectId")]
            [Validation(Required=false)]
            public string EntryObjectId { get; set; }

            /// <summary>
            /// <para>入口对象类型</para>
            /// 
            /// <b>Example:</b>
            /// <para>string_value</para>
            /// </summary>
            [NameInMap("entryObjectType")]
            [Validation(Required=false)]
            public string EntryObjectType { get; set; }

            /// <summary>
            /// <para>是否影子账单</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("isShadow")]
            [Validation(Required=false)]
            public bool? IsShadow { get; set; }

            /// <summary>
            /// <para>操作类型</para>
            /// 
            /// <b>Example:</b>
            /// <para>string_value</para>
            /// </summary>
            [NameInMap("operation")]
            [Validation(Required=false)]
            public string Operation { get; set; }

            /// <summary>
            /// <para>操作类型展示名称</para>
            /// 
            /// <b>Example:</b>
            /// <para>string_value</para>
            /// </summary>
            [NameInMap("operationDisplayName")]
            [Validation(Required=false)]
            public string OperationDisplayName { get; set; }

            /// <summary>
            /// <para>开始时间</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-10-01T12:00:00Z</para>
            /// </summary>
            [NameInMap("startTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

            /// <summary>
            /// <para>状态</para>
            /// 
            /// <b>Example:</b>
            /// <para>READY</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>状态展示名称</para>
            /// 
            /// <b>Example:</b>
            /// <para>string_value</para>
            /// </summary>
            [NameInMap("statusDisplayName")]
            [Validation(Required=false)]
            public string StatusDisplayName { get; set; }

            /// <summary>
            /// <para>租户ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>10000</para>
            /// </summary>
            [NameInMap("tenantId")]
            [Validation(Required=false)]
            public long? TenantId { get; set; }

            /// <summary>
            /// <para>汇总 credit 消耗</para>
            /// 
            /// <b>Example:</b>
            /// <para>string_value</para>
            /// </summary>
            [NameInMap("totalCreditCost")]
            [Validation(Required=false)]
            public string TotalCreditCost { get; set; }

            /// <summary>
            /// <para>WINNEXO 平台用户ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("wnUserId")]
            [Validation(Required=false)]
            public string WnUserId { get; set; }

        }

        /// <summary>
        /// <para>错误描述，成功时为空</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>页码</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("page")]
        [Validation(Required=false)]
        public long? Page { get; set; }

        /// <summary>
        /// <para>每页条数</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// <para>请求追踪 ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>019FF406-1B10-0065-A97D-2D1920C2A03D</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>总数</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("total")]
        [Validation(Required=false)]
        public long? Total { get; set; }

    }

}
