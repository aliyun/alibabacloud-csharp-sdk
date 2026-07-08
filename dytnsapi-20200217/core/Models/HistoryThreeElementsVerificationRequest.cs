// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dytnsapi20200217.Models
{
    public class HistoryThreeElementsVerificationRequest : TeaModel {
        /// <summary>
        /// <para>The authorization code. You can obtain it from the following sources:</para>
        /// <list type="bullet">
        /// <item><description><para>On the <a href="https://dytns.console.aliyun.com/analysis/square">Tag Plaza</a> page in the Phone Number Intelligence console, select the <b>three-element ID verification</b> tag and submit an application. You will receive an authorization code after the application is approved.</para>
        /// </description></item>
        /// <item><description><para>On the <a href="https://dytns.console.aliyun.com/analysis/apply">My Applications</a> page in the Phone Number Intelligence console, find the authorization ID for your approved <b>three-element ID verification</b> service.</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example</para>
        /// </summary>
        [NameInMap("AuthCode")]
        [Validation(Required=false)]
        public string AuthCode { get; set; }

        /// <summary>
        /// <para>The carrier to query. By default, the system queries the number\&quot;s carrier of record. Specify this parameter to route the query to a specific carrier.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>CMCC</c>: China Mobile</para>
        /// </description></item>
        /// <item><description><para><c>CUCC</c>: China Unicom</para>
        /// </description></item>
        /// <item><description><para><c>CTCC</c>: China Telecom</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>Due to number portability, a ported number\&quot;s historical carrier may be unknown. Use this parameter to explicitly query a specific carrier. If omitted, the query defaults to the number\&quot;s current carrier of record.</para>
        /// <para><b>Important</b> Specifying China Broadcasting Network is not supported and results in an HTTP 400 error.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>CMCC</para>
        /// </summary>
        [NameInMap("Carrier")]
        [Validation(Required=false)]
        public string Carrier { get; set; }

        /// <summary>
        /// <para>The ID number to verify.</para>
        /// <list type="bullet">
        /// <item><description>If <c>Mask</c> is set to <c>NORMAL</c>, the value of this parameter is in plaintext.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example</para>
        /// </summary>
        [NameInMap("CertCode")]
        [Validation(Required=false)]
        public string CertCode { get; set; }

        /// <summary>
        /// <para>The phone number to query.</para>
        /// <list type="bullet">
        /// <item><description>If <c>Mask</c> is set to <c>NORMAL</c>, this parameter must be an 11-digit mobile phone number.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example</para>
        /// </summary>
        [NameInMap("InputNumber")]
        [Validation(Required=false)]
        public string InputNumber { get; set; }

        /// <summary>
        /// <para>The encryption method. Valid value:</para>
        /// <list type="bullet">
        /// <item><description><b>NORMAL</b>: The phone number is not encrypted.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example</para>
        /// </summary>
        [NameInMap("Mask")]
        [Validation(Required=false)]
        public string Mask { get; set; }

        /// <summary>
        /// <para>The name to verify.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The historical point in time to verify, in <c>yyyyMMddHHmmss</c> format. If the specific time of day is unknown, set the <c>HHmmss</c> portion to <c>000000</c>. For example, <c>20230615000000</c> verifies ownership as of June 15, 2023.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example</para>
        /// </summary>
        [NameInMap("VerificationTime")]
        [Validation(Required=false)]
        public string VerificationTime { get; set; }

    }

}
