// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class ListActionRecordsRequest : TeaModel {
        /// <summary>
        /// <para>Filters records by the name of the change operation. Separate multiple names with commas.</para>
        /// 
        /// <b>Example:</b>
        /// <para>RestartInstance</para>
        /// </summary>
        [NameInMap("actionNames")]
        [Validation(Required=false)]
        public string ActionNames { get; set; }

        /// <summary>
        /// <para>The upper bound of the query range for the change start time. The value is a UNIX timestamp in milliseconds. If you do not specify this parameter, the current time is used.</para>
        /// </summary>
        [NameInMap("endTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        /// <summary>
        /// <para>The display type of change records. Default value: ACTION_RECORD.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ACTION_RECORD</para>
        /// </summary>
        [NameInMap("filter")]
        [Validation(Required=false)]
        public string Filter { get; set; }

        /// <summary>
        /// <para>The page number of the returned results.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("page")]
        [Validation(Required=false)]
        public int? Page { get; set; }

        /// <summary>
        /// <para>Filters records by the ID of the request that triggered the change.</para>
        /// 
        /// <b>Example:</b>
        /// <para>request-123</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The number of records returned per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("size")]
        [Validation(Required=false)]
        public int? Size { get; set; }

        /// <summary>
        /// <para>The lower bound of the query range for the change start time. The value is a UNIX timestamp in milliseconds.</para>
        /// </summary>
        [NameInMap("startTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

        /// <summary>
        /// <para>Filters records by the ID of the user that triggered the change.</para>
        /// 
        /// <b>Example:</b>
        /// <para>user-123</para>
        /// </summary>
        [NameInMap("userId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
