// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class ListClusterChecksResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of checks.</para>
        /// </summary>
        [NameInMap("checks")]
        [Validation(Required=false)]
        public List<ListClusterChecksResponseBodyChecks> Checks { get; set; }
        public class ListClusterChecksResponseBodyChecks : TeaModel {
            /// <summary>
            /// <para>The check ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1697100584236600453-ce0da5a1d627e4e9e9f96cae8ad07****-clustercheck-lboto</para>
            /// </summary>
            [NameInMap("check_id")]
            [Validation(Required=false)]
            public string CheckId { get; set; }

            /// <summary>
            /// <para>The creation time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-04-11T02:56:02.565982623Z</para>
            /// </summary>
            [NameInMap("created_at")]
            [Validation(Required=false)]
            public string CreatedAt { get; set; }

            /// <summary>
            /// <para>The completion time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-04-11T02:56:18.881054031Z</para>
            /// </summary>
            [NameInMap("finished_at")]
            [Validation(Required=false)]
            public string FinishedAt { get; set; }

            /// <summary>
            /// <para>The check status message.</para>
            /// 
            /// <b>Example:</b>
            /// <para>task succeed</para>
            /// </summary>
            [NameInMap("message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            /// <summary>
            /// <para>The check status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Succeeded</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The check type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ClusterUpgrade</para>
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

    }

}
