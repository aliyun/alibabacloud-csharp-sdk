// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20241212.Models
{
    public class GetDataStorageResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetDataStorageResponseBodyData Data { get; set; }
        public class GetDataStorageResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>100.0</para>
            /// </summary>
            [NameInMap("ColdStorageUsedCapacity")]
            [Validation(Required=false)]
            public double? ColdStorageUsedCapacity { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>cn-shanghai</para>
            /// </summary>
            [NameInMap("DataStorageRegionId")]
            [Validation(Required=false)]
            public string DataStorageRegionId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>deny</para>
            /// </summary>
            [NameInMap("DataStorageRegionPermission")]
            [Validation(Required=false)]
            public string DataStorageRegionPermission { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("DataStorageTotalCapacity")]
            [Validation(Required=false)]
            public long? DataStorageTotalCapacity { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>100.0</para>
            /// </summary>
            [NameInMap("DataStorageUsedCapacity")]
            [Validation(Required=false)]
            public double? DataStorageUsedCapacity { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>{\&quot;purchasedHotStorageCapacity\&quot;:1000,\&quot;usedHotStorageCapacity\&quot;:4.2,\&quot;usedHotStorageCapacityDetail\&quot;:{\&quot;ap-southeast-1\&quot;:4.2,\&quot;cn-shenzhen\&quot;:0.0,\&quot;cn-shanghai\&quot;:0.0}}</para>
            /// </summary>
            [NameInMap("DataStorageUsedCapacityDetail")]
            [Validation(Required=false)]
            public string DataStorageUsedCapacityDetail { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>aliyun-cloudsiem-data-171835723111****-cn-shanghai</para>
            /// </summary>
            [NameInMap("LogProject")]
            [Validation(Required=false)]
            public string LogProject { get; set; }

            [NameInMap("NormalizationLogStores")]
            [Validation(Required=false)]
            public List<GetDataStorageResponseBodyDataNormalizationLogStores> NormalizationLogStores { get; set; }
            public class GetDataStorageResponseBodyDataNormalizationLogStores : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>vulnerability-activity</para>
                /// </summary>
                [NameInMap("LogStoreName")]
                [Validation(Required=false)]
                public string LogStoreName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>180</para>
                /// </summary>
                [NameInMap("LogStoreTtl")]
                [Validation(Required=false)]
                public int? LogStoreTtl { get; set; }

            }

            [NameInMap("NormalizationLogViews")]
            [Validation(Required=false)]
            public List<GetDataStorageResponseBodyDataNormalizationLogViews> NormalizationLogViews { get; set; }
            public class GetDataStorageResponseBodyDataNormalizationLogViews : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>API security risk log</para>
                /// </summary>
                [NameInMap("ActivityName")]
                [Validation(Required=false)]
                public string ActivityName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>Security Category</para>
                /// </summary>
                [NameInMap("CategoryName")]
                [Validation(Required=false)]
                public string CategoryName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("DetectionRuleReferenceCount")]
                [Validation(Required=false)]
                public int? DetectionRuleReferenceCount { get; set; }

                [NameInMap("DetectionRuleReferenceProductIds")]
                [Validation(Required=false)]
                public List<string> DetectionRuleReferenceProductIds { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>[{\&quot;SCHEMA\&quot;:\&quot;AZURE_ACTIVE_DIRECTORY_AUDIT_ACTIVITY\&quot;}]</para>
                /// </summary>
                [NameInMap("LogSearchConditions")]
                [Validation(Required=false)]
                public string LogSearchConditions { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>risk-activity</para>
                /// </summary>
                [NameInMap("LogStoreName")]
                [Validation(Required=false)]
                public string LogStoreName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("LogViewExisted")]
                [Validation(Required=false)]
                public bool? LogViewExisted { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>risk_activity</para>
                /// </summary>
                [NameInMap("LogViewName")]
                [Validation(Required=false)]
                public string LogViewName { get; set; }

            }

            [NameInMap("SasLogStores")]
            [Validation(Required=false)]
            public List<GetDataStorageResponseBodyDataSasLogStores> SasLogStores { get; set; }
            public class GetDataStorageResponseBodyDataSasLogStores : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>sas-net-block</para>
                /// </summary>
                [NameInMap("LogCode")]
                [Validation(Required=false)]
                public string LogCode { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>host</para>
                /// </summary>
                [NameInMap("LogDeliveryGroup")]
                [Validation(Required=false)]
                public string LogDeliveryGroup { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>deny</para>
                /// </summary>
                [NameInMap("LogDeliveryPermission")]
                [Validation(Required=false)]
                public string LogDeliveryPermission { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>enable</para>
                /// </summary>
                [NameInMap("LogDeliveryStatus")]
                [Validation(Required=false)]
                public string LogDeliveryStatus { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2025-07-16T15:10:29</para>
                /// </summary>
                [NameInMap("LogDeliveryUpdateTime")]
                [Validation(Required=false)]
                public string LogDeliveryUpdateTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>Process Snapshot</para>
                /// </summary>
                [NameInMap("LogName")]
                [Validation(Required=false)]
                public string LogName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>[{\&quot;<b>topic</b>\&quot;:\&quot;sas-net-block\&quot;}]</para>
                /// </summary>
                [NameInMap("LogSearchConditions")]
                [Validation(Required=false)]
                public string LogSearchConditions { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("LogStoreExisted")]
                [Validation(Required=false)]
                public bool? LogStoreExisted { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>sas-security-log</para>
                /// </summary>
                [NameInMap("LogStoreName")]
                [Validation(Required=false)]
                public string LogStoreName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>180</para>
                /// </summary>
                [NameInMap("LogStoreTtl")]
                [Validation(Required=false)]
                public int? LogStoreTtl { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>81FB0DEA-52C1-55A0-8631-8E1B9A9D****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
