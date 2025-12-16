// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Schedulerx220190430.Models
{
    public class UpdateJobScriptRequest : TeaModel {
        /// <summary>
        /// <para>The application ID. You can obtain the application ID on the Applications page in the SchedulerX console.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testSchedulerx.defaultGroup</para>
        /// </summary>
        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public string GroupId { get; set; }

        /// <summary>
        /// <para>The job ID. You can obtain the ID on the Tasks page in the SchedulerX console.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>301</para>
        /// </summary>
        [NameInMap("JobId")]
        [Validation(Required=false)]
        public long? JobId { get; set; }

        /// <summary>
        /// <para>The namespace ID. You can obtain the namespace ID on the Namespaces page in the SchedulerX console.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>adcfc35d-e2fe-4fe9-bbaa-20e90ffc****</para>
        /// </summary>
        [NameInMap("Namespace")]
        [Validation(Required=false)]
        public string Namespace { get; set; }

        /// <summary>
        /// <para>The source of the namespace. This parameter is required only for a special third party.</para>
        /// 
        /// <b>Example:</b>
        /// <para>schedulerx</para>
        /// </summary>
        [NameInMap("NamespaceSource")]
        [Validation(Required=false)]
        public string NamespaceSource { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The script content.</para>
        /// 
        /// <b>Example:</b>
        /// <para>#!/bin/bash</para>
        /// <h1>The following are predefined variables provided by the system. You can use them to obtain information about the job run.</h1>
        /// <para>echo &quot;Job parameters: #{schedulerx.jobParameters}&quot;
        /// echo &quot;Shard index: #{schedulerx.shardingId}&quot;
        /// echo &quot;Shard parameters: #{schedulerx.shardingParameters}&quot;
        /// echo &quot;Total number of shards: #{schedulerx.shardingNum}&quot;
        /// echo &quot;Current retry count: #{schedulerx.attempt}&quot;
        /// echo &quot;Trigger type: #{schedulerx.triggerType}&quot;
        /// echo &quot;Scheduled timestamp: #{schedulerx.scheduleTime}&quot;
        /// echo &quot;Data timestamp: #{schedulerx.dataTime}&quot;</para>
        /// <h1>The output of the last line will be returned as the result</h1>
        /// <para>echo &quot;hello world&quot;</para>
        /// <h1>exit 1 indicates failure</h1>
        /// <para>exit 0</para>
        /// </summary>
        [NameInMap("ScriptContent")]
        [Validation(Required=false)]
        public string ScriptContent { get; set; }

        /// <summary>
        /// <para>The description of the script version.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Print job running information</para>
        /// </summary>
        [NameInMap("VersionDescription")]
        [Validation(Required=false)]
        public string VersionDescription { get; set; }

    }

}
