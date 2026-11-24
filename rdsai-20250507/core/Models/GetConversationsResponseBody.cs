// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RdsAi20250507.Models
{
    public class GetConversationsResponseBody : TeaModel {
        /// <summary>
        /// <para>The request result.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<GetConversationsResponseBodyData> Data { get; set; }
        public class GetConversationsResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The creation time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1764055092</para>
            /// </summary>
            [NameInMap("CreatedAt")]
            [Validation(Required=false)]
            public string CreatedAt { get; set; }

            /// <summary>
            /// <para>The ID of the historical conversation.</para>
            /// 
            /// <b>Example:</b>
            /// <para>60b335ca-124d-4ee1-864b-de554987****</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <para>The conversation introduction.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Test searching for RDS resources</para>
            /// </summary>
            [NameInMap("Introduction")]
            [Validation(Required=false)]
            public string Introduction { get; set; }

            /// <summary>
            /// <para>Indicates whether the session is running.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("IsRunning")]
            [Validation(Required=false)]
            public bool? IsRunning { get; set; }

            /// <summary>
            /// <para>The name of the historical conversation.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Search for RDS resources</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The session status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>idle</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The update time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1785919275</para>
            /// </summary>
            [NameInMap("UpdatedAt")]
            [Validation(Required=false)]
            public string UpdatedAt { get; set; }

        }

        /// <summary>
        /// <para>Indicates whether more pages are available.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("HasMore")]
        [Validation(Required=false)]
        public string HasMore { get; set; }

        /// <summary>
        /// <para>The paging Settings for the number of entries per page in a paged query. Valid values: 1 to 100. Default value: 100.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("Limit")]
        [Validation(Required=false)]
        public long? Limit { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>FE9C65D7-930F-57A5-A207-8C396329****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
