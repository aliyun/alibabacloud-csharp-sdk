// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sddp20190103.Models
{
    public class DescribeCategoryTemplateRuleListResponseBody : TeaModel {
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
        /// <para>The list of rules.</para>
        /// </summary>
        [NameInMap("Items")]
        [Validation(Required=false)]
        public List<DescribeCategoryTemplateRuleListResponseBodyItems> Items { get; set; }
        public class DescribeCategoryTemplateRuleListResponseBodyItems : TeaModel {
            /// <summary>
            /// <para>The description of the rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Rule for identifying ID card numbers</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The unique ID of the rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <para>The IDs of sensitive data types. Multiple IDs are separated by commas (,).</para>
            /// 
            /// <b>Example:</b>
            /// <para>1001,1002</para>
            /// </summary>
            [NameInMap("IdentificationRuleIds")]
            [Validation(Required=false)]
            public string IdentificationRuleIds { get; set; }

            /// <summary>
            /// <para>The scan scope of the rule. The value is a JSON array of the STRING type. Each element in a JSON array indicates a scan scope that contains the following fields:</para>
            /// <list type="bullet">
            /// <item><description><para><b>Asset</b>: the data asset type. Valid values: RDS, DRDS, PolarDB, OTS, ADB, and OceanBase. The value is of the STRING type.</para>
            /// </description></item>
            /// <item><description><para><b>Content</b>: the scan scope. The value is of the STRING type. Each element in a JSON array indicates a scan scope that contains the following fields:</para>
            /// <list type="bullet">
            /// <item><description><b>Range</b>: the matching condition. Valid values: Instance, database, table, column, project, bucket, and object. The value project is valid only for data assets in MaxCompute. The values bucket and object are valid only for data assets in Object Storage Service (OSS). The value of this parameter is of the STRING type.</description></item>
            /// <item><description><b>Operator</b>: the operator. Valid values: equals, regex, prefix, and suffix. The operator equals indicates a full match. The operator regex indicates a match by regular expression. The operator prefix indicates a match by prefix. The operator suffix indicates a match by suffix.</description></item>
            /// <item><description><b>Value</b>: the matching content. The value is of the STRING type.</description></item>
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
            /// <para>The name of the rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ID card number</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The sensitivity level of the data that is not compliant with the rule. Valid values: <b>1</b> to <b>11</b>.</para>
            /// <list type="bullet">
            /// <item><description><b>1</b>: No sensitive data is detected.</description></item>
            /// <item><description><b>2</b>: indicates the S1 sensitivity level.</description></item>
            /// <item><description><b>3</b>: indicates the S2 sensitivity level.</description></item>
            /// <item><description><b>4</b>: indicates the S3 sensitivity level.</description></item>
            /// <item><description><b>5</b>: indicates the S4 sensitivity level.</description></item>
            /// <item><description><b>6</b>: indicates the S5 sensitivity level.</description></item>
            /// <item><description><b>7</b>: indicates the S6 sensitivity level.</description></item>
            /// <item><description><b>8</b>: indicates the S7 sensitivity level.</description></item>
            /// <item><description><b>9</b>: indicates the S8 sensitivity level.</description></item>
            /// <item><description><b>10</b>: indicates the S9 sensitivity level.</description></item>
            /// <item><description><b>11</b>: indicates the S10 sensitivity level.</description></item>
            /// <item><description><b>null</b>: indicates all preceding sensitivity levels.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("RiskLevelId")]
            [Validation(Required=false)]
            public long? RiskLevelId { get; set; }

            /// <summary>
            /// <para>The status of the rule. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: disabled</description></item>
            /// <item><description><b>1</b>: enabled</description></item>
            /// <item><description><b>null</b>: all states</description></item>
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
