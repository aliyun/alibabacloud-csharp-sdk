// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Domain20180208.Models
{
    public class BatchQueryReceivedPushStatusResponseBody : TeaModel {
        /// <summary>
        /// <para>RAM鉴权失败时的标准化错误详情，JSON字符串，包含NoPermissionType、PolicyType、AuthPrincipalType、EncodedDiagnosticMessage等字段</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;AuthAction&quot;:&quot;domain:BatchQueryReceivedPushStatus&quot;,&quot;AuthPrincipalType&quot;:&quot;SubUser&quot;,&quot;NoPermissionType&quot;:&quot;ImplicitDeny&quot;,&quot;PolicyType&quot;:&quot;AccountLevelIdentityBasedPolicy&quot;}</para>
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
        /// <para>50</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>业务数据模块</para>
        /// </summary>
        [NameInMap("Module")]
        [Validation(Required=false)]
        public BatchQueryReceivedPushStatusResponseBodyModule Module { get; set; }
        public class BatchQueryReceivedPushStatusResponseBodyModule : TeaModel {
            /// <summary>
            /// <para>Push接收状态结果列表</para>
            /// </summary>
            [NameInMap("PushResults")]
            [Validation(Required=false)]
            public List<BatchQueryReceivedPushStatusResponseBodyModulePushResults> PushResults { get; set; }
            public class BatchQueryReceivedPushStatusResponseBodyModulePushResults : TeaModel {
                /// <summary>
                /// <para>域名列表，逗号分隔</para>
                /// 
                /// <b>Example:</b>
                /// <para>example.com,test.net</para>
                /// </summary>
                [NameInMap("DomainList")]
                [Validation(Required=false)]
                public string DomainList { get; set; }

                /// <summary>
                /// <para>外部业务ID，卖家发起时指定</para>
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
                /// <para>枚举值：PENDING（待接收）、ACCEPTED（已接收）、REJECTED（已拒绝）、EXPIRED（已过期）、CANCELLED（已取消）</para>
                /// 
                /// <b>Example:</b>
                /// <para>ACCEPTED</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>状态描述，买家视角</para>
                /// 
                /// <b>Example:</b>
                /// <para>已接收</para>
                /// </summary>
                [NameInMap("StatusDesc")]
                [Validation(Required=false)]
                public string StatusDesc { get; set; }

            }

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
