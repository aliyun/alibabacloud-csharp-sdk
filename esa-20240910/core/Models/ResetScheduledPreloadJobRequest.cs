// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class ResetScheduledPreloadJobRequest : TeaModel {
        /// <summary>
        /// <para>The scheduled preload job ID.</para>
        /// <remarks>
        /// <para>Notice: The scheduled preload job ID. This parameter is required. You can obtain the ID from the response of CreateScheduledPreloadJob after creating a job, or query existing job IDs by calling GetScheduledPreloadJob or ListScheduledPreloadJobs.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>665d3af3621bccf3fe29e1a4</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public string Id { get; set; }

    }

}
