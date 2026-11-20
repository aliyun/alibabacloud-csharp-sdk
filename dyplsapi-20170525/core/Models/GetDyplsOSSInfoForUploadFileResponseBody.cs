// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dyplsapi20170525.Models
{
    public class GetDyplsOSSInfoForUploadFileResponseBody : TeaModel {
        /// <summary>
        /// <para>Details of denied access.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("AccessDeniedDetail")]
        [Validation(Required=false)]
        public string AccessDeniedDetail { get; set; }

        /// <summary>
        /// <para>Request status code. Valid values:  </para>
        /// <list type="bullet">
        /// <item><description>OK: indicates that the request succeeded.  </description></item>
        /// <item><description>For other error codes, see <a href="https://help.aliyun.com/document_detail/109196.html">Error Code List</a>.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>Returned data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetDyplsOSSInfoForUploadFileResponseBodyData Data { get; set; }
        public class GetDyplsOSSInfoForUploadFileResponseBodyData : TeaModel {
            /// <summary>
            /// <para>AccessKey ID used for signing.</para>
            /// 
            /// <b>Example:</b>
            /// <para>YOUR_ACCESS_KEY_ID</para>
            /// </summary>
            [NameInMap("AccessKeyId")]
            [Validation(Required=false)]
            public string AccessKeyId { get; set; }

            /// <summary>
            /// <para>Expiration Time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1744613007</para>
            /// </summary>
            [NameInMap("ExpireTime")]
            [Validation(Required=false)]
            public string ExpireTime { get; set; }

            /// <summary>
            /// <para>Host address.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://alicom-**********-cn-zhangjiakou.aliyuncs.com">https://alicom-**********-cn-zhangjiakou.aliyuncs.com</a></para>
            /// </summary>
            [NameInMap("Host")]
            [Validation(Required=false)]
            public string Host { get; set; }

            /// <summary>
            /// <para>Signing policy.</para>
            /// 
            /// <b>Example:</b>
            /// <para>IjoiMjAyN*****9udGV</para>
            /// </summary>
            [NameInMap("Policy")]
            [Validation(Required=false)]
            public string Policy { get; set; }

            /// <summary>
            /// <para>Signature computed from the <b>AccessKey secret</b> and <b>policy</b>. When invoking the OSS API, OSS authenticates this signature to confirm the validity of the POST request.</para>
            /// 
            /// <b>Example:</b>
            /// <para>BXwW**********aoZH</para>
            /// </summary>
            [NameInMap("Signature")]
            [Validation(Required=false)]
            public string Signature { get; set; }

            /// <summary>
            /// <para>Policy path.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123456</para>
            /// </summary>
            [NameInMap("StartPath")]
            [Validation(Required=false)]
            public string StartPath { get; set; }

        }

        /// <summary>
        /// <para>Description of the status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>E2FD3B2F-5028-16E3-9F83-2F76F99B3873</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request succeeded. Valid values:  </para>
        /// <list type="bullet">
        /// <item><description><para>true: indicates success.  </para>
        /// </description></item>
        /// <item><description><para>false: indicates failure.</para>
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
