// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dytnsapi20200217.Models
{
    public class CertNoThreeElementVerificationRequest : TeaModel {
        /// <summary>
        /// <para>The authorization code. Sources:</para>
        /// <list type="bullet">
        /// <item><description>In the Cell Phone Number Service console, go to the <a href="https://dytns.console.aliyun.com/analysis/square">Tag Square</a> page, select the <b>ID Card Three Elements</b> tag, and submit a usage application. After the application is approved, you will obtain the authorization code.</description></item>
        /// <item><description>On the <a href="https://dytns.console.aliyun.com/analysis/apply">My Applications</a> page of the Cell Phone Number Service console, view the approved <b>ID Card Three Elements</b> authorization ID.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>QASDW@#**</para>
        /// </summary>
        [NameInMap("AuthCode")]
        [Validation(Required=false)]
        public string AuthCode { get; set; }

        /// <summary>
        /// <para>The name to be verified.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>张三</para>
        /// </summary>
        [NameInMap("CertName")]
        [Validation(Required=false)]
        public string CertName { get; set; }

        /// <summary>
        /// <para>The ID card number to be verified.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3***************0</para>
        /// </summary>
        [NameInMap("CertNo")]
        [Validation(Required=false)]
        public string CertNo { get; set; }

        /// <summary>
        /// <para>The BASE64 encoding of the portrait photo to be verified. <b>Remove the encoded URI information (such as <c>data:image/png;base64,</c>) before submission</b>. The photo size and the BASE64-encoded size must not exceed 50 KB.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>iVBOFMKODOFNDFP123DFSMOO...</para>
        /// </summary>
        [NameInMap("CertPicture")]
        [Validation(Required=false)]
        public string CertPicture { get; set; }

        /// <summary>
        /// <para>Specifies whether to encrypt. Currently only unencrypted is supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>不加密</para>
        /// </summary>
        [NameInMap("Mask")]
        [Validation(Required=false)]
        public string Mask { get; set; }

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
