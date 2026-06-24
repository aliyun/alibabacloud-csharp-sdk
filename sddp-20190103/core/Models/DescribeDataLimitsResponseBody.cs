// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sddp20190103.Models
{
    public class DescribeDataLimitsResponseBody : TeaModel {
        /// <summary>
        /// <para>The number of the returned page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <para>A list of data assets.</para>
        /// </summary>
        [NameInMap("Items")]
        [Validation(Required=false)]
        public List<DescribeDataLimitsResponseBodyItems> Items { get; set; }
        public class DescribeDataLimitsResponseBodyItems : TeaModel {
            /// <summary>
            /// <para>The audit status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>1</b>: Auditing enabled.</para>
            /// </description></item>
            /// <item><description><para><b>0</b>: Auditing disabled.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("AuditStatus")]
            [Validation(Required=false)]
            public int? AuditStatus { get; set; }

            /// <summary>
            /// <para>Indicates whether automatic scanning is enabled. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>0</b>: No.</para>
            /// </description></item>
            /// <item><description><para><b>1</b>: Yes.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("AutoScan")]
            [Validation(Required=false)]
            public int? AutoScan { get; set; }

            /// <summary>
            /// <para>The connectivity test status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>0</b>: Ready.</para>
            /// </description></item>
            /// <item><description><para><b>1</b>: Running.</para>
            /// </description></item>
            /// <item><description><para><b>2</b>: Connectivity test in progress.</para>
            /// </description></item>
            /// <item><description><para><b>3</b>: Connectivity test passed.</para>
            /// </description></item>
            /// <item><description><para><b>4</b>: Connectivity test failed.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("CheckStatus")]
            [Validation(Required=false)]
            public int? CheckStatus { get; set; }

            /// <summary>
            /// <para>The name of the connectivity test status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Connectivity detection status</para>
            /// </summary>
            [NameInMap("CheckStatusName")]
            [Validation(Required=false)]
            public string CheckStatusName { get; set; }

            /// <summary>
            /// <para>The data masking status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>1</b>: Enabled.</para>
            /// </description></item>
            /// <item><description><para><b>0</b>: Disabled.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("DatamaskStatus")]
            [Validation(Required=false)]
            public int? DatamaskStatus { get; set; }

            /// <summary>
            /// <para>The database version.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2.0</para>
            /// </summary>
            [NameInMap("DbVersion")]
            [Validation(Required=false)]
            public string DbVersion { get; set; }

            /// <summary>
            /// <para>The sensitive data detection status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>1</b>: Enabled.</para>
            /// </description></item>
            /// <item><description><para><b>0</b>: Disabled.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Enable")]
            [Validation(Required=false)]
            public int? Enable { get; set; }

            /// <summary>
            /// <para>The database engine type. Examples: <b>MySQL</b>, <b>SQLServer</b>, <b>Oracle</b>, <b>PostgreSQL</b>, and <b>MongoDB</b>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>MySQL</para>
            /// </summary>
            [NameInMap("EngineType")]
            [Validation(Required=false)]
            public string EngineType { get; set; }

            /// <summary>
            /// <para>The error code that is returned if the connectivity test fails.</para>
            /// 
            /// <b>Example:</b>
            /// <para>connect_network_error</para>
            /// </summary>
            [NameInMap("ErrorCode")]
            [Validation(Required=false)]
            public string ErrorCode { get; set; }

            /// <summary>
            /// <para>The error message that is returned if the connectivity test fails.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Incorrect password.</para>
            /// </summary>
            [NameInMap("ErrorMessage")]
            [Validation(Required=false)]
            public string ErrorMessage { get; set; }

            /// <summary>
            /// <para>The anomaly detection status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>0</b>: Disabled.</para>
            /// </description></item>
            /// <item><description><para><b>1</b>: Enabled (default).</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("EventStatus")]
            [Validation(Required=false)]
            public int? EventStatus { get; set; }

            /// <summary>
            /// <para>The time when the data asset was created. This value is a UNIX timestamp. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>145600000</para>
            /// </summary>
            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public long? GmtCreate { get; set; }

            /// <summary>
            /// <para>The unique ID of the data asset.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <para>The description of the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123</para>
            /// </summary>
            [NameInMap("InstanceDescription")]
            [Validation(Required=false)]
            public string InstanceDescription { get; set; }

            /// <summary>
            /// <para>The ID of the instance to which the data asset belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>12332</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The time when the last full scan was complete. This value is a UNIX timestamp in milliseconds.</para>
            /// <list type="bullet">
            /// <item><description><para>Format: UNIX timestamp</para>
            /// </description></item>
            /// <item><description><para>Unit: milliseconds</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>145600000</para>
            /// </summary>
            [NameInMap("LastFinishedTime")]
            [Validation(Required=false)]
            public long? LastFinishedTime { get; set; }

            /// <summary>
            /// <para>The time when the last scan started. This value is a UNIX timestamp in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>145600000</para>
            /// </summary>
            [NameInMap("LastStartTime")]
            [Validation(Required=false)]
            public long? LastStartTime { get; set; }

            /// <summary>
            /// <para>The name of the region in which the data asset is located.</para>
            /// 
            /// <b>Example:</b>
            /// <para>China (Hangzhou)</para>
            /// </summary>
            [NameInMap("LocalName")]
            [Validation(Required=false)]
            public string LocalName { get; set; }

            /// <summary>
            /// <para>The retention period of raw logs, in days.</para>
            /// 
            /// <b>Example:</b>
            /// <para>30</para>
            /// </summary>
            [NameInMap("LogStoreDay")]
            [Validation(Required=false)]
            public int? LogStoreDay { get; set; }

            /// <summary>
            /// <para>The ID of the member account to which the data asset belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>**********8103</para>
            /// </summary>
            [NameInMap("MemberAccount")]
            [Validation(Required=false)]
            public long? MemberAccount { get; set; }

            /// <summary>
            /// <para>The time when the next scan is scheduled to start. This value is a UNIX timestamp. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1676620236000</para>
            /// </summary>
            [NameInMap("NextStartTime")]
            [Validation(Required=false)]
            public long? NextStartTime { get; set; }

            /// <summary>
            /// <para>The status of Optical Character Recognition (OCR). Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>0</b>: Disabled.</para>
            /// </description></item>
            /// <item><description><para><b>1</b>: Enabled.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("OcrStatus")]
            [Validation(Required=false)]
            public int? OcrStatus { get; set; }

            /// <summary>
            /// <para>The ID of the parent asset, such as a bucket, DB, or <b>project</b>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>project</para>
            /// </summary>
            [NameInMap("ParentId")]
            [Validation(Required=false)]
            public string ParentId { get; set; }

            /// <summary>
            /// <para>The port number of the self-managed database.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3306</para>
            /// </summary>
            [NameInMap("Port")]
            [Validation(Required=false)]
            public int? Port { get; set; }

            /// <summary>
            /// <para>The status of the scan task. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>-1</b>: Invalid.</para>
            /// </description></item>
            /// <item><description><para><b>0</b>: Pending.</para>
            /// </description></item>
            /// <item><description><para><b>1</b>: Scanning.</para>
            /// </description></item>
            /// <item><description><para><b>2</b>: Paused.</para>
            /// </description></item>
            /// <item><description><para><b>3</b>: Completed.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("ProcessStatus")]
            [Validation(Required=false)]
            public int? ProcessStatus { get; set; }

            /// <summary>
            /// <para>The total number of data tables or files.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("ProcessTotalCount")]
            [Validation(Required=false)]
            public int? ProcessTotalCount { get; set; }

            /// <summary>
            /// <para>The ID of the region in which the data asset is located.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>The type of service to which the data asset belongs. Data assets can be instances, databases, or buckets. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>1</b>: MaxCompute</para>
            /// </description></item>
            /// <item><description><para><b>2</b>: OSS</para>
            /// </description></item>
            /// <item><description><para><b>3</b>: AnalyticDB for MySQL</para>
            /// </description></item>
            /// <item><description><para><b>4</b>: Tablestore</para>
            /// </description></item>
            /// <item><description><para><b>5</b>: RDS</para>
            /// </description></item>
            /// <item><description><para><b>6</b>: A self-managed database</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("ResourceType")]
            [Validation(Required=false)]
            public long? ResourceType { get; set; }

            /// <summary>
            /// <para>The code of the service to which the data asset belongs. Examples: MaxCompute, OSS, ADS, OTS, and <b>RDS</b>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>RDS</para>
            /// </summary>
            [NameInMap("ResourceTypeCode")]
            [Validation(Required=false)]
            public string ResourceTypeCode { get; set; }

            /// <summary>
            /// <para>The number of sensitive data samples. Valid values: <b>0</b>, <b>5</b>, and <b>10</b>. Unit: entries.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("SamplingSize")]
            [Validation(Required=false)]
            public int? SamplingSize { get; set; }

            /// <summary>
            /// <para>A list of security group IDs that are used by PrivateLink for agent-based auditing.</para>
            /// </summary>
            [NameInMap("SecurityGroupIdList")]
            [Validation(Required=false)]
            public List<string> SecurityGroupIdList { get; set; }

            /// <summary>
            /// <para>Indicates whether auditing is supported. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>true</b>: Yes.</para>
            /// </description></item>
            /// <item><description><para><b>false</b>: No.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("SupportAudit")]
            [Validation(Required=false)]
            public bool? SupportAudit { get; set; }

            /// <summary>
            /// <para>Indicates whether data masking is supported. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>true</b>: Yes.</para>
            /// </description></item>
            /// <item><description><para><b>false</b>: No.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("SupportDatamask")]
            [Validation(Required=false)]
            public bool? SupportDatamask { get; set; }

            /// <summary>
            /// <para>Indicates whether anomaly detection is supported. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>true</b>: Yes.</para>
            /// </description></item>
            /// <item><description><para><b>false</b>: No.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("SupportEvent")]
            [Validation(Required=false)]
            public bool? SupportEvent { get; set; }

            /// <summary>
            /// <para>Indicates whether OCR is supported. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>true</b>: Yes.</para>
            /// </description></item>
            /// <item><description><para><b>false</b>: No.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("SupportOcr")]
            [Validation(Required=false)]
            public bool? SupportOcr { get; set; }

            /// <summary>
            /// <para>Indicates whether sensitive data detection is supported. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>true</b>: Yes.</para>
            /// </description></item>
            /// <item><description><para><b>false</b>: No.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("SupportScan")]
            [Validation(Required=false)]
            public bool? SupportScan { get; set; }

            /// <summary>
            /// <para>The alias of the tenant.</para>
            /// 
            /// <b>Example:</b>
            /// <para>insta_gram</para>
            /// </summary>
            [NameInMap("TenantName")]
            [Validation(Required=false)]
            public string TenantName { get; set; }

            /// <summary>
            /// <para>The total number of fields. This parameter is returned only when the data asset is a table.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

            /// <summary>
            /// <para>The username of the data asset owner.</para>
            /// 
            /// <b>Example:</b>
            /// <para>tsts</para>
            /// </summary>
            [NameInMap("UserName")]
            [Validation(Required=false)]
            public string UserName { get; set; }

            /// <summary>
            /// <para>A list of vSwitch IDs that are used by PrivateLink for agent-based auditing.</para>
            /// </summary>
            [NameInMap("VSwitchIdList")]
            [Validation(Required=false)]
            public List<string> VSwitchIdList { get; set; }

            /// <summary>
            /// <para>The ID of the virtual private cloud (VPC) in which the data asset resides.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vpc-2zevcqke6hh09c41****</para>
            /// </summary>
            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

        }

        /// <summary>
        /// <para>The number of entries returned per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>769FB3C1-F4C9-42DF-9B72-7077A8989***</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
