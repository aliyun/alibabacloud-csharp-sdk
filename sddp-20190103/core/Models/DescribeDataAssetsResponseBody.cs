// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sddp20190103.Models
{
    public class DescribeDataAssetsResponseBody : TeaModel {
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
        /// <para>An array of data assets.</para>
        /// </summary>
        [NameInMap("Items")]
        [Validation(Required=false)]
        public List<DescribeDataAssetsResponseBodyItems> Items { get; set; }
        public class DescribeDataAssetsResponseBodyItems : TeaModel {
            /// <summary>
            /// <para>The access control list (ACL) of the OSS bucket.</para>
            /// <remarks>
            /// <para>This parameter is returned only when <b>RangeId</b> is <b>21&#x20;</b>(OSS buckets).</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>private</para>
            /// </summary>
            [NameInMap("Acl")]
            [Validation(Required=false)]
            public string Acl { get; set; }

            /// <summary>
            /// <para>The time when the data asset was created. The value is a UNIX timestamp in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1536751124000</para>
            /// </summary>
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public long? CreationTime { get; set; }

            /// <summary>
            /// <para>The type of the data asset.</para>
            /// 
            /// <b>Example:</b>
            /// <para>OSS_BUCKET</para>
            /// </summary>
            [NameInMap("DataType")]
            [Validation(Required=false)]
            public string DataType { get; set; }

            /// <summary>
            /// <para>The ID of the data asset.</para>
            /// 
            /// <b>Example:</b>
            /// <para>268</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <para>The sensitivity level of the data. This is a static field and is returned only when <b>RangeId</b> is <b>1</b> (MaxCompute projects).</para>
            /// <list type="bullet">
            /// <item><description><para><b>0</b>: Unclassified</para>
            /// </description></item>
            /// <item><description><para><b>1</b>: Confidential</para>
            /// </description></item>
            /// <item><description><para><b>2</b>: Sensitive</para>
            /// </description></item>
            /// <item><description><para><b>3</b>: Highly sensitive</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Labelsec")]
            [Validation(Required=false)]
            public bool? Labelsec { get; set; }

            /// <summary>
            /// <para>The name of the data asset.</para>
            /// 
            /// <b>Example:</b>
            /// <para>gxdata</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The key of the OSS object.</para>
            /// <remarks>
            /// <para>This parameter is returned only when <b>RangeId</b> is <b>22</b> (OSS objects).</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>test.txt</para>
            /// </summary>
            [NameInMap("ObjectKey")]
            [Validation(Required=false)]
            public string ObjectKey { get; set; }

            /// <summary>
            /// <para>The name of the risk level for the MaxCompute data asset. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>S1</b>: Low</para>
            /// </description></item>
            /// <item><description><para><b>S2</b>: Medium</para>
            /// </description></item>
            /// <item><description><para><b>S3</b>: High</para>
            /// </description></item>
            /// <item><description><para><b>S4</b>: Highest</para>
            /// </description></item>
            /// </list>
            /// <remarks>
            /// <para>This parameter is returned only when \<c>RangeId\\</c> is \<c>1\\</c> (MaxCompute projects).</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>S4</para>
            /// </summary>
            [NameInMap("OdpsRiskLevelName")]
            [Validation(Required=false)]
            public string OdpsRiskLevelName { get; set; }

            /// <summary>
            /// <para>The owner of the data asset.</para>
            /// 
            /// <b>Example:</b>
            /// <para>dtdep-239-******</para>
            /// </summary>
            [NameInMap("Owner")]
            [Validation(Required=false)]
            public string Owner { get; set; }

            /// <summary>
            /// <para>The code of the service to which the data asset belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>RDS</para>
            /// </summary>
            [NameInMap("ProductCode")]
            [Validation(Required=false)]
            public string ProductCode { get; set; }

            /// <summary>
            /// <para>The ID of the service to which the data asset belongs. Valid values:</para>
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
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("ProductId")]
            [Validation(Required=false)]
            public string ProductId { get; set; }

            /// <summary>
            /// <para>Indicates whether data protection is enabled. This is a static field and is returned only when <b>RangeId</b> is <b>1</b> (MaxCompute projects).</para>
            /// <list type="bullet">
            /// <item><description><para><b>false</b>: Data protection is disabled.</para>
            /// </description></item>
            /// <item><description><para><b>true</b>: Data protection is enabled. Data can only flow into the project, not out of it.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("Protection")]
            [Validation(Required=false)]
            public bool? Protection { get; set; }

            /// <summary>
            /// <para>The ID of the risk level. A larger value indicates a higher risk level. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>1</b>: No sensitive data detected</para>
            /// </description></item>
            /// <item><description><para><b>2</b>: Level 1</para>
            /// </description></item>
            /// <item><description><para><b>3</b>: Level 2</para>
            /// </description></item>
            /// <item><description><para><b>4</b>: Level 3</para>
            /// </description></item>
            /// <item><description><para><b>5</b>: Level 4</para>
            /// </description></item>
            /// <item><description><para><b>6</b>: Level 5</para>
            /// </description></item>
            /// <item><description><para><b>7</b>: Level 6</para>
            /// </description></item>
            /// <item><description><para><b>8</b>: Level 7</para>
            /// </description></item>
            /// <item><description><para><b>9</b>: Level 8</para>
            /// </description></item>
            /// <item><description><para><b>10</b>: Level 9</para>
            /// </description></item>
            /// <item><description><para><b>11</b>: Level 10</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("RiskLevelId")]
            [Validation(Required=false)]
            public long? RiskLevelId { get; set; }

            /// <summary>
            /// <para>The name of the risk level.</para>
            /// 
            /// <b>Example:</b>
            /// <para>High risk</para>
            /// </summary>
            [NameInMap("RiskLevelName")]
            [Validation(Required=false)]
            public string RiskLevelName { get; set; }

            /// <summary>
            /// <para>The name of the sensitive data detection rule that the data asset matches.</para>
            /// 
            /// <b>Example:</b>
            /// <para>***Rule</para>
            /// </summary>
            [NameInMap("RuleName")]
            [Validation(Required=false)]
            public string RuleName { get; set; }

            /// <summary>
            /// <para>Indicates whether the data asset contains sensitive data. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>true</b>: Yes</para>
            /// </description></item>
            /// <item><description><para><b>false</b>: No</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Sensitive")]
            [Validation(Required=false)]
            public bool? Sensitive { get; set; }

            /// <summary>
            /// <para>The total number of sensitive items in the data asset. For example, the total number of sensitive projects, packages, or tables in MaxCompute, the total number of sensitive databases or tables in RDS, or the total number of sensitive buckets or objects in OSS.</para>
            /// 
            /// <b>Example:</b>
            /// <para>24</para>
            /// </summary>
            [NameInMap("SensitiveCount")]
            [Validation(Required=false)]
            public int? SensitiveCount { get; set; }

            /// <summary>
            /// <para>The percentage of sensitive data in the data asset.</para>
            /// 
            /// <b>Example:</b>
            /// <para>45%</para>
            /// </summary>
            [NameInMap("SensitiveRatio")]
            [Validation(Required=false)]
            public string SensitiveRatio { get; set; }

            /// <summary>
            /// <para>The total number of items in the data asset. For example, the total number of projects, packages, or tables in MaxCompute, the total number of databases or tables in RDS, or the total number of buckets or objects in OSS.</para>
            /// 
            /// <b>Example:</b>
            /// <para>432</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The number of entries returned on each page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>71064826-726F-4ADA-B879-05D8055476FB</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of data assets that contain sensitive data.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
