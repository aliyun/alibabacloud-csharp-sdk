// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.VoiceNavigator20251111.Models
{
    public class ListScriptsResponseBody : TeaModel {
        /// <summary>
        /// <para>The internal error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The paginated result of the scenario list.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListScriptsResponseBodyData Data { get; set; }
        public class ListScriptsResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The page number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            /// <summary>
            /// <para>The number of entries per page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The list of scenarios.</para>
            /// </summary>
            [NameInMap("Scripts")]
            [Validation(Required=false)]
            public List<ListScriptsResponseBodyDataScripts> Scripts { get; set; }
            public class ListScriptsResponseBodyDataScripts : TeaModel {
                /// <summary>
                /// <para>The concurrency.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("Concurrency")]
                [Validation(Required=false)]
                public int? Concurrency { get; set; }

                /// <summary>
                /// <para>The creation time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1773228988000</para>
                /// </summary>
                [NameInMap("CreatedTime")]
                [Validation(Required=false)]
                public long? CreatedTime { get; set; }

                /// <summary>
                /// <para>The description.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Used for testing</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The draft version ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>efbafa38-336d-4eb0-865e-c16c97a91773</para>
                /// </summary>
                [NameInMap("DraftVersionId")]
                [Validation(Required=false)]
                public string DraftVersionId { get; set; }

                /// <summary>
                /// <para>The scenario name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Navigation test scenario</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The NLU invocation method.</para>
                /// 
                /// <b>Example:</b>
                /// <para>MANAGED</para>
                /// </summary>
                [NameInMap("NluAccessType")]
                [Validation(Required=false)]
                public string NluAccessType { get; set; }

                /// <summary>
                /// <para>The NLU engine.</para>
                /// 
                /// <b>Example:</b>
                /// <para>BEEBOT</para>
                /// </summary>
                [NameInMap("NluEngine")]
                [Validation(Required=false)]
                public string NluEngine { get; set; }

                /// <summary>
                /// <para>The number.</para>
                /// 
                /// <b>Example:</b>
                /// <para>13816111993</para>
                /// </summary>
                [NameInMap("Number")]
                [Validation(Required=false)]
                public string Number { get; set; }

                /// <summary>
                /// <para>The published version ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>efbafa38-336d-4eb0-865e-c16c97a91774</para>
                /// </summary>
                [NameInMap("PublishedVersionId")]
                [Validation(Required=false)]
                public string PublishedVersionId { get; set; }

                /// <summary>
                /// <para>The scenario ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>efbafa38-336d-4eb0-865e-c16c97a91772</para>
                /// </summary>
                [NameInMap("ScriptId")]
                [Validation(Required=false)]
                public string ScriptId { get; set; }

                /// <summary>
                /// <para>The status.</para>
                /// 
                /// <b>Example:</b>
                /// <para>DRAFT</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>The update time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1773228988000</para>
                /// </summary>
                [NameInMap("UpdatedTime")]
                [Validation(Required=false)]
                public long? UpdatedTime { get; set; }

            }

            /// <summary>
            /// <para>The total count.</para>
            /// 
            /// <b>Example:</b>
            /// <para>30</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

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
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Instance af81a389-91f0-4157-8d82-720edd02b66a
        ///  does not exist.</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The list of dynamic error parameters.</para>
        /// </summary>
        [NameInMap("Params")]
        [Validation(Required=false)]
        public List<string> Params { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>BA092E9B-3421-5862-BC75-E646B7587531</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
