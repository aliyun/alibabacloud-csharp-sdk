// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class RefreshVodObjectCachesResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the purge task. Multiple task IDs are separated by commas (,).
        /// The returned purge task IDs are merged based on the following rules:</para>
        /// <para>Purge tasks (at URL granularity) submitted for the same domain name within the same second are merged into a single RefreshTaskId.
        /// If purge tasks (at URL granularity) submitted for the same domain name within the same second exceed 2,000, they are merged into one RefreshTaskId per 2,000 tasks.</para>
        /// 
        /// <b>Example:</b>
        /// <para>70422*****2904</para>
        /// </summary>
        [NameInMap("RefreshTaskId")]
        [Validation(Required=false)]
        public string RefreshTaskId { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>D61E4801-EAFF-4A63-****-FBF6CE1CFD1C</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
