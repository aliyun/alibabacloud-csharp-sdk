// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dytnsapi20200217.Models
{
    public class PhoneNumberStatusForRealRequest : TeaModel {
        /// <summary>
        /// <para>The authorization code.</para>
        /// <remarks>
        /// <para> On the <b>My Applications</b> page in the <a href="https://dytns.console.aliyun.com/analysis/apply">Cell Phone Number Service console</a>, you can obtain the authorization ID.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Dd1r***4id</para>
        /// </summary>
        [NameInMap("AuthCode")]
        [Validation(Required=false)]
        public string AuthCode { get; set; }

        /// <summary>
        /// <para>The phone number to be queried.</para>
        /// <list type="bullet">
        /// <item><description>If the value of Mask is NORMAL, the value of this field is an 11-digit phone number.</description></item>
        /// <item><description>If the value of Mask is MD5, the value of this field is a 32-bit encrypted string.</description></item>
        /// <item><description>If the value of Mask is SHA256, the value of this field is a 64-bit encrypted string.</description></item>
        /// </list>
        /// <remarks>
        /// <para> Letters in the encrypted strings are not case-sensitive.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>189****8999</para>
        /// </summary>
        [NameInMap("InputNumber")]
        [Validation(Required=false)]
        public string InputNumber { get; set; }

        /// <summary>
        /// <para>The encryption method of the phone number. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>NORMAL</b>: The phone number is not encrypted.</description></item>
        /// <item><description><b>MD5</b></description></item>
        /// <item><description><b>SHA256</b></description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>NORMAL</para>
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
