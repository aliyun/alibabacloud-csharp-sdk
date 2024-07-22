// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appstream_center20210901.Models
{
    public class CreateAppInstanceGroupShrinkRequest : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("AppCenterImageId")]
        [Validation(Required=false)]
        public string AppCenterImageId { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("AppInstanceGroupName")]
        [Validation(Required=false)]
        public string AppInstanceGroupName { get; set; }

        [NameInMap("AutoPay")]
        [Validation(Required=false)]
        public bool? AutoPay { get; set; }

        [NameInMap("AutoRenew")]
        [Validation(Required=false)]
        public bool? AutoRenew { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("BizRegionId")]
        [Validation(Required=false)]
        public string BizRegionId { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("ChargeResourceMode")]
        [Validation(Required=false)]
        public string ChargeResourceMode { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("ChargeType")]
        [Validation(Required=false)]
        public string ChargeType { get; set; }

        [NameInMap("Network")]
        [Validation(Required=false)]
        public string NetworkShrink { get; set; }

        [NameInMap("NodePool")]
        [Validation(Required=false)]
        public string NodePoolShrink { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("Period")]
        [Validation(Required=false)]
        public int? Period { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("PeriodUnit")]
        [Validation(Required=false)]
        public string PeriodUnit { get; set; }

        [NameInMap("PreOpenAppId")]
        [Validation(Required=false)]
        public string PreOpenAppId { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("ProductType")]
        [Validation(Required=false)]
        public string ProductType { get; set; }

        [NameInMap("PromotionId")]
        [Validation(Required=false)]
        public string PromotionId { get; set; }

        [NameInMap("RuntimePolicy")]
        [Validation(Required=false)]
        public string RuntimePolicyShrink { get; set; }

        [NameInMap("SecurityPolicy")]
        [Validation(Required=false)]
        public string SecurityPolicyShrink { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("SessionTimeout")]
        [Validation(Required=false)]
        public int? SessionTimeout { get; set; }

        [NameInMap("StoragePolicy")]
        [Validation(Required=false)]
        public string StoragePolicyShrink { get; set; }

        [NameInMap("UserDefinePolicy")]
        [Validation(Required=false)]
        public string UserDefinePolicyShrink { get; set; }

        [NameInMap("UserInfo")]
        [Validation(Required=false)]
        public string UserInfoShrink { get; set; }

        [NameInMap("Users")]
        [Validation(Required=false)]
        public List<string> Users { get; set; }

        [NameInMap("VideoPolicy")]
        [Validation(Required=false)]
        public string VideoPolicyShrink { get; set; }

    }

}
