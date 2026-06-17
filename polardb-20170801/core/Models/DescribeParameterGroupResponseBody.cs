// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DescribeParameterGroupResponseBody : TeaModel {
        /// <summary>
        /// <para>A list of parameter templates.</para>
        /// </summary>
        [NameInMap("ParameterGroup")]
        [Validation(Required=false)]
        public List<DescribeParameterGroupResponseBodyParameterGroup> ParameterGroup { get; set; }
        public class DescribeParameterGroupResponseBodyParameterGroup : TeaModel {
            /// <summary>
            /// <para>The creation time of the parameter template, in <c>yyyy-MM-ddTHH:mm:ssZ</c> format (UTC).</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-03-10T08:40:39Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The database engine type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>MySQL</para>
            /// </summary>
            [NameInMap("DBType")]
            [Validation(Required=false)]
            public string DBType { get; set; }

            /// <summary>
            /// <para>The database engine version.</para>
            /// 
            /// <b>Example:</b>
            /// <para>8.0</para>
            /// </summary>
            [NameInMap("DBVersion")]
            [Validation(Required=false)]
            public string DBVersion { get; set; }

            /// <summary>
            /// <para>Specifies whether a cluster restart is required for the parameter template to take effect. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>0</b>: No restart is required.</para>
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
            public int? ParameterCounts { get; set; }

            /// <summary>
            /// <para>A list of parameters.</para>
            /// </summary>
            [NameInMap("ParameterDetail")]
            [Validation(Required=false)]
            public List<DescribeParameterGroupResponseBodyParameterGroupParameterDetail> ParameterDetail { get; set; }
            public class DescribeParameterGroupResponseBodyParameterGroupParameterDetail : TeaModel {
                /// <summary>
                /// <para>The parameter name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>back_log</para>
                /// </summary>
                [NameInMap("ParamName")]
                [Validation(Required=false)]
                public string ParamName { get; set; }

                /// <summary>
                /// <para>The parameter value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3000</para>
                /// </summary>
                [NameInMap("ParamValue")]
                [Validation(Required=false)]
                public string ParamValue { get; set; }

            }

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
            /// <item><description><para><b>0</b>: default template</para>
            /// </description></item>
            /// <item><description><para><b>1</b>: custom template</para>
            /// </description></item>
            /// <item><description><para><b>2</b>: automatic backup template. This type of template is an automatic backup of the previous settings, created when you apply a new template.</para>
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
        /// <para>F1F16757-D31B-49CA-9BF4-305BAF******</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
