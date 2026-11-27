// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pai_dlc20201203.Models
{
    public class GetRLLogContextRequest : TeaModel {
        /// <summary>
        /// <para>The text of the anchor log. The fallback path locates the log by prefix matching. This value is derived from Fatal[].RawMessage.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[rank0]: torch.OutOfMemoryError: CUDA out of memory. Tried to allocate 2.00 GiB</para>
        /// </summary>
        [NameInMap("AnchorMessage")]
        [Validation(Required=false)]
        public string AnchorMessage { get; set; }

        /// <summary>
        /// <para>The timestamp of the anchor log line in UTC RFC 3339 format with second precision.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-08-05T16:36:55Z</para>
        /// </summary>
        [NameInMap("AnchorTime")]
        [Validation(Required=false)]
        public string AnchorTime { get; set; }

        /// <summary>
        /// <para>The agent_collect_time of the anchor line as a nanosecond string. This value is derived from Fatal[].CollectNs. If provided, the exact path is used.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1785947815190122847</para>
        /// </summary>
        [NameInMap("CollectTime")]
        [Validation(Required=false)]
        public string CollectTime { get; set; }

    }

}
