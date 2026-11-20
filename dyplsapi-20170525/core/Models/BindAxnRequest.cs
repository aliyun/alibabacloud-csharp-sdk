// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dyplsapi20170525.Models
{
    public class BindAxnRequest : TeaModel {
        /// <summary>
        /// <para>The ASR model ID. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>7ee372834d2f4cc7ac0d0ab2d0ae1aac: General-Telephone-Mandarin Chinese model.</para>
        /// </description></item>
        /// <item><description><para>9b4afe3d224e4fa3bf963697113e2f77: General-Telephone-Cantonese model.</para>
        /// </description></item>
        /// <item><description><para>3655a6cb94764145a1f9a38a3c3b3b4b: General-Telephone-Regional accent model.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>7ee372834d2f4cc7ac0d0ab2d0ae1aac</para>
        /// </summary>
        [NameInMap("ASRModelId")]
        [Validation(Required=false)]
        public string ASRModelId { get; set; }

        /// <summary>
        /// <para>The ASR status. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>false</b>: Disabled. This is the default value.</description></item>
        /// <item><description><b>true</b>: Enabled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("ASRStatus")]
        [Validation(Required=false)]
        public bool? ASRStatus { get; set; }

        /// <summary>
        /// <para>Resets the number display logic in the binding relationship. Set the value to <b>1</b>, which indicates that the intermediate Number X is displayed for both the caller and the callee.</para>
        /// <remarks>
        /// <para>Due to carrier regulatory restrictions, the setting to display the real number during a call does not take effect.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CallDisplayType")]
        [Validation(Required=false)]
        public int? CallDisplayType { get; set; }

        /// <summary>
        /// <para>The single-call restriction status. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>CONTROL_AX_DISABLE</b>: Number A cannot call Number X.</description></item>
        /// <item><description><b>CONTROL_BX_DISABLE</b>: Number B cannot call Number X.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>CONTROL_AX_DISABLE</para>
        /// </summary>
        [NameInMap("CallRestrict")]
        [Validation(Required=false)]
        public string CallRestrict { get; set; }

        /// <summary>
        /// <para>The ring duration. Unit: seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("CallTimeout")]
        [Validation(Required=false)]
        public int? CallTimeout { get; set; }

        /// <summary>
        /// <para>The city specified for selecting Number X.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>If no available numbers in the specified city exist in the current number pool, or if this parameter is not specified, a number from another city is randomly assigned from the current number pool as Number X.</description></item>
        /// <item><description>If the <b>Number X allocation mode</b> is set to <b>strict match mode</b>, the system returns an allocation error when no eligible numbers are available.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Shanghai</para>
        /// </summary>
        [NameInMap("ExpectCity")]
        [Validation(Required=false)]
        public string ExpectCity { get; set; }

        /// <summary>
        /// <para>The expiration time of the binding relationship. Unit: seconds.</para>
        /// <remarks>
        /// <para>The expiration time must be at least 60 seconds later than the current time.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-09-05 12:00:00</para>
        /// </summary>
        [NameInMap("Expiration")]
        [Validation(Required=false)]
        public string Expiration { get; set; }

        [NameInMap("Extend")]
        [Validation(Required=false)]
        public string Extend { get; set; }

        /// <summary>
        /// <para>Specifies whether to record all calls generated for this binding relationship. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: Records calls.</description></item>
        /// <item><description><b>false</b>: Does not record calls. This is the default value.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("IsRecordingEnabled")]
        [Validation(Required=false)]
        public bool? IsRecordingEnabled { get; set; }

        /// <summary>
        /// <para>The number type.</para>
        /// <remarks>
        /// <para>This parameter applies to former Alibaba Dayu customers. Alibaba Cloud users can ignore this parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>AXB_170</para>
        /// </summary>
        [NameInMap("NoType")]
        [Validation(Required=false)]
        public string NoType { get; set; }

        /// <summary>
        /// <para>The external business extension field. This parameter is returned in the call record receipt message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>abcdef</para>
        /// </summary>
        [NameInMap("OutId")]
        [Validation(Required=false)]
        public string OutId { get; set; }

        /// <summary>
        /// <para>The external business ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>34553330****</para>
        /// </summary>
        [NameInMap("OutOrderId")]
        [Validation(Required=false)]
        public string OutOrderId { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>Number A of the AXN privacy number. Number A can be a mobile phone number or a landline number. If it is a landline number, the area code must be included, and no hyphen is required between the area code and the phone number.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>139****0000</para>
        /// </summary>
        [NameInMap("PhoneNoA")]
        [Validation(Required=false)]
        public string PhoneNoA { get; set; }

        /// <summary>
        /// <para>Number B of the AXN privacy number.</para>
        /// <para>Number B can be a mobile phone number or a landline number. If it is a landline number, the area code must be included, and no hyphen is required between the area code and the phone number.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>When Number A dials Number X, the call is forwarded to Number B by default. If Number B is not set, the call cannot be connected.</description></item>
        /// <item><description>When Number A dials Number X, the call is forwarded to Number B only when the <b>callback mode for Number A</b> is set to <b>default mode</b>. Otherwise, the call cannot be connected.</description></item>
        /// <item><description>To modify the <b>callback mode for Number A</b>, go to <a href="https://dyplsnext.console.aliyun.com/number-pool?resType=1">Number Pool Management</a> &gt; filter <b>AXN privacy number</b> &gt; <b>Number Pool Management</b> &gt; <b>Callback mode for Number A</b> &gt; <b>Adjust Configuration</b>.</description></item>
        /// <item><description>To update Number B, call the <a href="https://www.alibabacloud.com/help/en/pnp/developer-reference/api-dyplsapi-2017-05-25-updatesubscription">UpdateSubscription</a> operation.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>138****0000</para>
        /// </summary>
        [NameInMap("PhoneNoB")]
        [Validation(Required=false)]
        public string PhoneNoB { get; set; }

        /// <summary>
        /// <para>Number X of the AXN privacy number.</para>
        /// <para>Number X is a privacy number that you have <a href="https://dyplsnext.console.aliyun.com/numberbuy?spm=a2c4g.11186623.0.0.7e6449bbtiHP8m">purchased</a> in the console.</para>
        /// <remarks>
        /// <para>If Number X is not specified, a number is randomly selected from the specified number pool based on the ExpectCity parameter as Number X.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>139****1111</para>
        /// </summary>
        [NameInMap("PhoneNoX")]
        [Validation(Required=false)]
        public string PhoneNoX { get; set; }

        /// <summary>
        /// <para>The key of the number pool. You can obtain the <b>number pool key</b> on the <a href="https://dyplsnext.console.aliyun.com/number-pool?spm=a2c4g.11186623.0.0.7e6449bbtiHP8m">Number Pool Management</a> page in the Privacy Protection console.</para>
        /// 
        /// <b>Example:</b>
        /// <para>FC2256****</para>
        /// </summary>
        [NameInMap("PoolKey")]
        [Validation(Required=false)]
        public string PoolKey { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>Sets the corporate color ringback tone (CRBT) played during a dial-up to Number X after the AXN privacy number is attached.</para>
        /// <para>Specify the <b>ringtone field</b> and <b>CRBT encoding</b> for this parameter.</para>
        /// <para><b>Ringtone field</b> valid values:</para>
        /// <list type="bullet">
        /// <item><description>AXNRing_AB: The ringtone Settings before Number A dials Number X and the call is connected (with a callback number) in AXN mode.</description></item>
        /// <item><description>AXNRing_A: The ringtone Settings before Number A dials Number X and the call is connected (without a callback number) in AXN mode.</description></item>
        /// <item><description>AXNRing_N: The ringtone Settings before Number N dials Number X and the call is connected in AXN mode.</description></item>
        /// <item><description>AXNRing_A_PICKUP: The ringtone Settings after Number A dials Number X and the call is connected in AXN mode.</description></item>
        /// <item><description>AXNRing_N_PICKUP: The ringtone Settings after Number N dials Number X and the call is connected in AXN mode.</description></item>
        /// </list>
        /// <para><b>CRBT encoding</b>:</para>
        /// <para>You can obtain the corporate CRBT encoding on the <a href="https://dyplsnext.console.aliyun.com/number-pool/ringtone?resType=1">Corporate CRBT Management</a> page in the Privacy Protection console.</para>
        /// <para><b>Example</b>:</para>
        /// <para>To set the ringtone played before Number A dials Number X and the call is connected (without a callback number), enter &quot;AXNRing_A&quot;: &quot;1000****1&quot;.</para>
        /// <remarks>
        /// <para>The corporate CRBT configured at the attachment level takes precedence. If it is not set or does not take effect, the CRBT configured at the number pool level is used.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;AXNRing_N&quot;:&quot;1000<b><b>1&quot;,&quot;AXNRing_A&quot;:&quot;1000</b></b>1&quot;}</para>
        /// </summary>
        [NameInMap("RingConfig")]
        [Validation(Required=false)]
        public string RingConfig { get; set; }

    }

}
