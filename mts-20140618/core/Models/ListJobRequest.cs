// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mts20140618.Models
{
    public class ListJobRequest : TeaModel {
        /// <summary>
        /// <para>The end of the time range to query. Specify the time in the ISO 8601 standard in the <c>YYYY-MM-DDThh:mm:ssZ</c> format. The time must be in UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2014-01-11T12:00:00Z</para>
        /// </summary>
        [NameInMap("EndOfJobCreatedTimeRange")]
        [Validation(Required=false)]
        public string EndOfJobCreatedTimeRange { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
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
        /// <para>The token that is used to retrieve the next page of the query results. You do not need to specify this parameter for the first request. You must specify the token that is obtained from the previous query as the value of NextPageToken.</para>
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
        /// <para>The ID of the MPS queue to which the job is submitted. To obtain the ID of an MPS queue, you can log on to the <a href="https://mps.console.aliyun.com/overview">MPS console</a> and choose <b>Global Settings</b> &gt; <b>MPS Queue and Callback</b> in the left-side navigation pane.</para>
        /// 
        /// <b>Example:</b>
        /// <para>88c6ca184c0e424d5w5b665e2a12****</para>
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
        /// <para>The beginning of the time range to query. Specify the time in the ISO 8601 standard in the <c>YYYY-MM-DDThh:mm:ssZ</c> format. The time must be in UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2014-01-10T12:00:00Z</para>
        /// </summary>
        [NameInMap("StartOfJobCreatedTimeRange")]
        [Validation(Required=false)]
        public string StartOfJobCreatedTimeRange { get; set; }

        /// <summary>
        /// <para>The state of the transcoding job. Default value: <b>All</b>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>All</b></description></item>
        /// <item><description><b>Submitted</b></description></item>
        /// <item><description><b>Transcoding</b></description></item>
        /// <item><description><b>TranscodeSuccess</b></description></item>
        /// <item><description><b>TranscodeFail</b></description></item>
        /// <item><description><b>TranscodeCancelled</b></description></item>
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
