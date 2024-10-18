// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dypnsapi20170525.Models
{
    public class CreateVerifySchemeRequest : TeaModel {
        /// <summary>
        /// <para>The app name.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Alibaba Cloud Communications</para>
        /// </summary>
        [NameInMap("AppName")]
        [Validation(Required=false)]
        public string AppName { get; set; }

        /// <summary>
        /// <para>The verification type. You can select multiple types only when the phone number verification is supported. Separate multiple types with commas (,).</para>
        /// <list type="bullet">
        /// <item><description><b>1</b>: phone number verification</description></item>
        /// <item><description><b>2</b>: SMS verification</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1,2</para>
        /// </summary>
        [NameInMap("AuthType")]
        [Validation(Required=false)]
        public string AuthType { get; set; }

        /// <summary>
        /// <para>The bundle ID. This parameter is required when OsType is set to iOS. The bundle ID must be 1 to 128 characters in length and can contain digits, letters, hyphens (-), underscores (_), and periods (.).</para>
        /// 
        /// <b>Example:</b>
        /// <para>example.aliyundoc.com</para>
        /// </summary>
        [NameInMap("BundleId")]
        [Validation(Required=false)]
        public string BundleId { get; set; }

        /// <summary>
        /// <para>The channel code of China Mobile.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CmApiCode")]
        [Validation(Required=false)]
        public long? CmApiCode { get; set; }

        /// <summary>
        /// <para>The channel code of China Telecom.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("CtApiCode")]
        [Validation(Required=false)]
        public long? CtApiCode { get; set; }

        /// <summary>
        /// <para>The channel code of China Unicom.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("CuApiCode")]
        [Validation(Required=false)]
        public long? CuApiCode { get; set; }

        /// <summary>
        /// <para>The email address that receives the key.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="mailto:username@aliyundoc.com">username@aliyundoc.com</a></para>
        /// </summary>
        [NameInMap("Email")]
        [Validation(Required=false)]
        public string Email { get; set; }

        [NameInMap("HmAppIdentifier")]
        [Validation(Required=false)]
        public string HmAppIdentifier { get; set; }

        [NameInMap("HmPackageName")]
        [Validation(Required=false)]
        public string HmPackageName { get; set; }

        [NameInMap("HmSignName")]
        [Validation(Required=false)]
        public string HmSignName { get; set; }

        /// <summary>
        /// <para>The IP address whitelist.</para>
        /// 
        /// <b>Example:</b>
        /// <para>139.9.167.181
        /// 122.112.210.205
        /// 139.9.172.0/24</para>
        /// </summary>
        [NameInMap("IpWhiteList")]
        [Validation(Required=false)]
        public string IpWhiteList { get; set; }

        /// <summary>
        /// <para>The source URL of the HTML5 app page. We recommend that you specify this parameter as a domain name.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://h5.minexiot.com">https://h5.minexiot.com</a></para>
        /// </summary>
        [NameInMap("Origin")]
        [Validation(Required=false)]
        public string Origin { get; set; }

        /// <summary>
        /// <para>The type of the operating system for the terminal. Valid values: iOS and Android.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>iOS</para>
        /// </summary>
        [NameInMap("OsType")]
        [Validation(Required=false)]
        public string OsType { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The package name. This parameter is required when OsType is set to Android. The name must be 1 to 128 characters in length and can contain digits, letters, hyphens (-), underscores (_), and periods (.).</para>
        /// 
        /// <b>Example:</b>
        /// <para>com.aliyun</para>
        /// </summary>
        [NameInMap("PackName")]
        [Validation(Required=false)]
        public string PackName { get; set; }

        /// <summary>
        /// <para>The package signature. This parameter is required when OsType is set to Android. The signature must be 32 characters in length and can contain digits and letters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123aliyun</para>
        /// </summary>
        [NameInMap("PackSign")]
        [Validation(Required=false)]
        public string PackSign { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The service type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("SceneType")]
        [Validation(Required=false)]
        public string SceneType { get; set; }

        /// <summary>
        /// <para>The service name.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Aliyun</para>
        /// </summary>
        [NameInMap("SchemeName")]
        [Validation(Required=false)]
        public string SchemeName { get; set; }

        /// <summary>
        /// <para>The bound SMS signature. This parameter is valid only when AuthType is set to 2. The signature must be approved.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Aliyun Test</para>
        /// </summary>
        [NameInMap("SmsSignName")]
        [Validation(Required=false)]
        public string SmsSignName { get; set; }

        /// <summary>
        /// <para>The URL of the HTML5 app page.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://h5.minexiot.com/index.html">https://h5.minexiot.com/index.html</a></para>
        /// </summary>
        [NameInMap("Url")]
        [Validation(Required=false)]
        public string Url { get; set; }

    }

}
