// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Domain20180208.Models
{
    public class QueryPendingPushListResponseBody : TeaModel {
        /// <summary>
        /// <para>RAM鉴权失败时的标准化错误详情，JSON字符串，包含NoPermissionType、PolicyType、AuthPrincipalType、EncodedDiagnosticMessage等字段</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;AuthAction&quot;:&quot;domain:QueryPendingPushList&quot;,&quot;AuthPrincipalType&quot;:&quot;SubUser&quot;,&quot;NoPermissionType&quot;:&quot;ImplicitDeny&quot;,&quot;PolicyType&quot;:&quot;AccountLevelIdentityBasedPolicy&quot;}</para>
        /// </summary>
        [NameInMap("AccessDeniedDetail")]
        [Validation(Required=false)]
        public string AccessDeniedDetail { get; set; }

        /// <summary>
        /// <para>是否允许重试</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("AllowRetry")]
        [Validation(Required=false)]
        public bool? AllowRetry { get; set; }

        /// <summary>
        /// <para>HTTP状态码</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public long? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>本次返回的最大记录条数</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>业务数据模块</para>
        /// </summary>
        [NameInMap("Module")]
        [Validation(Required=false)]
        public QueryPendingPushListResponseBodyModule Module { get; set; }
        public class QueryPendingPushListResponseBodyModule : TeaModel {
            /// <summary>
            /// <para>当前页码</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageNum")]
            [Validation(Required=false)]
            public int? PageNum { get; set; }

            /// <summary>
            /// <para>每页大小</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>待接收Push列表</para>
            /// </summary>
            [NameInMap("PushList")]
            [Validation(Required=false)]
            public List<QueryPendingPushListResponseBodyModulePushList> PushList { get; set; }
            public class QueryPendingPushListResponseBodyModulePushList : TeaModel {
                /// <summary>
                /// <para>本次Push包含的域名数量</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("DomainCount")]
                [Validation(Required=false)]
                public int? DomainCount { get; set; }

                /// <summary>
                /// <para>域名列表，逗号分隔摘要</para>
                /// 
                /// <b>Example:</b>
                /// <para>example.com,test.net</para>
                /// </summary>
                [NameInMap("DomainList")]
                [Validation(Required=false)]
                public string DomainList { get; set; }

                /// <summary>
                /// <para>超过该时间未操作将自动关闭</para>
                /// <para>Use the UTC time format: yyyy-MM-ddTHH:mmZ</para>
                /// 
                /// <b>Example:</b>
                /// <para>2025-01-08T10:00:00Z</para>
                /// </summary>
                [NameInMap("ExpireTime")]
                [Validation(Required=false)]
                public string ExpireTime { get; set; }

                /// <summary>
                /// <para>卖家发起时指定，用于双方业务关联</para>
                /// 
                /// <b>Example:</b>
                /// <para>biz_order_001</para>
                /// </summary>
                [NameInMap("OutBizId")]
                [Validation(Required=false)]
                public string OutBizId { get; set; }

                /// <summary>
                /// <para>Push编号</para>
                /// 
                /// <b>Example:</b>
                /// <para>push_20250101_abc123</para>
                /// </summary>
                [NameInMap("PushNo")]
                [Validation(Required=false)]
                public string PushNo { get; set; }

                /// <summary>
                /// <para>Push发起时间</para>
                /// <para>Use the UTC time format: yyyy-MM-ddTHH:mmZ</para>
                /// 
                /// <b>Example:</b>
                /// <para>2025-01-01T10:00:00Z</para>
                /// </summary>
                [NameInMap("PushTime")]
                [Validation(Required=false)]
                public string PushTime { get; set; }

                /// <summary>
                /// <para>卖家发起Push时填写的备注信息</para>
                /// 
                /// <b>Example:</b>
                /// <para>代持域名转移，请尽快处理</para>
                /// </summary>
                [NameInMap("SellerRemark")]
                [Validation(Required=false)]
                public string SellerRemark { get; set; }

                /// <summary>
                /// <para>交易金额，0表示免费Push</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("TradeMoney")]
                [Validation(Required=false)]
                public string TradeMoney { get; set; }

            }

            /// <summary>
            /// <para>满足条件的总记录数</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>获取下一页需用到的凭证</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>唯一请求识别码</para>
        /// 
        /// <b>Example:</b>
        /// <para>2DEDFF32-7827-46B1-BE90-3DB8ABD91A58</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>是否调用成功</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
