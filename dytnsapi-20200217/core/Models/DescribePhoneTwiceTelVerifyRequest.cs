// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dytnsapi20200217.Models
{
    public class DescribePhoneTwiceTelVerifyRequest : TeaModel {
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
        /// <para>139*******</para>
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

        /// <summary>
        /// <para>The registration time. Specify the time in the yyyy-MM-dd HH:mm:ss format. This time is the service registration time of the mobile phone user. If the service registration time is later than the time when the phone number is assigned by a carrier, it indicates that the phone number is not a reassigned number. Otherwise, the phone number is a reassigned number.</para>
        /// <remarks>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description><para>If a carrier allocates a single number multiple times, the system will determine whether the phone number is a reassigned number based on the time when the carrier last allocated the phone number.</para>
        /// </description></item>
        /// <item><description><para>The service registration time must be later than 00:00:00 on January 1, 1970.</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2018-01-01 00:00:00</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
