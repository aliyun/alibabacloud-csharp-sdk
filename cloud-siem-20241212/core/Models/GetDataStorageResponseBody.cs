// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20241212.Models
{
    public class GetDataStorageResponseBody : TeaModel {
        /// <summary>
        /// <para>The detailed response content.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;DataStorageRegionId&quot;:&quot;cn-shanghai&quot;,&quot;DataStorageTotalCapacity&quot;:1000,&quot;DataStorageUsedCapacity&quot;:41.2,&quot;LogProject&quot;:&quot;aliyun-cloudsiem-data-1234567890123456-cn-shanghai&quot;,&quot;SasLogStores&quot;:[{&quot;LogName&quot;:&quot;Client events&quot;,&quot;LogStoreName&quot;:&quot;aegis-log-client&quot;,&quot;LogDeliveryStatus&quot;:&quot;enable&quot;,&quot;LogStoreTtl&quot;:180,&quot;LogDeliveryUpdateTime&quot;:&quot;2026-10-19T14:00:00&quot;,&quot;LogDeliveryPermission&quot;:&quot;allow&quot;,&quot;LogDeliveryGroup&quot;:&quot;host&quot;,&quot;LogSearchConditions&quot;:&quot;[{\&quot;<b>topic</b>\&quot;:\&quot;aegis-log-client\&quot;}]&quot;,&quot;LogCode&quot;:&quot;aegis-log-client&quot;,&quot;LogStoreExisted&quot;:true,&quot;UsedCapacity&quot;:10.3,&quot;AccountDeliveries&quot;:[{&quot;AccountId&quot;:1234567890123456,&quot;AccountName&quot;:&quot;1234567890123456&quot;,&quot;LogDeliveryStatus&quot;:&quot;enable&quot;,&quot;LogDeliveryUpdateTime&quot;:&quot;2026-10-19T14:00:00Z&quot;,&quot;IsDaAccount&quot;:true}]}],&quot;NormalizationLogStores&quot;:[{&quot;LogStoreName&quot;:&quot;host-activity&quot;,&quot;LogStoreTtl&quot;:180,&quot;UsedCapacity&quot;:10.3}],&quot;UnusedLogStores&quot;:[{&quot;LogStoreName&quot;:&quot;cloud-siem&quot;,&quot;LogStoreTtl&quot;:180,&quot;UsedCapacity&quot;:10.3}],&quot;RecordLogStores&quot;:[{&quot;LogStoreName&quot;:&quot;alert-record&quot;,&quot;LogStoreTtl&quot;:180,&quot;UsedCapacity&quot;:10.3}],&quot;NormalizationLogViews&quot;:[{&quot;CategoryName&quot;:&quot;Endpoint security&quot;,&quot;ActivityName&quot;:&quot;Host activity&quot;,&quot;LogViewName&quot;:&quot;host_activity&quot;,&quot;LogStoreName&quot;:&quot;host-activity&quot;,&quot;DetectionRuleReferenceCount&quot;:1,&quot;DetectionRuleReferenceProductIds&quot;:[&quot;sas&quot;],&quot;LogSearchConditions&quot;:&quot;[{\&quot;SCHEMA\&quot;:\&quot;host-activity\&quot;}]&quot;,&quot;LogViewExisted&quot;:true}],&quot;ColdStorageUsedCapacity&quot;:0.0,&quot;DataStorageUsedCapacityDetail&quot;:&quot;{\&quot;purchasedHotStorageCapacity\&quot;:1000,\&quot;usedHotStorageCapacity\&quot;:41.2,\&quot;usedColdStorageCapacity\&quot;:0.0,\&quot;usedHotStorageCapacityDetail\&quot;:{\&quot;cn-shanghai\&quot;:41.2},\&quot;usedColdStorageCapacityDetail\&quot;:{\&quot;cn-shanghai\&quot;:0.0}}&quot;,&quot;DataStorageRegionPermission&quot;:&quot;allow&quot;,&quot;LogServiceDisabled&quot;:false,&quot;LogProjectStateChangeAllowed&quot;:true,&quot;LogProjectState&quot;:&quot;ACTIVE&quot;,&quot;DeliverySettings&quot;:{&quot;PrerequisiteEnabled&quot;:true,&quot;CanConfigure&quot;:true,&quot;Enabled&quot;:true,&quot;Initialized&quot;:true,&quot;DaAccountId&quot;:&quot;1234567890123456&quot;,&quot;TargetProject&quot;:&quot;aliyun-cloudsiem-data-1234567890123456-cn-shanghai&quot;,&quot;TargetRegion&quot;:&quot;cn-shanghai&quot;,&quot;ConfigurationVersion&quot;:1,&quot;Accounts&quot;:[{&quot;AccountId&quot;:&quot;1234567890123456&quot;,&quot;AccountName&quot;:&quot;1234567890123456&quot;,&quot;DaAccount&quot;:true,&quot;Authorized&quot;:true}],&quot;Types&quot;:[{&quot;LogCode&quot;:&quot;aegis-log-client&quot;,&quot;SelectedAccountIds&quot;:[&quot;1234567890123456&quot;],&quot;AutoIncludeNewAccounts&quot;:true,&quot;Executions&quot;:[]}]}}</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetDataStorageResponseBodyData Data { get; set; }
        public class GetDataStorageResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The amount of cold storage used for user logs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100.0</para>
            /// </summary>
            [NameInMap("ColdStorageUsedCapacity")]
            [Validation(Required=false)]
            public double? ColdStorageUsedCapacity { get; set; }

            /// <summary>
            /// <para>The storage region for user-side logs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-shanghai</para>
            /// </summary>
            [NameInMap("DataStorageRegionId")]
            [Validation(Required=false)]
            public string DataStorageRegionId { get; set; }

            /// <summary>
            /// <para>Indicates whether the storage region can be modified. By default, modification is not allowed. Contact the product manager to reset the region. The region can be reset only once. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>allow: The storage region can be modified.</description></item>
            /// <item><description>deny: The storage region cannot be modified.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>deny</para>
            /// </summary>
            [NameInMap("DataStorageRegionPermission")]
            [Validation(Required=false)]
            public string DataStorageRegionPermission { get; set; }

            /// <summary>
            /// <para>The storage capacity purchased in subscription scenarios.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("DataStorageTotalCapacity")]
            [Validation(Required=false)]
            public long? DataStorageTotalCapacity { get; set; }

            /// <summary>
            /// <para>The storage capacity used in user log management.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100.0</para>
            /// </summary>
            [NameInMap("DataStorageUsedCapacity")]
            [Validation(Required=false)]
            public double? DataStorageUsedCapacity { get; set; }

            /// <summary>
            /// <para>The details of storage usage by log management users.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{\&quot;purchasedHotStorageCapacity\&quot;:1000,\&quot;usedHotStorageCapacity\&quot;:4.2,\&quot;usedHotStorageCapacityDetail\&quot;:{\&quot;ap-southeast-1\&quot;:4.2,\&quot;cn-shenzhen\&quot;:0.0,\&quot;cn-shanghai\&quot;:0.0}}</para>
            /// </summary>
            [NameInMap("DataStorageUsedCapacityDetail")]
            [Validation(Required=false)]
            public string DataStorageUsedCapacityDetail { get; set; }

            /// <summary>
            /// <para>The multi-account delivery settings for the current storage resource. This parameter is returned when the query is successful. If the read operation fails, refer to DeliverySettingsError.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;PrerequisiteEnabled&quot;:true,&quot;CanConfigure&quot;:true,&quot;Enabled&quot;:true,&quot;Initialized&quot;:true,&quot;DaAccountId&quot;:&quot;1234567890123456&quot;,&quot;TargetProject&quot;:&quot;aliyun-cloudsiem-data-1234567890123456-cn-shanghai&quot;,&quot;TargetRegion&quot;:&quot;cn-shanghai&quot;,&quot;ConfigurationVersion&quot;:1,&quot;Accounts&quot;:[{&quot;AccountId&quot;:&quot;1234567890123456&quot;,&quot;AccountName&quot;:&quot;1234567890123456&quot;,&quot;DaAccount&quot;:true,&quot;Authorized&quot;:true}],&quot;Types&quot;:[{&quot;LogCode&quot;:&quot;aegis-log-client&quot;,&quot;SelectedAccountIds&quot;:[&quot;1234567890123456&quot;],&quot;AutoIncludeNewAccounts&quot;:true,&quot;Executions&quot;:[]}]}</para>
            /// </summary>
            [NameInMap("DeliverySettings")]
            [Validation(Required=false)]
            public GetDataStorageResponseBodyDataDeliverySettings DeliverySettings { get; set; }
            public class GetDataStorageResponseBodyDataDeliverySettings : TeaModel {
                /// <summary>
                /// <para>The account directory of the current local account and managed members.</para>
                /// 
                /// <b>Example:</b>
                /// <para>[{&quot;AccountId&quot;:&quot;1234567890123456&quot;,&quot;AccountName&quot;:&quot;1234567890123456&quot;,&quot;DaAccount&quot;:true,&quot;Authorized&quot;:true}]</para>
                /// </summary>
                [NameInMap("Accounts")]
                [Validation(Required=false)]
                public List<GetDataStorageResponseBodyDataDeliverySettingsAccounts> Accounts { get; set; }
                public class GetDataStorageResponseBodyDataDeliverySettingsAccounts : TeaModel {
                    /// <summary>
                    /// <para>The UID of the source cloud account. The value is a decimal string.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1234567890123456</para>
                    /// </summary>
                    [NameInMap("AccountId")]
                    [Validation(Required=false)]
                    public string AccountId { get; set; }

                    /// <summary>
                    /// <para>The display name of the account. If the name is missing, the UID string is returned.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1234567890123456</para>
                    /// </summary>
                    [NameInMap("AccountName")]
                    [Validation(Required=false)]
                    public string AccountName { get; set; }

                    /// <summary>
                    /// <para>Indicates whether the account has the authorization required for log delivery. This parameter must be set to true when you add a member.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("Authorized")]
                    [Validation(Required=false)]
                    public bool? Authorized { get; set; }

                    /// <summary>
                    /// <para>Indicates whether the account is the current management and delivery target account, which is the local account.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("DaAccount")]
                    [Validation(Required=false)]
                    public bool? DaAccount { get; set; }

                }

                /// <summary>
                /// <para>Indicates whether the current account meets the conditions for configuring delivery settings. This is determined based on authorization, target project availability, capacity orders, and the current account identity. The PrerequisiteEnabled parameter must also be set to true.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("CanConfigure")]
                [Validation(Required=false)]
                public bool? CanConfigure { get; set; }

                /// <summary>
                /// <para>The version of the current delivery settings. When you modify multi-account configurations or specify member delivery, pass this value back as the ConfigurationVersion parameter. Query this value again after each modification. Do not use a fixed sample value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("ConfigurationVersion")]
                [Validation(Required=false)]
                public long? ConfigurationVersion { get; set; }

                /// <summary>
                /// <para>The UID of the current management and delivery target account. The value is a decimal string. This account is also the fixed local account in the account selection list.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1234567890123456</para>
                /// </summary>
                [NameInMap("DaAccountId")]
                [Validation(Required=false)]
                public string DaAccountId { get; set; }

                /// <summary>
                /// <para>The master switch for saved multi-account centralized delivery. A value of true indicates that the switch is turned on. A value of false indicates that the switch is turned off.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("Enabled")]
                [Validation(Required=false)]
                public bool? Enabled { get; set; }

                /// <summary>
                /// <para>Indicates whether the initialization of the account scope and automatic inclusion settings upon the first enabling is complete.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("Initialized")]
                [Validation(Required=false)]
                public bool? Initialized { get; set; }

                /// <summary>
                /// <para>Indicates whether the prerequisite of enabling multi-account security management in Security Center is met.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("PrerequisiteEnabled")]
                [Validation(Required=false)]
                public bool? PrerequisiteEnabled { get; set; }

                /// <summary>
                /// <para>The name of the current Simple Log Service project for centralized delivery. When you modify multi-account settings or specify member delivery, pass this value back as the TargetProject request parameter.</para>
                /// 
                /// <b>Example:</b>
                /// <para>aliyun-cloudsiem-data-1234567890123456-cn-shanghai</para>
                /// </summary>
                [NameInMap("TargetProject")]
                [Validation(Required=false)]
                public string TargetProject { get; set; }

                /// <summary>
                /// <para>The region ID of the current Simple Log Service project for centralized delivery.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-shanghai</para>
                /// </summary>
                [NameInMap("TargetRegion")]
                [Validation(Required=false)]
                public string TargetRegion { get; set; }

                /// <summary>
                /// <para>The account selection, automatic inclusion settings, and existing delivery status categorized by log type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>[{&quot;LogCode&quot;:&quot;aegis-log-client&quot;,&quot;SelectedAccountIds&quot;:[&quot;1234567890123456&quot;],&quot;AutoIncludeNewAccounts&quot;:true,&quot;Executions&quot;:[]}]</para>
                /// </summary>
                [NameInMap("Types")]
                [Validation(Required=false)]
                public List<GetDataStorageResponseBodyDataDeliverySettingsTypes> Types { get; set; }
                public class GetDataStorageResponseBodyDataDeliverySettingsTypes : TeaModel {
                    /// <summary>
                    /// <para>Indicates whether to automatically add subsequent new and available managed members to the selection scope of this log type.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("AutoIncludeNewAccounts")]
                    [Validation(Required=false)]
                    public bool? AutoIncludeNewAccounts { get; set; }

                    /// <summary>
                    /// <para>The list of statuses for existing source delivery records of this log type.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>[]</para>
                    /// </summary>
                    [NameInMap("Executions")]
                    [Validation(Required=false)]
                    public List<GetDataStorageResponseBodyDataDeliverySettingsTypesExecutions> Executions { get; set; }
                    public class GetDataStorageResponseBodyDataDeliverySettingsTypesExecutions : TeaModel {
                        /// <summary>
                        /// <para>The UID of the source account for this delivery record. The value is a decimal string.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1234567890123457</para>
                        /// </summary>
                        [NameInMap("AccountId")]
                        [Validation(Required=false)]
                        public string AccountId { get; set; }

                        /// <summary>
                        /// <para>A reserved compatibility field. The current implementation does not populate historical execution error codes. This field is usually empty or not returned. If execution fails, read the error code returned by the corresponding write operation.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>null</para>
                        /// </summary>
                        [NameInMap("ErrorCode")]
                        [Validation(Required=false)]
                        public string ErrorCode { get; set; }

                        /// <summary>
                        /// <para>The recorded delivery status. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description>RUNNING: The delivery is recorded as enabled after the last successful operation.</description></item>
                        /// <item><description>STOPPED: The delivery is recorded as disabled.
                        /// This field does not indicate real-time log arrival.</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>RUNNING</para>
                        /// </summary>
                        [NameInMap("Status")]
                        [Validation(Required=false)]
                        public string Status { get; set; }

                        /// <summary>
                        /// <para>The time when the delivery status was last updated. The value is a UNIX timestamp in milliseconds. If the record has no update time, this field is empty or not returned.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1792399200000</para>
                        /// </summary>
                        [NameInMap("UpdateTime")]
                        [Validation(Required=false)]
                        public long? UpdateTime { get; set; }

                    }

                    /// <summary>
                    /// <para>The unique identifier of the log type. This corresponds to UpdateDataStorageDelivery.LogCode.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>aegis-log-client</para>
                    /// </summary>
                    [NameInMap("LogCode")]
                    [Validation(Required=false)]
                    public string LogCode { get; set; }

                    /// <summary>
                    /// <para>The array of UIDs of the source accounts selected for this log type, including the local account. The response is a JSON string array. When you write an array(simple) request, serialize the value as comma-separated values.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>[&quot;1234567890123456&quot;]</para>
                    /// </summary>
                    [NameInMap("SelectedAccountIds")]
                    [Validation(Required=false)]
                    public List<string> SelectedAccountIds { get; set; }

                }

                /// <summary>
                /// <para>The reason code for why the configuration is unavailable. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>DA_UNAUTHORIZED: The management account is not authorized.</description></item>
                /// <item><description>TARGET_PROJECT_UNAVAILABLE: The target project is unavailable.</description></item>
                /// <item><description>LOG_CAPACITY_UNAVAILABLE: No valid capacity order exists.</description></item>
                /// <item><description>NOT_CURRENT_ACCOUNT: The operation is not performed by the current account.
                /// If the conditions are met, this parameter is empty or not returned.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>DA_UNAUTHORIZED</para>
                /// </summary>
                [NameInMap("UnavailableReason")]
                [Validation(Required=false)]
                public string UnavailableReason { get; set; }

            }

            /// <summary>
            /// <para>The read fault code for optional multi-account delivery settings. If the read failed, DELIVERY_SETTINGS_UNAVAILABLE is returned. If the read is successful, this field is empty or not returned and does not affect other storage fields.</para>
            /// 
            /// <b>Example:</b>
            /// <para>DELIVERY_SETTINGS_UNAVAILABLE</para>
            /// </summary>
            [NameInMap("DeliverySettingsError")]
            [Validation(Required=false)]
            public string DeliverySettingsError { get; set; }

            /// <summary>
            /// <para>The name of the Simple Log Service project that stores user logs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>aliyun-cloudsiem-data-171835723111****-cn-shanghai</para>
            /// </summary>
            [NameInMap("LogProject")]
            [Validation(Required=false)]
            public string LogProject { get; set; }

            /// <summary>
            /// <para>The status of the log project.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ACTIVE</para>
            /// </summary>
            [NameInMap("LogProjectState")]
            [Validation(Required=false)]
            public string LogProjectState { get; set; }

            /// <summary>
            /// <para>Indicates whether the status of the log project can be changed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("LogProjectStateChangeAllowed")]
            [Validation(Required=false)]
            public bool? LogProjectStateChangeAllowed { get; set; }

            /// <summary>
            /// <para>Indicates whether the log service is disabled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("LogServiceDisabled")]
            [Validation(Required=false)]
            public bool? LogServiceDisabled { get; set; }

            /// <summary>
            /// <para>The Logstore details for normalized data.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[{&quot;LogStoreName&quot;:&quot;host-activity&quot;,&quot;LogStoreTtl&quot;:180,&quot;UsedCapacity&quot;:10.3}]</para>
            /// </summary>
            [NameInMap("NormalizationLogStores")]
            [Validation(Required=false)]
            public List<GetDataStorageResponseBodyDataNormalizationLogStores> NormalizationLogStores { get; set; }
            public class GetDataStorageResponseBodyDataNormalizationLogStores : TeaModel {
                /// <summary>
                /// <para>Indicates whether automatic index discovery is enabled for the full-text index of the Logstore in Simple Log Service. This field is returned only when WithAutoKeyDetect=true is specified in the request, and is not returned if the read operation fails.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("AutoKeyDetect")]
                [Validation(Required=false)]
                public bool? AutoKeyDetect { get; set; }

                /// <summary>
                /// <para>Indicates whether the corresponding Logstore in Simple Log Service exists. A value of true indicates that the Logstore exists. A value of false indicates that the Logstore is not created and delivery is not enabled. In this case, automatic index discovery cannot be configured. This field is returned only when WithAutoKeyDetect=true is specified in the request.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("LogStoreExisted")]
                [Validation(Required=false)]
                public bool? LogStoreExisted { get; set; }

                /// <summary>
                /// <para>The name of the Logstore that stores normalized data.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vulnerability-activity</para>
                /// </summary>
                [NameInMap("LogStoreName")]
                [Validation(Required=false)]
                public string LogStoreName { get; set; }

                /// <summary>
                /// <para>The storage duration for normalized data.</para>
                /// 
                /// <b>Example:</b>
                /// <para>180</para>
                /// </summary>
                [NameInMap("LogStoreTtl")]
                [Validation(Required=false)]
                public int? LogStoreTtl { get; set; }

                /// <summary>
                /// <para>The used capacity of hot storage.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10.333</para>
                /// </summary>
                [NameInMap("UsedCapacity")]
                [Validation(Required=false)]
                public double? UsedCapacity { get; set; }

            }

            /// <summary>
            /// <para>The details of normalized datasets.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[{&quot;CategoryName&quot;:&quot;Endpoint security&quot;,&quot;ActivityName&quot;:&quot;Host activity&quot;,&quot;LogViewName&quot;:&quot;host_activity&quot;,&quot;LogStoreName&quot;:&quot;host-activity&quot;,&quot;DetectionRuleReferenceCount&quot;:1,&quot;DetectionRuleReferenceProductIds&quot;:[&quot;sas&quot;],&quot;LogSearchConditions&quot;:&quot;[{\&quot;SCHEMA\&quot;:\&quot;host-activity\&quot;}]&quot;,&quot;LogViewExisted&quot;:true}]</para>
            /// </summary>
            [NameInMap("NormalizationLogViews")]
            [Validation(Required=false)]
            public List<GetDataStorageResponseBodyDataNormalizationLogViews> NormalizationLogViews { get; set; }
            public class GetDataStorageResponseBodyDataNormalizationLogViews : TeaModel {
                /// <summary>
                /// <para>The log type of the normalized log.</para>
                /// 
                /// <b>Example:</b>
                /// <para>API security risk log</para>
                /// </summary>
                [NameInMap("ActivityName")]
                [Validation(Required=false)]
                public string ActivityName { get; set; }

                /// <summary>
                /// <para>The category of the normalized log.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Security Category</para>
                /// </summary>
                [NameInMap("CategoryName")]
                [Validation(Required=false)]
                public string CategoryName { get; set; }

                /// <summary>
                /// <para>The number of times the normalized dataset is referenced in the threat analysis integration center.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("DetectionRuleReferenceCount")]
                [Validation(Required=false)]
                public int? DetectionRuleReferenceCount { get; set; }

                /// <summary>
                /// <para>The list of products that reference the normalized dataset in the threat analysis integration center.</para>
                /// 
                /// <b>Example:</b>
                /// <para>[&quot;sas&quot;]</para>
                /// </summary>
                [NameInMap("DetectionRuleReferenceProductIds")]
                [Validation(Required=false)]
                public List<string> DetectionRuleReferenceProductIds { get; set; }

                /// <summary>
                /// <para>The query statement used to query log types in the normalized dataset.</para>
                /// 
                /// <b>Example:</b>
                /// <para>[{\&quot;SCHEMA\&quot;:\&quot;AZURE_ACTIVE_DIRECTORY_AUDIT_ACTIVITY\&quot;}]</para>
                /// </summary>
                [NameInMap("LogSearchConditions")]
                [Validation(Required=false)]
                public string LogSearchConditions { get; set; }

                /// <summary>
                /// <para>The Logstore in threat analysis that stores normalized logs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>risk-activity</para>
                /// </summary>
                [NameInMap("LogStoreName")]
                [Validation(Required=false)]
                public string LogStoreName { get; set; }

                /// <summary>
                /// <para>Indicates whether the normalized dataset exists. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>true: The dataset exists.</description></item>
                /// <item><description>false: The dataset does not exist.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("LogViewExisted")]
                [Validation(Required=false)]
                public bool? LogViewExisted { get; set; }

                /// <summary>
                /// <para>The name of the normalized dataset.</para>
                /// 
                /// <b>Example:</b>
                /// <para>risk_activity</para>
                /// </summary>
                [NameInMap("LogViewName")]
                [Validation(Required=false)]
                public string LogViewName { get; set; }

            }

            /// <summary>
            /// <para>The list of record Logstores.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[{&quot;LogStoreName&quot;:&quot;alert-record&quot;,&quot;LogStoreTtl&quot;:180,&quot;UsedCapacity&quot;:10.3}]</para>
            /// </summary>
            [NameInMap("RecordLogStores")]
            [Validation(Required=false)]
            public List<GetDataStorageResponseBodyDataRecordLogStores> RecordLogStores { get; set; }
            public class GetDataStorageResponseBodyDataRecordLogStores : TeaModel {
                /// <summary>
                /// <para>The name of the Logstore.</para>
                /// 
                /// <b>Example:</b>
                /// <para>alert-record</para>
                /// </summary>
                [NameInMap("LogStoreName")]
                [Validation(Required=false)]
                public string LogStoreName { get; set; }

                /// <summary>
                /// <para>The TTL of the Logstore.</para>
                /// 
                /// <b>Example:</b>
                /// <para>90</para>
                /// </summary>
                [NameInMap("LogStoreTtl")]
                [Validation(Required=false)]
                public int? LogStoreTtl { get; set; }

                /// <summary>
                /// <para>The used capacity of the Logstore.</para>
                /// 
                /// <b>Example:</b>
                /// <para>11.111</para>
                /// </summary>
                [NameInMap("UsedCapacity")]
                [Validation(Required=false)]
                public double? UsedCapacity { get; set; }

            }

            /// <summary>
            /// <para>The storage details of raw logs from Security Center.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[{&quot;LogName&quot;:&quot;Client events&quot;,&quot;LogStoreName&quot;:&quot;aegis-log-client&quot;,&quot;LogDeliveryStatus&quot;:&quot;enable&quot;,&quot;LogStoreTtl&quot;:180,&quot;LogDeliveryUpdateTime&quot;:&quot;2026-10-19T14:00:00&quot;,&quot;LogDeliveryPermission&quot;:&quot;allow&quot;,&quot;LogDeliveryGroup&quot;:&quot;host&quot;,&quot;LogSearchConditions&quot;:&quot;[{\&quot;<b>topic</b>\&quot;:\&quot;aegis-log-client\&quot;}]&quot;,&quot;LogCode&quot;:&quot;aegis-log-client&quot;,&quot;LogStoreExisted&quot;:true,&quot;UsedCapacity&quot;:10.3,&quot;AccountDeliveries&quot;:[{&quot;AccountId&quot;:1234567890123456,&quot;AccountName&quot;:&quot;1234567890123456&quot;,&quot;LogDeliveryStatus&quot;:&quot;enable&quot;,&quot;LogDeliveryUpdateTime&quot;:&quot;2026-10-19T14:00:00Z&quot;,&quot;IsDaAccount&quot;:true}]}]</para>
            /// </summary>
            [NameInMap("SasLogStores")]
            [Validation(Required=false)]
            public List<GetDataStorageResponseBodyDataSasLogStores> SasLogStores { get; set; }
            public class GetDataStorageResponseBodyDataSasLogStores : TeaModel {
                /// <summary>
                /// <para>The delivery records of the log type expanded by source account, including the current account and member accounts with existing records.</para>
                /// 
                /// <b>Example:</b>
                /// <para>[{&quot;AccountId&quot;:1234567890123456,&quot;AccountName&quot;:&quot;1234567890123456&quot;,&quot;LogDeliveryStatus&quot;:&quot;enable&quot;,&quot;LogDeliveryUpdateTime&quot;:&quot;2026-10-19T14:00:00Z&quot;,&quot;IsDaAccount&quot;:true}]</para>
                /// </summary>
                [NameInMap("AccountDeliveries")]
                [Validation(Required=false)]
                public List<GetDataStorageResponseBodyDataSasLogStoresAccountDeliveries> AccountDeliveries { get; set; }
                public class GetDataStorageResponseBodyDataSasLogStoresAccountDeliveries : TeaModel {
                    /// <summary>
                    /// <para>The UID of the source Alibaba Cloud account for the logs. This field is an int64 number.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1234567890123456</para>
                    /// </summary>
                    [NameInMap("AccountId")]
                    [Validation(Required=false)]
                    public long? AccountId { get; set; }

                    /// <summary>
                    /// <para>The display name of the source account. If the name is unavailable, the account UID string is used.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1234567890123456</para>
                    /// </summary>
                    [NameInMap("AccountName")]
                    [Validation(Required=false)]
                    public string AccountName { get; set; }

                    /// <summary>
                    /// <para>Indicates whether the account is the current management or target account. A value of true indicates the current account, and a value of false indicates a member source account.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("IsDaAccount")]
                    [Validation(Required=false)]
                    public bool? IsDaAccount { get; set; }

                    /// <summary>
                    /// <para>The recorded delivery status for the source account. Valid values: enable (enabled) and disable (disabled).</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>enable</para>
                    /// </summary>
                    [NameInMap("LogDeliveryStatus")]
                    [Validation(Required=false)]
                    public string LogDeliveryStatus { get; set; }

                    /// <summary>
                    /// <para>The last update time of the delivery status for the source account. This field is empty or not returned if no records are generated.</para>
                    /// <para>Use the UTC time format: yyyy-MM-ddTHH:mmZ</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2026-10-19T14:00:00Z</para>
                    /// </summary>
                    [NameInMap("LogDeliveryUpdateTime")]
                    [Validation(Required=false)]
                    public string LogDeliveryUpdateTime { get; set; }

                }

                /// <summary>
                /// <para>Indicates whether automatic index discovery is enabled for the full-text index of the Logstore in Simple Log Service. This field is returned only when WithAutoKeyDetect=true is specified in the request, and is not returned if the read operation fails.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("AutoKeyDetect")]
                [Validation(Required=false)]
                public bool? AutoKeyDetect { get; set; }

                /// <summary>
                /// <para>The log code.</para>
                /// 
                /// <b>Example:</b>
                /// <para>sas-net-block</para>
                /// </summary>
                [NameInMap("LogCode")]
                [Validation(Required=false)]
                public string LogCode { get; set; }

                /// <summary>
                /// <para>The group to which the log belongs. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>host: Host logs.</description></item>
                /// <item><description>security: Security logs.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>host</para>
                /// </summary>
                [NameInMap("LogDeliveryGroup")]
                [Validation(Required=false)]
                public string LogDeliveryGroup { get; set; }

                /// <summary>
                /// <para>Specifies whether you are allowed to toggle the log delivery switch. Log delivery is unavailable if the service is not purchased. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>allow: Allowed.</description></item>
                /// <item><description>deny: Not allowed.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>deny</para>
                /// </summary>
                [NameInMap("LogDeliveryPermission")]
                [Validation(Required=false)]
                public string LogDeliveryPermission { get; set; }

                /// <summary>
                /// <para>The log delivery status. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>enable: Delivery is enabled for the log.</description></item>
                /// <item><description>disable: Delivery is disabled for the log.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>enable</para>
                /// </summary>
                [NameInMap("LogDeliveryStatus")]
                [Validation(Required=false)]
                public string LogDeliveryStatus { get; set; }

                /// <summary>
                /// <para>The time of the last log delivery operation. The format is YYYY-MM-DDTHH:mm:ss.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2025-07-16T15:10:29</para>
                /// </summary>
                [NameInMap("LogDeliveryUpdateTime")]
                [Validation(Required=false)]
                public string LogDeliveryUpdateTime { get; set; }

                /// <summary>
                /// <para>The log name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Process Snapshot</para>
                /// </summary>
                [NameInMap("LogName")]
                [Validation(Required=false)]
                public string LogName { get; set; }

                /// <summary>
                /// <para>The default query conditions for the log. When multiple logs are stored in a single Logstore, you must use query conditions to perform a log query.</para>
                /// 
                /// <b>Example:</b>
                /// <para>[{\&quot;<b>topic</b>\&quot;:\&quot;sas-net-block\&quot;}]</para>
                /// </summary>
                [NameInMap("LogSearchConditions")]
                [Validation(Required=false)]
                public string LogSearchConditions { get; set; }

                /// <summary>
                /// <para>Indicates whether the Logstore where the log is stored exists. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>true: Exists.</description></item>
                /// <item><description>false: Does not exist.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("LogStoreExisted")]
                [Validation(Required=false)]
                public bool? LogStoreExisted { get; set; }

                /// <summary>
                /// <para>The name of the Logstore where the log is stored.</para>
                /// 
                /// <b>Example:</b>
                /// <para>sas-security-log</para>
                /// </summary>
                [NameInMap("LogStoreName")]
                [Validation(Required=false)]
                public string LogStoreName { get; set; }

                /// <summary>
                /// <para>The storage duration of the Logstore where the log is stored. The minimum storage duration is 30 days.</para>
                /// 
                /// <b>Example:</b>
                /// <para>180</para>
                /// </summary>
                [NameInMap("LogStoreTtl")]
                [Validation(Required=false)]
                public int? LogStoreTtl { get; set; }

                /// <summary>
                /// <para>The used capacity of hot storage.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10.333</para>
                /// </summary>
                [NameInMap("UsedCapacity")]
                [Validation(Required=false)]
                public double? UsedCapacity { get; set; }

            }

            /// <summary>
            /// <para>The list of legacy SIEM V1 Logstores.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[{&quot;LogStoreName&quot;:&quot;cloud-siem&quot;,&quot;LogStoreTtl&quot;:180,&quot;UsedCapacity&quot;:10.3}]</para>
            /// </summary>
            [NameInMap("UnusedLogStores")]
            [Validation(Required=false)]
            public List<GetDataStorageResponseBodyDataUnusedLogStores> UnusedLogStores { get; set; }
            public class GetDataStorageResponseBodyDataUnusedLogStores : TeaModel {
                /// <summary>
                /// <para>The name of the Logstore.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cloud-siem</para>
                /// </summary>
                [NameInMap("LogStoreName")]
                [Validation(Required=false)]
                public string LogStoreName { get; set; }

                /// <summary>
                /// <para>The data retention period.</para>
                /// 
                /// <b>Example:</b>
                /// <para>180</para>
                /// </summary>
                [NameInMap("LogStoreTtl")]
                [Validation(Required=false)]
                public int? LogStoreTtl { get; set; }

                /// <summary>
                /// <para>The used capacity of hot storage.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10.333</para>
                /// </summary>
                [NameInMap("UsedCapacity")]
                [Validation(Required=false)]
                public double? UsedCapacity { get; set; }

            }

        }

        /// <summary>
        /// <para>The request message ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>81FB0DEA-52C1-55A0-8631-8E1B9A9D****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
