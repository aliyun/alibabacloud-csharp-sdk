// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dytnsapi20200217.Models
{
    public class DescribePhoneNumberOperatorAttributeRequest : TeaModel {
        /// <summary>
        /// <para>The authorization code.</para>
        /// <remarks>
        /// <para> On the <b>My Applications</b> page in the <a href="https://dytns.console.aliyun.com/analysis/apply">Cell Phone Number Service console</a>, you can obtain the authorization code (also known as authorization ID).</para>
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
        /// <b>Example:</b>
        /// <para>示例值</para>
        /// </summary>
        [NameInMap("FlowName")]
        [Validation(Required=false)]
        public string FlowName { get; set; }

        /// <summary>
        /// <para>The phone number to be queried.</para>
        /// <list type="bullet">
        /// <item><description>If the value of Mask is NORMAL, specify an 11-digit phone number in plaintext.</description></item>
        /// <item><description>If the value of Mask is MD5, specify a 32-bit string that is encrypted by using MD5.</description></item>
        /// <item><description>If the value of Mask is SHA256, specify a 64-bit string that is encrypted by using SHA256.</description></item>
        /// </list>
        /// <remarks>
        /// <para> Letters in the encrypted strings are not case-sensitive.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>139****1234</para>
        /// </summary>
        [NameInMap("InputNumber")]
        [Validation(Required=false)]
        public string InputNumber { get; set; }

        /// <summary>
        /// <para>The encryption method of the phone number. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>NORMAL</b>: The phone number is not encrypted.</description></item>
        /// <item><description><b>MD5</b>: The phone number is MD5-encrypted.</description></item>
        /// <item><description><b>SHA256</b>: The phone number is SHA256-encrypted.</description></item>
        /// </list>
        /// <remarks>
        /// <para>Letters in the string must be uppercase.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MD5</para>
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

        /// <summary>
        /// <b>Example:</b>
        /// <para>示例值示例值示例值</para>
        /// </summary>
        [NameInMap("ResultCount")]
        [Validation(Required=false)]
        public string ResultCount { get; set; }

    }

}
