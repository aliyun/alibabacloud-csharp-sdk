// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20241212.Models
{
    public class GetDataStorageResponseBody : TeaModel {
        /// <summary>
        /// <para>The returned details.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetDataStorageResponseBodyData Data { get; set; }
        public class GetDataStorageResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The cold storage capacity used by user logs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100.0</para>
            /// </summary>
            [NameInMap("ColdStorageUsedCapacity")]
            [Validation(Required=false)]
            public double? ColdStorageUsedCapacity { get; set; }

            /// <summary>
            /// <para>The storage region of user logs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-shanghai</para>
            /// </summary>
            [NameInMap("DataStorageRegionId")]
            [Validation(Required=false)]
            public string DataStorageRegionId { get; set; }

            /// <summary>
            /// <para>Indicates whether the storage region can be modified. By default, the storage region cannot be modified. Contact your account manager to reset the region. The region can be reset only once. Valid values:</para>
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
            /// <para>The storage capacity purchased in the subscription scenario.</para>
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
            /// <para>The storage usage details in log management.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{\&quot;purchasedHotStorageCapacity\&quot;:1000,\&quot;usedHotStorageCapacity\&quot;:4.2,\&quot;usedHotStorageCapacityDetail\&quot;:{\&quot;ap-southeast-1\&quot;:4.2,\&quot;cn-shenzhen\&quot;:0.0,\&quot;cn-shanghai\&quot;:0.0}}</para>
            /// </summary>
            [NameInMap("DataStorageUsedCapacityDetail")]
            [Validation(Required=false)]
            public string DataStorageUsedCapacityDetail { get; set; }

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
            /// <para>The details of the Logstores for normalized data.</para>
            /// </summary>
            [NameInMap("NormalizationLogStores")]
            [Validation(Required=false)]
            public List<GetDataStorageResponseBodyDataNormalizationLogStores> NormalizationLogStores { get; set; }
            public class GetDataStorageResponseBodyDataNormalizationLogStores : TeaModel {
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
                /// <para>The storage duration of normalized data.</para>
                /// 
                /// <b>Example:</b>
                /// <para>180</para>
                /// </summary>
                [NameInMap("LogStoreTtl")]
                [Validation(Required=false)]
                public int? LogStoreTtl { get; set; }

                /// <summary>
                /// <para>The hot storage capacity used.</para>
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
                /// <para>The number of times the normalized dataset is referenced in the threat analysis access center.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("DetectionRuleReferenceCount")]
                [Validation(Required=false)]
                public int? DetectionRuleReferenceCount { get; set; }

                /// <summary>
                /// <para>The list of products that reference the normalized dataset in the threat analysis access center.</para>
                /// </summary>
                [NameInMap("DetectionRuleReferenceProductIds")]
                [Validation(Required=false)]
                public List<string> DetectionRuleReferenceProductIds { get; set; }

                /// <summary>
                /// <para>The query statement used to query the log type in the normalized dataset.</para>
                /// 
                /// <b>Example:</b>
                /// <para>[{\&quot;SCHEMA\&quot;:\&quot;AZURE_ACTIVE_DIRECTORY_AUDIT_ACTIVITY\&quot;}]</para>
                /// </summary>
                [NameInMap("LogSearchConditions")]
                [Validation(Required=false)]
                public string LogSearchConditions { get; set; }

                /// <summary>
                /// <para>The Logstore where threat analysis stores normalized logs.</para>
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
                /// <item><description>true: The normalized dataset exists.</description></item>
                /// <item><description>false: The normalized dataset does not exist.</description></item>
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
            /// </summary>
            [NameInMap("RecordLogStores")]
            [Validation(Required=false)]
            public List<GetDataStorageResponseBodyDataRecordLogStores> RecordLogStores { get; set; }
            public class GetDataStorageResponseBodyDataRecordLogStores : TeaModel {
                /// <summary>
                /// <para>The Logstore name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>alert-record</para>
                /// </summary>
                [NameInMap("LogStoreName")]
                [Validation(Required=false)]
                public string LogStoreName { get; set; }

                /// <summary>
                /// <para>The time-to-live (TTL) of the Logstore.</para>
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
            /// <para>The details of raw log storage in Security Center.</para>
            /// </summary>
            [NameInMap("SasLogStores")]
            [Validation(Required=false)]
            public List<GetDataStorageResponseBodyDataSasLogStores> SasLogStores { get; set; }
            public class GetDataStorageResponseBodyDataSasLogStores : TeaModel {
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
                /// <item><description>host: host logs.</description></item>
                /// <item><description>security: security logs.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>host</para>
                /// </summary>
                [NameInMap("LogDeliveryGroup")]
                [Validation(Required=false)]
                public string LogDeliveryGroup { get; set; }

                /// <summary>
                /// <para>Indicates whether log delivery can be toggled. Log delivery cannot be enabled if the service is not purchased. Valid values:</para>
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
                /// <item><description>enable: log delivery is enabled.</description></item>
                /// <item><description>disable: log delivery is disabled.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>enable</para>
                /// </summary>
                [NameInMap("LogDeliveryStatus")]
                [Validation(Required=false)]
                public string LogDeliveryStatus { get; set; }

                /// <summary>
                /// <para>The time when the log delivery was last modified.</para>
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
                /// <para>The default log query conditions for the log. When multiple logs are stored in the same Logstore, log query conditions are required to query individual logs.</para>
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
                /// <item><description>true: The Logstore exists.</description></item>
                /// <item><description>false: The Logstore does not exist.</description></item>
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
                /// <para>The storage duration of the Logstore where the log is stored. Logs are stored for at least 30 days.</para>
                /// 
                /// <b>Example:</b>
                /// <para>180</para>
                /// </summary>
                [NameInMap("LogStoreTtl")]
                [Validation(Required=false)]
                public int? LogStoreTtl { get; set; }

                /// <summary>
                /// <para>The hot storage capacity used.</para>
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
            /// </summary>
            [NameInMap("UnusedLogStores")]
            [Validation(Required=false)]
            public List<GetDataStorageResponseBodyDataUnusedLogStores> UnusedLogStores { get; set; }
            public class GetDataStorageResponseBodyDataUnusedLogStores : TeaModel {
                /// <summary>
                /// <para>The Logstore name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cloud-siem</para>
                /// </summary>
                [NameInMap("LogStoreName")]
                [Validation(Required=false)]
                public string LogStoreName { get; set; }

                /// <summary>
                /// <para>The data storage duration.</para>
                /// 
                /// <b>Example:</b>
                /// <para>180</para>
                /// </summary>
                [NameInMap("LogStoreTtl")]
                [Validation(Required=false)]
                public int? LogStoreTtl { get; set; }

                /// <summary>
                /// <para>The hot storage capacity used.</para>
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
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>81FB0DEA-52C1-55A0-8631-8E1B9A9D****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
