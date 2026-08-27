// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentTeams20260605.Models
{
    public class ListTeamDetailsResponseBody : TeaModel {
        /// <summary>
        /// <para>The response code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SUCCESS</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The list of team statistical details.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[...]</para>
        /// </summary>
        [NameInMap("Items")]
        [Validation(Required=false)]
        public List<ListTeamDetailsResponseBodyItems> Items { get; set; }
        public class ListTeamDetailsResponseBodyItems : TeaModel {
            /// <summary>
            /// <para>The URL of the team avatar.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://example.com/avatar.png">https://example.com/avatar.png</a></para>
            /// </summary>
            [NameInMap("AvatarUrl")]
            [Validation(Required=false)]
            public string AvatarUrl { get; set; }

            /// <summary>
            /// <para>The running status of the team.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Deleting</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The task success rate. Valid values: 0 to 100.</para>
            /// 
            /// <b>Example:</b>
            /// <para>95.5</para>
            /// </summary>
            [NameInMap("SuccessRate")]
            [Validation(Required=false)]
            public double? SuccessRate { get; set; }

            /// <summary>
            /// <para>The number of tasks for the team.</para>
            /// 
            /// <b>Example:</b>
            /// <para>12</para>
            /// </summary>
            [NameInMap("TaskCount")]
            [Validation(Required=false)]
            public int? TaskCount { get; set; }

            /// <summary>
            /// <para>The team name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>my-team</para>
            /// </summary>
            [NameInMap("TeamName")]
            [Validation(Required=false)]
            public string TeamName { get; set; }

            /// <summary>
            /// <para>The token usage within the time interval.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1024000</para>
            /// </summary>
            [NameInMap("TokenUsage")]
            [Validation(Required=false)]
            public long? TokenUsage { get; set; }

            /// <summary>
            /// <para>The number of workers associated with the team.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("WorkerCount")]
            [Validation(Required=false)]
            public int? WorkerCount { get; set; }

        }

        /// <summary>
        /// <para>The maximum number of records to return in this request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The response message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The pagination token for the next page. This parameter is empty if no more data is available.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>req-list-team-details-001</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>The total number of records that meet the conditions.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
