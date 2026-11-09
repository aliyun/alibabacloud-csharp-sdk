// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Wss20211221.Models
{
    public class DescribeGroupsRequest : TeaModel {
        /// <summary>
        /// <para>The end time of the period.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-03-28T02:06:00Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        /// <summary>
        /// <para>The list of group resource types.</para>
        /// </summary>
        [NameInMap("GroupResourceTypes")]
        [Validation(Required=false)]
        public List<string> GroupResourceTypes { get; set; }

        /// <summary>
        /// <para>The group type.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DEFAULT</para>
        /// </summary>
        [NameInMap("GroupType")]
        [Validation(Required=false)]
        public string GroupType { get; set; }

        /// <summary>
        /// <para>The Lingxiao instance ID.</para>
        /// </summary>
        [NameInMap("InstanceIds")]
        [Validation(Required=false)]
        public List<string> InstanceIds { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public string MaxResults { get; set; }

        /// <summary>
        /// <para>The pagination token. Leave this parameter empty for the first request. For subsequent requests, use the <c>nextToken</c> value returned in the previous response.</para>
        /// 
        /// <b>Example:</b>
        /// <para>eyJvZmZzZXQiOjIwfQ==</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The list of resource IDs.</para>
        /// </summary>
        [NameInMap("ResourceIds")]
        [Validation(Required=false)]
        public List<string> ResourceIds { get; set; }

        /// <summary>
        /// <para>The start time of the period.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-03-25 10:26:44</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

        /// <summary>
        /// <para>The list of states.</para>
        /// </summary>
        [NameInMap("States")]
        [Validation(Required=false)]
        public List<string> States { get; set; }

        /// <summary>
        /// <para>The effective period used for the query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true/false</para>
        /// </summary>
        [NameInMap("TimeUsingPeriod")]
        [Validation(Required=false)]
        public bool? TimeUsingPeriod { get; set; }

    }

}
