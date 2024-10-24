// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dysmsapi20170525.Models
{
    public class AddSmsSignRequest : TeaModel {
        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The description of the signature application. The description cannot exceed 200 characters in length. The description is one of the reference information for signature review. We recommend that you describe the use scenarios of your services in detail, and provide information that can verify the services, such as a website URL, a domain name with an ICP filing, an app download URL, an official account name, or a mini program name. For sign-in scenarios, you must also provide an account and password for tests. A detailed description can improve the review efficiency of signatures and templates.</para>
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
        /// <para>The signature files.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("SignFileList")]
        [Validation(Required=false)]
        public List<AddSmsSignRequestSignFileList> SignFileList { get; set; }
        public class AddSmsSignRequestSignFileList : TeaModel {
            /// <summary>
            /// <para>The Base64-encoded string of the qualification document. An image cannot exceed 2 MB in size. In some scenarios, you must upload supporting documents to apply for signatures. For more information, see <a href="https://help.aliyun.com/document_detail/108076.html">SMS signature specifications</a>.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>R0lGODlhHAAmAKIHAKqqqsvLy0hISObm5vf394uL****</para>
            /// </summary>
            [NameInMap("FileContents")]
            [Validation(Required=false)]
            public string FileContents { get; set; }

            /// <summary>
            /// <para>The format of the qualification document. You can upload multiple images. Images in JPG, PNG, GIF, or JPEG format are supported.</para>
            /// <para>In some scenarios, you must upload supporting documents to apply for signatures. For more information, see <a href="https://help.aliyun.com/document_detail/108076.html">SMS signature specifications</a>.</para>
            /// <remarks>
            /// <para>If you apply for a signature for other users or if the signature source is the name of an enterprise or public institution, you must upload a certificate and a letter of authorization. For more information, see <a href="https://help.aliyun.com/document_detail/108076.html">Certificate</a> and <a href="https://help.aliyun.com/document_detail/56741.html">Letter of authorization</a>.</para>
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
        /// <para>The name of the signature.</para>
        /// <remarks>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description><para>The signature name is not case-sensitive. For example, [Alibaba Cloud Communication] and [alibaba cloud communication] are considered as the same name.</para>
        /// </description></item>
        /// <item><description><para>If your verification code signature and general-purpose signature have the same name, the system uses the general-purpose signature to send messages by default.</para>
        /// </description></item>
        /// </list>
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
        /// <item><description><b>0</b>: the full name or abbreviation of an enterprise or institution</description></item>
        /// <item><description><b>1</b>: the full name or abbreviation of a website that has obtained an ICP filing from the Ministry of Industry and Information Technology (MIIT) of China</description></item>
        /// <item><description><b>2</b>: the full name or abbreviation of an app</description></item>
        /// <item><description><b>3</b>: the full name or abbreviation of an official account or mini-program</description></item>
        /// <item><description><b>4</b>: the full name or abbreviation of an e-commerce store</description></item>
        /// <item><description><b>5</b>: the full name or abbreviation of a trademark</description></item>
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
        /// <item><description><b>0</b>: verification code</description></item>
        /// <item><description><b>1</b>: general-purpose</description></item>
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
