// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.R_kvstore20150101.Models
{
    public class DescribeParameterGroupResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about the parameter template.</para>
        /// </summary>
        [NameInMap("ParameterGroup")]
        [Validation(Required=false)]
        public DescribeParameterGroupResponseBodyParameterGroup ParameterGroup { get; set; }
        public class DescribeParameterGroupResponseBodyParameterGroup : TeaModel {
            /// <summary>
            /// <para>The service category. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: Redis Open-Source Edition</description></item>
            /// <item><description><b>1</b>: Tair (Enterprise Edition)</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Category")]
            [Validation(Required=false)]
            public long? Category { get; set; }

            /// <summary>
            /// <para>The time when the parameter template was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-04-18 16:32:45</para>
            /// </summary>
            [NameInMap("Created")]
            [Validation(Required=false)]
            public string Created { get; set; }

            /// <summary>
            /// <para>The engine type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><em>redis</em>: Redis or Tair DRAM-based instance</description></item>
            /// <item><description><em>tair_pena</em>: Tair persistent memory-optimized instance</description></item>
            /// <item><description><em>tair_pdb</em>: Tair ESSD-based instance</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>redis</para>
            /// </summary>
            [NameInMap("Engine")]
            [Validation(Required=false)]
            public string Engine { get; set; }

            /// <summary>
            /// <para>The compatible engine version.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5.0</para>
            /// </summary>
            [NameInMap("EngineVersion")]
            [Validation(Required=false)]
            public string EngineVersion { get; set; }

            /// <summary>
            /// <para>The time when the parameter template was last modified.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-04-18 16:32:45</para>
            /// </summary>
            [NameInMap("Modified")]
            [Validation(Required=false)]
            public string Modified { get; set; }

            /// <summary>
            /// <para>The parameter template ID, which is globally unique.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sys-001*****</para>
            /// </summary>
            [NameInMap("ParamGroupId")]
            [Validation(Required=false)]
            public string ParamGroupId { get; set; }

            /// <summary>
            /// <para>The parameter details of the parameter template.</para>
            /// </summary>
            [NameInMap("ParamGroupsDetails")]
            [Validation(Required=false)]
            public List<DescribeParameterGroupResponseBodyParameterGroupParamGroupsDetails> ParamGroupsDetails { get; set; }
            public class DescribeParameterGroupResponseBodyParameterGroupParamGroupsDetails : TeaModel {
                /// <summary>
                /// <para>The name of the parameter.</para>
                /// 
                /// <b>Example:</b>
                /// <para>timeout</para>
                /// </summary>
                [NameInMap("ParamName")]
                [Validation(Required=false)]
                public string ParamName { get; set; }

                /// <summary>
                /// <para>The value of the parameter.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1000</para>
                /// </summary>
                [NameInMap("ParamValue")]
                [Validation(Required=false)]
                public string ParamValue { get; set; }

            }

            /// <summary>
            /// <para>The description of the parameter template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("ParameterGroupDesc")]
            [Validation(Required=false)]
            public string ParameterGroupDesc { get; set; }

            /// <summary>
            /// <para>The name of the parameter template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>testGroupName</para>
            /// </summary>
            [NameInMap("ParameterGroupName")]
            [Validation(Required=false)]
            public string ParameterGroupName { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>A501A191-BD70-5E50-98A9-C2A486A82****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
