// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dyplsapi20170525.Models
{
    public class UpdateSubscriptionRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the ASR model.</para>
        /// 
        /// <b>Example:</b>
        /// <para>980abddb908f48e8b987cb2cd303****</para>
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
        /// <para>Re-sets the phone number display logic in the phone number binding. Fixed value: <b>1</b>, indicating that phone number X is displayed on both the calling phone and the called phone.</para>
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
        /// <para>One-way call restrictions. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>CONTROL_AX_DISABLE</b>: Phone number A cannot be used to call phone number X.</description></item>
        /// <item><description><b>CONTROL_BX_DISABLE</b>: Phone number B cannot be used to call phone number X.</description></item>
        /// <item><description><b>CONTROL_CLEAR_DISABLE</b>: The call restrictions are cleared.</description></item>
        /// </list>
        /// <remarks>
        /// <para> This parameter is required when <b>OperateType</b> is set to <b>updateCallRestrict</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>CONTROL_BX_DISABLE</para>
        /// </summary>
        [NameInMap("CallRestrict")]
        [Validation(Required=false)]
        public string CallRestrict { get; set; }

        /// <summary>
        /// <para>Re-sets the expiration time of the phone number binding.</para>
        /// <remarks>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description><para>This parameter is required when <b>OperateType</b> is set to <b>updateExpire</b>.</para>
        /// </description></item>
        /// <item><description><para>The expiration time must be more than 1 minute later than the time when you call this API operation.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>2019-09-05 12:00:00</para>
        /// </summary>
        [NameInMap("Expiration")]
        [Validation(Required=false)]
        public string Expiration { get; set; }

        /// <summary>
        /// <para>The ID of number group G in the phone number binding.</para>
        /// <remarks>
        /// <para> This parameter is required when <b>OperateType</b> is set to <b>updateAxgGroup</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1234</para>
        /// </summary>
        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public string GroupId { get; set; }

        /// <summary>
        /// <para>Re-sets the recording status in the phone number binding.</para>
        /// <remarks>
        /// <para> This parameter does not have a default value. If you do not specify this parameter, the value of the corresponding field is not updated.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("IsRecordingEnabled")]
        [Validation(Required=false)]
        public bool? IsRecordingEnabled { get; set; }

        /// <summary>
        /// <para>The operation to modify the phone number binding. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>updateNoA</b>: modifies phone number A.</description></item>
        /// <item><description><b>updateNoB</b>: modifies phone number B.</description></item>
        /// <item><description><b>updateExpire</b>: modifies the validity period of the binding.</description></item>
        /// <item><description><b>updateAxgGroup</b>: modifies number group G.</description></item>
        /// <item><description><b>updateCallRestrict</b>: modifies one-way call restrictions.</description></item>
        /// <item><description><b>updateCallDisplayType</b>: updates the number display logic for calls.</description></item>
        /// <item><description><b>updateOutId</b>: updates the value of the OutId parameter.</description></item>
        /// <item><description><b>updateIsRecordingEnabled</b>: updates the status of the recording feature in the binding.</description></item>
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
        /// <para>Re-sets the value of the OutId parameter in the phone number binding.</para>
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
        /// <para>Phone number A in the phone number binding.</para>
        /// <remarks>
        /// <para> This parameter is required when <b>OperateType</b> is set to <b>updateNoA</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1390000****</para>
        /// </summary>
        [NameInMap("PhoneNoA")]
        [Validation(Required=false)]
        public string PhoneNoA { get; set; }

        /// <summary>
        /// <para>Phone number B in the phone number binding.</para>
        /// <remarks>
        /// <para> This parameter is required when <b>OperateType</b> is set to <b>updateNoB</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1390000****</para>
        /// </summary>
        [NameInMap("PhoneNoB")]
        [Validation(Required=false)]
        public string PhoneNoB { get; set; }

        /// <summary>
        /// <para>Phone number X in the phone number binding.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1390000****</para>
        /// </summary>
        [NameInMap("PhoneNoX")]
        [Validation(Required=false)]
        public string PhoneNoX { get; set; }

        /// <summary>
        /// <para>The key of the phone number pool.</para>
        /// <para>Log on to the <a href="https://dypls.console.aliyun.com/dypls.htm#/account">Phone Number Protection console</a> and view the key of the phone number pool on the <b>Number Pool Management</b> page.</para>
        /// <remarks>
        /// <para> This parameter is required when <b>ProductType</b> is left empty.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>FC122356****</para>
        /// </summary>
        [NameInMap("PoolKey")]
        [Validation(Required=false)]
        public string PoolKey { get; set; }

        /// <summary>
        /// <para>The product type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>AXB_170</b></description></item>
        /// <item><description><b>AXN_170</b></description></item>
        /// <item><description><b>AXN_95</b></description></item>
        /// <item><description><b>AXN_EXTENSION_REUSE</b></description></item>
        /// </list>
        /// <remarks>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description><para>This parameter is applicable to the original key accounts of Alibaba Cloud. This parameter can be ignored for Alibaba Cloud users.</para>
        /// </description></item>
        /// <item><description><para>This parameter is required when <b>PoolKey</b> is left empty.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>AXB_170</para>
        /// </summary>
        [NameInMap("ProductType")]
        [Validation(Required=false)]
        public string ProductType { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>Updates the ringtone code for enterprise Color Ring Back Tone (CRBT) in the phone number binding.</para>
        /// <para>AXB product:</para>
        /// <list type="bullet">
        /// <item><description>Ringtone setting when phone number A is used to call phone number X in the AXB binding: AXBRing_A</description></item>
        /// <item><description>Ringtone setting when phone number B is used to call phone number X in the AXB binding: AXBRing_B</description></item>
        /// </list>
        /// <para>AXN product:</para>
        /// <list type="bullet">
        /// <item><description>Ringtone setting (with a callback number) when phone number A is used to call phone number X in the AXN extension binding: AXNRing_AB</description></item>
        /// <item><description>Ringtone setting (without a callback number) when phone number A is used to call phone number X in the AXN extension binding: AXNRing_A</description></item>
        /// <item><description>Ringtone setting when phone number N is used to call phone number X in the AXN extension binding: AXNRing_N</description></item>
        /// </list>
        /// <para>AXG product:</para>
        /// <list type="bullet">
        /// <item><description>Ringtone setting (with a callback number) when phone number A is used to call phone number X in the AXG binding: AXGRing_AB</description></item>
        /// <item><description>Ringtone setting (without a callback number) when phone number A is used to call phone number X in the AXG binding: AXGRing_A</description></item>
        /// <item><description>Ringtone setting when a phone number in number group G is used to call phone number X in the AXG binding: AXGRing_G</description></item>
        /// </list>
        /// <para>Enterprise CRBT codes: Enterprise CRBT codes can be queried in the <a href="https://dypls.console.aliyun.com/dypls.htm#/account">Phone Number Protection console</a>. You can choose <b>Number Pool Management</b> &gt; <b>Enterprise CRBT Management</b> to view and manage enterprise CRBT codes. You can also upload, delete, or perform other operations on enterprise CRBT codes.</para>
        /// <remarks>
        /// <para> The bound enterprise CRBTs are preferentially used. If no enterprise CRBT is set or the setting does not take effect, the enterprise CRBTs at the phone number pool level are used.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;AXBRing_B&quot;:&quot;100000001&quot;,&quot;AXBRing_A&quot;:&quot;100000001&quot;}</para>
        /// </summary>
        [NameInMap("RingConfig")]
        [Validation(Required=false)]
        public string RingConfig { get; set; }

        /// <summary>
        /// <para>The binding ID.</para>
        /// <para>Log on to the <a href="https://dypls.console.aliyun.com/dypls.htm#/account">Phone Number Protection console</a>, choose <b>Number and Number Pool</b> &gt; <b>Number Management</b>. On the Number Management page, select the desired record and click Details to view the binding ID. Alternatively, you can view the value of the <b>SubsId</b> parameter returned by an API operation for a phone number binding such as BindAxb. The value of this parameter indicates a binding ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100000076879****</para>
        /// </summary>
        [NameInMap("SubsId")]
        [Validation(Required=false)]
        public string SubsId { get; set; }

    }

}
