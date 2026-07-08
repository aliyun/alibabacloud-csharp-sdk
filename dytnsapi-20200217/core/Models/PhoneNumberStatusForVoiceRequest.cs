// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dytnsapi20200217.Models
{
    public class PhoneNumberStatusForVoiceRequest : TeaModel {
        /// <summary>
        /// <para>The authorization code.</para>
        /// <remarks>
        /// <para>The authorization code is the authorization ID that you can find on the <b>My Applications</b> page of the <a href="https://dytns.console.aliyun.com/analysis/apply">Phone Number Encyclopedia console</a>.</para>
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
        /// <para>The phone number to query.</para>
        /// <list type="bullet">
        /// <item><description><para>If you set <c>Mask</c> to <c>NORMAL</c>, specify an 11-digit mobile number.</para>
        /// </description></item>
        /// <item><description><para>If you set <c>Mask</c> to <c>MD5</c>, specify a 32-bit encrypted string.</para>
        /// </description></item>
        /// <item><description><para>If you set <c>Mask</c> to <c>SHA256</c>, specify a 64-bit encrypted string.</para>
        /// </description></item>
        /// <item><description><para>If you set <c>Mask</c> to <c>SM3</c>, specify a 64-bit encrypted string.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>Notice: </para>
        /// </remarks>
        /// <para>The letters in the encrypted string are not case-sensitive.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>139****1234</para>
        /// </summary>
        [NameInMap("InputNumber")]
        [Validation(Required=false)]
        public string InputNumber { get; set; }

        /// <summary>
        /// <para>The encryption method. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>NORMAL</b>: The number is in plaintext.</para>
        /// </description></item>
        /// <item><description><para><b>MD5</b></para>
        /// </description></item>
        /// <item><description><para><b>SHA256</b></para>
        /// </description></item>
        /// <item><description><para><b>SM3</b></para>
        /// </description></item>
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
