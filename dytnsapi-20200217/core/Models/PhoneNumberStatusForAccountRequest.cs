// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dytnsapi20200217.Models
{
    public class PhoneNumberStatusForAccountRequest : TeaModel {
        /// <summary>
        /// <para>The authorization code.</para>
        /// <remarks>
        /// <para>On the <b>My Applications</b> page in the <a href="https://dytns.console.aliyun.com/analysis/apply">Phone Number Intelligence console</a>, obtain the authorization ID. This ID is the authorization code.</para>
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
        /// <item><description><para>If <c>Mask</c> is set to <c>NORMAL</c>, this parameter is an 11-digit mobile phone number.</para>
        /// </description></item>
        /// <item><description><para>If <c>Mask</c> is set to <c>MD5</c>, this parameter is a 32-character hashed string.</para>
        /// </description></item>
        /// <item><description><para>If <c>Mask</c> is set to <c>SHA256</c>, this parameter is a 64-character hashed string.</para>
        /// </description></item>
        /// <item><description><para>If <c>Mask</c> is set to <c>SM3</c>, this parameter is a 64-character hashed string.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>Notice: </para>
        /// </remarks>
        /// <para>The letters in the hashed string are case-insensitive.</para>
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
        /// <item><description><para><b>NORMAL</b>: The number is not encrypted.</para>
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
