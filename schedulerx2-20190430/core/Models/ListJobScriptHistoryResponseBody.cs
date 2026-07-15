// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Schedulerx220190430.Models
{
    public class ListJobScriptHistoryResponseBody : TeaModel {
        /// <summary>
        /// <para>The status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <para>The information about the jobs.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListJobScriptHistoryResponseBodyData Data { get; set; }
        public class ListJobScriptHistoryResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The information about the job\&quot;s historical scripts.</para>
            /// </summary>
            [NameInMap("JobScriptHistoryInfos")]
            [Validation(Required=false)]
            public List<ListJobScriptHistoryResponseBodyDataJobScriptHistoryInfos> JobScriptHistoryInfos { get; set; }
            public class ListJobScriptHistoryResponseBodyDataJobScriptHistoryInfos : TeaModel {
                /// <summary>
                /// <para>The creation time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2025-03-12 14:52:42</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// <para>The creator.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1272118248844842</para>
                /// </summary>
                [NameInMap("Creator")]
                [Validation(Required=false)]
                public string Creator { get; set; }

                /// <summary>
                /// <para>The script content.</para>
                /// 
                /// <b>Example:</b>
                /// <para>#!/bin/bash</para>
                /// <h1>The following are built-in variables provided by the system to retrieve job runtime information</h1>
                /// <para>echo &quot;Job parameters: #{schedulerx.jobParameters}&quot;
                /// echo &quot;Sharding ID: #{schedulerx.shardingId}&quot;
                /// echo &quot;Sharding parameters: #{schedulerx.shardingParameters}&quot;
                /// echo &quot;Total shards: #{schedulerx.shardingNum}&quot;
                /// echo &quot;Retry attempts: #{schedulerx.attempt}&quot;
                /// echo &quot;Trigger type: #{schedulerx.triggerType}&quot;
                /// echo &quot;Schedule timestamp: #{schedulerx.scheduleTime}&quot;
                /// echo &quot;Data timestamp: #{schedulerx.dataTime}&quot;</para>
                /// <h1>The last line of output will be returned as the result</h1>
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
                /// <para>init version</para>
                /// </summary>
                [NameInMap("VersionesDescription")]
                [Validation(Required=false)]
                public string VersionesDescription { get; set; }

            }

        }

        /// <summary>
        /// <para>The additional information returned only if an error occurs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>job is not existed, jobId=302</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4F68ABED-AC31-4412-9297-D9A8F0401108</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful. Valid values:</para>
        /// <para>true</para>
        /// <para>false</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
