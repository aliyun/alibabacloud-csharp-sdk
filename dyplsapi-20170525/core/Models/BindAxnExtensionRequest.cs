// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dyplsapi20170525.Models
{
    public class BindAxnExtensionRequest : TeaModel {
        /// <summary>
        /// <para>The ASR model ID. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>General-Telephone-Mandarin Chinese model ID: 7ee372834d2f4cc7ac0d0ab2d0ae1aac</para>
        /// </description></item>
        /// <item><description><para>General-Telephone-Cantonese model ID: 9b4afe3d224e4fa3bf963697113e2f77</para>
        /// </description></item>
        /// <item><description><para>General-Telephone-Regional accent model ID: 3655a6cb94764145a1f9a38a3c3b3b4b</para>
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
        /// <para>Resets the number display logic in the binding relationship. Set the value to <b>1</b>, which indicates that the intermediate number X is displayed for both the caller and the callee.</para>
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
        /// <para>The call restriction status. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>CONTROL_AX_DISABLE</b>: Number A cannot call number X.</description></item>
        /// <item><description><b>CONTROL_BX_DISABLE</b>: Number B cannot call number X.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>CONTROL_AX_DISABLE</para>
        /// </summary>
        [NameInMap("CallRestrict")]
        [Validation(Required=false)]
        public string CallRestrict { get; set; }

        /// <summary>
        /// <para>The city where you want to select number X.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>If no available numbers exist in the specified city in the current number pool, or if this parameter is not specified, the system randomly assigns a number from another city in the current number pool as number X.</description></item>
        /// <item><description>If the <b>number X allocation mode</b> is set to <b>strict match mode</b>, the system returns an allocation error when no eligible numbers are available.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Beijing</para>
        /// </summary>
        [NameInMap("ExpectCity")]
        [Validation(Required=false)]
        public string ExpectCity { get; set; }

        /// <summary>
        /// <para>The expiration time of the binding relationship. The time is accurate to seconds.</para>
        /// <remarks>
        /// <para>The expiration time must be at least 1 minute later than the current time.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2019-09-05 12:00:00</para>
        /// </summary>
        [NameInMap("Expiration")]
        [Validation(Required=false)]
        public string Expiration { get; set; }

        [NameInMap("Extend")]
        [Validation(Required=false)]
        public string Extend { get; set; }

        /// <summary>
        /// <para>The extension number of number X. The extension number must be 1 to 3 digits in length.</para>
        /// <remarks>
        /// <para>If you specify an extension number, you must also specify number X. This means that both the Extension and PhoneNoX parameters must be specified.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>130</para>
        /// </summary>
        [NameInMap("Extension")]
        [Validation(Required=false)]
        public string Extension { get; set; }

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
        /// <para>abcdef</para>
        /// </summary>
        [NameInMap("OutOrderId")]
        [Validation(Required=false)]
        public string OutOrderId { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The number A of the AXN extension number.
        /// Number A can be a mobile phone number or a landline number. For a landline number, you must add the area code. Do not add a hyphen between the area code and the phone number.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>139****0000</para>
        /// </summary>
        [NameInMap("PhoneNoA")]
        [Validation(Required=false)]
        public string PhoneNoA { get; set; }

        /// <summary>
        /// <para>The number B of the AXN extension number.</para>
        /// <para>Number B can be a mobile phone number or a landline number. For a landline number, you must add the area code. Do not add a hyphen between the area code and the phone number.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>When number A calls number X, the call is forwarded to number B by default. If number B is not specified, the call cannot be connected.</description></item>
        /// <item><description>When number A calls number X, the call is forwarded to number B only when the <b>callback mode for number A</b> is set to <b>default mode</b>. If it is not set to <b>default mode</b>, the call cannot be connected.</description></item>
        /// <item><description>To modify the <b>callback mode for number A</b>, go to <a href="https://dyplsnext.console.aliyun.com/number-pool?resType=1">Number Pool Management</a> &gt; filter by <b>AXN Extension Number</b> &gt; <b>Number Pool Management</b> &gt; <b>Callback Mode for Number A</b> &gt; <b>Adjust Configuration</b>.</description></item>
        /// <item><description>To update number B, call the <a href="https://www.alibabacloud.com/help/en/pnp/developer-reference/api-dyplsapi-2017-05-25-updatesubscription">UpdateSubscription</a> operation.</description></item>
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
        /// <para>The number X of the AXN extension number.</para>
        /// <para>Number X is a privacy number that you have <a href="https://dyplsnext.console.aliyun.com/numberbuy?spm=a2c4g.11186623.0.0.7e6449bbtiHP8m">purchased</a> in the console.</para>
        /// <remarks>
        /// <para>If you do not specify number X, the system randomly assigns a number from the specified number pool as number X based on the ExpectCity parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>139****1111</para>
        /// </summary>
        [NameInMap("PhoneNoX")]
        [Validation(Required=false)]
        public string PhoneNoX { get; set; }

        /// <summary>
        /// <para>The key of the number pool.</para>
        /// <para>You can obtain the <b>number pool key</b> on the <a href="https://dyplsnext.console.aliyun.com/number-pool?spm=a2c4g.11186623.0.0.7e6449bbtiHP8m">Number Pool Management</a> page in the Privacy Protection console.</para>
        /// 
        /// <b>Example:</b>
        /// <para>FC10000011111****</para>
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
        /// <para>Set the corporate ringback tone for dial-up to number X after the AXN extension number is bound.</para>
        /// <para>Specify the <b>ringtone field</b> and <b>ringback tone encoding</b> for this parameter.</para>
        /// <para>Valid values for the <b>ringtone field</b>:</para>
        /// <list type="bullet">
        /// <item><description>AXNRing_AB: The ringtone settings before number A calls number X and the call is connected (with a callback number) in the AXN extension number scenario.</description></item>
        /// <item><description>AXNRing_A: The ringtone settings before number A calls number X and the call is connected (without a callback number) in the AXN extension number scenario.</description></item>
        /// <item><description>AXNRing_N: The ringtone settings before the number on side N calls number X and the call is connected in the AXN extension number scenario.</description></item>
        /// <item><description>AXNRing_A_PICKUP: The ringtone settings after number A calls number X and the call is connected in the AXN extension number scenario.</description></item>
        /// <item><description>AXNRing_N_PICKUP: The ringtone settings after the number on side N calls number X and the call is connected in the AXN extension number scenario.</description></item>
        /// </list>
        /// <para><b>Ringback tone encoding</b>:</para>
        /// <para>You can obtain the corporate ringback tone encoding on the <a href="https://dyplsnext.console.aliyun.com/number-pool/ringtone?resType=1">Corporate Ringback Tone Management</a> page in the Privacy Protection console.</para>
        /// <para><b>Example</b>:</para>
        /// <para>To set the ringtone before number A calls number X and the call is connected (without a callback number), enter &quot;AXNRing_A&quot;: &quot;1000****1&quot;.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;AXNRing_N&quot;:&quot;1000<b><b>1&quot;,&quot;AXNRing_A&quot;:&quot;1000</b></b>1&quot;}</para>
        /// </summary>
        [NameInMap("RingConfig")]
        [Validation(Required=false)]
        public string RingConfig { get; set; }

    }

}
