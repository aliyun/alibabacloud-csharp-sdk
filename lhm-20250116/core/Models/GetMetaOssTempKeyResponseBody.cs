// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.LHM20250116.Models
{
    public class GetMetaOssTempKeyResponseBody : TeaModel {
        /// <summary>
        /// <para>The response body. For more information about the fields, see the child field descriptions.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public GetMetaOssTempKeyResponseBodyData Data { get; set; }
        public class GetMetaOssTempKeyResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The temporary AccessKey ID (STS token). This value is used together with securityToken to authenticate direct uploads to OSS. This is a sensitive credential. Do not hard-code it in your code or print it to logs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>STS.NY6bbCNqNPpt5GcSTEzB6Lahn</para>
            /// </summary>
            [NameInMap("ak")]
            [Validation(Required=false)]
            public string Ak { get; set; }

            /// <summary>
            /// <para>The name of the OSS bucket.</para>
            /// 
            /// <b>Example:</b>
            /// <para>lhm-pre-cn-hangzhou</para>
            /// </summary>
            [NameInMap("bucket")]
            [Validation(Required=false)]
            public string Bucket { get; set; }

            /// <summary>
            /// <para>The allowed OSS upload directory prefix. The value must end with a forward slash (/). The key of the uploaded object must start with this prefix. Otherwise, the request is rejected by OSS.</para>
            /// 
            /// <b>Example:</b>
            /// <para>teleport/meta/1063934947625635/</para>
            /// </summary>
            [NameInMap("dir")]
            [Validation(Required=false)]
            public string Dir { get; set; }

            /// <summary>
            /// <para>The endpoint of the region where the OSS bucket resides.</para>
            /// 
            /// <b>Example:</b>
            /// <para>oss-cn-hangzhou.aliyuncs.com</para>
            /// </summary>
            [NameInMap("endpoint")]
            [Validation(Required=false)]
            public string Endpoint { get; set; }

            /// <summary>
            /// <para>The credential expiration timestamp in Unix seconds. Before use, verify whether the current time has exceeded this value. If the credential has expired, obtain new credentials.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1779966540</para>
            /// </summary>
            [NameInMap("expire")]
            [Validation(Required=false)]
            public long? Expire { get; set; }

            /// <summary>
            /// <para>The Base64-encoded upload policy that defines constraints such as file size and path prefix. The decoded value is a JSON string.</para>
            /// 
            /// <b>Example:</b>
            /// <para>eyJleHBpcmF0aW9uIjoiMjAyNi0wNS0yOFQxMToxMjo1OC43MzZaIiwiY29uZGl0aW9ucyI6W1siY29udGVudC1sZW5ndGgtcmFuZ2UiLDAsMTA0ODU3NjAwXSxbInN0YXJ0cy13aXRoIiwiJGtleSIsInRlbGVwb3J0L21ldGEvMTA2MzkzNDk0NzYyNTYzNS8iXV19</para>
            /// </summary>
            [NameInMap("policy")]
            [Validation(Required=false)]
            public string Policy { get; set; }

            /// <summary>
            /// <para>The STS temporary security token. This value is used together with ak for authentication and is returned only in STS authentication mode. This is a sensitive credential. Do not hard-code it in your code or print it to logs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CAIS3QJ1q6Ft5B2yfSjIr5rsAOjugKcY9YqlSRPBlWEFZN1V3fD6gzz2IHhMfHFvA</para>
            /// </summary>
            [NameInMap("securityToken")]
            [Validation(Required=false)]
            public string SecurityToken { get; set; }

            /// <summary>
            /// <para>The signature calculated based on the policy. The OSS server uses this signature to verify the validity of upload requests.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ydDYrWUzfKNM6slVhjPhUx83qUo=</para>
            /// </summary>
            [NameInMap("signature")]
            [Validation(Required=false)]
            public string Signature { get; set; }

        }

        /// <summary>
        /// <para>The error code. An empty string is returned if the call is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("errCode")]
        [Validation(Required=false)]
        public string ErrCode { get; set; }

        /// <summary>
        /// <para>The error message. An empty string is returned if the call is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("errMessage")]
        [Validation(Required=false)]
        public string ErrMessage { get; set; }

        /// <summary>
        /// <para>Indicates whether the call is successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: The call is successful.</description></item>
        /// <item><description>false: The call failed. Check errCode and errMessage for troubleshooting.</description></item>
        /// </list>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
