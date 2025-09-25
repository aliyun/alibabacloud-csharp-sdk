// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth20190307.Models
{
    public class DescribeVerifyTokenRequest : TeaModel {
        /// <summary>
        /// <para>Verification ID. A unique ID that identifies a verification task, not exceeding 64 characters. For a single verification task, the system supports unlimited submissions until the final verification is passed and the task is completed.</para>
        /// <remarks>
        /// <para>Different BizIds are required for different verification tasks.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>39ecf51e-2f81-4dc5-90ee-ff86125be683</para>
        /// </summary>
        [NameInMap("BizId")]
        [Validation(Required=false)]
        public string BizId { get; set; }

        /// <summary>
        /// <para>Identifier for the business scenario using the real person authentication service. Please refer to <a href="https://help.aliyun.com/document_detail/127885.html">Business Settings</a> and complete the creation in the console first.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>RPBasicTest</para>
        /// </summary>
        [NameInMap("BizType")]
        [Validation(Required=false)]
        public string BizType { get; set; }

        /// <summary>
        /// <para>Callback seed.</para>
        /// 
        /// <b>Example:</b>
        /// <list type="bullet">
        /// <item><description></description></item>
        /// </list>
        /// </summary>
        [NameInMap("CallbackSeed")]
        [Validation(Required=false)]
        public string CallbackSeed { get; set; }

        /// <summary>
        /// <para>Callback URL.</para>
        /// 
        /// <b>Example:</b>
        /// <list type="bullet">
        /// <item><description></description></item>
        /// </list>
        /// </summary>
        [NameInMap("CallbackUrl")]
        [Validation(Required=false)]
        public string CallbackUrl { get; set; }

        /// <summary>
        /// <para>HTTP or HTTPS link to the retained portrait photo.</para>
        /// 
        /// <b>Example:</b>
        /// <para>http%3A%2F%2Fjiangsu.china.com.cn%2Fuploadfile%2F2015%2F0114%2F1421221304095989.jpg</para>
        /// </summary>
        [NameInMap("FaceRetainedImageUrl")]
        [Validation(Required=false)]
        public string FaceRetainedImageUrl { get; set; }

        /// <summary>
        /// <para>Redirect URL for failed verification.</para>
        /// 
        /// <b>Example:</b>
        /// <list type="bullet">
        /// <item><description></description></item>
        /// </list>
        /// </summary>
        [NameInMap("FailedRedirectUrl")]
        [Validation(Required=false)]
        public string FailedRedirectUrl { get; set; }

        /// <summary>
        /// <para>HTTP or HTTPS link to the national emblem side of the ID card image.</para>
        /// 
        /// <b>Example:</b>
        /// <para>http%3A%2F%2Fjiangsu.china.com.cn%2Fuploadfile%2F2015%2F0114%2F1421221304095989.jpg</para>
        /// </summary>
        [NameInMap("IdCardBackImageUrl")]
        [Validation(Required=false)]
        public string IdCardBackImageUrl { get; set; }

        /// <summary>
        /// <para>HTTP or HTTPS link to the portrait side of the ID card image.</para>
        /// 
        /// <b>Example:</b>
        /// <para>http%3A%2F%2Fjiangsu.china.com.cn%2Fuploadfile%2F2015%2F0114%2F1421221304095989.jpg</para>
        /// </summary>
        [NameInMap("IdCardFrontImageUrl")]
        [Validation(Required=false)]
        public string IdCardFrontImageUrl { get; set; }

        /// <summary>
        /// <para>ID card number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>330100xxxxxxxxxxxx</para>
        /// </summary>
        [NameInMap("IdCardNumber")]
        [Validation(Required=false)]
        public string IdCardNumber { get; set; }

        /// <summary>
        /// <para>Name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>张三</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>Redirect URL upon successful verification.</para>
        /// 
        /// <b>Example:</b>
        /// <list type="bullet">
        /// <item><description></description></item>
        /// </list>
        /// </summary>
        [NameInMap("PassedRedirectUrl")]
        [Validation(Required=false)]
        public string PassedRedirectUrl { get; set; }

        /// <summary>
        /// <para>ID of the end user, such as the account ID of the end user.</para>
        /// 
        /// <b>Example:</b>
        /// <para>user111</para>
        /// </summary>
        [NameInMap("UserId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

        /// <summary>
        /// <para>User IP.</para>
        /// 
        /// <b>Example:</b>
        /// <para>192.168.<em><b>.</b></em></para>
        /// </summary>
        [NameInMap("UserIp")]
        [Validation(Required=false)]
        public string UserIp { get; set; }

        /// <summary>
        /// <para>User phone number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>187********</para>
        /// </summary>
        [NameInMap("UserPhoneNumber")]
        [Validation(Required=false)]
        public string UserPhoneNumber { get; set; }

        /// <summary>
        /// <para>User registration time. Expressed in timestamp format, unit: milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1577808000000</para>
        /// </summary>
        [NameInMap("UserRegistTime")]
        [Validation(Required=false)]
        public long? UserRegistTime { get; set; }

    }

}
