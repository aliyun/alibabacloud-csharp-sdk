// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeParameterGroupsResponseBody : TeaModel {
        /// <summary>
        /// <para>The details of the parameter templates.</para>
        /// </summary>
        [NameInMap("ParameterGroups")]
        [Validation(Required=false)]
        public DescribeParameterGroupsResponseBodyParameterGroups ParameterGroups { get; set; }
        public class DescribeParameterGroupsResponseBodyParameterGroups : TeaModel {
            [NameInMap("ParameterGroup")]
            [Validation(Required=false)]
            public List<DescribeParameterGroupsResponseBodyParameterGroupsParameterGroup> ParameterGroup { get; set; }
            public class DescribeParameterGroupsResponseBodyParameterGroupsParameterGroup : TeaModel {
                /// <summary>
                /// <para>The time when the parameter template was created. The time follows the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time is displayed in UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2019-11-21T01:48:39Z</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// <para>The database engine of the instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>mysql</para>
                /// </summary>
                [NameInMap("Engine")]
                [Validation(Required=false)]
                public string Engine { get; set; }

                /// <summary>
                /// <para>The database engine version.</para>
                /// 
                /// <b>Example:</b>
                /// <para>5.7</para>
                /// </summary>
                [NameInMap("EngineVersion")]
                [Validation(Required=false)]
                public string EngineVersion { get; set; }

                /// <summary>
                /// <para>Indicates whether the restart of an instance is required for the parameter template to take effect. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>0: A restart is not required.</description></item>
                /// <item><description>1: A restart is required.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("ForceRestart")]
                [Validation(Required=false)]
                public int? ForceRestart { get; set; }

                /// <summary>
                /// <para>The number of parameters in the parameter template.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("ParamCounts")]
                [Validation(Required=false)]
                public int? ParamCounts { get; set; }

                /// <summary>
                /// <para>The type of the parameter template. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>0: the default parameter template.</description></item>
                /// <item><description>1: a custom parameter template.</description></item>
                /// <item><description>2: an automatic backup parameter template. After you apply this type of template, the system automatically backs up the original parameter settings and saves the backup as a template.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("ParameterGroupDesc")]
                [Validation(Required=false)]
                public string ParameterGroupDesc { get; set; }

                /// <summary>
                /// <para>The ID of the parameter template.</para>
                /// 
                /// <b>Example:</b>
                /// <para>rpg-****</para>
                /// </summary>
                [NameInMap("ParameterGroupId")]
                [Validation(Required=false)]
                public string ParameterGroupId { get; set; }

                /// <summary>
                /// <para>The name of the parameter template.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test1234</para>
                /// </summary>
                [NameInMap("ParameterGroupName")]
                [Validation(Required=false)]
                public string ParameterGroupName { get; set; }

                /// <summary>
                /// <para>The type of the parameter template. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>0: the default parameter template.</description></item>
                /// <item><description>1: a custom parameter template.</description></item>
                /// <item><description>2: an automatic backup parameter template. After you apply this type of template, the system automatically backs up the original parameter settings and saves the backup as a template.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("ParameterGroupType")]
                [Validation(Required=false)]
                public int? ParameterGroupType { get; set; }

                /// <summary>
                /// <para>The time when the parameter template was last updated. The time follows the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time is displayed in UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2019-11-21T02:21:35Z</para>
                /// </summary>
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
