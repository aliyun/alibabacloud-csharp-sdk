// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CCC20200701.Models
{
    public class ListAttemptsRequest : TeaModel {
        /// <summary>
        /// <para>Filter by agent ID. This parameter is optional and defaults to empty.</para>
        /// 
        /// <b>Example:</b>
        /// <para>agent@ccc-test</para>
        /// </summary>
        [NameInMap("AgentId")]
        [Validation(Required=false)]
        public string AgentId { get; set; }

        /// <summary>
        /// <para>Call record ID, which has the same value as the call ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>job-16976964500325****</para>
        /// </summary>
        [NameInMap("AttemptId")]
        [Validation(Required=false)]
        public string AttemptId { get; set; }

        /// <summary>
        /// <para>Filter by called number. Optional. Default is empty.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1888888****</para>
        /// </summary>
        [NameInMap("Callee")]
        [Validation(Required=false)]
        public string Callee { get; set; }

        /// <summary>
        /// <para>Filter by caller number. This parameter is optional and defaults to empty.</para>
        /// 
        /// <b>Example:</b>
        /// <para>05711234****</para>
        /// </summary>
        [NameInMap("Caller")]
        [Validation(Required=false)]
        public string Caller { get; set; }

        /// <summary>
        /// <para>Predictive outbound dialing Activity ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6badb397-a8b5-40b6-21019d382a09</para>
        /// </summary>
        [NameInMap("CampaignId")]
        [Validation(Required=false)]
        public string CampaignId { get; set; }

        /// <summary>
        /// <para>System-generated contact ID. Customers do not need to concern themselves with this value.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>60ecb1a2-4480-4d01-bede-c5b7655bfadf</para>
        /// </summary>
        [NameInMap("CaseId")]
        [Validation(Required=false)]
        public string CaseId { get; set; }

        /// <summary>
        /// <para>Filter by call ID. This parameter is optional and defaults to empty.</para>
        /// 
        /// <b>Example:</b>
        /// <para>job-16976964500325****</para>
        /// </summary>
        [NameInMap("ContactId")]
        [Validation(Required=false)]
        public string ContactId { get; set; }

        /// <summary>
        /// <para>Extended query conditions in JSON format. Currently supports caseIds for batch queries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;caseIds&quot;:[&quot;964f05a7-fc15-4a05-93a6-cd7421c4459e&quot;,&quot;5e2d508b-0df6-4077-8099-d3fff51ea6d0&quot;,&quot;da037029-8c83-4270-a90e-e7734be76af6&quot;]}</para>
        /// </summary>
        [NameInMap("Criteria")]
        [Validation(Required=false)]
        public string Criteria { get; set; }

        /// <summary>
        /// <para>End Time. This parameter is optional. If not specified, it defaults to the End Time of the predictive outbound dialing Activity. The format is a UNIX timestamp in milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1634115698291</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        /// <summary>
        /// <para>Instance ID</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ccc-test</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>Page number. The product of PageNumber and PageSize must not exceed 10 000.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>Page size. The product of PageNumber and PageSize must not exceed 10 000.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>Filter by skill group ID. This parameter is optional and defaults to empty, which means no filtering is applied.</para>
        /// 
        /// <b>Example:</b>
        /// <para>skillgroup@ccc-test</para>
        /// </summary>
        [NameInMap("QueueId")]
        [Validation(Required=false)]
        public string QueueId { get; set; }

        /// <summary>
        /// <para>Start Time. This parameter is optional. If not specified, it defaults to the Start Time of the predictive outbound dialing Activity. The format is a UNIX timestamp in milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1634115688291</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

    }

}
