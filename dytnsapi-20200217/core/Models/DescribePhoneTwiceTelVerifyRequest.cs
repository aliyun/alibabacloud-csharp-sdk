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
        /// <para>On the <b>My Applications</b> page in the <a href="https://dytns.console.aliyun.com/analysis/apply">Phone Number Verification Service console</a>, get the Authorization ID. This ID is your authorization code.</para>
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
        /// <para>The phone number to be queried. The number can be a mobile phone number or an encrypted string.</para>
        /// <list type="bullet">
        /// <item><description><para>If the value of <b>Mask</b> is <b>NORMAL</b>, <b>InputNumber</b> is an 11-digit mobile phone number.</para>
        /// </description></item>
        /// <item><description><para>If the value of <b>Mask</b> is <b>MD5</b>, <b>InputNumber</b> is a 32-bit encrypted string.</para>
        /// </description></item>
        /// <item><description><para>If the value of <b>Mask</b> is <b>SHA256</b>, <b>InputNumber</b> is a 64-bit encrypted string.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>Notice: </para>
        /// </remarks>
        /// <para>The encrypted string is not case-sensitive.</para>
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
        /// <item><description><para><b>NORMAL</b>: The phone number is not encrypted.</para>
        /// </description></item>
        /// <item><description><para><b>MD5</b></para>
        /// </description></item>
        /// <item><description><para><b>SHA256</b></para>
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

        /// <summary>
        /// <para>The registration time of a phone number. The time must be in the <c>yyyy-MM-dd HH:mm:ss</c> format. The value of this parameter is the registration time of a mobile phone user in your business. If the registration time is later than the time when a carrier assigns a number, the number is not a recycled number. Otherwise, the number is a recycled number.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description><para>If a phone number is assigned for multiple times, the system uses the last assignment time as the criterion.</para>
        /// </description></item>
        /// <item><description><para>The registration time must be later than <c>1970-01-01 00:00:00</c>.</para>
        /// </description></item>
        /// </list>
        /// </remarks>
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
