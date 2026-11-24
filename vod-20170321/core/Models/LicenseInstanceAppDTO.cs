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
        /// 
        /// <b>Example:</b>
        /// <para>0d3f2a7c1b9e4f58</para>
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// <para>beginOn</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-01-02T03:04:05Z</para>
        /// </summary>
        [NameInMap("BeginOn")]
        [Validation(Required=false)]
        public string BeginOn { get; set; }

        /// <summary>
        /// <para>contractNo</para>
        /// 
        /// <b>Example:</b>
        /// <para>782590648253664</para>
        /// </summary>
        [NameInMap("ContractNo")]
        [Validation(Required=false)]
        public string ContractNo { get; set; }

        /// <summary>
        /// <para>creationTime</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-01-02T03:04:05Z</para>
        /// </summary>
        [NameInMap("CreationTime")]
        [Validation(Required=false)]
        public string CreationTime { get; set; }

        /// <summary>
        /// <para>expiredOn</para>
        /// 
        /// <b>Example:</b>
        /// <para>2027-01-02T03:04:05Z</para>
        /// </summary>
        [NameInMap("ExpiredOn")]
        [Validation(Required=false)]
        public string ExpiredOn { get; set; }

        /// <summary>
        /// <para>instanceId</para>
        /// 
        /// <b>Example:</b>
        /// <para>lsn_9f2a1c7b3d8e4f56</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>itemId</para>
        /// 
        /// <b>Example:</b>
        /// <para>3ba9c7d21f4e6a80</para>
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
            /// 
            /// <b>Example:</b>
            /// <para>Player</para>
            /// </summary>
            [NameInMap("BusinessType")]
            [Validation(Required=false)]
            public string BusinessType { get; set; }

            /// <summary>
            /// <para>featureIds</para>
            /// 
            /// <b>Example:</b>
            /// <para>4326</para>
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
            /// 
            /// <b>Example:</b>
            /// <para>150</para>
            /// </summary>
            [NameInMap("SdkId")]
            [Validation(Required=false)]
            public int? SdkId { get; set; }

            /// <summary>
            /// <para>sdkName</para>
            /// 
            /// <b>Example:</b>
            /// <para>VOD Player SDK</para>
            /// </summary>
            [NameInMap("SdkName")]
            [Validation(Required=false)]
            public string SdkName { get; set; }

            /// <summary>
            /// <para>subscription</para>
            /// 
            /// <b>Example:</b>
            /// <para>Standard_Bundling</para>
            /// </summary>
            [NameInMap("Subscription")]
            [Validation(Required=false)]
            public string Subscription { get; set; }

            /// <summary>
            /// <para>subscriptionImp</para>
            /// 
            /// <b>Example:</b>
            /// <para>Standard</para>
            /// </summary>
            [NameInMap("SubscriptionImp")]
            [Validation(Required=false)]
            public string SubscriptionImp { get; set; }

            /// <summary>
            /// <para>subscriptionPkg</para>
            /// 
            /// <b>Example:</b>
            /// <para>Standard_Bundling</para>
            /// </summary>
            [NameInMap("SubscriptionPkg")]
            [Validation(Required=false)]
            public string SubscriptionPkg { get; set; }

        }

        /// <summary>
        /// <para>modificationTime</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-01-02T03:04:05Z</para>
        /// </summary>
        [NameInMap("ModificationTime")]
        [Validation(Required=false)]
        public string ModificationTime { get; set; }

        /// <summary>
        /// <para>status</para>
        /// 
        /// <b>Example:</b>
        /// <para>Normal</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>userId</para>
        /// 
        /// <b>Example:</b>
        /// <para>2544469002080159</para>
        /// </summary>
        [NameInMap("UserId")]
        [Validation(Required=false)]
        public long? UserId { get; set; }

    }

}
