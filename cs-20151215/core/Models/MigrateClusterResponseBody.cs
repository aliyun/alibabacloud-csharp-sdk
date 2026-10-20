// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class MigrateClusterResponseBody : TeaModel {
        /// <summary>
        /// <para>The cluster ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>c21e0591548ba4c10bdb535d657******</para>
        /// </summary>
        [NameInMap("cluster_id")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>687C5BAA-D103-4993-884B-C35E43******</para>
        /// </summary>
        [NameInMap("request_id")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The task ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>T-62ccd14aacb8db06ca******</para>
        /// </summary>
        [NameInMap("task_id")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

    }

}
