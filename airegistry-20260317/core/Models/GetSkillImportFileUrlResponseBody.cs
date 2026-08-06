// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AIRegistry20260317.Models
{
    public class GetSkillImportFileUrlResponseBody : TeaModel {
        /// <summary>
        /// <para>The returned result.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetSkillImportFileUrlResponseBodyData Data { get; set; }
        public class GetSkillImportFileUrlResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The file type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>application/zip</para>
            /// </summary>
            [NameInMap("ContentType")]
            [Validation(Required=false)]
            public string ContentType { get; set; }

            /// <summary>
            /// <para>The maximum size of the file that can be uploaded, in MB.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("MaxSize")]
            [Validation(Required=false)]
            public string MaxSize { get; set; }

            /// <summary>
            /// <para>The file name in the authorized OSS bucket.</para>
            /// <remarks>
            /// <para>You can use one of the following methods to pass in images: FaceContrastPicture, FaceContrastPictureUrl, CertifyId, or OSS. Select one of these methods.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>1190239587066411/skill/import/5e993afe-f629-4619-9ac2-51b125300cdd/2026/06/09/35059076-5992-4a71-a706-89230e57f2a2/ui-ux-pro-max.zip</para>
            /// </summary>
            [NameInMap("OssObjectName")]
            [Validation(Required=false)]
            public string OssObjectName { get; set; }

            /// <summary>
            /// <para>The file upload URL. The client uses this URL to upload the file.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://mse-shared-cn-hangzhou.oss-cn-hangzhou.aliyuncs.com/skill/import/199xxxxxxxx0842/xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxx/2026/06/10/xxxx-xxxx-xxxx-xxxx-xxxxxxxxxx/1781082579097.zip?Expires=1781083479&OSSAccessKeyId=STS.NZXGXTD2yoDLd5PfsYxjFrvBJ&Signature=Loyyzzzzzzzz%3D&security-token=CAIStgxxxxxxx">https://mse-shared-cn-hangzhou.oss-cn-hangzhou.aliyuncs.com/skill/import/199xxxxxxxx0842/xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxx/2026/06/10/xxxx-xxxx-xxxx-xxxx-xxxxxxxxxx/1781082579097.zip?Expires=1781083479&amp;OSSAccessKeyId=STS.NZXGXTD2yoDLd5PfsYxjFrvBJ&amp;Signature=Loyyzzzzzzzz%3D&amp;security-token=CAIStgxxxxxxx</a></para>
            /// </summary>
            [NameInMap("UploadUrl")]
            [Validation(Required=false)]
            public string UploadUrl { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>D9E87E66-9EF0-5C10-A5E6-924020A0C9B7</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
