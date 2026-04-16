// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FC20230330.Models
{
    public class FunctionLockInfo : TeaModel {
        /// <summary>
        /// <para>锁定时间</para>
        /// 
        /// <b>Example:</b>
        /// <para>2025-04-05T10:00:00Z</para>
        /// </summary>
        [NameInMap("lockedAt")]
        [Validation(Required=false)]
        public string LockedAt { get; set; }

        /// <summary>
        /// <para>锁定方名称</para>
        /// 
        /// <b>Example:</b>
        /// <para>AgentRun</para>
        /// </summary>
        [NameInMap("lockedBy")]
        [Validation(Required=false)]
        public string LockedBy { get; set; }

        /// <summary>
        /// <para>锁定的资源类型列表</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;function&quot;, &quot;trigger&quot;, &quot;version&quot;, &quot;alias&quot;]</para>
        /// </summary>
        [NameInMap("lockedResources")]
        [Validation(Required=false)]
        public List<string> LockedResources { get; set; }

    }

}
