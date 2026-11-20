// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dyplsapi20170525.Models
{
    public class BindBatchAxgRequest : TeaModel {
        /// <summary>
        /// <para>The list of AXG bindings.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("AxgBindList")]
        [Validation(Required=false)]
        public List<BindBatchAxgRequestAxgBindList> AxgBindList { get; set; }
        public class BindBatchAxgRequestAxgBindList : TeaModel {
            /// <summary>
            /// <para>The ASR model ID. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>The ID of the telephony model for Mandarin: 7ee372834d2f4cc7ac0d0ab2d0ae1aac</para>
            /// </description></item>
            /// <item><description><para>The ID of the telephony model for Cantonese: 9b4afe3d224e4fa3bf963697113e2f77</para>
            /// </description></item>
            /// <item><description><para>The ID of the telephony model for local accents: 3655a6cb94764145a1f9a38a3c3b3b4b</para>
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
            /// <para>The automatic speech recognition (ASR) status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>false</b> (default): The ASR feature is disabled.</para>
            /// </description></item>
            /// <item><description><para><b>true</b>: The ASR feature is enabled.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("ASRStatus")]
            [Validation(Required=false)]
            public bool? ASRStatus { get; set; }

            /// <summary>
            /// <para>Resets the number display logic for the binding. Set the value to <b>1</b>. This indicates that the intermediate number (Number X) is displayed to both the calling and called parties.</para>
            /// <remarks>
            /// <para>Due to carrier regulations, the feature of displaying real numbers is not supported.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("CallDisplayType")]
            [Validation(Required=false)]
            public int? CallDisplayType { get; set; }

            /// <summary>
            /// <para>The one-way call restriction. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>CONTROL_AX_DISABLE</b>: Number A cannot call Number X.</para>
            /// </description></item>
            /// <item><description><para><b>CONTROL_BX_DISABLE</b>: Number B cannot call Number X.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>CONTROL_AX_DISABLE</para>
            /// </summary>
            [NameInMap("CallRestrict")]
            [Validation(Required=false)]
            public string CallRestrict { get; set; }

            /// <summary>
            /// <para>The city to which Number X belongs.</para>
            /// <remarks>
            /// <list type="bullet">
            /// <item><description><para>If no numbers are available in the specified city, or if this parameter is not specified, a number from another city in the current number pool is randomly selected and used as Number X.</para>
            /// </description></item>
            /// <item><description><para>If <b>Number X Assignment Mode</b> is set to <b>Strict Match Mode</b> and no eligible number is found, an allocation error is reported.</para>
            /// </description></item>
            /// </list>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>北京</para>
            /// </summary>
            [NameInMap("ExpectCity")]
            [Validation(Required=false)]
            public string ExpectCity { get; set; }

            /// <summary>
            /// <para>The expiration time of the binding. The value is accurate to seconds.</para>
            /// <remarks>
            /// <list type="bullet">
            /// <item><description><para>The expiration time must be more than 1 minute later than the current time.</para>
            /// </description></item>
            /// <item><description><para>This parameter is required.</para>
            /// </description></item>
            /// </list>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>2022-07-11 01:05:15</para>
            /// </summary>
            [NameInMap("Expiration")]
            [Validation(Required=false)]
            public string Expiration { get; set; }

            /// <summary>
            /// <para>The group ID (GID) in the AXG binding.</para>
            /// <para>You can view the GID in the following ways:</para>
            /// <list type="bullet">
            /// <item><description><para>Log on to the Phone Number Protection console. On the <a href="https://dyplsnext.console.aliyun.com/number-pool">Number Pool Management</a> page, select <b>AXG Privacy Number</b> and click <b>G Number Group Management</b> to view the GIDs of all G number groups.</para>
            /// </description></item>
            /// <item><description><para>If you use the <a href="https://help.aliyun.com/document_detail/110250.html">CreateAxgGroup</a> operation to create a G number group, the value of the <b>GroupId</b> parameter in the response is the GID.</para>
            /// </description></item>
            /// </list>
            /// <remarks>
            /// <para>The G number group must contain at least one phone number.</para>
            /// </remarks>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>200001234****</para>
            /// </summary>
            [NameInMap("GroupId")]
            [Validation(Required=false)]
            public string GroupId { get; set; }

            /// <summary>
            /// <para>Specifies whether to record all calls made in the binding. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>true</b>: Call recording is enabled.</para>
            /// </description></item>
            /// <item><description><para><b>false</b> (default): Call recording is disabled.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("IsRecordingEnabled")]
            [Validation(Required=false)]
            public bool? IsRecordingEnabled { get; set; }

            /// <summary>
            /// <para>The extension field. This parameter is carried in call record messages.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1***********0fd</para>
            /// </summary>
            [NameInMap("OutId")]
            [Validation(Required=false)]
            public string OutId { get; set; }

            /// <summary>
            /// <para>The external business ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20***************677</para>
            /// </summary>
            [NameInMap("OutOrderId")]
            [Validation(Required=false)]
            public string OutOrderId { get; set; }

            /// <summary>
            /// <para>Number A in the AXG binding. Number A can be a mobile phone number or a landline number. If you use a landline number, add the area code, and do not add a hyphen between the area code and the landline number.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>139****0000</para>
            /// </summary>
            [NameInMap("PhoneNoA")]
            [Validation(Required=false)]
            public string PhoneNoA { get; set; }

            /// <summary>
            /// <para>Number B in the AXG binding.</para>
            /// <para>Number B can be a mobile phone number or a landline number. If you use a landline number, add the area code, and do not add a hyphen between the area code and the landline number.</para>
            /// <remarks>
            /// <list type="bullet">
            /// <item><description><para>When Number A calls Number X, the call is transferred to Number B by default. If Number B is not specified, the call fails.</para>
            /// </description></item>
            /// <item><description><para>When Number A calls Number X, if <b>A Callback Mode</b> is set to <b>Default Mode</b>, the call is transferred to Number B. Otherwise, the call fails.</para>
            /// </description></item>
            /// <item><description><para>To modify <b>A Callback Mode</b>, on the <a href="https://dyplsnext.console.aliyun.com/number-pool?resType=1">Number Pool Management</a> page, select <b>AXG Privacy Number</b> and choose <b>Pool Management</b> &gt; <b>A Callback Mode</b> &gt; <b>Adjust Configuration</b>.</para>
            /// </description></item>
            /// <item><description><para>To update Number B, call the <a href="https://help.aliyun.com/zh/pnp/developer-reference/api-dyplsapi-2017-05-25-updatesubscription?spm=a2c4g.11186623.0.i16">UpdateSubscription</a> operation.</para>
            /// </description></item>
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
            /// <para>Number X in the AXG binding.</para>
            /// <para>Number X must be a <a href="https://dyplsnext.console.aliyun.com/numberbuy?spm=a2c4g.11186623.0.0.7e6449bbtiHP8m">purchased privacy number</a>. You can log on to the Phone Number Protection console, go to the <a href="https://dyplsnext.console.aliyun.com/number/list">Number Management</a> page, and then select <b>AXG Privacy Number</b> to obtain Number X.</para>
            /// <remarks>
            /// <para>If you do not specify Number X, a random number is selected from the number pool based on the <b>ExpectCity</b> parameter and used as Number X.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>139****1111</para>
            /// </summary>
            [NameInMap("PhoneNoX")]
            [Validation(Required=false)]
            public string PhoneNoX { get; set; }

            /// <summary>
            /// <para>The corporate ringback tone (CRBT) that is played when Number X in an AXG binding is called.</para>
            /// <para>You must specify the <b>ringtone field</b> and the <b>CRBT code</b>.</para>
            /// <para>Valid values for the <b>ringtone field</b>:</para>
            /// <list type="bullet">
            /// <item><description><para><c>AXGRing_AB</c>: the ringtone for calls from Number A to Number X (with a callback number).</para>
            /// </description></item>
            /// <item><description><para><c>AXGRing_A</c>: the ringtone for calls from Number A to Number X (without a callback number).</para>
            /// </description></item>
            /// <item><description><para><c>AXGRing_G</c>: the ringtone for calls from a number in Group G to Number X.</para>
            /// </description></item>
            /// </list>
            /// <para><b>CRBT code</b>:</para>
            /// <para>You can log on to the Phone Number Protection console and obtain the CRBT code on the <a href="https://dyplsnext.console.aliyun.com/number-pool/ringtone?resType=1">Corporate CRBT Management</a> page.</para>
            /// <para><b>Example</b>:</para>
            /// <para>To set the ringtone for calls from Number A to Number X (without a callback number), specify <c>&quot;AXGRing_A&quot;: &quot;1000****1&quot;</c>.</para>
            /// <remarks>
            /// <para>The CRBT that is set at the binding level takes precedence over the CRBT that is set at the number pool level.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;AXGRing_AB&quot;:&quot;1000<b><b>2&quot;,&quot;AXGRing_A&quot;:&quot;1000</b></b>1&quot;}</para>
            /// </summary>
            [NameInMap("RingConfig")]
            [Validation(Required=false)]
            public string RingConfig { get; set; }

        }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The key of the number pool.</para>
        /// <para>You can log on to the Phone Number Protection console and obtain the key on the <a href="https://dyplsnext.console.aliyun.com/number-pool">Number Pool Management</a> page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>FC2235****</para>
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

    }

}
