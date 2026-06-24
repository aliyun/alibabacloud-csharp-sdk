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
        /// <para>A list of risk levels.</para>
        /// </summary>
        [NameInMap("RiskLevelList")]
        [Validation(Required=false)]
        public List<DescribeRiskLevelsResponseBodyRiskLevelList> RiskLevelList { get; set; }
        public class DescribeRiskLevelsResponseBodyRiskLevelList : TeaModel {
            /// <summary>
            /// <para>The description of the risk level. You can customize the description.</para>
            /// <para>The following list describes the mappings between risk level names and their default descriptions:</para>
            /// <list type="bullet">
            /// <item><description><para><b>NA</b>: No sensitive data is detected</para>
            /// </description></item>
            /// <item><description><para><b>S1</b>: Level-1 sensitive data</para>
            /// </description></item>
            /// <item><description><para><b>S2</b>: Level-2 sensitive data</para>
            /// </description></item>
            /// <item><description><para><b>S3</b>: Level-3 sensitive data</para>
            /// </description></item>
            /// <item><description><para><b>S4</b>: Level-4 sensitive data</para>
            /// </description></item>
            /// <item><description><para><b>S5</b>: Level-5 sensitive data</para>
            /// </description></item>
            /// <item><description><para><b>S6</b>: Level-6 sensitive data</para>
            /// </description></item>
            /// <item><description><para><b>S7</b>: Level-7 sensitive data</para>
            /// </description></item>
            /// <item><description><para><b>S8</b>: Level-8 sensitive data</para>
            /// </description></item>
            /// <item><description><para><b>S9</b>: Level-9 sensitive data</para>
            /// </description></item>
            /// <item><description><para><b>S10</b>: Level-10 sensitive data</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>S3</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The unique ID of the risk level. Valid values: 1 to 11. Each risk level ID corresponds to a risk level name. For example, the risk level ID 2 corresponds to the risk level S1.</para>
            /// <para>For more information about the mappings, see the description of the Name parameter.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <para>The name of the risk level for the sensitive data. The maximum risk level is S10 and varies based on the data classification template. The maximum risk level is S4 for the <b>built-in data security classification template for Alibaba and Ant Group</b>, and S5 for the <b>built-in data classification template for the finance industry (with reference to JR/T 0197-2020 Financial Data Security - Guidelines for Data Security Classification)</b> and the <b>built-in data classification standard for the energy industry</b>. If you use a copied template, the maximum risk level is S10.
            /// The following list describes the mappings between risk level names and IDs:</para>
            /// <list type="bullet">
            /// <item><description><para><b>NA</b>: 1</para>
            /// </description></item>
            /// <item><description><para><b>S1</b>: 2</para>
            /// </description></item>
            /// <item><description><para><b>S2</b>: 3</para>
            /// </description></item>
            /// <item><description><para><b>S3</b>: 4</para>
            /// </description></item>
            /// <item><description><para><b>S4</b>: 5</para>
            /// </description></item>
            /// <item><description><para><b>S5</b>: 6</para>
            /// </description></item>
            /// <item><description><para><b>S6</b>: 7</para>
            /// </description></item>
            /// <item><description><para><b>S7</b>: 8</para>
            /// </description></item>
            /// <item><description><para><b>S8</b>: 9</para>
            /// </description></item>
            /// <item><description><para><b>S9</b>: 10</para>
            /// </description></item>
            /// <item><description><para><b>S10</b>: 11</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>S1</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The number of times the risk level is referenced in the template. The default value is 0.</para>
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
