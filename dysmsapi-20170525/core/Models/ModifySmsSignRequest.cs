// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dysmsapi20170525.Models
{
    public class ModifySmsSignRequest : TeaModel {
        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The scenario description of your released services. Provide the information of your services, such as a website URL, a domain name with an ICP filing, an app download URL, or the name of your WeChat official account or mini program. For sign-in scenarios, you must also provide an account and password for tests. A detailed description can improve the review efficiency of signatures and templates.</para>
        /// <remarks>
        /// <para>The description can be up to 200 characters in length.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>This is the abbreviation of our company.</para>
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
        /// <para>The list of signature files.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("SignFileList")]
        [Validation(Required=false)]
        public List<ModifySmsSignRequestSignFileList> SignFileList { get; set; }
        public class ModifySmsSignRequestSignFileList : TeaModel {
            /// <summary>
            /// <para>The base64-encoded string of the signed files. The size of the image cannot exceed 2 MB.</para>
            /// <para>In some scenarios, documents are required to prove your identity. For more information, see <a href="https://help.aliyun.com/document_detail/108076.html">Signature specifications</a>.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>R0lGODlhHAAmAKIHAKqqqsvLy0hISObm5vf394uLiwAA</para>
            /// </summary>
            [NameInMap("FileContents")]
            [Validation(Required=false)]
            public string FileContents { get; set; }

            /// <summary>
            /// <para>The format of the documents. You can upload multiple images. JPG, PNG, GIF, and JPEG are supported.</para>
            /// <para>In some scenarios, documents are required to prove your identity. For more information, see <a href="https://help.aliyun.com/document_detail/108076.html">Signature specifications</a>.</para>
            /// <remarks>
            /// <para>If the signature is used for other purposes or the signature source is an enterprise or public institution, you must upload some documents and an authorization letter. For more information, see <a href="https://help.aliyun.com/document_detail/108076.html">Documents</a> and <a href="https://help.aliyun.com/document_detail/56741.html">Letter of authorization</a>.</para>
            /// </remarks>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>jpg</para>
            /// </summary>
            [NameInMap("FileSuffix")]
            [Validation(Required=false)]
            public string FileSuffix { get; set; }

        }

        /// <summary>
        /// <para>The signature.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Aliyun</para>
        /// </summary>
        [NameInMap("SignName")]
        [Validation(Required=false)]
        public string SignName { get; set; }

        /// <summary>
        /// <para>The source of the signature. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: full name or abbreviation of an enterprise or institution.</description></item>
        /// <item><description><b>1</b>: full name or abbreviation of a website with Ministry of Industry and Information Technology (MIIT) filing.</description></item>
        /// <item><description><b>2</b>: full name or abbreviation of an app.</description></item>
        /// <item><description><b>3</b>: full name or abbreviation of a WeChat official account or applet.</description></item>
        /// <item><description><b>4</b>: full name or abbreviation of an e-commerce store.</description></item>
        /// <item><description><b>5</b>: full name or abbreviation of a trademark.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("SignSource")]
        [Validation(Required=false)]
        public int? SignSource { get; set; }

        /// <summary>
        /// <para>The type of the signature. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: verification-code signature</description></item>
        /// <item><description><b>1</b>: general-purpose signature</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("SignType")]
        [Validation(Required=false)]
        public int? SignType { get; set; }

    }

}
