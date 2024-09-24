// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class CreateFileDetectUploadUrlResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the request, which is used to locate and troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>09969D2C-4FAD-429E-BFBF-9A60DEF8BF6F</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>An array consisting of the parameters that are required to upload a file.</para>
        /// </summary>
        [NameInMap("UploadUrlList")]
        [Validation(Required=false)]
        public List<CreateFileDetectUploadUrlResponseBodyUploadUrlList> UploadUrlList { get; set; }
        public class CreateFileDetectUploadUrlResponseBodyUploadUrlList : TeaModel {
            /// <summary>
            /// <para>The status code returned. The status code <b>200</b> indicates that the request was successful. Other status codes indicate that the request failed. You can identify the cause of the failure based on the status code.</para>
            /// 
            /// <b>Example:</b>
            /// <para>200</para>
            /// </summary>
            [NameInMap("Code")]
            [Validation(Required=false)]
            public string Code { get; set; }

            /// <summary>
            /// <para>The signature information.</para>
            /// </summary>
            [NameInMap("Context")]
            [Validation(Required=false)]
            public CreateFileDetectUploadUrlResponseBodyUploadUrlListContext Context { get; set; }
            public class CreateFileDetectUploadUrlResponseBodyUploadUrlListContext : TeaModel {
                /// <summary>
                /// <para>The AccessKey ID that is used to access the OSS bucket.</para>
                /// 
                /// <b>Example:</b>
                /// <para>LTAI4G1mgPbjvGQuiV1X****</para>
                /// </summary>
                [NameInMap("AccessId")]
                [Validation(Required=false)]
                public string AccessId { get; set; }

                /// <summary>
                /// <para>The key of the file that is used after the file is uploaded to the OSS bucket.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1/2022/06/23/15/41/16559701077444693a0c6-33b2-4cc2-a99f-9f38b8b8****</para>
                /// </summary>
                [NameInMap("OssKey")]
                [Validation(Required=false)]
                public string OssKey { get; set; }

                /// <summary>
                /// <para>The policy that poses limits on file upload. For example, the policy can limit the size of the file.</para>
                /// 
                /// <b>Example:</b>
                /// <para>eyJleHBpcmF0aW9uIjoiMjAyMi0wNy0yM1QxMDo1ODoxMC43NTNaIiwiY29uZGl0aW9ucyI6W1siY29udGVudC1sZW5ndGgtcmFuZ2UiLDAsMjA5NzE1MjBdLFsiZXEiLCIka2V5IiwiMS8yMDIyLzA2LzIzLzE4LzU4LzE2NTU5ODE4OTA3NTM4NTc2MjFkNS1kN2E1LTQ5YzAtOGJjZi0yMTMyY2JiYTdmYzMi****</para>
                /// </summary>
                [NameInMap("Policy")]
                [Validation(Required=false)]
                public string Policy { get; set; }

                /// <summary>
                /// <para>The signature that is used to upload the file.</para>
                /// 
                /// <b>Example:</b>
                /// <para>wDhPgVdnY/bkKFYcYFl+4crl****</para>
                /// </summary>
                [NameInMap("Signature")]
                [Validation(Required=false)]
                public string Signature { get; set; }

            }

            /// <summary>
            /// <para>The timestamp when the values of the parameters expire. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1658562101370</para>
            /// </summary>
            [NameInMap("Expire")]
            [Validation(Required=false)]
            public string Expire { get; set; }

            /// <summary>
            /// <para>Indicates whether the file exists in the cloud. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: The file exists in the cloud. You do not need to upload the file.</description></item>
            /// <item><description><b>false</b>: The file does not exist in the cloud. You must upload the file.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("FileExist")]
            [Validation(Required=false)]
            public bool? FileExist { get; set; }

            /// <summary>
            /// <para>The identifier of the file.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0a212417e65c26ff133cfff28f6c****</para>
            /// </summary>
            [NameInMap("HashKey")]
            [Validation(Required=false)]
            public string HashKey { get; set; }

            /// <summary>
            /// <para>The internal endpoint of the URL to which the file is uploaded.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="http://example.com">http://example.com</a></para>
            /// </summary>
            [NameInMap("InternalUrl")]
            [Validation(Required=false)]
            public string InternalUrl { get; set; }

            /// <summary>
            /// <para>The error message returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>successful</para>
            /// </summary>
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            /// <summary>
            /// <para>The public endpoint of the URL to which the file is uploaded.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="http://example.com">http://example.com</a></para>
            /// </summary>
            [NameInMap("PublicUrl")]
            [Validation(Required=false)]
            public string PublicUrl { get; set; }

        }

    }

}
