// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentRun20250910.Models
{
    public class ListModelProvidersResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>SUCCESS</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("data")]
        [Validation(Required=false)]
        public ListModelProvidersResponseBodyData Data { get; set; }
        public class ListModelProvidersResponseBodyData : TeaModel {
            [NameInMap("items")]
            [Validation(Required=false)]
            public List<ListModelProvidersResponseBodyDataItems> Items { get; set; }
            public class ListModelProvidersResponseBodyDataItems : TeaModel {
                /// <summary>
                /// <para>baseUrl</para>
                /// 
                /// <b>Example:</b>
                /// <para>baseUrl</para>
                /// </summary>
                [NameInMap("baseUrl")]
                [Validation(Required=false)]
                public string BaseUrl { get; set; }

                /// <summary>
                /// <para>modelInfoConfig</para>
                /// </summary>
                [NameInMap("modelInfoConfig")]
                [Validation(Required=false)]
                public ModelInfoConfig ModelInfoConfig { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>native</para>
                /// </summary>
                [NameInMap("modelType")]
                [Validation(Required=false)]
                public string ModelType { get; set; }

                [NameInMap("models")]
                [Validation(Required=false)]
                public List<string> Models { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>providerName</para>
                /// </summary>
                [NameInMap("providerName")]
                [Validation(Required=false)]
                public string ProviderName { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("pageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("pageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>211</para>
            /// </summary>
            [NameInMap("total")]
            [Validation(Required=false)]
            public long? Total { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>F8A0F5F3-0C3E-4C82-9D4F-5E4B6A7C8D9E</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
