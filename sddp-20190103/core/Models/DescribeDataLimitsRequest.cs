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
        /// <para>Settings the page number of the current page when you perform a paged query. For more information about paging, refer to the paging parameters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

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
        /// <para>The end of the creation time range. Format: timestamp. Unit: milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1616068534877</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

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
        /// <para>This parameter is deprecated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("FeatureType")]
        [Validation(Required=false)]
        public int? FeatureType { get; set; }

        /// <summary>
        /// <para>The language of the request and response. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>zh</b>: Chinese.</description></item>
        /// <item><description><b>en</b>: English.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The ID of the member accounts.</para>
        /// 
        /// <b>Example:</b>
        /// <para>**********8103</para>
        /// </summary>
        [NameInMap("MemberAccount")]
        [Validation(Required=false)]
        public long? MemberAccount { get; set; }

        /// <summary>
        /// <para>The maximum number of entries to return on each page when you perform a paged query. For more information about paging, refer to the paging parameters.</para>
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
        /// <item><description>The project name or ID for MaxCompute.</description></item>
        /// <item><description>The bucket name or ID for OSS.</description></item>
        /// <item><description>The instance name or ID, or the database name or ID for RDS.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1112</para>
        /// </summary>
        [NameInMap("ParentId")]
        [Validation(Required=false)]
        public string ParentId { get; set; }

        /// <summary>
        /// <para>Required. The type of the product to which the data asset belongs. Valid values:</para>
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
        /// <para>1</para>
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public int? ResourceType { get; set; }

        /// <summary>
        /// <para>The region where the asset resides.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("ServiceRegionId")]
        [Validation(Required=false)]
        public string ServiceRegionId { get; set; }

        /// <summary>
        /// <para>The start of the creation time range. Format: timestamp. Unit: milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1616068534877</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

    }

}
