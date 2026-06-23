// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class GetClusterCheckResponseBody : TeaModel {
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
        /// <para>The check items.</para>
        /// </summary>
        [NameInMap("check_items")]
        [Validation(Required=false)]
        public Dictionary<string, List<Dictionary<string, object>>> CheckItems { get; set; }

        /// <summary>
        /// <para>The creation time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2023-10-16T08:31:20.292030178Z</para>
        /// </summary>
        [NameInMap("created_at")]
        [Validation(Required=false)]
        public string CreatedAt { get; set; }

        /// <summary>
        /// <para>The completion time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2023-10-16T08:35:20.292030178Z</para>
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
