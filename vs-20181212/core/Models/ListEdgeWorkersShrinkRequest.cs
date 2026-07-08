// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vs20181212.Models
{
    public class ListEdgeWorkersShrinkRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required for renewal scenarios.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2025-05-14T15:20:37+08:00</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The list of cluster IDs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;hive-4fbf3928d40e43948b98acdb4fb5aaed&quot;]</para>
        /// </summary>
        [NameInMap("HiveIds")]
        [Validation(Required=false)]
        public string HiveIdsShrink { get; set; }

        /// <summary>
        /// <para>The list of payload IDs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ew-xxxxxx</para>
        /// </summary>
        [NameInMap("InstanceIds")]
        [Validation(Required=false)]
        public string InstanceIdsShrink { get; set; }

        /// <summary>
        /// <para>The page number of the query. The value starts from 1. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries to return on each page for a paged query. The maximum value is 100. Default value: 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The list of package IDs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;pk-4fbf3928d40e43948b98acdb4fb5aaed&quot;]</para>
        /// </summary>
        [NameInMap("PlanIds")]
        [Validation(Required=false)]
        public string PlanIdsShrink { get; set; }

        /// <summary>
        /// <para>Specification</para>
        /// 
        /// <b>Example:</b>
        /// <para>ew.gn8t6xlarge-rb.x1p</para>
        /// </summary>
        [NameInMap("Spec")]
        [Validation(Required=false)]
        public string Spec { get; set; }

        /// <summary>
        /// <para>The parameter for filtering by time range. The time must be in ISO 8601 format and use UTC. The format is yyyy-MM-ddTHH:mm:ssZ.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-05-25T06:35:26+08:00</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// <para>The list of statuses.</para>
        /// </summary>
        [NameInMap("Statuses")]
        [Validation(Required=false)]
        public string StatusesShrink { get; set; }

    }

}
