// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Domain20180208.Models
{
    public class AcceptPushResponseBody : TeaModel {
        /// <summary>
        /// <para>RAM鉴权失败时的标准化错误详情，JSON字符串，包含NoPermissionType、PolicyType、AuthPrincipalType、EncodedDiagnosticMessage等字段</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;AuthAction&quot;:&quot;domain:AcceptPush&quot;,&quot;AuthPrincipalType&quot;:&quot;SubUser&quot;,&quot;NoPermissionType&quot;:&quot;ImplicitDeny&quot;,&quot;PolicyType&quot;:&quot;AccountLevelIdentityBasedPolicy&quot;}</para>
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
        /// <para>业务数据模块</para>
        /// </summary>
        [NameInMap("Module")]
        [Validation(Required=false)]
        public AcceptPushResponseBodyModule Module { get; set; }
        public class AcceptPushResponseBodyModule : TeaModel {
            /// <summary>
            /// <para>结果码，失败时返回</para>
            /// 
            /// <b>Example:</b>
            /// <para>ALREADY_ACCEPTED</para>
            /// </summary>
            [NameInMap("Code")]
            [Validation(Required=false)]
            public string Code { get; set; }

            /// <summary>
            /// <para>结果描述</para>
            /// 
            /// <b>Example:</b>
            /// <para>接收成功</para>
            /// </summary>
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

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
            /// <para>是否接收成功</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Success")]
            [Validation(Required=false)]
            public bool? Success { get; set; }

        }

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
