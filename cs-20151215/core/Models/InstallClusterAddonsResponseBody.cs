// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class InstallClusterAddonsResponseBody : TeaModel {
        /// <summary>
        /// <para>集群ID。</para>
        /// 
        /// <b>Example:</b>
        /// <para>c82e6987e2961451182edacd74faf****</para>
        /// </summary>
        [NameInMap("cluster_id")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// <para>请求ID。</para>
        /// 
        /// <b>Example:</b>
        /// <para>687C5BAA-D103-4993-884B-C35E4314****</para>
        /// </summary>
        [NameInMap("request_id")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>任务ID。</para>
        /// 
        /// <b>Example:</b>
        /// <para>T-5a54309c80282e39ea0****</para>
        /// </summary>
        [NameInMap("task_id")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

    }

}
