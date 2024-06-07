// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dyplsapi20170525.Models
{
    public class UpdateSubscriptionRequest : TeaModel {
        /// <summary>
        /// The ID of the ASR model.
        /// </summary>
        [NameInMap("ASRModelId")]
        [Validation(Required=false)]
        public string ASRModelId { get; set; }

        /// <summary>
        /// Specifies whether to enable automatic speech recognition (ASR). Valid values:
        /// 
        /// *   **false** (default): disables ASR.
        /// *   **true**: enables ASR.
        /// </summary>
        [NameInMap("ASRStatus")]
        [Validation(Required=false)]
        public bool? ASRStatus { get; set; }

        /// <summary>
        /// Re-sets the phone number display logic in the phone number binding. Fixed value: **1**, indicating that phone number X is displayed on both the calling phone and the called phone.
        /// 
        /// >  Due to the regulatory restrictions imposed by carriers, the setting to display real phone numbers during calls does not take effect.
        /// </summary>
        [NameInMap("CallDisplayType")]
        [Validation(Required=false)]
        public int? CallDisplayType { get; set; }

        /// <summary>
        /// One-way call restrictions. Valid values:
        /// 
        /// *   **CONTROL_AX_DISABLE**: Phone number A cannot be used to call phone number X.
        /// *   **CONTROL_BX_DISABLE**: Phone number B cannot be used to call phone number X.
        /// *   **CONTROL_CLEAR_DISABLE**: The call restrictions are cleared.
        /// 
        /// >  This parameter is required when **OperateType** is set to **updateCallRestrict**.
        /// </summary>
        [NameInMap("CallRestrict")]
        [Validation(Required=false)]
        public string CallRestrict { get; set; }

        /// <summary>
        /// Re-sets the expiration time of the phone number binding.
        /// 
        /// > 
        /// 
        /// *   This parameter is required when **OperateType** is set to **updateExpire**.
        /// 
        /// *   The expiration time must be more than 1 minute later than the time when you call this API operation.
        /// </summary>
        [NameInMap("Expiration")]
        [Validation(Required=false)]
        public string Expiration { get; set; }

        /// <summary>
        /// The ID of number group G in the phone number binding.
        /// 
        /// >  This parameter is required when **OperateType** is set to **updateAxgGroup**.
        /// </summary>
        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public string GroupId { get; set; }

        /// <summary>
        /// Re-sets the recording status in the phone number binding.
        /// 
        /// >  This parameter does not have a default value. If you do not specify this parameter, the value of the corresponding field is not updated.
        /// </summary>
        [NameInMap("IsRecordingEnabled")]
        [Validation(Required=false)]
        public bool? IsRecordingEnabled { get; set; }

        /// <summary>
        /// The operation to modify the phone number binding. Valid values:
        /// 
        /// *   **updateNoA**: modifies phone number A.
        /// *   **updateNoB**: modifies phone number B.
        /// *   **updateExpire**: modifies the validity period of the binding.
        /// *   **updateAxgGroup**: modifies number group G.
        /// *   **updateCallRestrict**: modifies one-way call restrictions.
        /// *   **updateCallDisplayType**: updates the number display logic for calls.
        /// *   **updateOutId**: updates the value of the OutId parameter.
        /// *   **updateIsRecordingEnabled**: updates the status of the recording feature in the binding.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("OperateType")]
        [Validation(Required=false)]
        public string OperateType { get; set; }

        /// <summary>
        /// Re-sets the value of the OutId parameter in the phone number binding.
        /// </summary>
        [NameInMap("OutId")]
        [Validation(Required=false)]
        public string OutId { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// Phone number A in the phone number binding.
        /// 
        /// >  This parameter is required when **OperateType** is set to **updateNoA**.
        /// </summary>
        [NameInMap("PhoneNoA")]
        [Validation(Required=false)]
        public string PhoneNoA { get; set; }

        /// <summary>
        /// Phone number B in the phone number binding.
        /// 
        /// >  This parameter is required when **OperateType** is set to **updateNoB**.
        /// </summary>
        [NameInMap("PhoneNoB")]
        [Validation(Required=false)]
        public string PhoneNoB { get; set; }

        /// <summary>
        /// Phone number X in the phone number binding.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("PhoneNoX")]
        [Validation(Required=false)]
        public string PhoneNoX { get; set; }

        /// <summary>
        /// The key of the phone number pool.
        /// 
        /// Log on to the [Phone Number Protection console](https://dypls.console.aliyun.com/dypls.htm#/account) and view the key of the phone number pool on the **Number Pool Management** page.
        /// 
        /// >  This parameter is required when **ProductType** is left empty.
        /// </summary>
        [NameInMap("PoolKey")]
        [Validation(Required=false)]
        public string PoolKey { get; set; }

        /// <summary>
        /// The product type. Valid values:
        /// 
        /// *   **AXB_170**
        /// *   **AXN_170**
        /// *   **AXN_95**
        /// *   **AXN_EXTENSION_REUSE**
        /// 
        /// > 
        /// 
        /// *   This parameter is applicable to the original key accounts of Alibaba Cloud. This parameter can be ignored for Alibaba Cloud users.
        /// 
        /// *   This parameter is required when **PoolKey** is left empty.
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
        /// Updates the ringtone code for enterprise Color Ring Back Tone (CRBT) in the phone number binding.
        /// 
        /// AXB product:
        /// 
        /// *   Ringtone setting when phone number A is used to call phone number X in the AXB binding: AXBRing_A
        /// *   Ringtone setting when phone number B is used to call phone number X in the AXB binding: AXBRing_B
        /// 
        /// AXN product:
        /// 
        /// *   Ringtone setting (with a callback number) when phone number A is used to call phone number X in the AXN extension binding: AXNRing_AB
        /// *   Ringtone setting (without a callback number) when phone number A is used to call phone number X in the AXN extension binding: AXNRing_A
        /// *   Ringtone setting when phone number N is used to call phone number X in the AXN extension binding: AXNRing_N
        /// 
        /// AXG product:
        /// 
        /// *   Ringtone setting (with a callback number) when phone number A is used to call phone number X in the AXG binding: AXGRing_AB
        /// *   Ringtone setting (without a callback number) when phone number A is used to call phone number X in the AXG binding: AXGRing_A
        /// *   Ringtone setting when a phone number in number group G is used to call phone number X in the AXG binding: AXGRing_G
        /// 
        /// Enterprise CRBT codes: Enterprise CRBT codes can be queried in the [Phone Number Protection console](https://dypls.console.aliyun.com/dypls.htm#/account). You can choose **Number Pool Management** > **Enterprise CRBT Management** to view and manage enterprise CRBT codes. You can also upload, delete, or perform other operations on enterprise CRBT codes.
        /// 
        /// >  The bound enterprise CRBTs are preferentially used. If no enterprise CRBT is set or the setting does not take effect, the enterprise CRBTs at the phone number pool level are used.
        /// </summary>
        [NameInMap("RingConfig")]
        [Validation(Required=false)]
        public string RingConfig { get; set; }

        /// <summary>
        /// The binding ID.
        /// 
        /// Log on to the [Phone Number Protection console](https://dypls.console.aliyun.com/dypls.htm#/account), choose **Number and Number Pool** > **Number Management**. On the Number Management page, select the desired record and click Details to view the binding ID. Alternatively, you can view the value of the **SubsId** parameter returned by an API operation for a phone number binding such as BindAxb. The value of this parameter indicates a binding ID.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("SubsId")]
        [Validation(Required=false)]
        public string SubsId { get; set; }

    }

}
