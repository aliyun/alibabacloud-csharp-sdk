// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.R_kvstore20150101.Models
{
    public class DescribeParameterGroupsResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of parameter templates.</para>
        /// </summary>
        [NameInMap("ParameterGroups")]
        [Validation(Required=false)]
        public List<DescribeParameterGroupsResponseBodyParameterGroups> ParameterGroups { get; set; }
        public class DescribeParameterGroupsResponseBodyParameterGroups : TeaModel {
            /// <summary>
            /// <para>The service category. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: Community Edition</description></item>
            /// <item><description><b>1</b>: Enhanced Edition (Tair)</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
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
            /// <item><description><b>redis</b>: Redis or Tair DRAM-based instance</description></item>
            /// <item><description><b>tair_pena</b>: Tair persistent memory-optimized instance</description></item>
            /// <item><description><b>tair_pdb</b>: Tair ESSD-based instance</description></item>
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
            /// <para>5</para>
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
            /// <para>The parameter template ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test01</para>
            /// </summary>
            [NameInMap("ParamGroupId")]
            [Validation(Required=false)]
            public string ParamGroupId { get; set; }

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
        /// <para>686BB8A6-BBA5-47E5-8A75-D2ADE433****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
