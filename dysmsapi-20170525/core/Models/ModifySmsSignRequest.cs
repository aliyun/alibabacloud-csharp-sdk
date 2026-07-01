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
        /// <para>The description of the SMS signature application. The description cannot exceed 200 characters in length.</para>
        /// <para>The description is used as a reference for signature review. A complete description helps reviewers understand your business scenario and improves review efficiency. Guidelines:</para>
        /// <list type="bullet">
        /// <item><description>Provide the use case of a service that is already online.</description></item>
        /// <item><description>Provide an SMS example from a real scenario to illustrate your business scenario.</description></item>
        /// <item><description>Provide the values passed for variables, and describe the business scenario in detail and the reason for choosing the variable attributes.</description></item>
        /// <item><description>Provide the website URL of the actual service, a filed domain name, or an app store download link.</description></item>
        /// <item><description>For logon scenarios, provide a test account and password.</description></item>
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
        public List<ModifySmsSignRequestSignFileList> SignFileList { get; set; }
        public class ModifySmsSignRequestSignFileList : TeaModel {
            /// <summary>
            /// <para>签名的纸质证明文件经base64编码后的字符串。图片不超过2 MB。</para>
            /// <para>个别场景下，申请签名需要上传证明文件。详细说明，请参见<a href="https://help.aliyun.com/document_detail/108076.html">短信签名规范</a>。</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>R0lGODlhHAAmAKIHAKqqqsvLy0hISObm5vf394uLiwAA</para>
            /// </summary>
            [NameInMap("FileContents")]
            [Validation(Required=false)]
            public string FileContents { get; set; }

            /// <summary>
            /// <para>签名的证明文件格式，支持上传多张图片。当前支持JPG、PNG、GIF或JPEG格式的图片。</para>
            /// <para>个别场景下，申请签名需要上传证明文件。详细说明，请参见<a href="https://help.aliyun.com/document_detail/108076.html">短信签名规范</a>。</para>
            /// <remarks>
            /// <para>如果签名用途为他用或个人认证用户的自用签名来源为企事业单位名时，还需上传证明文件和委托授权书，详情请参见<a href="https://help.aliyun.com/document_detail/108076.html">证明文件</a>和<a href="https://help.aliyun.com/document_detail/56741.html">授权委托书</a>。</para>
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
        /// <para>The signature name.</para>
        /// <remarks>
        /// <para>You can modify a signature that has been approved, but you cannot change its name. The modified signature must be reviewed and approved before it can be used. The original signature cannot be used until the review is complete.</para>
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
        /// <para>The signature source. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: full name or abbreviation of an enterprise or public institution.</description></item>
        /// <item><description><b>1</b>: full name or abbreviation of a website filed with the Ministry of Industry and Information Technology (MIIT).</description></item>
        /// <item><description><b>2</b>: full name or abbreviation of an app.</description></item>
        /// <item><description><b>3</b>: full name or abbreviation of an official account or mini program.</description></item>
        /// <item><description><b>4</b>: full name or abbreviation of a store on an e-commerce platform.</description></item>
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
        /// <para>The signature type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>0</b>: verification code.</para>
        /// </description></item>
        /// <item><description><para><b>1</b>: general.</para>
        /// </description></item>
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
