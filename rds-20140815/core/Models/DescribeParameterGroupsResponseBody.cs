// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeParameterGroupsResponseBody : TeaModel {
        [NameInMap("ParameterGroups")]
        [Validation(Required=false)]
        public DescribeParameterGroupsResponseBodyParameterGroups ParameterGroups { get; set; }
        public class DescribeParameterGroupsResponseBodyParameterGroups : TeaModel {
            [NameInMap("ParameterGroup")]
            [Validation(Required=false)]
            public List<DescribeParameterGroupsResponseBodyParameterGroupsParameterGroup> ParameterGroup { get; set; }
            public class DescribeParameterGroupsResponseBodyParameterGroupsParameterGroup : TeaModel {
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                [NameInMap("Engine")]
                [Validation(Required=false)]
                public string Engine { get; set; }

                [NameInMap("EngineVersion")]
                [Validation(Required=false)]
                public string EngineVersion { get; set; }

                [NameInMap("ForceRestart")]
                [Validation(Required=false)]
                public int? ForceRestart { get; set; }

                [NameInMap("ParamCounts")]
                [Validation(Required=false)]
                public int? ParamCounts { get; set; }

                [NameInMap("ParameterGroupDesc")]
                [Validation(Required=false)]
                public string ParameterGroupDesc { get; set; }

                [NameInMap("ParameterGroupId")]
                [Validation(Required=false)]
                public string ParameterGroupId { get; set; }

                [NameInMap("ParameterGroupName")]
                [Validation(Required=false)]
                public string ParameterGroupName { get; set; }

                [NameInMap("ParameterGroupType")]
                [Validation(Required=false)]
                public int? ParameterGroupType { get; set; }

                [NameInMap("UpdateTime")]
                [Validation(Required=false)]
                public string UpdateTime { get; set; }

            }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>D4A23265-C5B6-42E1-98A0-EFA1EB42E723</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether parameter templates exist in the specified region. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true</description></item>
        /// <item><description>false<remarks>
        /// <para>Notice: This parameter is deprecated.</para>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("SignalForOptimizeParams")]
        [Validation(Required=false)]
        public bool? SignalForOptimizeParams { get; set; }

    }

}
