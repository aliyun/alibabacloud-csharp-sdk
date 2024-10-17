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
        /// <para>An array that consists of data assets.</para>
        /// </summary>
        [NameInMap("Items")]
        [Validation(Required=false)]
        public List<DescribeDataAssetsResponseBodyItems> Items { get; set; }
        public class DescribeDataAssetsResponseBodyItems : TeaModel {
            /// <summary>
            /// <para>The access control list (ACL) that controls the access permissions on the OSS bucket.</para>
            /// <remarks>
            /// <para>This parameter is returned only when you set the parameter <b>RangeId</b> to <b>21</b>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>private</para>
            /// </summary>
            [NameInMap("Acl")]
            [Validation(Required=false)]
            public string Acl { get; set; }

            /// <summary>
            /// <para>The time when the data asset was created. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1536751124000</para>
            /// </summary>
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public long? CreationTime { get; set; }

            /// <summary>
            /// <para>The data type of the data asset.</para>
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
            /// <para>The sensitivity tag of the data. The value is fixed as <b>0</b>. <b>0</b>, <b>1</b>, <b>2</b>, or <b>3</b> is returned for this parameter only when you set the parameter <b>RangeId</b> to <b>1</b>.</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: unclassified</description></item>
            /// <item><description><b>1</b>: confidential</description></item>
            /// <item><description><b>2</b>: sensitive</description></item>
            /// <item><description><b>3</b>: highly sensitive</description></item>
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
            /// <para>The key value of the OSS object.</para>
            /// <remarks>
            /// <para>This parameter is returned only when you set the parameter <b>RangeId</b> to <b>22</b>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>Internal</para>
            /// </summary>
            [NameInMap("ObjectKey")]
            [Validation(Required=false)]
            public string ObjectKey { get; set; }

            /// <summary>
            /// <para>The sensitivity level of the MaxCompute data asset. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>S1</b>: low sensitivity level</description></item>
            /// <item><description><b>S2</b>: medium sensitivity level</description></item>
            /// <item><description><b>S3</b>: high sensitivity level</description></item>
            /// <item><description><b>S4</b>: highest sensitivity level</description></item>
            /// </list>
            /// <remarks>
            /// <para>This parameter is returned only when you set the parameter <b>RangeId</b> to <b>1</b>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>S4</para>
            /// </summary>
            [NameInMap("OdpsRiskLevelName")]
            [Validation(Required=false)]
            public string OdpsRiskLevelName { get; set; }

            /// <summary>
            /// <para>The account that owns the data asset.</para>
            /// 
            /// <b>Example:</b>
            /// <para>dtdep-239-******</para>
            /// </summary>
            [NameInMap("Owner")]
            [Validation(Required=false)]
            public string Owner { get; set; }

            /// <summary>
            /// <para>The name of the service to which the data asset belongs.</para>
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
            /// <item><description><b>1</b>: MaxCompute</description></item>
            /// <item><description><b>2</b>: OSS</description></item>
            /// <item><description><b>3</b>: AnalyticDB for MySQL</description></item>
            /// <item><description><b>4</b>: Tablestore</description></item>
            /// <item><description><b>5</b>: ApsaraDB RDS</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("ProductId")]
            [Validation(Required=false)]
            public string ProductId { get; set; }

            /// <summary>
            /// <para>Indicates whether the data protection mechanism is enabled for the data asset. The value is fixed as <b>false</b>. <b>true</b> or <b>false</b> is returned for this parameter only when you set the parameter <b>RangeId</b> to <b>1</b>.</para>
            /// <list type="bullet">
            /// <item><description><b>false</b>: The data protection mechanism is disabled.</description></item>
            /// <item><description><b>true</b>: The data protection mechanism is enabled. Only data inbound is supported. Data outbound is not supported.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("Protection")]
            [Validation(Required=false)]
            public bool? Protection { get; set; }

            /// <summary>
            /// <para>The sensitivity level of the data asset. A higher sensitivity level indicates that the identified data is more sensitive. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>1</b>: No sensitive data is identified.</description></item>
            /// <item><description><b>2</b>: sensitive data at level 1.</description></item>
            /// <item><description><b>3</b>: sensitive data at level 2.</description></item>
            /// <item><description><b>3</b>: sensitive data at level 3.</description></item>
            /// <item><description><b>5</b>: sensitive data at level 4.</description></item>
            /// <item><description><b>6</b>: sensitive data at level 5.</description></item>
            /// <item><description><b>7</b>: sensitive data at level 6.</description></item>
            /// <item><description><b>8</b>: sensitive data at level 7.</description></item>
            /// <item><description><b>9</b>: sensitive data at level 8.</description></item>
            /// <item><description><b>10</b>: sensitive data at level 9.</description></item>
            /// <item><description><b>11</b>: sensitive data at level 10.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("RiskLevelId")]
            [Validation(Required=false)]
            public long? RiskLevelId { get; set; }

            /// <summary>
            /// <para>The name of the sensitivity level for the data asset.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Medium sensitivity level</para>
            /// </summary>
            [NameInMap("RiskLevelName")]
            [Validation(Required=false)]
            public string RiskLevelName { get; set; }

            /// <summary>
            /// <para>The name of the sensitive data detection rule that the data asset hits.</para>
            /// 
            /// <b>Example:</b>
            /// <para>\<em>\</em>\* rule</para>
            /// </summary>
            [NameInMap("RuleName")]
            [Validation(Required=false)]
            public string RuleName { get; set; }

            /// <summary>
            /// <para>Indicates whether the data asset contains sensitive data. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: yes</description></item>
            /// <item><description><b>false</b>: no</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Sensitive")]
            [Validation(Required=false)]
            public bool? Sensitive { get; set; }

            /// <summary>
            /// <para>The total number of sensitive data assets. For example, the value can be the total number of sensitive MaxCompute projects, packages, or tables, the total number of sensitive ApsaraDB RDS databases or tables, or the total number of sensitive OSS buckets or objects.</para>
            /// 
            /// <b>Example:</b>
            /// <para>24</para>
            /// </summary>
            [NameInMap("SensitiveCount")]
            [Validation(Required=false)]
            public int? SensitiveCount { get; set; }

            /// <summary>
            /// <para>The percentage of sensitive data in all data assets.</para>
            /// 
            /// <b>Example:</b>
            /// <para>45%</para>
            /// </summary>
            [NameInMap("SensitiveRatio")]
            [Validation(Required=false)]
            public string SensitiveRatio { get; set; }

            /// <summary>
            /// <para>The total number of data assets. For example, the value can be the total number of MaxCompute projects, packages, or tables, the total number of ApsaraDB RDS databases or tables, or the total number of OSS buckets or objects.</para>
            /// 
            /// <b>Example:</b>
            /// <para>432</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The number of entries returned per page.</para>
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
        /// <para>The total number of queried data assets that contain sensitive data.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
