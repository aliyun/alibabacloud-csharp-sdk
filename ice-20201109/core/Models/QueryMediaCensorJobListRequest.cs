// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class QueryMediaCensorJobListRequest : TeaModel {
        /// <summary>
        /// <para>The end of the time range to query.</para>
        /// <list type="bullet">
        /// <item><description>Specify the time in the ISO 8601 standard. The time must be in UTC.</description></item>
        /// <item><description>Format: yyyy-MM-ddTHH:mm:ssZ.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>2022-02-14T02:16:07Z</para>
        /// </summary>
        [NameInMap("EndOfJobCreatedTimeRange")]
        [Validation(Required=false)]
        public string EndOfJobCreatedTimeRange { get; set; }

        /// <summary>
        /// <para>The IDs of the content moderation jobs. You can obtain the ID of a content moderation job from the response parameters of the SubmitMediaCensorJob operation. Separate multiple IDs with commas (,).</para>
        /// 
        /// <b>Example:</b>
        /// <para>fa9c34be3bcf42919ac4d1775239****,78dc866518b843259669df58ed30****</para>
        /// </summary>
        [NameInMap("JobIds")]
        [Validation(Required=false)]
        public string JobIds { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// <list type="bullet">
        /// <item><description>Default value: <b>30</b>.</description></item>
        /// <item><description>Valid values: <b>1 to 300</b>.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaximumPageSize")]
        [Validation(Required=false)]
        public long? MaximumPageSize { get; set; }

        /// <summary>
        /// <para>The pagination token that is used in the next request to retrieve a new page of results. You do not need to specify this parameter for the first request. You must specify the token that is obtained from the previous query as the value of NextToken.</para>
        /// 
        /// <b>Example:</b>
        /// <para>79aff3eee82242e092899db5f669</para>
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
        /// <para>The ID of the ApsaraVideo Media Processing (MPS) queue to which the jobs were submitted.</para>
        /// 
        /// <b>Example:</b>
        /// <para>c5b30b7c0d0e4a0abde1d5f9e751****</para>
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
        /// <para>The beginning of the time range to query.</para>
        /// <list type="bullet">
        /// <item><description>Specify the time in the ISO 8601 standard. The time must be in UTC.</description></item>
        /// <item><description>Format: yyyy-MM-ddTHH:mm:ssZ.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>2021-12-22T03:48:05Z</para>
        /// </summary>
        [NameInMap("StartOfJobCreatedTimeRange")]
        [Validation(Required=false)]
        public string StartOfJobCreatedTimeRange { get; set; }

        /// <summary>
        /// <para>The state of the jobs that you want to query. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>All</b>: all jobs.</description></item>
        /// <item><description><b>Queuing</b>: the jobs that are waiting in the queue.</description></item>
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
