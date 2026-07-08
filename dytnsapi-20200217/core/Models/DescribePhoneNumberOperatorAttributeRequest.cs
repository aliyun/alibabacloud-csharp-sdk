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
        /// <para>On the <b>My Applications</b> page of the <a href="https://dytns.console.aliyun.com/analysis/apply">Cell Phone Number Service console</a>, obtain the authorization ID, which is the authorization code.</para>
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
        /// <para>A system parameter. You do not need to specify this parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <list type="bullet">
        /// <item><description></description></item>
        /// </list>
        /// </summary>
        [NameInMap("FlowName")]
        [Validation(Required=false)]
        public string FlowName { get; set; }

        /// <summary>
        /// <para>The phone number that you want to query.</para>
        /// <list type="bullet">
        /// <item><description>If Mask is set to NORMAL, this field is an 11-digit phone number.</description></item>
        /// <item><description>If Mask is set to MD5, this field is a 32-character encrypted string.</description></item>
        /// <item><description>If Mask is set to SHA256, this field is a 64-character encrypted string.</description></item>
        /// <item><description>If Mask is set to SM3, this field is a 64-character encrypted string.</description></item>
        /// </list>
        /// <remarks>
        /// <para>Notice: The letters in the encrypted string are not case-sensitive.</notice></para>
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
        /// <item><description><b>NORMAL</b>: no encryption</description></item>
        /// <item><description><b>MD5</b>: MD5 encryption</description></item>
        /// <item><description><b>SHA256</b>: SHA256 encryption</description></item>
        /// <item><description><b>SM3</b>: SM3 encryption</description></item>
        /// </list>
        /// <remarks>
        /// <para>Notice: All letters in the string must be uppercase.</notice></para>
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
        /// <para>A system parameter. You do not need to specify this parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <list type="bullet">
        /// <item><description></description></item>
        /// </list>
        /// </summary>
        [NameInMap("ResultCount")]
        [Validation(Required=false)]
        public string ResultCount { get; set; }

    }

}
