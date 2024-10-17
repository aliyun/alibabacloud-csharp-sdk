// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sddp20190103.Models
{
    public class DescribeInstancesResponseBody : TeaModel {
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
        /// <para>An array that consists of the data assets.</para>
        /// </summary>
        [NameInMap("Items")]
        [Validation(Required=false)]
        public List<DescribeInstancesResponseBodyItems> Items { get; set; }
        public class DescribeInstancesResponseBodyItems : TeaModel {
            /// <summary>
            /// <para>The time when the data asset was created. The value is a UNIX timestamp. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1637226782000</para>
            /// </summary>
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public long? CreationTime { get; set; }

            /// <summary>
            /// <para>The name of the department to which the data asset belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>***DemoCenter</para>
            /// </summary>
            [NameInMap("DepartName")]
            [Validation(Required=false)]
            public string DepartName { get; set; }

            /// <summary>
            /// <para>The unique ID of the data asset in DSC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>11111</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <para>The description of the data asset.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Data asset Information 1</para>
            /// </summary>
            [NameInMap("InstanceDescription")]
            [Validation(Required=false)]
            public string InstanceDescription { get; set; }

            /// <summary>
            /// <para>The security status of the data asset. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: The data asset is secure.</description></item>
            /// <item><description><b>false</b>: The data asset is insecure.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Labelsec")]
            [Validation(Required=false)]
            public bool? Labelsec { get; set; }

            /// <summary>
            /// <para>The time when the data asset was last scanned. The value is a UNIX timestamp. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1637622793000</para>
            /// </summary>
            [NameInMap("LastFinishTime")]
            [Validation(Required=false)]
            public long? LastFinishTime { get; set; }

            [NameInMap("MemberAliUid")]
            [Validation(Required=false)]
            public string MemberAliUid { get; set; }

            /// <summary>
            /// <para>A list of tags.</para>
            /// </summary>
            [NameInMap("ModelTags")]
            [Validation(Required=false)]
            public List<DescribeInstancesResponseBodyItemsModelTags> ModelTags { get; set; }
            public class DescribeInstancesResponseBodyItemsModelTags : TeaModel {
                /// <summary>
                /// <para>The ID of the tag. Valid values:</para>
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
                /// <para>The name of the tag. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>Personal sensitive information</description></item>
                /// <item><description>Personal information</description></item>
                /// <item><description>General information</description></item>
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
            /// <para>The name of the data asset.</para>
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
            /// <para>The Alibaba Cloud account to which the data asset belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>dtdep-239-******</para>
            /// </summary>
            [NameInMap("Owner")]
            [Validation(Required=false)]
            public string Owner { get; set; }

            /// <summary>
            /// <para>The name of the service to which the data asset belongs, such as MaxCompute, OSS, and ApsaraDB RDS. For more information about the types of data assets that DSC can scan to detect sensitive data, see <a href="https://help.aliyun.com/document_detail/212906.html">Supported data assets</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>RDS</para>
            /// </summary>
            [NameInMap("ProductCode")]
            [Validation(Required=false)]
            public string ProductCode { get; set; }

            /// <summary>
            /// <para>The ID of the service to which the data asset belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("ProductId")]
            [Validation(Required=false)]
            public string ProductId { get; set; }

            /// <summary>
            /// <para>The protection status of the data asset. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: The data asset is being protected.</description></item>
            /// <item><description><b>false</b>: The data asset is not protected.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("Protection")]
            [Validation(Required=false)]
            public bool? Protection { get; set; }

            /// <summary>
            /// <para>The ID of the sensitivity level for the data asset. A higher sensitivity level ID indicates that the identified data is more sensitive.</para>
            /// <list type="bullet">
            /// <item><description><b>1</b>: No sensitive data is detected.</description></item>
            /// <item><description><b>2</b>: sensitive data at level 1.</description></item>
            /// <item><description><b>3</b>: sensitive data at level 2.</description></item>
            /// <item><description><b>4</b>: sensitive data at level 3.</description></item>
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
            /// <para>Sensitive data at level 1</para>
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
            /// <item><description><b>true</b></description></item>
            /// <item><description><b>false</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Sensitive")]
            [Validation(Required=false)]
            public bool? Sensitive { get; set; }

            /// <summary>
            /// <para>The number of sensitive data objects in the data asset. For example, if the data asset is an ApsaraDB RDS instance, the value indicates the number of sensitive tables in all databases of the instance.</para>
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
            /// <para>Tenant 1</para>
            /// </summary>
            [NameInMap("TenantName")]
            [Validation(Required=false)]
            public string TenantName { get; set; }

            /// <summary>
            /// <para>The total number of data objects in the data asset. For example, if the data asset is an ApsaraDB RDS instance, the value indicates the total number of tables in all databases of the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>231</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

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
        /// <para>71064826-726F-4ADA-B879-05D8055476FB</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of data assets.</para>
        /// 
        /// <b>Example:</b>
        /// <para>231</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
