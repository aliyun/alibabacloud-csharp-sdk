// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class ResetScheduledPreloadJobRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the scheduled prefetch task.</para>
        /// <remarks>
        /// <para>Notice: The ID of the scheduled prefetch task. This parameter is required. You can obtain the ID from the response of CreateScheduledPreloadJob after creating a task, or query the ID of an existing task by calling GetScheduledPreloadJob or ListScheduledPreloadJobs..</para>
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
