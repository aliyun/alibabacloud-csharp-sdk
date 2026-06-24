// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sddp20190103.Models
{
    public class DescribeDataLimitsRequest : TeaModel {
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
        /// <para>The page number to return.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

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
        /// <para>The end of the time range to query. This value is a UNIX timestamp. Unit: milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1616068534877</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        /// <summary>
        /// <para>The type of the database engine. Examples: <b>MySQL</b>, <b>SQLServer</b>, <b>Oracle</b>, <b>PostgreSQL</b>, and <b>MongoDB</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MySQL</para>
        /// </summary>
        [NameInMap("EngineType")]
        [Validation(Required=false)]
        public string EngineType { get; set; }

        /// <summary>
        /// <para>This parameter is deprecated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("FeatureType")]
        [Validation(Required=false)]
        public int? FeatureType { get; set; }

        /// <summary>
        /// <para>The language of the content within the request and response. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>zh</b>: Chinese.</para>
        /// </description></item>
        /// <item><description><para><b>en</b>: English.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The ID of the member account.</para>
        /// 
        /// <b>Example:</b>
        /// <para>**********8103</para>
        /// </summary>
        [NameInMap("MemberAccount")]
        [Validation(Required=false)]
        public long? MemberAccount { get; set; }

        /// <summary>
        /// <para>The number of entries to return on each page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The ID of the parent asset to which the data asset belongs. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>The name or ID of a MaxCompute project.</para>
        /// </description></item>
        /// <item><description><para>The name or ID of an OSS bucket.</para>
        /// </description></item>
        /// <item><description><para>The name or ID of an RDS instance or database.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1112</para>
        /// </summary>
        [NameInMap("ParentId")]
        [Validation(Required=false)]
        public string ParentId { get; set; }

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
        /// <para>1</para>
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public int? ResourceType { get; set; }

        /// <summary>
        /// <para>The ID of the region where the data asset is located.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("ServiceRegionId")]
        [Validation(Required=false)]
        public string ServiceRegionId { get; set; }

        /// <summary>
        /// <para>The beginning of the time range to query. This value is a UNIX timestamp. Unit: milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1616068534877</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

    }

}
