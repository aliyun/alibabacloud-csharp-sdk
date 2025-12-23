// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OpenSearch20171225.Models
{
    public class DescribeABTestExperimentResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>D77D0DAF-790D-F5F5-A9C0-133738165014</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The details of the test.</para>
        /// </summary>
        [NameInMap("result")]
        [Validation(Required=false)]
        public DescribeABTestExperimentResponseBodyResult Result { get; set; }
        public class DescribeABTestExperimentResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>The time when the test was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1588842080</para>
            /// </summary>
            [NameInMap("created")]
            [Validation(Required=false)]
            public int? Created { get; set; }

            /// <summary>
            /// <para>The ID of the test.</para>
            /// 
            /// <b>Example:</b>
            /// <para>12888</para>
            /// </summary>
            [NameInMap("id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <para>The name of the test.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test1</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The status of the test. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true: in effect</description></item>
            /// <item><description>false: not in effect</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("online")]
            [Validation(Required=false)]
            public bool? Online { get; set; }

            /// <summary>
            /// <para>The parameters of the test.</para>
            /// </summary>
            [NameInMap("params")]
            [Validation(Required=false)]
            public DescribeABTestExperimentResponseBodyResultParams Params { get; set; }
            public class DescribeABTestExperimentResponseBodyResultParams : TeaModel {
                /// <summary>
                /// <para>The name of the rough sort policy.</para>
                /// 
                /// <b>Example:</b>
                /// <para>default</para>
                /// </summary>
                [NameInMap("first_formula_name")]
                [Validation(Required=false)]
                public string FirstFormulaName { get; set; }

            }

            /// <summary>
            /// <para>The percentage of traffic that is routed to the test.</para>
            /// 
            /// <b>Example:</b>
            /// <para>30</para>
            /// </summary>
            [NameInMap("traffic")]
            [Validation(Required=false)]
            public int? Traffic { get; set; }

            /// <summary>
            /// <para>The time when the test was last modified.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1588842080</para>
            /// </summary>
            [NameInMap("updated")]
            [Validation(Required=false)]
            public int? Updated { get; set; }

        }

    }

}
