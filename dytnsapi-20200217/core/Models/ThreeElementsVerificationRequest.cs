// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dytnsapi20200217.Models
{
    public class ThreeElementsVerificationRequest : TeaModel {
        /// <summary>
        /// <para>The authorization code.</para>
        /// <remarks>
        /// <para>On the <b>My Applications</b> page of the <a href="https://dytns.console.aliyun.com/analysis/apply">Cell Phone Number Service console</a>, the authorization ID is the authorization code.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>QASDW@#**</para>
        /// </summary>
        [NameInMap("AuthCode")]
        [Validation(Required=false)]
        public string AuthCode { get; set; }

        /// <summary>
        /// <para>The ID card number to be verified.</para>
        /// <list type="bullet">
        /// <item><description>If Mask is set to NORMAL, this field is in plaintext.</description></item>
        /// <item><description>If Mask is set to MD5, encrypt this field by using MD5.</description></item>
        /// <item><description>If Mask is set to SHA256, encrypt this field by using SHA256.</description></item>
        /// </list>
        /// <remarks>
        /// <para>Notice: Letters in the encrypted string are case-insensitive.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>83d8040d3cb2181e04****dc6ff5566d4493876a4a5da782887446356b0a787e</para>
        /// </summary>
        [NameInMap("CertCode")]
        [Validation(Required=false)]
        public string CertCode { get; set; }

        /// <summary>
        /// <para>The phone number to be verified.</para>
        /// <list type="bullet">
        /// <item><description>If Mask is set to NORMAL, this field is in plaintext.</description></item>
        /// <item><description>If Mask is set to MD5, encrypt this field by using MD5.</description></item>
        /// <item><description>If Mask is set to SHA256, encrypt this field by using SHA256.</description></item>
        /// </list>
        /// <remarks>
        /// <para>Notice: Letters in the encrypted string are case-insensitive.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1390000****</para>
        /// </summary>
        [NameInMap("InputNumber")]
        [Validation(Required=false)]
        public string InputNumber { get; set; }

        /// <summary>
        /// <para>The encryption method. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>NORMAL</b>: No encryption.</para>
        /// </description></item>
        /// <item><description><para><b>MD5</b></para>
        /// </description></item>
        /// <item><description><para><b>SHA256</b></para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MD5</para>
        /// </summary>
        [NameInMap("Mask")]
        [Validation(Required=false)]
        public string Mask { get; set; }

        /// <summary>
        /// <para>The name to be verified.</para>
        /// <list type="bullet">
        /// <item><description>If Mask is set to NORMAL, this field is in plaintext.</description></item>
        /// <item><description>If Mask is set to MD5, encrypt this field by using MD5.</description></item>
        /// <item><description>If Mask is set to SHA256, encrypt this field by using SHA256.</description></item>
        /// </list>
        /// <remarks>
        /// <para>Notice: Letters in the encrypted string are case-insensitive.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>阿里云</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

    }

}
