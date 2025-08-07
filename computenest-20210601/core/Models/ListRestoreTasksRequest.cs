// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ComputeNest20210601.Models
{
    public class ListRestoreTasksRequest : TeaModel {
        /// <summary>
        /// <para>The list of the filters.</para>
        /// </summary>
        [NameInMap("Filter")]
        [Validation(Required=false)]
        public List<ListRestoreTasksRequestFilter> Filter { get; set; }
        public class ListRestoreTasksRequestFilter : TeaModel {
            /// <summary>
            /// <para>The parameter name of the filter. You can specify one or more parameter names to query services. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>RestoreTaskId: the ID of the restore task.</description></item>
            /// <item><description>ServiceInstanceId: The ID of the service instance.</description></item>
            /// <item><description>Status</description></item>
            /// <item><description>StartTime</description></item>
            /// <item><description>EndTime</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>ServiceInstanceId</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The parameter values of the filter.</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public List<string> Value { get; set; }

        }

        /// <summary>
        /// <para>The number of rows displayed per page in paginated queries. Maximum: 100 rows per page. Default: 20 rows.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>NextToken</para>
        /// 
        /// <b>Example:</b>
        /// <para>AAAAAWns8w4MmhzeptXVRG0PUEU=</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

    }

}
