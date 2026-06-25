// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SchedulerX320240624.Models
{
    public class SyncJobsRequest : TeaModel {
        /// <summary>
        /// <para>A list of job IDs.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("JobIds")]
        [Validation(Required=false)]
        public List<long?> JobIds { get; set; }

        /// <summary>
        /// <para>The name of the source application that contains the jobs.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test-source</para>
        /// </summary>
        [NameInMap("OriginalAppName")]
        [Validation(Required=false)]
        public string OriginalAppName { get; set; }

        /// <summary>
        /// <para>The ID of the source cluster that contains the jobs.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxljob-00ed7f0d742b1</para>
        /// </summary>
        [NameInMap("OriginalClusterId")]
        [Validation(Required=false)]
        public string OriginalClusterId { get; set; }

        /// <summary>
        /// <para>The name of the destination application.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test-target</para>
        /// </summary>
        [NameInMap("TargetAppName")]
        [Validation(Required=false)]
        public string TargetAppName { get; set; }

        /// <summary>
        /// <para>The ID of the destination cluster.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxljob-008bfb1541111</para>
        /// </summary>
        [NameInMap("TargetClusterId")]
        [Validation(Required=false)]
        public string TargetClusterId { get; set; }

    }

}
