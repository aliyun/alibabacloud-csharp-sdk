// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class LicenseInstanceAppDTO : TeaModel {
        /// <summary>
        /// <para>appId</para>
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// <para>beginOn</para>
        /// </summary>
        [NameInMap("BeginOn")]
        [Validation(Required=false)]
        public string BeginOn { get; set; }

        /// <summary>
        /// <para>contractNo</para>
        /// </summary>
        [NameInMap("ContractNo")]
        [Validation(Required=false)]
        public string ContractNo { get; set; }

        /// <summary>
        /// <para>creationTime</para>
        /// </summary>
        [NameInMap("CreationTime")]
        [Validation(Required=false)]
        public string CreationTime { get; set; }

        /// <summary>
        /// <para>expiredOn</para>
        /// </summary>
        [NameInMap("ExpiredOn")]
        [Validation(Required=false)]
        public string ExpiredOn { get; set; }

        /// <summary>
        /// <para>instanceId</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>itemId</para>
        /// </summary>
        [NameInMap("ItemId")]
        [Validation(Required=false)]
        public string ItemId { get; set; }

        /// <summary>
        /// <para>LicenseConfigDTOS</para>
        /// </summary>
        [NameInMap("LicenseConfigs")]
        [Validation(Required=false)]
        public List<LicenseInstanceAppDTOLicenseConfigs> LicenseConfigs { get; set; }
        public class LicenseInstanceAppDTOLicenseConfigs : TeaModel {
            /// <summary>
            /// <para>businessType</para>
            /// </summary>
            [NameInMap("BusinessType")]
            [Validation(Required=false)]
            public string BusinessType { get; set; }

            /// <summary>
            /// <para>featureIds</para>
            /// </summary>
            [NameInMap("FeatureIds")]
            [Validation(Required=false)]
            public string FeatureIds { get; set; }

            /// <summary>
            /// <para>isTrial</para>
            /// </summary>
            [NameInMap("IsTrial")]
            [Validation(Required=false)]
            public bool? IsTrial { get; set; }

            /// <summary>
            /// <para>sdkId</para>
            /// </summary>
            [NameInMap("SdkId")]
            [Validation(Required=false)]
            public int? SdkId { get; set; }

            /// <summary>
            /// <para>sdkName</para>
            /// </summary>
            [NameInMap("SdkName")]
            [Validation(Required=false)]
            public string SdkName { get; set; }

            /// <summary>
            /// <para>subscription</para>
            /// </summary>
            [NameInMap("Subscription")]
            [Validation(Required=false)]
            public string Subscription { get; set; }

            /// <summary>
            /// <para>subscriptionImp</para>
            /// </summary>
            [NameInMap("SubscriptionImp")]
            [Validation(Required=false)]
            public string SubscriptionImp { get; set; }

            /// <summary>
            /// <para>subscriptionPkg</para>
            /// </summary>
            [NameInMap("SubscriptionPkg")]
            [Validation(Required=false)]
            public string SubscriptionPkg { get; set; }

        }

        /// <summary>
        /// <para>modificationTime</para>
        /// </summary>
        [NameInMap("ModificationTime")]
        [Validation(Required=false)]
        public string ModificationTime { get; set; }

        /// <summary>
        /// <para>status</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>userId</para>
        /// </summary>
        [NameInMap("UserId")]
        [Validation(Required=false)]
        public long? UserId { get; set; }

    }

}
