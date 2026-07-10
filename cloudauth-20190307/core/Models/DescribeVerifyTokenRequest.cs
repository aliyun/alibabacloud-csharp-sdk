// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth20190307.Models
{
    public class DescribeVerifyTokenRequest : TeaModel {
        /// <summary>
        /// <para>The authentication ID. A unique ID that identifies an authentication task. The value can be up to 64 characters in length. For a single authentication task, the system supports unlimited submissions until the authentication is passed and the task is completed.</para>
        /// <remarks>
        /// <para>Use a different BizId for each different authentication task.</para>
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
        /// <para>The business scenario identifier for using the ID Verification service. Create one in the console first. For more information, see <a href="https://help.aliyun.com/document_detail/127885.html">Business settings</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>RPBasicTest</para>
        /// </summary>
        [NameInMap("BizType")]
        [Validation(Required=false)]
        public string BizType { get; set; }

        /// <summary>
        /// <para>The callback seed.</para>
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
        /// <para>The callback URL.</para>
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
        /// <para>The HTTP or HTTPS URL of the retained face photo.</para>
        /// 
        /// <b>Example:</b>
        /// <para>http%3A%2F%2Fjiangsu.china.com.cn%2Fuploadfile%2F2015%2F0114%2F1421221304095989.jpg</para>
        /// </summary>
        [NameInMap("FaceRetainedImageUrl")]
        [Validation(Required=false)]
        public string FaceRetainedImageUrl { get; set; }

        /// <summary>
        /// <para>The redirect URL upon verification failure.</para>
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
        /// <para>The HTTP or HTTPS URL of the national emblem side of the ID card image.</para>
        /// 
        /// <b>Example:</b>
        /// <para>http%3A%2F%2Fjiangsu.china.com.cn%2Fuploadfile%2F2015%2F0114%2F1421221304095989.jpg</para>
        /// </summary>
        [NameInMap("IdCardBackImageUrl")]
        [Validation(Required=false)]
        public string IdCardBackImageUrl { get; set; }

        /// <summary>
        /// <para>The HTTP or HTTPS URL of the portrait side of the ID card image.</para>
        /// 
        /// <b>Example:</b>
        /// <para>http%3A%2F%2Fjiangsu.china.com.cn%2Fuploadfile%2F2015%2F0114%2F1421221304095989.jpg</para>
        /// </summary>
        [NameInMap("IdCardFrontImageUrl")]
        [Validation(Required=false)]
        public string IdCardFrontImageUrl { get; set; }

        /// <summary>
        /// <para>The ID card number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>330100xxxxxxxxxxxx</para>
        /// </summary>
        [NameInMap("IdCardNumber")]
        [Validation(Required=false)]
        public string IdCardNumber { get; set; }

        /// <summary>
        /// <para>The name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>张三</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The redirect URL upon successful verification.</para>
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
        /// <para>The ID of the end user, such as the account ID of the end user.</para>
        /// 
        /// <b>Example:</b>
        /// <para>user111</para>
        /// </summary>
        [NameInMap("UserId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

        /// <summary>
        /// <para>The IP address of the user.</para>
        /// 
        /// <b>Example:</b>
        /// <para>192.168.<em><b>.</b></em></para>
        /// </summary>
        [NameInMap("UserIp")]
        [Validation(Required=false)]
        public string UserIp { get; set; }

        /// <summary>
        /// <para>The phone number of the user.</para>
        /// 
        /// <b>Example:</b>
        /// <para>187********</para>
        /// </summary>
        [NameInMap("UserPhoneNumber")]
        [Validation(Required=false)]
        public string UserPhoneNumber { get; set; }

        /// <summary>
        /// <para>The registration time of the user. Specify the value in UNIX timestamp format. Unit: milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1577808000000</para>
        /// </summary>
        [NameInMap("UserRegistTime")]
        [Validation(Required=false)]
        public long? UserRegistTime { get; set; }

    }

}
