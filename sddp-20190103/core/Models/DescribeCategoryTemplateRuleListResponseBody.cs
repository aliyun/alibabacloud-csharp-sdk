// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sddp20190103.Models
{
    public class DescribeCategoryTemplateRuleListResponseBody : TeaModel {
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
        /// <para>A list of template rules.</para>
        /// </summary>
        [NameInMap("Items")]
        [Validation(Required=false)]
        public List<DescribeCategoryTemplateRuleListResponseBodyItems> Items { get; set; }
        public class DescribeCategoryTemplateRuleListResponseBodyItems : TeaModel {
            /// <summary>
            /// <para>The description of the rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Template rule for identifying ID card numbers</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The unique ID of the template rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <para>A comma-separated list of IDs of the associated atomic models.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1001,1002</para>
            /// </summary>
            [NameInMap("IdentificationRuleIds")]
            [Validation(Required=false)]
            public string IdentificationRuleIds { get; set; }

            /// <summary>
            /// <para>The scope of data that the template rule scans. This parameter is a string converted from a JSON array. Each element in the JSON array represents a data scanning scope and contains the following fields:</para>
            /// <list type="bullet">
            /// <item><description><para><b>Asset</b>: A string that indicates the asset type. Valid values include RDS, DRDS, PolarDB, OTS, ADB, OceanBase, and ODPS.</para>
            /// </description></item>
            /// <item><description><para><b>Content</b>: The specific scope of the asset to scan. This is an array of objects, where each object contains the following fields:</para>
            /// <list type="bullet">
            /// <item><description><para><b>Range</b>: A string that indicates the matching range. Valid values include instance, database, table, column, project (for MaxCompute assets only), bucket (for OSS assets only), and object (for OSS assets only).</para>
            /// </description></item>
            /// <item><description><para><b>Operator</b>: A string that indicates the matching condition. Valid values include equals, regex (regular expression), prefix, and suffix.</para>
            /// </description></item>
            /// <item><description><para><b>Value</b>: A string that indicates the content to match.</para>
            /// </description></item>
            /// </list>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>[{&quot;Asset&quot;:&quot;RDS&quot;,&quot;Content&quot;:[{&quot;Range&quot;:&quot;database&quot;,&quot;Operator&quot;:&quot;regex&quot;,&quot;Value&quot;:&quot;register&quot;}]},{&quot;Asset&quot;:&quot;RDS&quot;,&quot;Content&quot;:[{&quot;Range&quot;:&quot;table&quot;,&quot;Operator&quot;:&quot;regex&quot;,&quot;Value&quot;:&quot;register&quot;}]},{&quot;Asset&quot;:&quot;RDS&quot;,&quot;Content&quot;:[{&quot;Range&quot;:&quot;column&quot;,&quot;Operator&quot;:&quot;regex&quot;,&quot;Value&quot;:&quot;register&quot;}]},{&quot;Asset&quot;:&quot;ODPS&quot;,&quot;Content&quot;:[{&quot;Range&quot;:&quot;project&quot;,&quot;Operator&quot;:&quot;regex&quot;,&quot;Value&quot;:&quot;register&quot;}]},{&quot;Asset&quot;:&quot;ODPS&quot;,&quot;Content&quot;:[{&quot;Range&quot;:&quot;table&quot;,&quot;Operator&quot;:&quot;regex&quot;,&quot;Value&quot;:&quot;register&quot;}]},{&quot;Asset&quot;:&quot;ODPS&quot;,&quot;Content&quot;:[{&quot;Range&quot;:&quot;column&quot;,&quot;Operator&quot;:&quot;regex&quot;,&quot;Value&quot;:&quot;register&quot;}]}]</para>
            /// </summary>
            [NameInMap("IdentificationScope")]
            [Validation(Required=false)]
            public string IdentificationScope { get; set; }

            /// <summary>
            /// <para>The name of the template rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ID card</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The risk level of the template rule. The value ranges from <b>1</b> to <b>11</b>. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>1</b>: No risk.</para>
            /// </description></item>
            /// <item><description><para><b>2</b>: S1.</para>
            /// </description></item>
            /// <item><description><para><b>3</b>: S2.</para>
            /// </description></item>
            /// <item><description><para><b>4</b>: S3.</para>
            /// </description></item>
            /// <item><description><para><b>5</b>: S4.</para>
            /// </description></item>
            /// <item><description><para><b>6</b>: S5.</para>
            /// </description></item>
            /// <item><description><para><b>7</b>: S6.</para>
            /// </description></item>
            /// <item><description><para><b>8</b>: S7.</para>
            /// </description></item>
            /// <item><description><para><b>9</b>: S8.</para>
            /// </description></item>
            /// <item><description><para><b>10</b>: S9.</para>
            /// </description></item>
            /// <item><description><para><b>11</b>: S10.</para>
            /// </description></item>
            /// <item><description><para><b>null</b>: Indicates all risk levels, including No risk, S1, S2, S3, S4, S5, S6, S7, S8, S9, and S10.</para>
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
            /// <para>The status of the template rule. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>0</b>: disabled.</para>
            /// </description></item>
            /// <item><description><para><b>1</b>: enabled.</para>
            /// </description></item>
            /// <item><description><para><b>null</b>: Represents all statuses, including enabled and disabled.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

        }

        /// <summary>
        /// <para>The number of template rules returned on each page.</para>
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
        /// <para>136082B3-B21F-5E9D-B68E-991FFD205D24</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of rules in the template.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
