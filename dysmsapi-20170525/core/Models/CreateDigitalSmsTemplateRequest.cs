// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dysmsapi20170525.Models
{
    public class CreateDigitalSmsTemplateRequest : TeaModel {
        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The application description. Describe your business use case for the template.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>***业务需要</para>
        /// </summary>
        [NameInMap("Remark")]
        [Validation(Required=false)]
        public string Remark { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The signature.</para>
        /// 
        /// <b>Example:</b>
        /// <para>签名</para>
        /// </summary>
        [NameInMap("SignName")]
        [Validation(Required=false)]
        public string SignName { get; set; }

        /// <summary>
        /// <para>An array of objects that define the template content.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("TemplateContents")]
        [Validation(Required=false)]
        public List<CreateDigitalSmsTemplateRequestTemplateContents> TemplateContents { get; set; }
        public class CreateDigitalSmsTemplateRequestTemplateContents : TeaModel {
            /// <summary>
            /// <para>The file content, converted to a Base64 string. The file must be UTF-8 encoded before the Base64 conversion.</para>
            /// 
            /// <b>Example:</b>
            /// <para>字符</para>
            /// </summary>
            [NameInMap("FileContents")]
            [Validation(Required=false)]
            public string FileContents { get; set; }

            /// <summary>
            /// <para>The file name without the extension.</para>
            /// 
            /// <b>Example:</b>
            /// <para>file-1</para>
            /// </summary>
            [NameInMap("FileName")]
            [Validation(Required=false)]
            public string FileName { get; set; }

            /// <summary>
            /// <para>The file size, in bytes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1840901</para>
            /// </summary>
            [NameInMap("FileSize")]
            [Validation(Required=false)]
            public int? FileSize { get; set; }

            /// <summary>
            /// <para>The file suffix. Supported formats are <c>txt</c> for text; <c>gif</c>, <c>jpg</c>, and <c>png</c> for images; <c>mp3</c> for audio; and <c>mp4</c> for video. You can upload only one video file per template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>txt</para>
            /// </summary>
            [NameInMap("FileSuffix")]
            [Validation(Required=false)]
            public string FileSuffix { get; set; }

        }

        /// <summary>
        /// <para>The template name. The name can contain up to 20 characters.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>****模板</para>
        /// </summary>
        [NameInMap("TemplateName")]
        [Validation(Required=false)]
        public string TemplateName { get; set; }

    }

}
