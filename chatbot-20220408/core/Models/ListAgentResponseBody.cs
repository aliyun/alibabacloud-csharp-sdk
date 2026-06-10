// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Chatbot20220408.Models
{
    public class ListAgentResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of business spaces.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListAgentResponseBodyData> Data { get; set; }
        public class ListAgentResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The business space ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>881</para>
            /// </summary>
            [NameInMap("AgentId")]
            [Validation(Required=false)]
            public long? AgentId { get; set; }

            /// <summary>
            /// <para>The business space signature, used to identify the business space in Platform-as-a-Service (PaaS) API calls.</para>
            /// 
            /// <b>Example:</b>
            /// <para>4e7400028e6f4a7393ed3acf6a7b8927_p_beebot_public</para>
            /// </summary>
            [NameInMap("AgentKey")]
            [Validation(Required=false)]
            public string AgentKey { get; set; }

            /// <summary>
            /// <para>The name of the business space.</para>
            /// 
            /// <b>Example:</b>
            /// <para>业务空间_881</para>
            /// </summary>
            [NameInMap("AgentName")]
            [Validation(Required=false)]
            public string AgentName { get; set; }

            /// <summary>
            /// <para>Details of the associated commodity instance. The object keys are commodity codes.</para>
            /// </summary>
            [NameInMap("InstanceInfos")]
            [Validation(Required=false)]
            public Dictionary<string, object> InstanceInfos { get; set; }

        }

        /// <summary>
        /// <para>The page number of the returned results.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries returned on the current page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>F55D90C1-31BE-4B2A-AA3F-25EFC36F9419</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total count of business spaces that match the query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
