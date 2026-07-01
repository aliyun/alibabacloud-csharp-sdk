// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dysmsapi20170525.Models
{
    public class ChangeSignatureQualificationResponseBody : TeaModel {
        /// <summary>
        /// <para>Details of the access denial. This field is returned only if RAM authentication fails.</para>
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
        /// <item><description><para>A value of <c>OK</c> indicates that the request was successful.</para>
        /// </description></item>
        /// <item><description><para>For other error codes, see the error code list in this topic or the <a href="https://help.aliyun.com/document_detail/101346.html">API Error Codes</a> topic.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The returned data structure.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ChangeSignatureQualificationResponseBodyData Data { get; set; }
        public class ChangeSignatureQualificationResponseBodyData : TeaModel {
            /// <summary>
            /// <para>This field is not used. You can ignore it.</para>
            /// </summary>
            [NameInMap("Data")]
            [Validation(Required=false)]
            public Dictionary<string, object> Data { get; set; }

            /// <summary>
            /// <para>The status code of the request.</para>
            /// 
            /// <b>Example:</b>
            /// <para>OK</para>
            /// </summary>
            [NameInMap("ErrCode")]
            [Validation(Required=false)]
            public string ErrCode { get; set; }

            /// <summary>
            /// <para>The description of the status code.</para>
            /// 
            /// <b>Example:</b>
            /// <para>OK</para>
            /// </summary>
            [NameInMap("ErrMessage")]
            [Validation(Required=false)]
            public string ErrMessage { get; set; }

            /// <summary>
            /// <para>Indicates whether the call was successful.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Success")]
            [Validation(Required=false)]
            public bool? Success { get; set; }

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
        /// <para>The request ID. Alibaba Cloud generates this unique identifier to help you troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0A974B78-02BF-4C79-ADF3-90CFBA1B55B1</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the call was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: The call was successful.</para>
        /// </description></item>
        /// <item><description><para><b>false</b>: The call failed.</para>
        /// </description></item>
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
