// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dysmsapi20170525.Models
{
    public class QuerySmsAuthorizationLetterResponseBody : TeaModel {
        [NameInMap("AccessDeniedDetail")]
        [Validation(Required=false)]
        public string AccessDeniedDetail { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<QuerySmsAuthorizationLetterResponseBodyData> Data { get; set; }
        public class QuerySmsAuthorizationLetterResponseBodyData : TeaModel {
            /// <summary>
            /// <para>委托授权方</para>
            /// 
            /// <b>Example:</b>
            /// <para>示例值示例值</para>
            /// </summary>
            [NameInMap("Authorization")]
            [Validation(Required=false)]
            public string Authorization { get; set; }

            /// <summary>
            /// <para>委托授权书有效期</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-01-01~2026-01-01</para>
            /// </summary>
            [NameInMap("AuthorizationLetterExpDate")]
            [Validation(Required=false)]
            public string AuthorizationLetterExpDate { get; set; }

            /// <summary>
            /// <para>委托授权书id</para>
            /// 
            /// <b>Example:</b>
            /// <para>10000******</para>
            /// </summary>
            [NameInMap("AuthorizationLetterId")]
            [Validation(Required=false)]
            public long? AuthorizationLetterId { get; set; }

            /// <summary>
            /// <para>委托授权书命名</para>
            /// 
            /// <b>Example:</b>
            /// <para>示例值示例值</para>
            /// </summary>
            [NameInMap("AuthorizationLetterName")]
            [Validation(Required=false)]
            public string AuthorizationLetterName { get; set; }

            /// <summary>
            /// <para>委托授权书图片地址</para>
            /// </summary>
            [NameInMap("AuthorizationLetterPic")]
            [Validation(Required=false)]
            public string AuthorizationLetterPic { get; set; }

            /// <summary>
            /// <para>授权方统一社会信用代码</para>
            /// 
            /// <b>Example:</b>
            /// <para>9****************A</para>
            /// </summary>
            [NameInMap("OrganizationCode")]
            [Validation(Required=false)]
            public string OrganizationCode { get; set; }

            /// <summary>
            /// <para>被委托授权方</para>
            /// 
            /// <b>Example:</b>
            /// <para>示例值示例值示例值</para>
            /// </summary>
            [NameInMap("ProxyAuthorization")]
            [Validation(Required=false)]
            public string ProxyAuthorization { get; set; }

            /// <summary>
            /// <para>委托授权签名范围</para>
            /// 
            /// <b>Example:</b>
            /// <para>示例值</para>
            /// </summary>
            [NameInMap("SignScope")]
            [Validation(Required=false)]
            public string SignScope { get; set; }

            /// <summary>
            /// <para>委托授权书审核状态（初始化INT/审核通过PASSED）</para>
            /// 
            /// <b>Example:</b>
            /// <para>PASSED</para>
            /// </summary>
            [NameInMap("State")]
            [Validation(Required=false)]
            public string State { get; set; }

            /// <summary>
            /// <para>委托授权书可用状态（可用VALID/不可用INVALID）</para>
            /// 
            /// <b>Example:</b>
            /// <para>VALID</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>25D5AFDE-8EBC-132E-8909-1FDC071D</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
