// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DescribeParameterGroupResponseBody : TeaModel {
        /// <summary>
        /// <para>Details about the parameter templates.</para>
        /// </summary>
        [NameInMap("ParameterGroup")]
        [Validation(Required=false)]
        public List<DescribeParameterGroupResponseBodyParameterGroup> ParameterGroup { get; set; }
        public class DescribeParameterGroupResponseBodyParameterGroup : TeaModel {
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
            /// <para>Indicates whether to restart the cluster when this parameter template is applied. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: A restart is not required.</description></item>
            /// <item><description><b>1</b>: A restart is required.</description></item>
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
            /// <para>Details about the parameters.</para>
            /// </summary>
            [NameInMap("ParameterDetail")]
            [Validation(Required=false)]
            public List<DescribeParameterGroupResponseBodyParameterGroupParameterDetail> ParameterDetail { get; set; }
            public class DescribeParameterGroupResponseBodyParameterGroupParameterDetail : TeaModel {
                /// <summary>
                /// <para>The name of the parameter.</para>
                /// 
                /// <b>Example:</b>
                /// <para>back_log</para>
                /// </summary>
                [NameInMap("ParamName")]
                [Validation(Required=false)]
                public string ParamName { get; set; }

                /// <summary>
                /// <para>The value of the parameter.</para>
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
            /// <item><description><b>0</b>: the default parameter template.</description></item>
            /// <item><description><b>1</b>: a custom parameter template.</description></item>
            /// <item><description><b>2</b>: an automatic backup parameter template. After you apply this type of template, the system automatically backs up the original parameter settings and saves the backup as a template.</description></item>
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
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>F1F16757-D31B-49CA-9BF4-305BAF******</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
