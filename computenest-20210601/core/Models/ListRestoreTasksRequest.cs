// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ComputeNest20210601.Models
{
    public class ListRestoreTasksRequest : TeaModel {
        /// <summary>
        /// <para>The filter.</para>
        /// </summary>
        [NameInMap("Filter")]
        [Validation(Required=false)]
        public List<ListRestoreTasksRequestFilter> Filter { get; set; }
        public class ListRestoreTasksRequestFilter : TeaModel {
            /// <summary>
            /// <para>The name of the filter. You can query by one or more filter names. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>RestoreTaskId: The restore job ID.</para>
            /// </description></item>
            /// <item><description><para>ServiceInstanceId: The service instance ID.</para>
            /// </description></item>
            /// <item><description><para>Status: The status.</para>
            /// </description></item>
            /// <item><description><para>StartTime: The start time.</para>
            /// </description></item>
            /// <item><description><para>EndTime: The end time.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>ServiceInstanceId</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>A list of filter values.</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public List<string> Value { get; set; }

        }

        /// <summary>
        /// <para>The number of entries to return on each page. Maximum value: 100. Default value: 20.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The token that is used to retrieve the next page of results.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AAAAAWns8w4MmhzeptXVRG0PUEU=</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

    }

}
