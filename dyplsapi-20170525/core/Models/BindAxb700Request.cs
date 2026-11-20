// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dyplsapi20170525.Models
{
    public class BindAxb700Request : TeaModel {
        /// <summary>
        /// <para>Optional. The ASR model ID. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>General-Phone-Mandarin model ID: 7ee372834d2f4cc7ac0d0ab2d0ae1aac</description></item>
        /// <item><description>General-Phone-Cantonese model ID: 9b4afe3d224e4fa3bf963697113e2f77</description></item>
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
        /// <para>The audio prompt encoding.</para>
        /// <list type="bullet">
        /// <item><description>ACallX_Apre: The audio prompt encoding played to A before the call is connected when A calls X.</description></item>
        /// <item><description>ACallX_Ain: The audio prompt encoding played to A after the call is connected when A calls X.</description></item>
        /// <item><description>ACallX_Bin: The audio prompt encoding played to B after the call is connected when A calls X.</description></item>
        /// <item><description>BCallX_Bpre: The audio prompt encoding played to B before the call is connected when B calls X.</description></item>
        /// <item><description>BCallX_Ain: The audio prompt encoding played to A after the call is connected when B calls X.</description></item>
        /// <item><description>BCallX_Bin: The audio prompt encoding played to B after the call is connected when B calls X.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>{
        /// &quot;ACallX_Apre&quot;:&quot;185&quot;
        /// }</para>
        /// </summary>
        [NameInMap("Audio")]
        [Validation(Required=false)]
        public string Audio { get; set; }

        /// <summary>
        /// <para>The one-way call restriction logic. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>CONTROL_AX_DISABLE: Number A cannot call number X.</para>
        /// </description></item>
        /// <item><description><para>CONTROL_BX_DISABLE: Number B cannot call number X.</para>
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
        /// <para>The sequential ringing duration. Unit: seconds. Valid values: 5 to 20.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("CallTimeout")]
        [Validation(Required=false)]
        public long? CallTimeout { get; set; }

        /// <summary>
        /// <para>Optional. The DTMF key configuration for 700AXB number binding. The following items can be configured:</para>
        /// <list type="bullet">
        /// <item><description>endCallIvrPhoneNo: The audio playback target, A or B.</description></item>
        /// <item><description>waitingDtmfTime: The maximum wait time after the first audio file is played. Maximum value: 30 seconds.</description></item>
        /// <item><description>maxLoop dtmf: The maximum number of times the first audio file is replayed when a key press does not match. Maximum value: 5.</description></item>
        /// <item><description>step1File: The name of the first audio file.</description></item>
        /// <item><description>step2File: The name of the second audio file.</description></item>
        /// <item><description>validKey: The valid key values, such as 1,2. Only two valid key values can be configured, separated by commas (,).</description></item>
        /// <item><description>waitingEndCall: The carrier hang-up wait time. Maximum value: 10 seconds.</description></item>
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
        /// <para>The expiration time of the number binding.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>The expiration time must be at least 1 minute later than the current binding time, accurate to the second.</description></item>
        /// <item><description>You can manually unbind the number at any time before the binding expires.</description></item>
        /// <item><description>If you unbind a number that is in an active call, the current call is not affected.</description></item>
        /// </list>
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
        /// <para>The industrial Internet identifier code, which has a one-to-one mapping with OrderId.</para>
        /// <para>The code supports characters such as &quot;.&quot; and &quot;/&quot; as domain separators. The code must not contain non-printable characters such as spaces or line breaks.</para>
        /// <para>This field is required when the caller generates the industrial Internet identifier code independently.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Either OrderId or IndustrialId is required depending on the business scenario.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>700.100.1/12345678</para>
        /// </summary>
        [NameInMap("IndustrialId")]
        [Validation(Required=false)]
        public string IndustrialId { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the ASR service. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>false: Disable (default).</para>
        /// </description></item>
        /// <item><description><para>true: Enable.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("NeedAsr")]
        [Validation(Required=false)]
        public bool? NeedAsr { get; set; }

        /// <summary>
        /// <para>Specifies whether call recording files are required for all calls made through this number binding. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>true: Enable recording.</para>
        /// </description></item>
        /// <item><description><para>false: Disable recording (default).</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
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
        /// <item><description><para>This field is required when the caller submits a business order code and the platform generates an industrial Internet identifier code.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Either OrderId or IndustrialId is required depending on the business scenario.</description></item>
        /// </list>
        /// </remarks>
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
        /// <para>FC2258****</para>
        /// </summary>
        [NameInMap("PoolKey")]
        [Validation(Required=false)]
        public string PoolKey { get; set; }

        /// <summary>
        /// <para>The recording file format. Valid values: mp3 and wav.</para>
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
        /// <para>The phone number of user A.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>139****0000</para>
        /// </summary>
        [NameInMap("TelA")]
        [Validation(Required=false)]
        public string TelA { get; set; }

        /// <summary>
        /// <para>The phone number of user B.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>136****0000</para>
        /// </summary>
        [NameInMap("TelB")]
        [Validation(Required=false)]
        public string TelB { get; set; }

        /// <summary>
        /// <para>Optional. The intermediate number X.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>If the caller does not specify an X number,</description></item>
        /// <item><description>the platform assigns a number from the number pool as the X number.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>700********0000</para>
        /// </summary>
        [NameInMap("TelX")]
        [Validation(Required=false)]
        public string TelX { get; set; }

    }

}
