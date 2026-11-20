// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dyplsapi20170525.Models
{
    public class BindGxb700Request : TeaModel {
        /// <summary>
        /// <para>The ASR model ID. Valid values: </para>
        /// <list type="bullet">
        /// <item><description>General-Phone-Chinese Mandarin model ID: 7ee372834d2f4cc7ac0d0ab2d0ae1aac </description></item>
        /// <item><description>General-Phone-Chinese Cantonese model ID: 9b4afe3d224e4fa3bf963697113e2f77 </description></item>
        /// <item><description>General-Phone-Regional Accent model ID: 3655a6cb94764145a1f9a38a3c3b3b4b.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>7ee372834d2f4cc7ac0d0ab2d0ae1aac</para>
        /// </summary>
        [NameInMap("AsrModelId")]
        [Validation(Required=false)]
        public string AsrModelId { get; set; }

        /// <summary>
        /// <para>The audio prompt code.</para>
        /// <list type="bullet">
        /// <item><description>GCallX_Gpre: the audio prompt code played to the caller before the call is connected when a number in group G calls number X.</description></item>
        /// <item><description>GCallX_Gin: the audio prompt code played to the caller after the call is connected when a number in group G calls number X.</description></item>
        /// <item><description>GCallX_Bin: the audio prompt code played to user B after the call is connected when a number in group G calls number X.</description></item>
        /// <item><description>BCallX_Bpre: the audio prompt code played to user B before the call is connected when user B calls number X.</description></item>
        /// <item><description>BCallX_Gin: the audio prompt code played to the callee after the call is connected when number X is called.</description></item>
        /// <item><description>BCallX_Bin: the audio prompt code played to user B after the call is connected when user B calls number X.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>{
        /// &quot;GCallX_Gpre&quot;:&quot;185&quot;
        /// }</para>
        /// </summary>
        [NameInMap("Audio")]
        [Validation(Required=false)]
        public string Audio { get; set; }

        /// <summary>
        /// <para>The one-way call restriction logic. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>CONTROL_BX_DISABLE: number B cannot call number X.</description></item>
        /// <item><description>CONTROL_GX_DISABLE: numbers in number group G cannot call number X.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>CONTROL_AX_DISABLE</para>
        /// </summary>
        [NameInMap("CallRestrict")]
        [Validation(Required=false)]
        public string CallRestrict { get; set; }

        /// <summary>
        /// <para>The sequential ringing duration. Unit: seconds. Valid values: 5 to 20.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("CallTimeout")]
        [Validation(Required=false)]
        public long? CallTimeout { get; set; }

        /// <summary>
        /// <para>Phone number A.
        /// The DefaultA number for the GXB private number.</para>
        /// <remarks>
        /// <para>Note
        /// The callback mode can be configured at the number pool level. When the callback mode is set to default, this field takes effect. When user B calls number X, the call is forwarded to this A number by default. If number A is not configured, the call cannot be connected.
        /// To update number A, call the number binding modification operation.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>138****0000</para>
        /// </summary>
        [NameInMap("DefaultA")]
        [Validation(Required=false)]
        public string DefaultA { get; set; }

        /// <summary>
        /// <para>The DTMF key configuration, used when setting up AXB intermediate number binding. The following items can be configured:</para>
        /// <list type="bullet">
        /// <item><description>endCallIvrPhoneNo: the party to play the audio prompt to, A or B. </description></item>
        /// <item><description>waitingDtmfTime: the maximum wait time after the first audio prompt is played. Maximum value: 30 seconds. </description></item>
        /// <item><description>maxLoop dtmf: the maximum number of times the first audio file is played in a loop when the key input does not match. Maximum value: 5. </description></item>
        /// <item><description>step1File: the name of the first audio file. </description></item>
        /// <item><description>step2File: the name of the second audio file.</description></item>
        /// <item><description>validKey: the valid key values, such as 1,2. Only two valid key values can be configured, separated by &quot;,&quot;. </description></item>
        /// <item><description>waitingEndCall: the carrier hang-up wait time. Maximum value: 10 seconds.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>{     &quot;endCallIvrPhoneNo&quot;:&quot;A&quot;,     &quot;waitingDtmfTime&quot;:10,     &quot;maxLoop&quot;:3,     &quot;step1File&quot;:&quot;62ab72f8-4750-4234-859e-e8d678c0cad3-flow_tts_test_1.wav&quot;,     &quot;step2File&quot;:&quot;62ab72f8-4750-4234-859e-e8d678c0cad3-flow_tts_test_2.wav&quot;,     &quot;validKey&quot;:&quot;1,2&quot;,     &quot;waitingEndCall&quot;:2 }</para>
        /// </summary>
        [NameInMap("DtmfConfig")]
        [Validation(Required=false)]
        public string DtmfConfig { get; set; }

        /// <summary>
        /// <para>The expiration time of the number binding.</para>
        /// <remarks>
        /// <para>Note
        /// The expiration time must be at least 1 minute later than the current binding time, accurate to the second.
        /// You can manually unbind the number at any time before the binding expires.
        /// If you unbind a number that is in an active call, the current call is not affected.</para>
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
        /// <para>The ID of number group G.</para>
        /// <para>Number group G is created by using the &quot;Create G Number Group&quot; message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10000*****</para>
        /// </summary>
        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public string GroupId { get; set; }

        /// <summary>
        /// <list type="bullet">
        /// <item><description><para>The Industrial Internet identifier code, which has a one-to-one mapping with OrderID.</para>
        /// </description></item>
        /// <item><description><para>The code supports characters such as &quot;.&quot; and &quot;/&quot; as domain separators. The code must not contain non-printable characters such as spaces or line breaks.</para>
        /// </description></item>
        /// <item><description><para>This field is required when the business user generates the Industrial Internet identifier code independently.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>700.100.1/12345678</para>
        /// </summary>
        [NameInMap("IndustrialId")]
        [Validation(Required=false)]
        public string IndustrialId { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the ASR service. Valid values: </para>
        /// <list type="bullet">
        /// <item><description><para>false: Disabled (default value).</para>
        /// </description></item>
        /// <item><description><para>true: Enabled.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("NeedAsr")]
        [Validation(Required=false)]
        public bool? NeedAsr { get; set; }

        /// <summary>
        /// <para>Specifies whether the business user requires all call media files generated by this number binding relationship. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: Enable recording.</description></item>
        /// <item><description>false: Disable recording (default value).</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("NeedRecord")]
        [Validation(Required=false)]
        public bool? NeedRecord { get; set; }

        /// <summary>
        /// <para>The business order code.</para>
        /// <list type="bullet">
        /// <item><description><para>This code has a one-to-one mapping with the actual business order and must be unique.</para>
        /// </description></item>
        /// <item><description><para>The code supports characters such as &quot;.&quot; and &quot;/&quot; as domain separators. The code must not contain non-printable characters such as spaces or line breaks.</para>
        /// </description></item>
        /// <item><description><para>This field is required when the business user submits a business order code and the platform generates an Industrial Internet identifier code.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>12345678</para>
        /// </summary>
        [NameInMap("OrderId")]
        [Validation(Required=false)]
        public string OrderId { get; set; }

        /// <summary>
        /// <para>An external business extension field. This parameter is returned in the call record receipt message.</para>
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
        /// <para>abcdefgh</para>
        /// </summary>
        [NameInMap("OutOrderId")]
        [Validation(Required=false)]
        public string OutOrderId { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The key of the China 700 number pool.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>FC10000016848****</para>
        /// </summary>
        [NameInMap("PoolKey")]
        [Validation(Required=false)]
        public string PoolKey { get; set; }

        /// <summary>
        /// <para>The recording type. Valid values: mp3 and wav.</para>
        /// 
        /// <b>Example:</b>
        /// <para>mp3</para>
        /// </summary>
        [NameInMap("RecType")]
        [Validation(Required=false)]
        public string RecType { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>Phone number of user B.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>136****0000</para>
        /// </summary>
        [NameInMap("TelB")]
        [Validation(Required=false)]
        public string TelB { get; set; }

        /// <summary>
        /// <para>The intermediate number X. If the business user does not specify an X number, the platform assigns a number from the number pool as the X number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>700********0000</para>
        /// </summary>
        [NameInMap("TelX")]
        [Validation(Required=false)]
        public string TelX { get; set; }

    }

}
