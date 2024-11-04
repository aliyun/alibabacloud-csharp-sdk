// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dyplsapi20170525.Models
{
    public class BindAxbRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the ASR model. On the <a href="https://dyplsnext.console.aliyun.com/?spm=5176.12818093.categories-n-products.ddypls.22e616d0a0tEFC#/asr">Automatic Speech Recognition (ASR) Model Management</a> page, you can view the ID of the ASR model.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7ee372834d2f4cc7ac0d0ab2d0ae1aac</para>
        /// </summary>
        [NameInMap("ASRModelId")]
        [Validation(Required=false)]
        public string ASRModelId { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable automatic speech recognition (ASR). Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>false</b> (default): disables ASR.</description></item>
        /// <item><description><b>true</b>: enables ASR.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("ASRStatus")]
        [Validation(Required=false)]
        public bool? ASRStatus { get; set; }

        /// <summary>
        /// <para>Re-sets the phone number display logic in the AXB binding. Fixed value: <b>1</b>, indicating that phone number X is displayed on both the calling phone and the called phone.</para>
        /// <remarks>
        /// <para> Due to the regulatory restrictions imposed by carriers, the setting to display real phone numbers during calls does not take effect.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CallDisplayType")]
        [Validation(Required=false)]
        public int? CallDisplayType { get; set; }

        /// <summary>
        /// <para>The status of the one-way call restriction. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>CONTROL_AX_DISABLE</b>: Phone number A cannot be used to call phone number X.</description></item>
        /// <item><description><b>CONTROL_BX_DISABLE</b>: Phone number B cannot be used to call phone number X.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>CONTROL_AX_DISABLE</para>
        /// </summary>
        [NameInMap("CallRestrict")]
        [Validation(Required=false)]
        public string CallRestrict { get; set; }

        /// <summary>
        /// <para>The maximum ringing duration for each number in sequential ringing. Unit: seconds. The value ranges from 5 to 20.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("CallTimeout")]
        [Validation(Required=false)]
        public int? CallTimeout { get; set; }

        /// <summary>
        /// <para>Specifies the dual tone multiple frequency (DTMF) key configuration in the AXB binding. The following content can be configured:</para>
        /// <list type="bullet">
        /// <item><description>endCallIvrPhoneNo: for whom the audio is played, user A or user B.</description></item>
        /// <item><description>waitingDtmfTime: the maximum waiting time after the first audio is played. The maximum waiting time is 30 seconds.</description></item>
        /// <item><description>maxLoop: the maximum number of loop playback times of the first audio if the DTMF key is not matched. The maximum number of loop playback times is 5.</description></item>
        /// <item><description>step1File: the name of the first audio.</description></item>
        /// <item><description>step2File: the name of the second audio.</description></item>
        /// <item><description>validKey: the valid key values, such as 1,2. Only two valid key values can be set, and the key values are separated by a comma (,).</description></item>
        /// <item><description>waitingEndCall: The waiting duration to hang up a call. The waiting duration is allowed by a carrier. The maximum waiting duration is 10 seconds.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>{
        ///     &quot;endCallIvrPhoneNo&quot;:&quot;A&quot;,
        ///     &quot;waitingDtmfTime&quot;:10,
        ///     &quot;maxLoop&quot;:3,
        ///     &quot;step1File&quot;:&quot;62ab72f8-4750-4234-859e-e8d678c0cad3-flow_tts_test_1.wav&quot;,
        ///     &quot;step2File&quot;:&quot;62ab72f8-4750-4234-859e-e8d678c0cad3-flow_tts_test_2.wav&quot;,
        ///     &quot;validKey&quot;:&quot;1,2&quot;,
        ///     &quot;waitingEndCall&quot;:2
        /// }</para>
        /// </summary>
        [NameInMap("DtmfConfig")]
        [Validation(Required=false)]
        public string DtmfConfig { get; set; }

        /// <summary>
        /// <para>Specifies the city to which phone number X to be selected belongs.</para>
        /// <list type="bullet">
        /// <item><description>If no phone number for the specified city is available in the current phone number pool or this parameter is not specified, a phone number that belongs to another city is randomly selected from the current phone number pool and assigned as phone number X.</description></item>
        /// <item><description>If<b>Number X Assignment Mode</b> is set to <b>Strict Matching Mode</b> and no phone number meets the requirement, the system displays an allocation error.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>hangzhou</para>
        /// </summary>
        [NameInMap("ExpectCity")]
        [Validation(Required=false)]
        public string ExpectCity { get; set; }

        /// <summary>
        /// <para>The expiration time of the AXB binding.</para>
        /// <remarks>
        /// <para> The expiration time must be more than 1 minute later than the time when you call this API operation.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-09-05 12:00:00</para>
        /// </summary>
        [NameInMap("Expiration")]
        [Validation(Required=false)]
        public string Expiration { get; set; }

        /// <summary>
        /// <para>Specifies whether to record all calls made by the bound phone numbers. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b></description></item>
        /// <item><description><b>false</b> (default)</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("IsRecordingEnabled")]
        [Validation(Required=false)]
        public bool? IsRecordingEnabled { get; set; }

        /// <summary>
        /// <para>The extension field for the external business. This parameter is returned in a call record receipt.</para>
        /// 
        /// <b>Example:</b>
        /// <para>abcdef</para>
        /// </summary>
        [NameInMap("OutId")]
        [Validation(Required=false)]
        public string OutId { get; set; }

        /// <summary>
        /// <para>The ID of the external business.</para>
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
        /// <para>Phone number A in the AXB binding.</para>
        /// <para>Phone number A can be set to a mobile phone number or a landline phone number. The landline phone number must be added with an area code, and no hyphen is required between the area code and the landline phone number.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>139****0000</para>
        /// </summary>
        [NameInMap("PhoneNoA")]
        [Validation(Required=false)]
        public string PhoneNoA { get; set; }

        /// <summary>
        /// <para>Phone number B in the AXB binding. If phone number A is used to call phone number X, the call is forwarded to phone number B. Phone number B can be set to a mobile phone number or a landline phone number. The landline phone number must be added with an area code, and no hyphen is required between the area code and the landline phone number.</para>
        /// <remarks>
        /// <para> If you need to update phone number B, call the <a href="https://help.aliyun.com/document_detail/110253.html">UpdateSubscription</a> operation.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>139****0000</para>
        /// </summary>
        [NameInMap("PhoneNoB")]
        [Validation(Required=false)]
        public string PhoneNoB { get; set; }

        /// <summary>
        /// <para>Phone number X in the AXB binding.</para>
        /// <para>Phone number X is the phone number that you purchased in the <a href="https://dypls.console.aliyun.com/dypls.htm#/account">Phone Number Protection console</a> or by using the <a href="https://help.aliyun.com/document_detail/110266.html">BuySecretNo</a> operation before you bind a phone number. Phone number X is used to forward calls.</para>
        /// <para>If you do not specify this parameter, a random phone number is selected from the phone number pool based on the value of the ExpectCity parameter and is used as phone number X.</para>
        /// 
        /// <b>Example:</b>
        /// <para>139****0000</para>
        /// </summary>
        [NameInMap("PhoneNoX")]
        [Validation(Required=false)]
        public string PhoneNoX { get; set; }

        /// <summary>
        /// <para>The key of the phone number pool.</para>
        /// <para>Log on to the <a href="https://dypls.console.aliyun.com/dypls.htm#/account">Phone Number Protection console</a> and view the key of the phone number pool on the <b>Number Pool Management</b> page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>FC5526*****</para>
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
        /// <para>Sets the ringtone code for enterprise Color Ring Back Tone (CRBT) in the AXB binding.</para>
        /// <list type="bullet">
        /// <item><description>Ringtone setting when phone number A is used to call phone number X in the AXB binding: AXBRing_A</description></item>
        /// <item><description>Ringtone setting when phone number B is used to call phone number X in the AXB binding: AXBRing_B</description></item>
        /// </list>
        /// <para>Enterprise CRBT codes: Enterprise CRBT codes can be queried in the <a href="https://dypls.console.aliyun.com/dypls.htm#/account">Phone Number Protection console</a>. You can choose <b>Number Pool Management</b> &gt; <b>Enterprise CRBT Management</b> to view enterprise CRBT codes. You can also upload, delete, or perform other operations on enterprise CRBT codes.</para>
        /// <remarks>
        /// <para> The bound enterprise CRBTs are preferentially used. If no enterprise CRBT is set or the setting does not take effect, the enterprise CRBTs at the phone number pool level are used.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;AXBRing_B&quot;:&quot;1000<b><b>1&quot;,&quot;AXBRing_A&quot;:&quot;1000</b></b>1&quot;}</para>
        /// </summary>
        [NameInMap("RingConfig")]
        [Validation(Required=false)]
        public string RingConfig { get; set; }

    }

}
