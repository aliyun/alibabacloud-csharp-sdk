// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class DescribeEdgeContainerAppStatsRequest : TeaModel {
        /// <summary>
        /// <para>Basic information about the application.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>app-xxxx</para>
        /// </summary>
        [NameInMap("App")]
        [Validation(Required=false)]
        public string App { get; set; }

        /// <summary>
        /// <para>The end time to retrieve data. The date must be in ISO 8601 format and use UTC. The format is yyyy-MM-ddTHH:mm:ssZ.</para>
        /// <remarks>
        /// <para>The end time must be later than the start time.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2024-09-02T16:04:05Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The metric fields.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pod_ready_rate</para>
        /// </summary>
        [NameInMap("Fields")]
        [Validation(Required=false)]
        public string Fields { get; set; }

        /// <summary>
        /// <para>The Internet Service Provider (ISP).</para>
        /// 
        /// <b>Example:</b>
        /// <para>telecom,unicom,mobile</para>
        /// </summary>
        [NameInMap("Isp")]
        [Validation(Required=false)]
        public string Isp { get; set; }

        /// <summary>
        /// <para>The region.</para>
        /// 
        /// <b>Example:</b>
        /// <para>huizhou</para>
        /// </summary>
        [NameInMap("Locate")]
        [Validation(Required=false)]
        public string Locate { get; set; }

        /// <summary>
        /// <para>The start time. The date must be in ISO 8601 format and use UTC. The format is yyyy-MM-ddTHH:mm:ssZ.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2024-09-02T15:04:05Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// <para>The tenant.</para>
        /// 
        /// <b>Example:</b>
        /// <para>t-xxxx</para>
        /// </summary>
        [NameInMap("Tenant")]
        [Validation(Required=false)]
        public string Tenant { get; set; }

    }

}
