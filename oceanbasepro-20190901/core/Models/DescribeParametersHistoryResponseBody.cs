// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OceanBasePro20190901.Models
{
    public class DescribeParametersHistoryResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>EE205C00-30E4-XXXX-XXXX-87E3A8A2AA0C</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The list of parameter modification records.</para>
        /// </summary>
        [NameInMap("Respond")]
        [Validation(Required=false)]
        public DescribeParametersHistoryResponseBodyRespond Respond { get; set; }
        public class DescribeParametersHistoryResponseBodyRespond : TeaModel {
            /// <summary>
            /// <para>The number of the page to return.    </para>
            /// <list type="bullet">
            /// <item><description>Start value: 1   </description></item>
            /// <item><description>Default value: 1</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            /// <summary>
            /// <para>The information about parameters.</para>
            /// </summary>
            [NameInMap("Parameters")]
            [Validation(Required=false)]
            public List<DescribeParametersHistoryResponseBodyRespondParameters> Parameters { get; set; }
            public class DescribeParametersHistoryResponseBodyRespondParameters : TeaModel {
                /// <summary>
                /// <para>The time when the parameter modification was initiated.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2024-11-26T08:03:34Z</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// <para>The resource ID of the parameter type. When you called this operation to query the modification history of cluster parameters, the value is DEFAULT_DIMENSION_VALUE. When you called this operation to query the modification history of tenant parameters, the value is the tenant ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>t69uo********</para>
                /// </summary>
                [NameInMap("DimensionValue")]
                [Validation(Required=false)]
                public string DimensionValue { get; set; }

                /// <summary>
                /// <para>The name of the parameter.</para>
                /// 
                /// <b>Example:</b>
                /// <para>connect_timeout</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The value of the parameter after the modification.</para>
                /// 
                /// <b>Example:</b>
                /// <para>30</para>
                /// </summary>
                [NameInMap("NewValue")]
                [Validation(Required=false)]
                public string NewValue { get; set; }

                /// <summary>
                /// <para>The value of the parameter before the modification.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("OldValue")]
                [Validation(Required=false)]
                public string OldValue { get; set; }

                /// <summary>
                /// <para>The modification status of the parameter. Valid values: </para>
                /// <list type="bullet">
                /// <item><description>APPLIED: The parameter was modified.</description></item>
                /// <item><description>SCHEDULING: The parameter was to be modified.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>APPLIED</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>The time when the parameter modification took effect.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2024-11-26T08:03:34Z</para>
                /// </summary>
                [NameInMap("UpdateTime")]
                [Validation(Required=false)]
                public string UpdateTime { get; set; }

            }

            /// <summary>
            /// <para>The total count, which takes effect in a pagination query.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

    }

}
