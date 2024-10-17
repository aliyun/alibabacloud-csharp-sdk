// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sddp20190103.Models
{
    public class DescribeRiskLevelsResponseBody : TeaModel {
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
        /// <para>An array that consists of sensitivity levels.</para>
        /// </summary>
        [NameInMap("RiskLevelList")]
        [Validation(Required=false)]
        public List<DescribeRiskLevelsResponseBodyRiskLevelList> RiskLevelList { get; set; }
        public class DescribeRiskLevelsResponseBodyRiskLevelList : TeaModel {
            /// <summary>
            /// <para>The description of the sensitivity level. You can enter a custom description.</para>
            /// <para>The following list describes the sensitivity level names and the corresponding default description:</para>
            /// <list type="bullet">
            /// <item><description><b>NA</b>: which indicates that no sensitive data is detected.</description></item>
            /// <item><description><b>S1</b>: which indicates the sensitive data at sensitivity level 1.</description></item>
            /// <item><description><b>S2</b>: which indicates the sensitive data at sensitivity level 2.</description></item>
            /// <item><description><b>S3</b>: which indicates the sensitive data at sensitivity level 3.</description></item>
            /// <item><description><b>S4</b>: which indicates the sensitive data at sensitivity level 4.</description></item>
            /// <item><description><b>S5</b>: which indicates the sensitive data at sensitivity level 5.</description></item>
            /// <item><description><b>S6</b>: which indicates the sensitive data at sensitivity level 6.</description></item>
            /// <item><description><b>S7</b>: which indicates the sensitive data at sensitivity level 7.</description></item>
            /// <item><description><b>S8</b>: which indicates the sensitive data at sensitivity level 8.</description></item>
            /// <item><description><b>S9</b>: which indicates the sensitive data at sensitivity level 9.</description></item>
            /// <item><description><b>S10</b>: which indicates the sensitive data at sensitivity level 10.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Sensitive data at sensitivity level 1</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The unique ID of the sensitivity level. Valid values: 1 to 11. Each sensitivity level ID maps a sensitivity level. For example, the sensitivity level ID of 2 corresponds to the sensitivity level S1.</para>
            /// <para>For more information, see the description of the Name parameter.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <para>The name of the sensitivity level. The highest sensitivity level varies based on rule templates. The highest sensitivity level is S10. The highest sensitivity level of the <b>Built-in data security classification templates for Alibaba and Ant Group</b> is S4, and that of the <b>built-in classification templates for financial data</b> and <b>built-in classification templates for assets</b> is S5. For more information about the built-in classification templates for financial data, see Guidelines for Security Classification of Financial Data and Security Data - JRT 0197-2020. For a copied rule template, the highest sensitivity level is S10. The following list describes the sensitivity level names and the corresponding IDs:</para>
            /// <list type="bullet">
            /// <item><description><b>NA</b>: 1</description></item>
            /// <item><description><b>S1</b>: 2</description></item>
            /// <item><description><b>S2</b>: 3</description></item>
            /// <item><description><b>S3</b>: 4</description></item>
            /// <item><description><b>S4</b>: 5</description></item>
            /// <item><description><b>S5</b>: 6</description></item>
            /// <item><description><b>S6</b>: 7</description></item>
            /// <item><description><b>S7</b>: 8</description></item>
            /// <item><description><b>S8</b>: 9</description></item>
            /// <item><description><b>S9</b>: 10</description></item>
            /// <item><description><b>S10</b>: 11</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>S1</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The number of times that each sensitivity level is referenced in the rule template. Default value: 0.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("ReferenceNum")]
            [Validation(Required=false)]
            public int? ReferenceNum { get; set; }

        }

    }

}
