// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardbx20200202.Models
{
    public class DescribeParameterGroupsResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeParameterGroupsResponseBodyData Data { get; set; }
        public class DescribeParameterGroupsResponseBodyData : TeaModel {
            [NameInMap("ParameterGroups")]
            [Validation(Required=false)]
            public List<DescribeParameterGroupsResponseBodyDataParameterGroups> ParameterGroups { get; set; }
            public class DescribeParameterGroupsResponseBodyDataParameterGroups : TeaModel {
                [NameInMap("CnForceRestart")]
                [Validation(Required=false)]
                public bool? CnForceRestart { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("CnParamCount")]
                [Validation(Required=false)]
                public int? CnParamCount { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>polarx</para>
                /// </summary>
                [NameInMap("DbType")]
                [Validation(Required=false)]
                public string DbType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>5.7</para>
                /// </summary>
                [NameInMap("DbVersion")]
                [Validation(Required=false)]
                public string DbVersion { get; set; }

                [NameInMap("DnForceRestart")]
                [Validation(Required=false)]
                public bool? DnForceRestart { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("DnParamCount")]
                [Validation(Required=false)]
                public int? DnParamCount { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2024-12-19T16:41:31+08:00</para>
                /// </summary>
                [NameInMap("GmtCreated")]
                [Validation(Required=false)]
                public string GmtCreated { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1605079985000</para>
                /// </summary>
                [NameInMap("GmtModified")]
                [Validation(Required=false)]
                public string GmtModified { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>rpg-s1y1xy06****fqs7y</para>
                /// </summary>
                [NameInMap("ParameterGroupId")]
                [Validation(Required=false)]
                public string ParameterGroupId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>dstest_api_new</para>
                /// </summary>
                [NameInMap("ParameterGroupName")]
                [Validation(Required=false)]
                public string ParameterGroupName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("ParameterGroupType")]
                [Validation(Required=false)]
                public string ParameterGroupType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>enterprise</para>
                /// </summary>
                [NameInMap("Series")]
                [Validation(Required=false)]
                public string Series { get; set; }

            }

            /// <summary>
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
