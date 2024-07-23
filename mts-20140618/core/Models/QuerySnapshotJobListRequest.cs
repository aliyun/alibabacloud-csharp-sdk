// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mts20140618.Models
{
    public class QuerySnapshotJobListRequest : TeaModel {
        /// <summary>
        /// <para>The snapshot configuration.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2014-01-12T12:00:00Z</para>
        /// </summary>
        [NameInMap("EndOfJobCreatedTimeRange")]
        [Validation(Required=false)]
        public string EndOfJobCreatedTimeRange { get; set; }

        /// <summary>
        /// <para>The ID of the MPS queue to which the snapshot jobs that you want to query are submitted. To obtain the ID, you can log on to the <b>MPS console</b> and choose <b>Global Settings</b> &gt; <b>Pipelines</b> in the left-side navigation pane.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("MaximumPageSize")]
        [Validation(Required=false)]
        public long? MaximumPageSize { get; set; }

        /// <summary>
        /// <para>The end of the time range within which the creation time of snapshot jobs to be queried is.</para>
        /// <list type="bullet">
        /// <item><description>Specify the time in the ISO 8601 standard in the</description></item>
        /// <item><description>YYYY-MM-DDThh:mm:ssZ format. The time must be in UTC.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>cc6cbef8e8d5481ca536f5d2a466****</para>
        /// </summary>
        [NameInMap("NextPageToken")]
        [Validation(Required=false)]
        public string NextPageToken { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The start time for taking snapshots. Unit: milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>b11c171cced04565b1f38f1ecc39****</para>
        /// </summary>
        [NameInMap("PipelineId")]
        [Validation(Required=false)]
        public string PipelineId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The beginning of the time range within which the creation time of snapshot jobs to be queried is.</para>
        /// <list type="bullet">
        /// <item><description>Specify the time in the ISO 8601 standard in the</description></item>
        /// <item><description>YYYY-MM-DDThh:mm:ssZ format. The time must be in UTC.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>72dfa5e679ab4be9a3ed9974c736****</para>
        /// </summary>
        [NameInMap("SnapshotJobIds")]
        [Validation(Required=false)]
        public string SnapshotJobIds { get; set; }

        /// <summary>
        /// <para>The time when the job was created.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2014-01-10T12:00:00Z</para>
        /// </summary>
        [NameInMap("StartOfJobCreatedTimeRange")]
        [Validation(Required=false)]
        public string StartOfJobCreatedTimeRange { get; set; }

        /// <summary>
        /// <para>The information about the snapshot jobs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Snapshoting</para>
        /// </summary>
        [NameInMap("State")]
        [Validation(Required=false)]
        public string State { get; set; }

    }

}
