// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dysmsapi20170525.Models
{
    public class QuerySmsAuthorizationLetterResponseBody : TeaModel {
        /// <summary>
        /// <para>The details of the access denial. This parameter is returned only when the RAM check fails.</para>
        /// 
        /// <b>Example:</b>
        /// <para>无</para>
        /// </summary>
        [NameInMap("AccessDeniedDetail")]
        [Validation(Required=false)]
        public string AccessDeniedDetail { get; set; }

        /// <summary>
        /// <para>The status code of the request.</para>
        /// <list type="bullet">
        /// <item><description>The value OK indicates that the request was successful.</description></item>
        /// <item><description>For other error codes, see the error code list in this topic or <a href="https://help.aliyun.com/document_detail/101346.html">API error codes</a>.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The information of the letters of authorization.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<QuerySmsAuthorizationLetterResponseBodyData> Data { get; set; }
        public class QuerySmsAuthorizationLetterResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The authorizing party.</para>
            /// 
            /// <b>Example:</b>
            /// <para>菜鸟网络科技有限公司</para>
            /// </summary>
            [NameInMap("Authorization")]
            [Validation(Required=false)]
            public string Authorization { get; set; }

            /// <summary>
            /// <para>The validity period of the letter of authorization. Format: YYYY-MM-DD~YYYY-MM-DD.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-01-01~2026-01-01</para>
            /// </summary>
            [NameInMap("AuthorizationLetterExpDate")]
            [Validation(Required=false)]
            public string AuthorizationLetterExpDate { get; set; }

            /// <summary>
            /// <para>The letter of authorization ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10000******</para>
            /// </summary>
            [NameInMap("AuthorizationLetterId")]
            [Validation(Required=false)]
            public long? AuthorizationLetterId { get; set; }

            /// <summary>
            /// <para>The name of the letter of authorization.</para>
            /// 
            /// <b>Example:</b>
            /// <para>菜鸟公司授权书</para>
            /// </summary>
            [NameInMap("AuthorizationLetterName")]
            [Validation(Required=false)]
            public string AuthorizationLetterName { get; set; }

            /// <summary>
            /// <para>The URL of the letter of authorization file.</para>
            /// </summary>
            [NameInMap("AuthorizationLetterPic")]
            [Validation(Required=false)]
            public string AuthorizationLetterPic { get; set; }

            /// <summary>
            /// <para>The unified social credit code of the authorizing party.</para>
            /// 
            /// <b>Example:</b>
            /// <para>9****************A</para>
            /// </summary>
            [NameInMap("OrganizationCode")]
            [Validation(Required=false)]
            public string OrganizationCode { get; set; }

            /// <summary>
            /// <para>The authorized party.</para>
            /// 
            /// <b>Example:</b>
            /// <para>支付宝（中国）网络技术有限公司</para>
            /// </summary>
            [NameInMap("ProxyAuthorization")]
            [Validation(Required=false)]
            public string ProxyAuthorization { get; set; }

            /// <summary>
            /// <para>The authorized signature scope. If multiple signatures are included, the signatures are separated by Chinese enumeration commas (、).</para>
            /// 
            /// <b>Example:</b>
            /// <para>菜鸟网络、菜鸟驿站、菜鸟裹裹</para>
            /// </summary>
            [NameInMap("SignScope")]
            [Validation(Required=false)]
            public string SignScope { get; set; }

            /// <summary>
            /// <para>The status of the letter of authorization, which is related to the review status of the signature. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>INT</b>: Pending review. The letter of authorization has been created. After you submit a signature application, it enters the review process.</description></item>
            /// <item><description><b>PASSED</b>: Review passed. When a signature in the authorized signature scope of the letter of authorization passes the review, the status of the letter of authorization changes to PASSED.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>PASSED</para>
            /// </summary>
            [NameInMap("State")]
            [Validation(Required=false)]
            public string State { get; set; }

            /// <summary>
            /// <para>The availability status of the letter of authorization, which is related to the validity period of the letter of authorization. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>VALID</b>: Available. The letter of authorization is within the validity period.</description></item>
            /// <item><description><b>INVALID</b>: Unavailable. The letter of authorization has expired.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>VALID</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// <para>The description of the status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The ID of the request, which is a unique identifier generated by Alibaba Cloud for the request and can be used to troubleshoot and locate issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>25D5AFDE-8EBC-132E-8909-1FDC071D</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the API call was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: The call was successful.</description></item>
        /// <item><description><b>false</b>: The call failed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
