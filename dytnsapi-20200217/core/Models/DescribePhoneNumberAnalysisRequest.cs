// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dytnsapi20200217.Models
{
    public class DescribePhoneNumberAnalysisRequest : TeaModel {
        /// <summary>
        /// <para>The authorization code.</para>
        /// <remarks>
        /// <para>Log on to the <a href="https://dytns.console.aliyun.com/analysis/apply">Phone Number Service console</a>, go to the <b>My Applications</b> page, and obtain the authorization ID, which is the authorization code.</para>
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
        /// <para>The phone number to be queried.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>187****5620</para>
        /// </summary>
        [NameInMap("InputNumber")]
        [Validation(Required=false)]
        public string InputNumber { get; set; }

        /// <summary>
        /// <para>The encryption method of the phone number. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>NORMAL</b>: no encryption</para>
        /// </description></item>
        /// <item><description><para><b>MD5</b></para>
        /// </description></item>
        /// <item><description><para><b>SHA256</b></para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>NORMAL</para>
        /// </summary>
        [NameInMap("Mask")]
        [Validation(Required=false)]
        public string Mask { get; set; }

        /// <summary>
        /// <para>The type of the phone number. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>0</b>: mobile phone number</para>
        /// </description></item>
        /// <item><description><para><b>1</b>: mobile IMEI number</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("NumberType")]
        [Validation(Required=false)]
        public long? NumberType { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The score threshold of the phone number. Valid values: <b>0 to 100</b>.</para>
        /// <remarks>
        /// <para>Notice: Whether the specified score threshold is accepted is determined by the server. When the specified score threshold is not accepted, the data entered in this field is invalid.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("Rate")]
        [Validation(Required=false)]
        public long? Rate { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

    }

}
