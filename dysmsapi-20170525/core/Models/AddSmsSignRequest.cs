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
        /// <para>The description of the SMS signature scenario. The description cannot exceed 200 characters in length.</para>
        /// <para>This is reference information for signature review. Providing a complete application description helps reviewers understand your business scenario and improves review efficiency. Guidelines for filling in:</para>
        /// <list type="bullet">
        /// <item><description><para>You can provide the use cases of a business that has been launched.</para>
        /// </description></item>
        /// <item><description><para>You can provide real-world SMS message examples to reflect your business scenarios.</para>
        /// </description></item>
        /// <item><description><para>You can provide the parameter values passed to variables and describe the business use cases and the reasons for choosing these variable attributes in detail.</para>
        /// </description></item>
        /// <item><description><para>You can provide the website links, registered domain names, or app store download links of your actual business.</para>
        /// </description></item>
        /// <item><description><para>For login scenarios, you can provide a test account and password.</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>当前的短信签名应用于双11大促推广营销</para>
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
        public List<AddSmsSignRequestSignFileList> SignFileList { get; set; }
        public class AddSmsSignRequestSignFileList : TeaModel {
            /// <summary>
            /// <para>The Base64-encoded string of the qualification certificate file for the signature. The image size cannot exceed 2 MB. In some scenarios, you need to upload a certificate file when you apply for a signature.</para>
            /// <para>For detailed specifications, see <a href="https://help.aliyun.com/document_detail/463316.html">File upload specifications</a>.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>R0lGODlhHAAmAKIHAKqqqsvLy0hISObm5vf394uL****</para>
            /// </summary>
            [NameInMap("FileContents")]
            [Validation(Required=false)]
            public string FileContents { get; set; }

            /// <summary>
            /// <para>The format of the signature certificate file. Multiple images can be uploaded. Currently, JPG, PNG, GIF, and JPEG formats are supported. In some scenarios, you need to upload a certificate file when you apply for a signature.</para>
            /// <remarks>
            /// <para>If the signature is for third-party use or if you are an individual-certified user whose self-use signature source is an enterprise or public institution name, you also need to upload a certificate file and a power of attorney. For more information, see <a href="https://help.aliyun.com/document_detail/108076.html">Certificate file</a> and <a href="https://help.aliyun.com/document_detail/56741.html">Power of attorney</a>.</para>
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
        /// <para>The signature name. The signature name must comply with the <a href="~~108076#section-0p8-qn8-mmy~~">Signature specifications</a>.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Signature names are case-insensitive. For example, [Aliyun Communication] and [aliyun communication] are considered the same name.</description></item>
        /// <item><description>When your verification code signature and general-purpose signature have the same name, the system uses the general-purpose signature to send SMS messages by default.</description></item>
        /// </list>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>阿里云</para>
        /// </summary>
        [NameInMap("SignName")]
        [Validation(Required=false)]
        public string SignName { get; set; }

        /// <summary>
        /// <para>The source of the signature. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: Full name or abbreviation of an enterprise or public institution.</description></item>
        /// <item><description><b>1</b>: Full name or abbreviation of a website registered with the Ministry of Industry and Information Technology (MIIT).</description></item>
        /// <item><description><b>2</b>: Full name or abbreviation of an app.</description></item>
        /// <item><description><b>3</b>: Full name or abbreviation of an official account or mini program.</description></item>
        /// <item><description><b>4</b>: Full name or abbreviation of an e-commerce platform store name.</description></item>
        /// <item><description><b>5</b>: Full name or abbreviation of a trademark name.</description></item>
        /// </list>
        /// <para>For detailed descriptions of signature sources, see <a href="https://help.aliyun.com/en/sms/user-guide/signature-specifications-1?spm=a2c4g.11186623.0.0.4f9710fder2gR7#section-xup-k46-yi4">Signature source</a>.</para>
        /// <remarks>
        /// <para>This API does not support applying for signatures whose signature source is <b>Test or learning</b> or <b>Online trial</b>. If you need to apply for signatures with these two sources, go to the <a href="https://dysms.console.aliyun.com/domestic/text/sign/add/qualification">Short Message Service (SMS) console</a> to submit your application.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("SignSource")]
        [Validation(Required=false)]
        public int? SignSource { get; set; }

        /// <summary>
        /// <para>The type of the signature.</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: Verification code</description></item>
        /// <item><description><b>1</b>: General-purpose</description></item>
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
