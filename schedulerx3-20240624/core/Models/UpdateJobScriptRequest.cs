// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SchedulerX320240624.Models
{
    public class UpdateJobScriptRequest : TeaModel {
        /// <summary>
        /// <para>The application name.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test-app</para>
        /// </summary>
        [NameInMap("AppName")]
        [Validation(Required=false)]
        public string AppName { get; set; }

        /// <summary>
        /// <para>The cluster ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxljob-b6ec1xxxx</para>
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// <para>The task ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>74</para>
        /// </summary>
        [NameInMap("JobId")]
        [Validation(Required=false)]
        public long? JobId { get; set; }

        /// <summary>
        /// <para>The script content.</para>
        /// 
        /// <b>Example:</b>
        /// <para>#!/bin/bash
        /// echo &quot;xxl-job: hello shell&quot;</para>
        /// <para>echo &quot;Script path: $0&quot;
        /// echo &quot;Task parameter: $1&quot;
        /// echo &quot;Shard index = $2&quot;
        /// echo &quot;Total shards = $3&quot;</para>
        /// <para>echo &quot;Good bye!&quot;
        /// exit 0</para>
        /// </summary>
        [NameInMap("ScriptContent")]
        [Validation(Required=false)]
        public string ScriptContent { get; set; }

        /// <summary>
        /// <para>The script version description.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>init version</para>
        /// </summary>
        [NameInMap("VersionDescription")]
        [Validation(Required=false)]
        public string VersionDescription { get; set; }

    }

}
