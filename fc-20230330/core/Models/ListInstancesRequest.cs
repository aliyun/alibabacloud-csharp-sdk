// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FC20230330.Models
{
    public class ListInstancesRequest : TeaModel {
        /// <summary>
        /// <para>The end time of the query range, specified as a UNIX timestamp in milliseconds.</para>
        /// </summary>
        [NameInMap("endTimeMs")]
        [Validation(Required=false)]
        public long? EndTimeMs { get; set; }

        /// <summary>
        /// <para>A list of instance IDs to return.</para>
        /// </summary>
        [NameInMap("instanceIds")]
        [Validation(Required=false)]
        public List<string> InstanceIds { get; set; }

        /// <summary>
        /// <para>An array of instance statuses. The operation returns only instances whose status is in this array.</para>
        /// </summary>
        [NameInMap("instanceStatus")]
        [Validation(Required=false)]
        public List<string> InstanceStatus { get; set; }

        /// <summary>
        /// <para>The maximum number of instances to return.</para>
        /// </summary>
        [NameInMap("limit")]
        [Validation(Required=false)]
        public string Limit { get; set; }

        /// <summary>
        /// <para>The function version or alias.</para>
        /// 
        /// <b>Example:</b>
        /// <para>LATEST</para>
        /// </summary>
        [NameInMap("qualifier")]
        [Validation(Required=false)]
        public string Qualifier { get; set; }

        /// <summary>
        /// <para>The token that specifies where to start the query. It is returned in a truncated response and can be used to retrieve the next page of results.</para>
        /// </summary>
        [NameInMap("startKey")]
        [Validation(Required=false)]
        public string StartKey { get; set; }

        /// <summary>
        /// <para>The start time of the query range, specified as a UNIX timestamp in milliseconds.</para>
        /// </summary>
        [NameInMap("startTimeMs")]
        [Validation(Required=false)]
        public long? StartTimeMs { get; set; }

        /// <summary>
        /// <para>Specifies whether to list all active instances.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("withAllActive")]
        [Validation(Required=false)]
        public bool? WithAllActive { get; set; }

    }

}
