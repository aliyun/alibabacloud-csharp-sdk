// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20241212.Models
{
    public class ListDataConnectorsResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of collectors.</para>
        /// </summary>
        [NameInMap("DataConnector")]
        [Validation(Required=false)]
        public List<ListDataConnectorsResponseBodyDataConnector> DataConnector { get; set; }
        public class ListDataConnectorsResponseBodyDataConnector : TeaModel {
            /// <summary>
            /// <para>The configuration item ID of the collector access object in the multi-cloud configuration.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-smbc-prod-cloudtrail.s3.cn-north-1.amazonaws.com.cn_AKIAX4AUG6AYSJO7FAG4</para>
            /// </summary>
            [NameInMap("AuthConfigId")]
            [Validation(Required=false)]
            public string AuthConfigId { get; set; }

            /// <summary>
            /// <para>The cloud product of the authentication configuration.</para>
            /// 
            /// <b>Example:</b>
            /// <para>salesForceRestAPI</para>
            /// </summary>
            [NameInMap("AuthConfigProduct")]
            [Validation(Required=false)]
            public string AuthConfigProduct { get; set; }

            /// <summary>
            /// <para>The cloud vendor of the authentication configuration.</para>
            /// 
            /// <b>Example:</b>
            /// <para>SALESFORCE</para>
            /// </summary>
            [NameInMap("AuthConfigVendor")]
            [Validation(Required=false)]
            public string AuthConfigVendor { get; set; }

            /// <summary>
            /// <para>The creation time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-06-01T02:14:24Z</para>
            /// </summary>
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public long? CreationTime { get; set; }

            /// <summary>
            /// <para>The collector configuration information.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{\&quot;endpoint\&quot;:\&quot;csrm-sentinel.s3.cn-north-1.amazonaws.com.cn_AKIARGUYUGSX6A6VUXQJ\&quot;,\&quot;bucket\&quot;:\&quot;csrm-sentinel\&quot;,\&quot;prefix\&quot;:\&quot;AliTest/\&quot;,\&quot;format\&quot;:{\&quot;type\&quot;:\&quot;JSON\&quot;},\&quot;encoding\&quot;:\&quot;UTF-8\&quot;}</para>
            /// </summary>
            [NameInMap("DataConnectorConfig")]
            [Validation(Required=false)]
            public string DataConnectorConfig { get; set; }

            /// <summary>
            /// <para>The collector ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>dc-07423146117d77db266f78bc41f4fd80</para>
            /// </summary>
            [NameInMap("DataConnectorId")]
            [Validation(Required=false)]
            public string DataConnectorId { get; set; }

            /// <summary>
            /// <para>The data connector name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>dc-***</para>
            /// </summary>
            [NameInMap("DataConnectorName")]
            [Validation(Required=false)]
            public string DataConnectorName { get; set; }

            /// <summary>
            /// <para>The connector status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>enable</para>
            /// </summary>
            [NameInMap("DataConnectorStatus")]
            [Validation(Required=false)]
            public string DataConnectorStatus { get; set; }

            /// <summary>
            /// <para>The connector type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>oss</para>
            /// </summary>
            [NameInMap("DataConnectorType")]
            [Validation(Required=false)]
            public string DataConnectorType { get; set; }

            /// <summary>
            /// <para>The destination data source ID. This parameter is required only for synchronization.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ds-t3ywipile7gctobaunx0</para>
            /// </summary>
            [NameInMap("DestDataSourceId")]
            [Validation(Required=false)]
            public string DestDataSourceId { get; set; }

            /// <summary>
            /// <para>The Simple Log Service project name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>aliyun-cloudsiem-channel-1371069058301795-cn-shanghai</para>
            /// </summary>
            [NameInMap("LogProjectName")]
            [Validation(Required=false)]
            public string LogProjectName { get; set; }

            /// <summary>
            /// <para>The log storage region ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("LogRegionId")]
            [Validation(Required=false)]
            public string LogRegionId { get; set; }

            /// <summary>
            /// <para>The Simple Log Service Logstore name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ls-wecom-crontasklog-prod</para>
            /// </summary>
            [NameInMap("LogStoreName")]
            [Validation(Required=false)]
            public string LogStoreName { get; set; }

            /// <summary>
            /// <para>The name of the SLS data import job associated with the collector.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1a2b3c4d5e6f7a8b9c0d1e2f3a4b****</para>
            /// </summary>
            [NameInMap("SlsIngestionJobName")]
            [Validation(Required=false)]
            public string SlsIngestionJobName { get; set; }

            /// <summary>
            /// <para>The status of the SLS data import job associated with the collector.</para>
            /// 
            /// <b>Example:</b>
            /// <para>running</para>
            /// </summary>
            [NameInMap("SlsIngestionJobState")]
            [Validation(Required=false)]
            public string SlsIngestionJobState { get; set; }

            /// <summary>
            /// <para>The source data type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>s3</para>
            /// </summary>
            [NameInMap("SrcDataType")]
            [Validation(Required=false)]
            public string SrcDataType { get; set; }

            /// <summary>
            /// <para>The update time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-01-04 22:31:54</para>
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public long? UpdateTime { get; set; }

        }

        /// <summary>
        /// <para>The maximum number of records returned in this request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The token for the next query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AAAAASLVeIxed4466E0LVmGkzwS6hJKd9DGVGMDRM6Lu****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The current page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of records per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6276D891-*****-55B2-87B9-74D413F7****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of records.</para>
        /// 
        /// <b>Example:</b>
        /// <para>57</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
