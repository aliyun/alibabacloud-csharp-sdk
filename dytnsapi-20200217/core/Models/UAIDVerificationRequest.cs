// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dytnsapi20200217.Models
{
    public class UAIDVerificationRequest : TeaModel {
        /// <summary>
        /// <para>The authorization code.</para>
        /// <remarks>
        /// <para>In <b>Cell Phone Number Service</b> -&gt; <a href="https://dytns.console.aliyun.com/analysis/square"><b>Tag Marketplace</b></a>, select a tag and submit a usage application. After the application is approved, you will obtain this authorization code.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>HwD97InG</para>
        /// </summary>
        [NameInMap("AuthCode")]
        [Validation(Required=false)]
        public string AuthCode { get; set; }

        /// <summary>
        /// <para>The carrier of the user. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>CM</b>: China Mobile.</description></item>
        /// <item><description><b>CU</b>: China Unicom.</description></item>
        /// <item><description><b>CT</b>: China Telecom.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CM</para>
        /// </summary>
        [NameInMap("Carrier")]
        [Validation(Required=false)]
        public string Carrier { get; set; }

        /// <summary>
        /// <para>The public IP address. This parameter is required when the carrier is China Unicom (CU). Both IPv4 and IPv6 addresses are supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2408:8440:308:29dc:ed00:c4ec:475c:25a4</para>
        /// </summary>
        [NameInMap("Ip")]
        [Validation(Required=false)]
        public string Ip { get; set; }

        /// <summary>
        /// <para>The external serial number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>b8b5b3a*******0b9893484fdf412c99</para>
        /// </summary>
        [NameInMap("OutId")]
        [Validation(Required=false)]
        public string OutId { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The province ID. This parameter is optional when the carrier is China Unicom (CU). The value must be the same as the value of the province field in the response returned when the token is obtained.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Province")]
        [Validation(Required=false)]
        public string Province { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The carrier authorization token.  </para>
        /// <remarks>
        /// <para>For information about how to obtain the authorization token and its signature, see the GetUAIDApplyTokenSign API documentation.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MIGfMA0********3DQEBAQUAA4GNADCB</para>
        /// </summary>
        [NameInMap("Token")]
        [Validation(Required=false)]
        public string Token { get; set; }

        /// <summary>
        /// <para>The user authorization code, which indicates that the user has granted authorization. The value must be a unique random number that does not exceed 128 characters in length.  </para>
        /// <para><warning>When you integrate the service, we recommend that you include UAID-related content in the privacy policy of your product.</warning></para>
        /// 
        /// <b>Example:</b>
        /// <para>Md****a3Em</para>
        /// </summary>
        [NameInMap("UserGrantId")]
        [Validation(Required=false)]
        public string UserGrantId { get; set; }

    }

}
