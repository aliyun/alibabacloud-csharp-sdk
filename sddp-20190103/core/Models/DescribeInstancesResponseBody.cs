// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sddp20190103.Models
{
    public class DescribeInstancesResponseBody : TeaModel {
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
        /// <para>The details of the data asset instances returned.</para>
        /// </summary>
        [NameInMap("Items")]
        [Validation(Required=false)]
        public List<DescribeInstancesResponseBodyItems> Items { get; set; }
        public class DescribeInstancesResponseBodyItems : TeaModel {
            /// <summary>
            /// <para>The time when the data asset instance was created. The value is a UNIX timestamp. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1637226782000</para>
            /// </summary>
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public long? CreationTime { get; set; }

            /// <summary>
            /// <para>The name of the department to which the data asset instance belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>***DemoCenter</para>
            /// </summary>
            [NameInMap("DepartName")]
            [Validation(Required=false)]
            public string DepartName { get; set; }

            /// <summary>
            /// <para>The unique ID of the data asset instance recorded in Data Security Center.</para>
            /// 
            /// <b>Example:</b>
            /// <para>11111</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <para>The description of the data asset instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>instance dscription</para>
            /// </summary>
            [NameInMap("InstanceDescription")]
            [Validation(Required=false)]
            public string InstanceDescription { get; set; }

            /// <summary>
            /// <para>The security status of the data asset instance. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: Secure.</description></item>
            /// <item><description><b>false</b>: Not secure.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Labelsec")]
            [Validation(Required=false)]
            public bool? Labelsec { get; set; }

            /// <summary>
            /// <para>The time when the most recent scan of the data asset instance was completed. The value is a UNIX timestamp. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1637622793000</para>
            /// </summary>
            [NameInMap("LastFinishTime")]
            [Validation(Required=false)]
            public long? LastFinishTime { get; set; }

            /// <summary>
            /// <para>If the management account has enabled multi-account management and the asset belongs to another member account, this field displays the UID of the member account.</para>
            /// 
            /// <b>Example:</b>
            /// <para>12567890126</para>
            /// </summary>
            [NameInMap("MemberAliUid")]
            [Validation(Required=false)]
            public string MemberAliUid { get; set; }

            /// <summary>
            /// <para>The list of data tags.</para>
            /// </summary>
            [NameInMap("ModelTags")]
            [Validation(Required=false)]
            public List<DescribeInstancesResponseBodyItemsModelTags> ModelTags { get; set; }
            public class DescribeInstancesResponseBodyItemsModelTags : TeaModel {
                /// <summary>
                /// <para>The data tag ID. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>101</b>: personal sensitive information</description></item>
                /// <item><description><b>102</b>: personal information</description></item>
                /// <item><description><b>107</b>: general information</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>101</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// <para>The data tag name. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>个人敏感信息</description></item>
                /// <item><description>个人信息</description></item>
                /// <item><description>通用信息</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>personal sensitive data</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

            /// <summary>
            /// <para>The name of the data asset instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>gxdata</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>This parameter is deprecated.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("OdpsRiskLevelName")]
            [Validation(Required=false)]
            public string OdpsRiskLevelName { get; set; }

            /// <summary>
            /// <para>The Alibaba Cloud account that owns the data asset instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>dtdep-239-******</para>
            /// </summary>
            [NameInMap("Owner")]
            [Validation(Required=false)]
            public string Owner { get; set; }

            /// <summary>
            /// <para>The name of the product to which the data asset instance belongs, such as MaxCompute, OSS, or RDS. For supported product names, see <a href="https://help.aliyun.com/document_detail/212906.html">Data types from which sensitive data can be detected</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>RDS</para>
            /// </summary>
            [NameInMap("ProductCode")]
            [Validation(Required=false)]
            public string ProductCode { get; set; }

            /// <summary>
            /// <para>The ID of the product to which the data asset instance belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("ProductId")]
            [Validation(Required=false)]
            public string ProductId { get; set; }

            /// <summary>
            /// <para>The protection status of the data asset instance. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: Protected.</description></item>
            /// <item><description><b>false</b>: Not protected.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("Protection")]
            [Validation(Required=false)]
            public bool? Protection { get; set; }

            /// <summary>
            /// <para>The risk level ID of the data asset instance. A higher risk level ID indicates more sensitive data is detected.</para>
            /// <list type="bullet">
            /// <item><description><b>1</b>: No sensitive data is detected. No risk.</description></item>
            /// <item><description><b>2</b>: Sensitive data risk at level 1.</description></item>
            /// <item><description><b>3</b>: Sensitive data risk at level 2.</description></item>
            /// <item><description><b>4</b>: Sensitive data risk at level 3.</description></item>
            /// <item><description><b>5</b>: Sensitive data risk at level 4.</description></item>
            /// <item><description><b>6</b>: Sensitive data risk at level 5.</description></item>
            /// <item><description><b>7</b>: Sensitive data risk at level 6.</description></item>
            /// <item><description><b>8</b>: Sensitive data risk at level 7.</description></item>
            /// <item><description><b>9</b>: Sensitive data risk at level 8.</description></item>
            /// <item><description><b>10</b>: Sensitive data risk at level 9.</description></item>
            /// <item><description><b>11</b>: Sensitive data risk at level 10.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("RiskLevelId")]
            [Validation(Required=false)]
            public long? RiskLevelId { get; set; }

            /// <summary>
            /// <para>The risk level name of the data asset instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>S1</para>
            /// </summary>
            [NameInMap("RiskLevelName")]
            [Validation(Required=false)]
            public string RiskLevelName { get; set; }

            /// <summary>
            /// <para>The name of the sensitive data detection rule that the data asset instance hits.</para>
            /// 
            /// <b>Example:</b>
            /// <para>*** rule</para>
            /// </summary>
            [NameInMap("RuleName")]
            [Validation(Required=false)]
            public string RuleName { get; set; }

            /// <summary>
            /// <para>Indicates whether the data asset instance contains sensitive data. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: Contains sensitive data.</description></item>
            /// <item><description><b>false</b>: Does not contain sensitive data.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Sensitive")]
            [Validation(Required=false)]
            public bool? Sensitive { get; set; }

            /// <summary>
            /// <para>The total number of sensitive data items in the data asset instance. For example, if the data asset is ApsaraDB RDS, this value indicates the total number of sensitive tables in the databases of the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123</para>
            /// </summary>
            [NameInMap("SensitiveCount")]
            [Validation(Required=false)]
            public int? SensitiveCount { get; set; }

            /// <summary>
            /// <para>The name of the tenant.</para>
            /// 
            /// <b>Example:</b>
            /// <para>tenant</para>
            /// </summary>
            [NameInMap("TenantName")]
            [Validation(Required=false)]
            public string TenantName { get; set; }

            /// <summary>
            /// <para>The total number of data items in the data asset instance. For example, if the data asset is ApsaraDB RDS, this value indicates the total number of tables in the databases of the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>231</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The number of data asset instances on each page.</para>
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
        /// <para>71064826-726F-4ADA-B879-05D8055476FB</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of data asset instances returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>231</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
