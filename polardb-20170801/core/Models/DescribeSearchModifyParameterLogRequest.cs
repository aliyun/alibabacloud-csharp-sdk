// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DescribeSearchModifyParameterLogRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the PolarDB for MySQL primary cluster. This ID is used to query the parameter modification history of the associated Search cluster. Before you call this operation, you must enable PolarSearch for the target cluster. You can add a search node on the Basic Information page of the cluster in the console. This operation is not applicable to clusters for which Search is not enabled.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pc-xxxxxxxx</para>
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// <para>The end time of the query in UTC. Format: yyyy-MM-ddTHH:mmZ. Only records with a modification time earlier than this time are returned. The end time cannot be earlier than the start time.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-10-14T02:00Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The start time of the query in UTC. Format: yyyy-MM-ddTHH:mmZ. Only records with a modification time later than this time are returned.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-10-14T01:00Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
