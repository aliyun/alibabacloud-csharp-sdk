// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dysmsapi20170525.Models
{
    public class CreateSmsAuthorizationLetterRequest : TeaModel {
        /// <summary>
        /// <para>The authorizing party, that is, the owner of the signature. Only the middle dot <c>·</c>, Chinese <c>【】（）</c>, English <c>()</c>, and spaces are supported. Other symbols or purely numeric input are not allowed. The length cannot exceed 150 characters.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>菜鸟网络科技有限公司</para>
        /// </summary>
        [NameInMap("Authorization")]
        [Validation(Required=false)]
        public string Authorization { get; set; }

        /// <summary>
        /// <para>The validity period of the authorization letter. Format: <c>YYYY-MM-DD~YYYY-MM-DD</c>.</para>
        /// <remarks>
        /// <para>The recommended validity period is 1 to 3 years. Set a reasonable time period and avoid making the validity period too long or too short.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2023-01-01~2026-01-01</para>
        /// </summary>
        [NameInMap("AuthorizationLetterExpDate")]
        [Validation(Required=false)]
        public string AuthorizationLetterExpDate { get; set; }

        /// <summary>
        /// <para>The name of the authorization letter. The name cannot be the same as any of your other authorization letters. Only Chinese characters, English characters, or a combination with numbers are supported. Symbols or purely numeric input are not allowed. The length cannot exceed 100 characters.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>菜鸟公司授权书</para>
        /// </summary>
        [NameInMap("AuthorizationLetterName")]
        [Validation(Required=false)]
        public string AuthorizationLetterName { get; set; }

        /// <summary>
        /// <para>The fileKey of the authorization letter.</para>
        /// <ol>
        /// <item><description>The authorization letter file uploaded to OSS. Download the <a href="https://help-static-aliyun-doc.aliyuncs.com/file-manage-files/zh-CN/20250414/bvpcmo/%E6%8E%88%E6%9D%83%E5%A7%94%E6%89%98%E4%B9%A6%E6%A8%A1%E7%89%88.doc">Authorization Letter Template</a>, then fill it out and stamp it according to the <a href="https://help.aliyun.com/document_detail/56741.html">specifications</a> before uploading. File upload requirements:</description></item>
        /// </ol>
        /// <list type="bullet">
        /// <item><description>The name of the file to be uploaded cannot contain Chinese characters or special characters.</description></item>
        /// <item><description>Only images in JPG, PNG, GIF, or JPEG format are supported, and the image must not exceed 5 MB.</description></item>
        /// </list>
        /// <ol start="2">
        /// <item><description>To obtain the fileKey, see <a href="https://help.aliyun.com/document_detail/2833114.html">Upload files through OSS</a>.</description></item>
        /// </ol>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123456/test1719383196031.jpg</para>
        /// </summary>
        [NameInMap("AuthorizationLetterPic")]
        [Validation(Required=false)]
        public string AuthorizationLetterPic { get; set; }

        /// <summary>
        /// <para>The unified social credit code of the authorizing party. The length cannot exceed 150 characters. The credit code must be consistent with the unified social credit code field in the qualification information bound to the signature. Otherwise, the signature creation will fail.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9****************A</para>
        /// </summary>
        [NameInMap("OrganizationCode")]
        [Validation(Required=false)]
        public string OrganizationCode { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The authorized party, that is, the signature applicant. Only the middle dot <c>·</c>, Chinese <c>【】（）</c>, English <c>()</c>, and spaces are supported. Other symbols or purely numeric input are not allowed. The length cannot exceed 150 characters.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>支付宝（中国）网络技术有限公司</para>
        /// </summary>
        [NameInMap("ProxyAuthorization")]
        [Validation(Required=false)]
        public string ProxyAuthorization { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The list of authorized signatures. The number of signatures cannot exceed 100.</para>
        /// <remarks>
        /// <para>We recommend that you authorize all signatures that may be used at once in the authorization letter. This prevents subsequent signature applications from falling outside the scope of the authorization letter, which would cause review failure and require you to supplement the authorization letter.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("SignList")]
        [Validation(Required=false)]
        public List<string> SignList { get; set; }

    }

}
