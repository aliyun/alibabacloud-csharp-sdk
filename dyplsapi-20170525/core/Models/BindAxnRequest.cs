// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dyplsapi20170525.Models
{
    public class BindAxnRequest : TeaModel {
        /// <summary>
        /// The ID of the ASR model. On the [Automatic Speech Recognition (ASR) Model Management](https://dyplsnext.console.aliyun.com/?spm=5176.12818093.categories-n-products.ddypls.22e616d0a0tEFC#/asr) page, you can view the ID of the ASR model.
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
        /// Re-sets the phone number display logic in the AXN binding. Fixed value: **1**, indicating that phone number X is displayed on both the calling phone and the called phone.
        /// 
        /// >  Due to the regulatory restrictions imposed by carriers, the setting to display real phone numbers during calls does not take effect.
        /// </summary>
        [NameInMap("CallDisplayType")]
        [Validation(Required=false)]
        public int? CallDisplayType { get; set; }

        /// <summary>
        /// The status of one-way call restrictions. Valid values:
        /// 
        /// *   **CONTROL_AX_DISABLE**: Phone number A cannot be used to call phone number X.
        /// *   **CONTROL_BX_DISABLE**: Phone number B cannot be used to call phone number X.
        /// </summary>
        [NameInMap("CallRestrict")]
        [Validation(Required=false)]
        public string CallRestrict { get; set; }

        /// <summary>
        /// The maximum ringing duration for each number in sequential ringing. Unit: seconds.
        /// </summary>
        [NameInMap("CallTimeout")]
        [Validation(Required=false)]
        public int? CallTimeout { get; set; }

        /// <summary>
        /// Specifies the city to which phone number X to be selected belongs.
        /// 
        /// *   If no phone number for the specified city is available in the current phone number pool or this parameter is not specified, a phone number that belongs to another city is randomly selected from the current phone number pool and assigned as phone number X.
        /// *   If **Number X Assignment Mode** is set to **Strict Matching Mode** and no phone number meets the requirement, the system displays an allocation error.
        /// </summary>
        [NameInMap("ExpectCity")]
        [Validation(Required=false)]
        public string ExpectCity { get; set; }

        /// <summary>
        /// The expiration time of the AXN binding. Unit: seconds.
        /// 
        /// >  The expiration time must be more than 60 seconds later than the time when you call this API operation.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Expiration")]
        [Validation(Required=false)]
        public string Expiration { get; set; }

        /// <summary>
        /// Specifies whether to record all calls made by the bound phone numbers. Valid values:
        /// 
        /// *   **true**
        /// *   **false** (default)
        /// </summary>
        [NameInMap("IsRecordingEnabled")]
        [Validation(Required=false)]
        public bool? IsRecordingEnabled { get; set; }

        /// <summary>
        /// The type of the phone number.
        /// 
        /// >  This parameter is applicable to the key accounts of Alibaba Cloud. This parameter can be ignored for Alibaba Cloud users.
        /// </summary>
        [NameInMap("NoType")]
        [Validation(Required=false)]
        public string NoType { get; set; }

        /// <summary>
        /// The extension field for the external business. This parameter is returned in a call record receipt.
        /// </summary>
        [NameInMap("OutId")]
        [Validation(Required=false)]
        public string OutId { get; set; }

        /// <summary>
        /// The ID of the external business.
        /// </summary>
        [NameInMap("OutOrderId")]
        [Validation(Required=false)]
        public string OutOrderId { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// Phone number A in the AXN binding. Phone number A can be set to a mobile phone number or a landline phone number. The landline phone number must be added with an area code, and no hyphen is required between the area code and the landline phone number.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("PhoneNoA")]
        [Validation(Required=false)]
        public string PhoneNoA { get; set; }

        /// <summary>
        /// Phone number B in the AXN binding. If phone number A is used to call phone number X, the call is forwarded to phone number B. Phone number B can be set to a mobile phone number or a landline phone number. The landline phone number must be added with an area code, and no hyphen is required between the area code and the landline phone number.
        /// 
        /// >  If phone number B is not specified in the AXN binding, the system automatically generates a nonexistent number. If phone number A is used to call phone number X, the nonexistent number is returned. If you need to update phone number B, call the [UpdateSubscription](https://help.aliyun.com/document_detail/110253.html) operation.
        /// </summary>
        [NameInMap("PhoneNoB")]
        [Validation(Required=false)]
        public string PhoneNoB { get; set; }

        /// <summary>
        /// Phone number X in the AXN binding. Phone number X is the phone number that you purchased in the [Phone Number Protection console](https://dypls.console.aliyun.com/dypls.htm#/account) or by using the [BuySecretNo](https://help.aliyun.com/document_detail/110266.html) operation before you bind a phone number. Phone number X is used to forward calls.
        /// 
        /// >  If you do not specify this parameter, a random phone number is selected from the phone number pool based on the value of the ExpectCity parameter and is used as phone number X.
        /// </summary>
        [NameInMap("PhoneNoX")]
        [Validation(Required=false)]
        public string PhoneNoX { get; set; }

        /// <summary>
        /// The key of the phone number pool. Log on to the [Phone Number Protection console ](https://dypls.console.aliyun.com/dypls.htm#/account)and view the key of the phone number pool on the **Number Pool Management** page.
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
        /// Sets the ringtone code for enterprise Color Ring Back Tone (CRBT) in the AXN extension binding.
        /// 
        /// *   Ringtone setting (with a callback number) when phone number A is used to call phone number X in the AXN extension binding: AXNRing_AB
        /// *   Ringtone setting (without a callback number) when phone number A is used to call phone number X in the AXN extension binding: AXNRing_A
        /// *   Ringtone setting when an N-side number is used to call phone number X in the AXN extension binding: AXNRing_N
        /// 
        /// Enterprise CRBT codes: Enterprise CRBT codes can be queried in the [Phone Number Protection console](https://dypls.console.aliyun.com/dypls.htm#/account). You can choose **Number Pool Management > Enterprise CRBT Management** to view enterprise CRBT codes. You can also upload, delete, or perform other operations on enterprise CRBT codes.
        /// 
        /// >  The bound enterprise CRBTs are preferentially used. If no enterprise CRBT is set or the setting does not take effect, the enterprise CRBTs at the phone number pool level are used.
        /// </summary>
        [NameInMap("RingConfig")]
        [Validation(Required=false)]
        public string RingConfig { get; set; }

    }

}
