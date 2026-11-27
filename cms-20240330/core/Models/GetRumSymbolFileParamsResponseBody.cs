// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class GetRumSymbolFileParamsResponseBody : TeaModel {
        /// <summary>
        /// <para>The collection of signature parameters required for form upload, including key, policy, x-oss-signature-version, x-oss-credential, x-oss-date, and x-oss-signature. The signatures in the examples are for illustration purposes only and cannot be used for actual uploads. Use the complete parameters returned by the API operation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;key&quot;:&quot;user/workspace/service-id/1.0.0/build-1/bundle.js.map&quot;,&quot;policy&quot;:&quot;eyJleHBpcmF0aW9uIjoiMjAyNi0wNi0wM1QxMjozMDowMC4wMDBaIiwiY29uZGl0aW9ucyI6W3siYnVja2V0IjoiYnVja2V0In0seyJ4LW9zcy1zaWduYXR1cmUtdmVyc2lvbiI6Ik9TUzQtSE1BQy1TSEEyNTYifSx7Ingtb3NzLWNyZWRlbnRpYWwiOiJBS0lERVhBTVBMRS8yMDI2MDYwMy9jbi1oYW5nemhvdS9vc3MvYWxpeXVuX3Y0X3JlcXVlc3QifSx7Ingtb3NzLWRhdGUiOiIyMDI2MDYwM1QxMjAwMDBaIn0sWyJlcSIsIiRrZXkiLCJ1c2VyL3dvcmtzcGFjZS9zZXJ2aWNlLWlkLzEuMC4wL2J1aWxkLTEvYnVuZGxlLmpzLm1hcCJdLFsiY29udGVudC1sZW5ndGgtcmFuZ2UiLDEsNTI0Mjg4MDAwXV19&quot;,&quot;x-oss-signature-version&quot;:&quot;OSS4-HMAC-SHA256&quot;,&quot;x-oss-credential&quot;:&quot;AKIDEXAMPLE/20260603/cn-hangzhou/oss/aliyun_v4_request&quot;,&quot;x-oss-date&quot;:&quot;20260603T120000Z&quot;,&quot;x-oss-signature&quot;:&quot;0000000000000000000000000000000000000000000000000000000000000000&quot;}</para>
        /// </summary>
        [NameInMap("formData")]
        [Validation(Required=false)]
        public Dictionary<string, string> FormData { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>request-1</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The form upload URL for directly uploading symbol files to OSS.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://bucket.oss-cn-hangzhou.aliyuncs.com">https://bucket.oss-cn-hangzhou.aliyuncs.com</a></para>
        /// </summary>
        [NameInMap("uploadUrl")]
        [Validation(Required=false)]
        public string UploadUrl { get; set; }

    }

}
