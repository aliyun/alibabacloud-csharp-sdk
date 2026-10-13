// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RdsAi20250507.Models
{
    public class ListLLMTokenUsageRequest : TeaModel {
        /// <summary>
        /// <para>The end time of the inspection in UTC. Specify the time in the ISO 8601 standard. Format: YYYY-MM-DDTHH:mm:ssZ. The end time must be at least 2 hours later than the start time.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-02-03T02:10:00Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The instance ID of the AI application.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ra-supabase-8moov5lxba****</para>
        /// </summary>
        [NameInMap("InstanceName")]
        [Validation(Required=false)]
        public string InstanceName { get; set; }

        /// <summary>
        /// <para>The model to query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>qwen-flash</para>
        /// </summary>
        [NameInMap("Model")]
        [Validation(Required=false)]
        public string Model { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-beijing</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The start time of the inspection in UTC. Specify the time in the ISO 8601 standard. Format: YYYY-MM-DDTHH:mm:ssZ.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-03-31T16:00:00Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
