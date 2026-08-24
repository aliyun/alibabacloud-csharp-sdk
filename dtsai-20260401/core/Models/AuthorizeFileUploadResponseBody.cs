// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DtsAI20260401.Models
{
    public class AuthorizeFileUploadResponseBody : TeaModel {
        /// <summary>
        /// <para>The temporary AccessKey ID used for OSS PostObject.</para>
        /// 
        /// <b>Example:</b>
        /// <para>STS.NV5xxx</para>
        /// </summary>
        [NameInMap("AccessKeyId")]
        [Validation(Required=false)]
        public string AccessKeyId { get; set; }

        /// <summary>
        /// <para>The destination OSS bucket.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dts-ai-upload-cn-beijing7500163e0eae09</para>
        /// </summary>
        [NameInMap("Bucket")]
        [Validation(Required=false)]
        public string Bucket { get; set; }

        /// <summary>
        /// <para>The Base64-encoded PostObject policy, which includes the ObjectKey and file size limits.</para>
        /// 
        /// <b>Example:</b>
        /// <para>eyJleHBpcmF0aW9uIjo...</para>
        /// </summary>
        [NameInMap("EncodedPolicy")]
        [Validation(Required=false)]
        public string EncodedPolicy { get; set; }

        /// <summary>
        /// <para>OSS Endpoint</para>
        /// 
        /// <b>Example:</b>
        /// <para>oss-cn-beijing.aliyuncs.com</para>
        /// </summary>
        [NameInMap("Endpoint")]
        [Validation(Required=false)]
        public string Endpoint { get; set; }

        /// <summary>
        /// <para>The error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>InvalidParameter</para>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>The parameter [Query] is not valid.</para>
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// <para>The business-level HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The object key that must be used as-is for the upload.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0a1b_123456_0123456789abcdef0123456789abcdef</para>
        /// </summary>
        [NameInMap("ObjectKey")]
        [Validation(Required=false)]
        public string ObjectKey { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>A30D0930-xxxx-xxxx-xxxx-C2C661CC8B58</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The Security Token Service (STS) token.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CAISxxx</para>
        /// </summary>
        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

        /// <summary>
        /// <para>The policy signature.</para>
        /// 
        /// <b>Example:</b>
        /// <para>masked-signature</para>
        /// </summary>
        [NameInMap("Signature")]
        [Validation(Required=false)]
        public string Signature { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
