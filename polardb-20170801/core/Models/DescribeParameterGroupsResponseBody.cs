// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
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
            /// <para>The time when the parameter template was created. The time is in the <c>yyyy-MM-ddTHH:mm:ssZ</c> format. The time is displayed in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-03-10T08:40:39Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The type of the database engine.</para>
            /// 
            /// <b>Example:</b>
            /// <para>MySQL</para>
            /// </summary>
            [NameInMap("DBType")]
            [Validation(Required=false)]
            public string DBType { get; set; }

            /// <summary>
            /// <para>The version of the database engine.</para>
            /// 
            /// <b>Example:</b>
            /// <para>8.0</para>
            /// </summary>
            [NameInMap("DBVersion")]
            [Validation(Required=false)]
            public string DBVersion { get; set; }

            /// <summary>
            /// <para>Indicates whether a cluster restart is required for the parameter template to take effect. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>0</b>: A restart is not required.</para>
            /// </description></item>
            /// <item><description><para><b>1</b>: A restart is required.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("ForceRestart")]
            [Validation(Required=false)]
            public string ForceRestart { get; set; }

            /// <summary>
            /// <para>The number of parameters in the parameter template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("ParameterCounts")]
            [Validation(Required=false)]
            public long? ParameterCounts { get; set; }

            /// <summary>
            /// <para>The description of the parameter template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>testgroup</para>
            /// </summary>
            [NameInMap("ParameterGroupDesc")]
            [Validation(Required=false)]
            public string ParameterGroupDesc { get; set; }

            /// <summary>
            /// <para>The ID of the parameter template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>pcpg-**************</para>
            /// </summary>
            [NameInMap("ParameterGroupId")]
            [Validation(Required=false)]
            public string ParameterGroupId { get; set; }

            /// <summary>
            /// <para>The name of the parameter template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("ParameterGroupName")]
            [Validation(Required=false)]
            public string ParameterGroupName { get; set; }

            /// <summary>
            /// <para>The type of the parameter template. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>0</b>: system default template</para>
            /// </description></item>
            /// <item><description><para><b>1</b>: user-defined template</para>
            /// </description></item>
            /// <item><description><para><b>2</b>: automatic backup template (The system automatically backs up the previous parameter settings as a template after you apply a new template.)</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("ParameterGroupType")]
            [Validation(Required=false)]
            public string ParameterGroupType { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>944CED46-A6F7-40C6-B6DC-C6E5CC******</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
