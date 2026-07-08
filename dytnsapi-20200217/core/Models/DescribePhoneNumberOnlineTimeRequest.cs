// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dytnsapi20200217.Models
{
    public class DescribePhoneNumberOnlineTimeRequest : TeaModel {
        /// <summary>
        /// <para>The authorization code.</para>
        /// <remarks>
        /// <para>Log on to the <a href="https://dytns.console.aliyun.com/analysis/apply">Cell Phone Number Service console</a>, go to the <b>My Applications</b> page, and obtain the authorization ID, which is the authorization code.</para>
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
        /// <para>The external carrier. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>MOBILE</b>: China Mobile.</description></item>
        /// <item><description><b>UNICOM</b>: China Unicom.</description></item>
        /// <item><description><b>TELECOM</b>: China Telecom.</description></item>
        /// </list>
        /// <remarks>
        /// <para>Notice: This parameter is optional. Alibaba Cloud automatically determines the carrier type based on the phone number. The value of this field has no impact on the query result.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>UNICOM</para>
        /// </summary>
        [NameInMap("Carrier")]
        [Validation(Required=false)]
        public string Carrier { get; set; }

        /// <summary>
        /// <para>The phone number to be queried.</para>
        /// <list type="bullet">
        /// <item><description>If Mask is set to NORMAL, this field is an 11-digit phone number.</description></item>
        /// <item><description>If Mask is set to MD5, this field is a 32-character encrypted string.</description></item>
        /// <item><description>If Mask is set to SHA256, this field is a 64-character encrypted string.</description></item>
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
        /// <para>The encryption method of the phone number. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>NORMAL</b>: no encryption</description></item>
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
