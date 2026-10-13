// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MaxCompute20220104.Models
{
    public class GetLogviewDownloadUrlResponseBody : TeaModel {
        /// <summary>
        /// <para>The presigned OSS download URL for the offline Logview file. The URL is valid for 10 minutes from the time it is generated. The file name extension is .txt and the content is JSON data in UTF-8 encoding. The download URL is determined by useVpcEndpoint. If the link expires, invoke this operation again. The sample URL is desensitized and cannot be used for actual downloads.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://example-bucket.oss-cn-hangzhou.aliyuncs.com/logview/offline/logview_detail_odps_project_20260409110419512gx6ofeaj8fb.txt?OSSAccessKeyId=LTAI5tExample****&Expires=1791777900&Signature=example">https://example-bucket.oss-cn-hangzhou.aliyuncs.com/logview/offline/logview_detail_odps_project_20260409110419512gx6ofeaj8fb.txt?OSSAccessKeyId=LTAI5tExample****&amp;Expires=1791777900&amp;Signature=example</a>****</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public string Data { get; set; }

        /// <summary>
        /// <para>The error code. This field is not assigned a value when this operation is successfully processed. The sample value NO_PERMISSION is used to illustrate a common permission error and must not be combined with the success response example.</para>
        /// 
        /// <b>Example:</b>
        /// <para>NO_PERMISSION</para>
        /// </summary>
        [NameInMap("errorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>The error message. This field is not assigned a value when this operation is successfully processed. The sample value Forbidden is used to illustrate a common permission error and must not be combined with the success response example.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Forbidden</para>
        /// </summary>
        [NameInMap("errorMsg")]
        [Validation(Required=false)]
        public string ErrorMsg { get; set; }

        /// <summary>
        /// <para>The HTTP status code field. This field is not assigned a value when this operation is successfully processed. Do not rely solely on whether this field equals 200 to determine success. Process the result based on the actual HTTP response status and returned content. The sample value 200 is used only to illustrate the field format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("httpCode")]
        [Validation(Required=false)]
        public int? HttpCode { get; set; }

        /// <summary>
        /// <para>The request ID. This ID is used to locate and troubleshoot the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0be3e0aa16667684362147582e038f</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
