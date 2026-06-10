// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WebsiteBuild20250429.Models
{
    public class GetAppInstanceTempShortUrlResponseBody : TeaModel {
        /// <summary>
        /// <para>access denied details</para>
        /// 
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("AccessDeniedDetail")]
        [Validation(Required=false)]
        public string AccessDeniedDetail { get; set; }

        /// <summary>
        /// <para>is retry allowed</para>
        /// 
        /// <b>Example:</b>
        /// <para>False</para>
        /// </summary>
        [NameInMap("AllowRetry")]
        [Validation(Required=false)]
        public bool? AllowRetry { get; set; }

        /// <summary>
        /// <para>App Name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dewuApp</para>
        /// </summary>
        [NameInMap("AppName")]
        [Validation(Required=false)]
        public string AppName { get; set; }

        /// <summary>
        /// <para>dynamic code, currently unused. Please ignore.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ERROR-oo1</para>
        /// </summary>
        [NameInMap("DynamicCode")]
        [Validation(Required=false)]
        public string DynamicCode { get; set; }

        /// <summary>
        /// <para>dynamic message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SYSTEM_ERROR</para>
        /// </summary>
        [NameInMap("DynamicMessage")]
        [Validation(Required=false)]
        public string DynamicMessage { get; set; }

        /// <summary>
        /// <para>returned error parameters</para>
        /// </summary>
        [NameInMap("ErrorArgs")]
        [Validation(Required=false)]
        public List<object> ErrorArgs { get; set; }

        /// <summary>
        /// <para>response data</para>
        /// </summary>
        [NameInMap("Module")]
        [Validation(Required=false)]
        public GetAppInstanceTempShortUrlResponseBodyModule Module { get; set; }
        public class GetAppInstanceTempShortUrlResponseBodyModule : TeaModel {
            /// <summary>
            /// <para>time-to-live (TTL)</para>
            /// <para>Use the UTC time format: yyyy-MM-ddTHH:mm:ss.SSSZ</para>
            /// 
            /// <b>Example:</b>
            /// <para>123456</para>
            /// </summary>
            [NameInMap("ExpireAtTime")]
            [Validation(Required=false)]
            public string ExpireAtTime { get; set; }

            /// <summary>
            /// <para>temporary short URL</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="http://www.aliyun.com">http://www.aliyun.com</a></para>
            /// </summary>
            [NameInMap("TempShortUrl")]
            [Validation(Required=false)]
            public string TempShortUrl { get; set; }

            /// <summary>
            /// <para>full URL</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://bj.download.cycore.cn/zhkt-student-cystore-https/2025/9/31/10/12/9b48342f-e595-4c60-8032-dccd355e7552.jpg">https://bj.download.cycore.cn/zhkt-student-cystore-https/2025/9/31/10/12/9b48342f-e595-4c60-8032-dccd355e7552.jpg</a></para>
            /// </summary>
            [NameInMap("Url")]
            [Validation(Required=false)]
            public string Url { get; set; }

        }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>6C6B99AC-39EC-5350-874C-204128C905E6</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Error code</para>
        /// 
        /// <b>Example:</b>
        /// <para>SYSTEM.ERROR</para>
        /// </summary>
        [NameInMap("RootErrorCode")]
        [Validation(Required=false)]
        public string RootErrorCode { get; set; }

        /// <summary>
        /// <para>abnormal message</para>
        /// 
        /// <b>Example:</b>
        /// <para>系统异常</para>
        /// </summary>
        [NameInMap("RootErrorMsg")]
        [Validation(Required=false)]
        public string RootErrorMsg { get; set; }

        /// <summary>
        /// <para>Reserved parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>True</para>
        /// </summary>
        [NameInMap("Synchro")]
        [Validation(Required=false)]
        public bool? Synchro { get; set; }

    }

}
