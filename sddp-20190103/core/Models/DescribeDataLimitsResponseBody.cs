// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sddp20190103.Models
{
    public class DescribeDataLimitsResponseBody : TeaModel {
        /// <summary>
        /// <para>The page number of the returned page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <para>The data assets.</para>
        /// </summary>
        [NameInMap("Items")]
        [Validation(Required=false)]
        public List<DescribeDataLimitsResponseBodyItems> Items { get; set; }
        public class DescribeDataLimitsResponseBodyItems : TeaModel {
            /// <summary>
            /// <para>Indicates whether the security audit feature is enabled. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>1</b>: yes</description></item>
            /// <item><description><b>0</b>: no</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("AuditStatus")]
            [Validation(Required=false)]
            public int? AuditStatus { get; set; }

            /// <summary>
            /// <para>Indicates whether the data asset can be automatically scanned. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: no</description></item>
            /// <item><description><b>1</b>: yes</description></item>
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
            /// <item><description><b>0</b>: The data detection is ready.</description></item>
            /// <item><description><b>1</b>: The data detection is running.</description></item>
            /// <item><description><b>2</b>: The connectivity test is in progress.</description></item>
            /// <item><description><b>3</b>: The connectivity test is passed.</description></item>
            /// <item><description><b>4</b>: The connectivity test failed.</description></item>
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
            /// <para>Connectivity test status</para>
            /// </summary>
            [NameInMap("CheckStatusName")]
            [Validation(Required=false)]
            public string CheckStatusName { get; set; }

            /// <summary>
            /// <para>Indicates whether DSC has the data de-identification permissions on the data asset. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>1</b>: yes</description></item>
            /// <item><description><b>0</b>: no</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("DatamaskStatus")]
            [Validation(Required=false)]
            public int? DatamaskStatus { get; set; }

            /// <summary>
            /// <para>The database engine version.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2.0</para>
            /// </summary>
            [NameInMap("DbVersion")]
            [Validation(Required=false)]
            public string DbVersion { get; set; }

            /// <summary>
            /// <para>Indicates whether DSC has the data identification permissions on the data asset. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>1</b>: yes</description></item>
            /// <item><description><b>0</b>: no</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Enable")]
            [Validation(Required=false)]
            public int? Enable { get; set; }

            /// <summary>
            /// <para>The type of the database engine. Valid values include <b>MySQL</b>, <b>SQLServer</b>, <b>Oracle</b>, <b>PostgreSQL</b>, and <b>MongoDB</b>.</para>
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
            /// <para>The reason for the failure.</para>
            /// 
            /// <b>Example:</b>
            /// <para>The password is invalid.</para>
            /// </summary>
            [NameInMap("ErrorMessage")]
            [Validation(Required=false)]
            public string ErrorMessage { get; set; }

            /// <summary>
            /// <para>Indicates whether the data leak prevention feature is enabled. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: no</description></item>
            /// <item><description><b>1</b>: yes (default)</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("EventStatus")]
            [Validation(Required=false)]
            public int? EventStatus { get; set; }

            /// <summary>
            /// <para>The time when the data asset was created. The value is a UNIX timestamp. Unit: milliseconds.</para>
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
            /// <para>The ID of the data asset to which the table belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>12332</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The time when the last scan is performed.</para>
            /// <list type="bullet">
            /// <item><description>The value is a UNIX timestamp.</description></item>
            /// <item><description>Unit: milliseconds.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>145600000</para>
            /// </summary>
            [NameInMap("LastFinishedTime")]
            [Validation(Required=false)]
            public long? LastFinishedTime { get; set; }

            /// <summary>
            /// <para>The last scan start time of data assets, in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>145600000</para>
            /// </summary>
            [NameInMap("LastStartTime")]
            [Validation(Required=false)]
            public long? LastStartTime { get; set; }

            /// <summary>
            /// <para>The region in which the data asset resides.</para>
            /// 
            /// <b>Example:</b>
            /// <para>China (Hangzhou)</para>
            /// </summary>
            [NameInMap("LocalName")]
            [Validation(Required=false)]
            public string LocalName { get; set; }

            /// <summary>
            /// <para>The retention period of raw logs. Unit: days.</para>
            /// 
            /// <b>Example:</b>
            /// <para>30</para>
            /// </summary>
            [NameInMap("LogStoreDay")]
            [Validation(Required=false)]
            public int? LogStoreDay { get; set; }

            /// <summary>
            /// <para>The ID of the member.</para>
            /// 
            /// <b>Example:</b>
            /// <para>**********8103</para>
            /// </summary>
            [NameInMap("MemberAccount")]
            [Validation(Required=false)]
            public long? MemberAccount { get; set; }

            /// <summary>
            /// <para>The next time when the data asset is scanned. The value is a UNIX timestamp. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1676620236000</para>
            /// </summary>
            [NameInMap("NextStartTime")]
            [Validation(Required=false)]
            public long? NextStartTime { get; set; }

            /// <summary>
            /// <para>Indicates whether the optical character recognition (OCR) feature is enabled. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: no</description></item>
            /// <item><description><b>1</b>: yes</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("OcrStatus")]
            [Validation(Required=false)]
            public int? OcrStatus { get; set; }

            /// <summary>
            /// <para>The parent ID of the data asset that you want to query. Valid values include <b>bucket, db, and project</b>.</para>
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
            /// <para>The status of the data asset scan. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>-1</b>: invalid</description></item>
            /// <item><description><b>0</b>: waiting</description></item>
            /// <item><description><b>1</b>: being scanned</description></item>
            /// <item><description><b>2</b>: suspended</description></item>
            /// <item><description><b>3</b>: completed</description></item>
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
            /// <para>The region in which the asset resides.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>The type of the service to which the data asset belongs. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>1</b>: MaxCompute</description></item>
            /// <item><description><b>2</b>: OSS</description></item>
            /// <item><description><b>3</b>: AnalyticDB for MySQL</description></item>
            /// <item><description><b>4</b>: Tablestore</description></item>
            /// <item><description><b>5</b>: ApsaraDB RDS</description></item>
            /// <item><description><b>6</b>: self-managed database</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("ResourceType")]
            [Validation(Required=false)]
            public long? ResourceType { get; set; }

            /// <summary>
            /// <para>The code of the service to which the data asset belongs. Valid values: <b>MaxCompute, OSS, ADS, OTS, and RDS</b>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>RDS</para>
            /// </summary>
            [NameInMap("ResourceTypeCode")]
            [Validation(Required=false)]
            public string ResourceTypeCode { get; set; }

            /// <summary>
            /// <para>The number of sensitive data samples. Valid values: <b>0</b>, <b>5</b>, and <b>10</b>. Unit: data entries.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("SamplingSize")]
            [Validation(Required=false)]
            public int? SamplingSize { get; set; }

            /// <summary>
            /// <para>A list of the IDs of the security groups that are used by PrivateLink when you install the DSC agent.</para>
            /// </summary>
            [NameInMap("SecurityGroupIdList")]
            [Validation(Required=false)]
            public List<string> SecurityGroupIdList { get; set; }

            /// <summary>
            /// <para>Indicates whether the security audit feature is supported. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: yes</description></item>
            /// <item><description><b>false</b>: no</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("SupportAudit")]
            [Validation(Required=false)]
            public bool? SupportAudit { get; set; }

            /// <summary>
            /// <para>Indicates whether the data de-identification feature is supported. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: yes</description></item>
            /// <item><description><b>false</b>: no</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("SupportDatamask")]
            [Validation(Required=false)]
            public bool? SupportDatamask { get; set; }

            /// <summary>
            /// <para>Indicates whether anomalous event detection is supported. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b></description></item>
            /// <item><description><b>false</b></description></item>
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
            /// <item><description><b>true</b>: yes</description></item>
            /// <item><description><b>false</b>: no</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("SupportOcr")]
            [Validation(Required=false)]
            public bool? SupportOcr { get; set; }

            /// <summary>
            /// <para>Indicates whether the data asset scan feature is supported. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: yes</description></item>
            /// <item><description><b>false</b>: no</description></item>
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
            /// <para>The total number of fields in the table.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

            /// <summary>
            /// <para>The username that is used to access the data asset.</para>
            /// 
            /// <b>Example:</b>
            /// <para>tsts</para>
            /// </summary>
            [NameInMap("UserName")]
            [Validation(Required=false)]
            public string UserName { get; set; }

            /// <summary>
            /// <para>A list of the IDs of the vSwitches that are used by PrivateLink when you install the DSC agent.</para>
            /// </summary>
            [NameInMap("VSwitchIdList")]
            [Validation(Required=false)]
            public List<string> VSwitchIdList { get; set; }

            /// <summary>
            /// <para>The ID of the virtual private cloud (VPC) to which the data asset belongs.</para>
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
