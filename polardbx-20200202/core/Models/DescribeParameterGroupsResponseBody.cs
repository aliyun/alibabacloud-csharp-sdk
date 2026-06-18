// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardbx20200202.Models
{
    public class DescribeParameterGroupsResponseBody : TeaModel {
        /// <summary>
        /// <para>The instance details.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeParameterGroupsResponseBodyData Data { get; set; }
        public class DescribeParameterGroupsResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The parameter template name.</para>
            /// </summary>
            [NameInMap("ParameterGroups")]
            [Validation(Required=false)]
            public List<DescribeParameterGroupsResponseBodyDataParameterGroups> ParameterGroups { get; set; }
            public class DescribeParameterGroupsResponseBodyDataParameterGroups : TeaModel {
                /// <summary>
                /// <para>Indicates whether a forced restart of CN is required.</para>
                /// </summary>
                [NameInMap("CnForceRestart")]
                [Validation(Required=false)]
                public bool? CnForceRestart { get; set; }

                /// <summary>
                /// <para>The number of CN parameters.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("CnParamCount")]
                [Validation(Required=false)]
                public int? CnParamCount { get; set; }

                /// <summary>
                /// <para>The database type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>polarx</para>
                /// </summary>
                [NameInMap("DbType")]
                [Validation(Required=false)]
                public string DbType { get; set; }

                /// <summary>
                /// <para>The database engine version.</para>
                /// 
                /// <b>Example:</b>
                /// <para>5.7</para>
                /// </summary>
                [NameInMap("DbVersion")]
                [Validation(Required=false)]
                public string DbVersion { get; set; }

                /// <summary>
                /// <para>Indicates whether a forced restart of DN is required.</para>
                /// </summary>
                [NameInMap("DnForceRestart")]
                [Validation(Required=false)]
                public bool? DnForceRestart { get; set; }

                /// <summary>
                /// <para>The number of DN parameters.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("DnParamCount")]
                [Validation(Required=false)]
                public int? DnParamCount { get; set; }

                /// <summary>
                /// <para>The time when the account was created.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2024-12-19T16:41:31+08:00</para>
                /// </summary>
                [NameInMap("GmtCreated")]
                [Validation(Required=false)]
                public string GmtCreated { get; set; }

                /// <summary>
                /// <para>The modification time, in timestamp format.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1605079985000</para>
                /// </summary>
                [NameInMap("GmtModified")]
                [Validation(Required=false)]
                public string GmtModified { get; set; }

                /// <summary>
                /// <para>The parameter template ID.</para>
                /// <remarks>
                /// <para>You can call the <a href="https://help.aliyun.com/document_detail/207178.html">DescribeParameterGroups</a> operation to query the details of all parameter templates in the specified region, including the parameter template ID.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>rpg-s1y1xy06****fqs7y</para>
                /// </summary>
                [NameInMap("ParameterGroupId")]
                [Validation(Required=false)]
                public string ParameterGroupId { get; set; }

                /// <summary>
                /// <para>The parameter template name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>dstest_api_new</para>
                /// </summary>
                [NameInMap("ParameterGroupName")]
                [Validation(Required=false)]
                public string ParameterGroupName { get; set; }

                /// <summary>
                /// <para>The parameter templatetype.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("ParameterGroupType")]
                [Validation(Required=false)]
                public string ParameterGroupType { get; set; }

                /// <summary>
                /// <para>The instance edition. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>enterprise</b>: Enterprise Edition.</description></item>
                /// <item><description><b>standard</b>: Standard Edition.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>enterprise</para>
                /// </summary>
                [NameInMap("Series")]
                [Validation(Required=false)]
                public string Series { get; set; }

            }

            /// <summary>
            /// <para>The request ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1E5DCFFC-A00D-****-836E-73318F8CA577</para>
            /// </summary>
            [NameInMap("RequestId")]
            [Validation(Required=false)]
            public string RequestId { get; set; }

        }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>9B2F3840-5C98-475C-B269-2D5C3A31797C</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
