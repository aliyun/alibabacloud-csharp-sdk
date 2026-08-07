// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sddp20190103.Models
{
    public class DescribeDataLimitsResponseBody : TeaModel {
        /// <summary>
        /// <para>The page number of the current page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <para>The list of data assets.</para>
        /// </summary>
        [NameInMap("Items")]
        [Validation(Required=false)]
        public List<DescribeDataLimitsResponseBodyItems> Items { get; set; }
        public class DescribeDataLimitsResponseBodyItems : TeaModel {
            /// <summary>
            /// <para>The audit status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>1</b>: audit enabled.</description></item>
            /// <item><description><b>0</b>: audit disabled.</description></item>
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
            /// <item><description><b>0</b>: disabled.</description></item>
            /// <item><description><b>1</b>: enabled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("AutoScan")]
            [Validation(Required=false)]
            public int? AutoScan { get; set; }

            /// <summary>
            /// <para>The data detection status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: ready.</description></item>
            /// <item><description><b>1</b>: running.</description></item>
            /// <item><description><b>2</b>: connectivity test in progress.</description></item>
            /// <item><description><b>3</b>: connectivity test passed.</description></item>
            /// <item><description><b>4</b>: connectivity test failed.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("CheckStatus")]
            [Validation(Required=false)]
            public int? CheckStatus { get; set; }

            /// <summary>
            /// <para>The name of the data detection status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Connectivity detection status</para>
            /// </summary>
            [NameInMap("CheckStatusName")]
            [Validation(Required=false)]
            public string CheckStatusName { get; set; }

            /// <summary>
            /// <para>The data masking permission status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>1</b>: enabled.</description></item>
            /// <item><description><b>0</b>: disabled.</description></item>
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
            /// <para>The detection permission status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>1</b>: enabled.</description></item>
            /// <item><description><b>0</b>: disabled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Enable")]
            [Validation(Required=false)]
            public int? Enable { get; set; }

            /// <summary>
            /// <para>The database type. Valid values: <b>MySQL</b>, <b>SQLServer</b>, <b>Oracle</b>, <b>PostgreSQL</b>, <b>MongoDB</b>, and others.</para>
            /// 
            /// <b>Example:</b>
            /// <para>MySQL</para>
            /// </summary>
            [NameInMap("EngineType")]
            [Validation(Required=false)]
            public string EngineType { get; set; }

            /// <summary>
            /// <para>The error code.</para>
            /// 
            /// <b>Example:</b>
            /// <para>connect_network_error</para>
            /// </summary>
            [NameInMap("ErrorCode")]
            [Validation(Required=false)]
            public string ErrorCode { get; set; }

            /// <summary>
            /// <para>The failure reason.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Incorrect password.</para>
            /// </summary>
            [NameInMap("ErrorMessage")]
            [Validation(Required=false)]
            public string ErrorMessage { get; set; }

            /// <summary>
            /// <para>The data leak prevention switch. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: disabled.</description></item>
            /// <item><description><b>1</b>: enabled (default).</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("EventStatus")]
            [Validation(Required=false)]
            public int? EventStatus { get; set; }

            /// <summary>
            /// <para>The creation time. Format: timestamp. Unit: milliseconds.</para>
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
            /// <para>The instance ID of the asset to which the data asset table belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>12332</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The time when the last full scan was completed.</para>
            /// <list type="bullet">
            /// <item><description>Format: timestamp</description></item>
            /// <item><description>Unit: milliseconds</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>145600000</para>
            /// </summary>
            [NameInMap("LastFinishedTime")]
            [Validation(Required=false)]
            public long? LastFinishedTime { get; set; }

            /// <summary>
            /// <para>The time when the last scan of the data asset started. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>145600000</para>
            /// </summary>
            [NameInMap("LastStartTime")]
            [Validation(Required=false)]
            public long? LastStartTime { get; set; }

            /// <summary>
            /// <para>The name of the region where the data resides.</para>
            /// 
            /// <b>Example:</b>
            /// <para>China (Hangzhou)</para>
            /// </summary>
            [NameInMap("LocalName")]
            [Validation(Required=false)]
            public string LocalName { get; set; }

            /// <summary>
            /// <para>The raw log storage duration. Unit: days.</para>
            /// 
            /// <b>Example:</b>
            /// <para>30</para>
            /// </summary>
            [NameInMap("LogStoreDay")]
            [Validation(Required=false)]
            public int? LogStoreDay { get; set; }

            /// <summary>
            /// <para>The member accounts ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>**********8103</para>
            /// </summary>
            [NameInMap("MemberAccount")]
            [Validation(Required=false)]
            public long? MemberAccount { get; set; }

            /// <summary>
            /// <para>The next execution time. Format: timestamp. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1676620236000</para>
            /// </summary>
            [NameInMap("NextStartTime")]
            [Validation(Required=false)]
            public long? NextStartTime { get; set; }

            /// <summary>
            /// <para>The OCR status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: disabled.</description></item>
            /// <item><description><b>1</b>: enabled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("OcrStatus")]
            [Validation(Required=false)]
            public int? OcrStatus { get; set; }

            /// <summary>
            /// <para>The parent ID of the asset to query. Valid values: <b>bucket</b>, <b>db</b>, <b>project</b>, and others.</para>
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
            /// <para>The scan status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>-1</b>: invalid.</description></item>
            /// <item><description><b>0</b>: waiting.</description></item>
            /// <item><description><b>1</b>: scanning.</description></item>
            /// <item><description><b>2</b>: paused.</description></item>
            /// <item><description><b>3</b>: completed.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("ProcessStatus")]
            [Validation(Required=false)]
            public int? ProcessStatus { get; set; }

            /// <summary>
            /// <para>The total number of tables or files.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("ProcessTotalCount")]
            [Validation(Required=false)]
            public int? ProcessTotalCount { get; set; }

            /// <summary>
            /// <para>The region where the asset resides.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>The type of the product to which the data asset belongs. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>1</b>: MaxCompute</description></item>
            /// <item><description><b>2</b>: OSS</description></item>
            /// <item><description><b>3</b>: ADS</description></item>
            /// <item><description><b>4</b>: OTS</description></item>
            /// <item><description><b>5</b>: RDS</description></item>
            /// <item><description><b>6</b>: SELF_DB</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("ResourceType")]
            [Validation(Required=false)]
            public long? ResourceType { get; set; }

            /// <summary>
            /// <para>The product type code of the data source. Valid values: <b>MaxCompute</b>, <b>OSS</b>, <b>ADS</b>, <b>OTS</b>, <b>RDS</b>, and others.</para>
            /// 
            /// <b>Example:</b>
            /// <para>RDS</para>
            /// </summary>
            [NameInMap("ResourceTypeCode")]
            [Validation(Required=false)]
            public string ResourceTypeCode { get; set; }

            /// <summary>
            /// <para>The sensitive data sampling size. Valid values: <b>0</b>, <b>5</b>, and <b>10</b>. Unit: entries.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("SamplingSize")]
            [Validation(Required=false)]
            public int? SamplingSize { get; set; }

            /// <summary>
            /// <para>The list of security group IDs used by PrivateLink in agent-based auditing.</para>
            /// </summary>
            [NameInMap("SecurityGroupIdList")]
            [Validation(Required=false)]
            public List<string> SecurityGroupIdList { get; set; }

            /// <summary>
            /// <para>Indicates whether auditing is supported. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: Supported.</description></item>
            /// <item><description><b>false</b>: Not supported.</description></item>
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
            /// <item><description><b>true</b>: Supported.</description></item>
            /// <item><description><b>false</b>: Not supported.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("SupportDatamask")]
            [Validation(Required=false)]
            public bool? SupportDatamask { get; set; }

            /// <summary>
            /// <para>Indicates whether anomalous activity detection is supported. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: Supported.</description></item>
            /// <item><description><b>false</b>: Not supported.</description></item>
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
            /// <item><description><b>true</b>: Supported.</description></item>
            /// <item><description><b>false</b>: Not supported.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("SupportOcr")]
            [Validation(Required=false)]
            public bool? SupportOcr { get; set; }

            /// <summary>
            /// <para>Indicates whether scanning is supported. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: Supported.</description></item>
            /// <item><description><b>false</b>: Not supported.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("SupportScan")]
            [Validation(Required=false)]
            public bool? SupportScan { get; set; }

            /// <summary>
            /// <para>The tenant alias.</para>
            /// 
            /// <b>Example:</b>
            /// <para>insta_gram</para>
            /// </summary>
            [NameInMap("TenantName")]
            [Validation(Required=false)]
            public string TenantName { get; set; }

            /// <summary>
            /// <para>The total number of fields in the data asset table.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

            /// <summary>
            /// <para>The username of the data owner.</para>
            /// 
            /// <b>Example:</b>
            /// <para>tsts</para>
            /// </summary>
            [NameInMap("UserName")]
            [Validation(Required=false)]
            public string UserName { get; set; }

            /// <summary>
            /// <para>The list of vSwitch IDs used by PrivateLink in agent-based auditing.</para>
            /// </summary>
            [NameInMap("VSwitchIdList")]
            [Validation(Required=false)]
            public List<string> VSwitchIdList { get; set; }

            /// <summary>
            /// <para>The VPC ID to which the data asset belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vpc-2zevcqke6hh09c41****</para>
            /// </summary>
            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

        }

        /// <summary>
        /// <para>The maximum number of entries returned per page.</para>
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
        /// <para>769FB3C1-F4C9-42DF-9B72-7077A8989***</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
