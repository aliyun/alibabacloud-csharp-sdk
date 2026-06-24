// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sddp20190103.Models
{
    public class DescribeInstancesResponseBody : TeaModel {
        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <para>The details of the data asset instances.</para>
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
            /// <para>The unique ID of the data asset instance that is recorded in Data Security Center.</para>
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
            /// <item><description><para><b>true</b>: secure</para>
            /// </description></item>
            /// <item><description><para><b>false</b>: insecure</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Labelsec")]
            [Validation(Required=false)]
            public bool? Labelsec { get; set; }

            /// <summary>
            /// <para>The time when the last scan of the data asset instance was completed. The value is a UNIX timestamp. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1637622793000</para>
            /// </summary>
            [NameInMap("LastFinishTime")]
            [Validation(Required=false)]
            public long? LastFinishTime { get; set; }

            /// <summary>
            /// <para>If multi-account management is enabled and the asset belongs to a member account, this parameter indicates the UID of the member account.</para>
            /// 
            /// <b>Example:</b>
            /// <para>12567890126</para>
            /// </summary>
            [NameInMap("MemberAliUid")]
            [Validation(Required=false)]
            public string MemberAliUid { get; set; }

            /// <summary>
            /// <para>The list of data labels.</para>
            /// </summary>
            [NameInMap("ModelTags")]
            [Validation(Required=false)]
            public List<DescribeInstancesResponseBodyItemsModelTags> ModelTags { get; set; }
            public class DescribeInstancesResponseBodyItemsModelTags : TeaModel {
                /// <summary>
                /// <para>The ID of the data label. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><b>101</b>: Personal sensitive information</para>
                /// </description></item>
                /// <item><description><para><b>102</b>: Personal information</para>
                /// </description></item>
                /// <item><description><para><b>107</b>: General information</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>101</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// <para>The name of the data label. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para>Personal sensitive information</para>
                /// </description></item>
                /// <item><description><para>Personal information</para>
                /// </description></item>
                /// <item><description><para>General information</para>
                /// </description></item>
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
            /// <para>The name of the product to which the data asset instance belongs, such as MaxCompute, OSS, or RDS. For more information about the supported products, see <a href="https://help.aliyun.com/document_detail/212906.html">Data assets that can be scanned for sensitive data</a>.</para>
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
            /// <item><description><para><b>true</b>: The instance is protected.</para>
            /// </description></item>
            /// <item><description><para><b>false</b>: The instance is not protected.</para>
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
            /// <para>The ID of the threat level for the data asset instance. The higher the threat level ID, the more sensitive the data.</para>
            /// <list type="bullet">
            /// <item><description><para><b>1</b>: No sensitive data is detected. No threat.</para>
            /// </description></item>
            /// <item><description><para><b>2</b>: Threat level 1.</para>
            /// </description></item>
            /// <item><description><para><b>3</b>: Threat level 2.</para>
            /// </description></item>
            /// <item><description><para><b>4</b>: Threat level 3.</para>
            /// </description></item>
            /// <item><description><para><b>5</b>: Threat level 4.</para>
            /// </description></item>
            /// <item><description><para><b>6</b>: Threat level 5.</para>
            /// </description></item>
            /// <item><description><para><b>7</b>: Threat level 6.</para>
            /// </description></item>
            /// <item><description><para><b>8</b>: Threat level 7.</para>
            /// </description></item>
            /// <item><description><para><b>9</b>: Threat level 8.</para>
            /// </description></item>
            /// <item><description><para><b>10</b>: Threat level 9.</para>
            /// </description></item>
            /// <item><description><para><b>11</b>: Threat level 10.</para>
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
            /// <para>The name of the threat level for the data asset instance.</para>
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
            /// <item><description><para><b>true</b>: yes</para>
            /// </description></item>
            /// <item><description><para><b>false</b>: no</para>
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
            /// <para>The total amount of sensitive data in the data asset instance. For example, if the data asset is an RDS instance, this parameter indicates the total number of sensitive tables in the instance.</para>
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
            /// <para>The total amount of data in the data asset instance. For example, if the data asset is an RDS instance, this parameter indicates the total number of tables in the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>231</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The number of data asset instances returned on each page.</para>
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
        /// <para>The total number of data asset instances.</para>
        /// 
        /// <b>Example:</b>
        /// <para>231</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
