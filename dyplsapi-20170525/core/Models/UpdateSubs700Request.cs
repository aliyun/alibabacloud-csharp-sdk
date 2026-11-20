// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dyplsapi20170525.Models
{
    public class UpdateSubs700Request : TeaModel {
        /// <summary>
        /// <para>The ASR model ID. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>General-telephone-Mandarin Chinese model ID: 7ee372834d2f4cc7ac0d0ab2d0ae1aac.</description></item>
        /// <item><description>General-telephone-Cantonese model ID: 9b4afe3d224e4fa3bf963697113e2f77.</description></item>
        /// <item><description>General-telephone-regional accent model ID: 3655a6cb94764145a1f9a38a3c3b3b4b.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>7ee372834d2f4cc7ac0d0ab2d0ae1aac</para>
        /// </summary>
        [NameInMap("AsrModelId")]
        [Validation(Required=false)]
        public string AsrModelId { get; set; }

        /// <summary>
        /// <para>Optional. The audio playback code.</para>
        /// <list type="bullet">
        /// <item><description>AXB mode:
        /// ACallX_Apre: The audio playback code for the voice prompt played to Number A before the call is connected when Number A calls Number X.
        /// ACallX_Ain: The audio playback code for the voice prompt played to Number A after the call is connected when Number A calls Number X.
        /// ACallX_Bin: The audio playback code for the voice prompt played to Number B after the call is connected when Number A calls Number X.
        /// BCallX_Bpre: The audio playback code for the voice prompt played to Number B before the call is connected when Number B calls Number X.
        /// BCallX_Ain: The audio playback code for the voice prompt played to Number A after the call is connected when Number B calls Number X.
        /// BCallX_Bin: The audio playback code for the voice prompt played to Number B after the call is connected when Number B calls Number X.</description></item>
        /// <item><description>GXB mode:
        /// GCallX_Gpre: The audio playback code for the voice prompt played to the caller before the call is connected when a number in Group G calls Number X.
        /// GCallX_Gin: The audio playback code for the voice prompt played to the caller after the call is connected when a number in Group G calls Number X.
        /// GCallX_Bin: The audio playback code for the voice prompt played to Number B after the call is connected when a number in Group G calls Number X.
        /// BCallX_Bpre: The audio playback code for the voice prompt played to Number B before the call is connected when Number B calls Number X.
        /// BCallX_Gin: The audio playback code for the voice prompt played to the callee after the call is connected when Number B calls Number X.
        /// BCallX_Bin: The audio playback code for the voice prompt played to Number B after the call is connected when Number B calls Number X.</description></item>
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
        /// <para>The new single-call restriction logic.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CONTROL_AX_DISABLE</para>
        /// </summary>
        [NameInMap("CallRestrict")]
        [Validation(Required=false)]
        public string CallRestrict { get; set; }

        /// <summary>
        /// <para>The default Number A for the GXB private number. Note: The callback mode can be set at the number pool level. When the callback mode is set to the default mode, this field takes effect. When Number B calls Number X, the call is forwarded to this Number A by default. If Number A is not set, the call cannot be connected. To update Number A, call the number binding modification API.</para>
        /// 
        /// <b>Example:</b>
        /// <para>138****0000</para>
        /// </summary>
        [NameInMap("DefaultA")]
        [Validation(Required=false)]
        public string DefaultA { get; set; }

        /// <summary>
        /// <para>The new expiration time of the binding relationship.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-09-05 12:00:00</para>
        /// </summary>
        [NameInMap("Expiration")]
        [Validation(Required=false)]
        public string Expiration { get; set; }

        /// <summary>
        /// <para>The new group ID in the binding relationship.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Sample value</para>
        /// </summary>
        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public string GroupId { get; set; }

        /// <summary>
        /// <para>Optional. The Industrial Internet identification code, which has a one-to-one mapping with the OrderId. The code supports characters such as periods (.) and forward slashes (/) to separate code domains. The code must not contain non-printable characters, such as spaces and line breaks. This field is required when the business user generates the Industrial Internet identification code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>700.100.1/12345678</para>
        /// </summary>
        [NameInMap("IndustrialId")]
        [Validation(Required=false)]
        public string IndustrialId { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the ASR feature. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>false: Disables the feature. This is the default value.</description></item>
        /// <item><description>true: Enables the feature.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("NeedAsr")]
        [Validation(Required=false)]
        public bool? NeedAsr { get; set; }

        /// <summary>
        /// <para>The new media selection in the binding relationship.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("NeedRecord")]
        [Validation(Required=false)]
        public bool? NeedRecord { get; set; }

        /// <summary>
        /// <para>The operation type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>updateNoA: Updates Number A.</description></item>
        /// <item><description>updateNoB: Updates Number B.</description></item>
        /// <item><description>updateExpire: Updates the validity period of the binding relationship.</description></item>
        /// <item><description>updateGroup: Updates the Number G group.</description></item>
        /// <item><description>updateNoDefaultA: Updates the default callback Number A in GXB mode.</description></item>
        /// <item><description>updateCallRestrict: Sets the single-call restriction.</description></item>
        /// <item><description>updateOutId: Updates the OutId field.</description></item>
        /// <item><description>updateIsRecordingEnabled: Updates the recording status in the binding.</description></item>
        /// <item><description>updateAsr: Updates the ASR status in the binding.</description></item>
        /// <item><description>updateAudio: Updates the ringtone configuration in the binding.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>updateNoA</para>
        /// </summary>
        [NameInMap("OperateType")]
        [Validation(Required=false)]
        public string OperateType { get; set; }

        /// <summary>
        /// <para>The order ID. This parameter is required in practice. Encrypt the order ID for reporting to the regulatory platform.</para>
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

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The key of the number pool.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>FC10000016848****</para>
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
        /// <para>The ID of the binding relationship, which uniquely identifies the number binding relationship.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10000*****</para>
        /// </summary>
        [NameInMap("SubsId")]
        [Validation(Required=false)]
        public long? SubsId { get; set; }

        /// <summary>
        /// <para>The new Number A in the binding relationship.</para>
        /// 
        /// <b>Example:</b>
        /// <para>138****0000</para>
        /// </summary>
        [NameInMap("TelA")]
        [Validation(Required=false)]
        public string TelA { get; set; }

        /// <summary>
        /// <para>The new Number B in the binding relationship.</para>
        /// 
        /// <b>Example:</b>
        /// <para>136****0000</para>
        /// </summary>
        [NameInMap("TelB")]
        [Validation(Required=false)]
        public string TelB { get; set; }

        /// <summary>
        /// <para>The intermediate Number X. If the business user does not specify Number X, the application platform assigns a number from the number pool as Number X.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>700********0000</para>
        /// </summary>
        [NameInMap("TelX")]
        [Validation(Required=false)]
        public string TelX { get; set; }

    }

}
