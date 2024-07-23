// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mts20140618.Models
{
    public class QueryFpShotJobListRequest : TeaModel {
        /// <summary>
        /// <para>The end of the time range within which the jobs to be queried were created. </para>
        /// <list type="bullet">
        /// <item><description>Specify the time in the ISO 8601 standard in the</description></item>
        /// <item><description>YYYY-MM-DDThh:mm:ssZ format. The time must be in UTC.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>2022-02-14T02:16:07Z</para>
        /// </summary>
        [NameInMap("EndOfJobCreatedTimeRange")]
        [Validation(Required=false)]
        public string EndOfJobCreatedTimeRange { get; set; }

        /// <summary>
        /// <para>The ID of the media fingerprint analysis job that you want to query. To view the job ID, log on to the <a href="https://mps.console.aliyun.com/overview">ApsaraVideo Media Processing (MPS) console</a>, click <b>Tasks</b> in the left-side navigation pane, and then click the <b>Video DNA</b> tab on the Tasks page. You can query up to 10 media fingerprint analysis jobs at a time. Separate multiple job IDs with commas (,).</para>
        /// 
        /// <b>Example:</b>
        /// <para>88c6ca184c0e47098a5b665e2a12****</para>
        /// </summary>
        [NameInMap("JobIds")]
        [Validation(Required=false)]
        public string JobIds { get; set; }

        /// <summary>
        /// <para>The maximum number of entries to return on each page. </para>
        /// <list type="bullet">
        /// <item><description>Default value: <b>10</b>.</description></item>
        /// <item><description>Valid values: <b>1 to 100</b>.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("MaximumPageSize")]
        [Validation(Required=false)]
        public long? MaximumPageSize { get; set; }

        /// <summary>
        /// <para>The token that is used to retrieve the next page of the query results. You do not need to specify this parameter in the first request. The response to the first request contains this parameter, which you add to the next request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>16f01ad6175e4230ac42bb5182cd****</para>
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
        /// <para>The ID of the MPS queue. To view the ID of the MPS queue, log on to the <a href="https://mps.console.aliyun.com/overview">MPS console</a> and choose <b>Global Settings</b> &gt; <b>Pipelines</b> in the left-side navigation pane.</para>
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
        /// <para>The beginning of the time range within which the jobs to be queried were created. </para>
        /// <list type="bullet">
        /// <item><description>Specify the time in the ISO 8601 standard in the</description></item>
        /// <item><description>YYYY-MM-DDThh:mm:ssZ format. The time must be in UTC.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>2021-12-22T03:48:05Z</para>
        /// </summary>
        [NameInMap("StartOfJobCreatedTimeRange")]
        [Validation(Required=false)]
        public string StartOfJobCreatedTimeRange { get; set; }

        /// <summary>
        /// <para>The status of the jobs to be queried. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>All</b>: all jobs.</description></item>
        /// <item><description><b>Queuing</b>: the jobs that are being queued.</description></item>
        /// <item><description><b>Analysing</b>: the jobs that are in progress.</description></item>
        /// <item><description><b>Fail</b>: failed jobs.</description></item>
        /// <item><description><b>Success</b>: successful jobs.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>All</para>
        /// </summary>
        [NameInMap("State")]
        [Validation(Required=false)]
        public string State { get; set; }

    }

}
