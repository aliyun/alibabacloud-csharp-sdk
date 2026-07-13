// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BDRC20230808.Models
{
    public class DescribeTasksRequest : TeaModel {
        /// <summary>
        /// <para>The maximum number of entries to return per page. The valid range is 10 to 500. If this parameter is omitted or its value is less than 10, a default value of 10 is used. Values greater than 500 are treated as 500.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>A pagination token. To retrieve the next page of results, set this parameter to the <c>NextToken</c> value from the response of the previous API call. For more information, see the API description above.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cae**********699</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>Specifies the status of tasks to query. If this parameter is omitted, the API returns tasks in all states. Valid values: <c>CREATED</c>, <c>RUNNING</c>, <c>COMPLETE</c>, <c>FAILED</c>, <c>EXPIRED</c>, and <c>CANCELED</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>RUNNING</para>
        /// </summary>
        [NameInMap("TaskStatus")]
        [Validation(Required=false)]
        public string TaskStatus { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>UPDATE_RESOURCES</para>
        /// </summary>
        [NameInMap("TaskType")]
        [Validation(Required=false)]
        public string TaskType { get; set; }

    }

}
