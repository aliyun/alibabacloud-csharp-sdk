// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class ListModelCardsResponseBody : TeaModel {
        /// <summary>
        /// <para>The response status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Ok</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The response data.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public List<ListModelCardsResponseBodyData> Data { get; set; }
        public class ListModelCardsResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The list of available paths for the model card. Each element consists of a path and a type member. The API definition does not specify the criteria for determining availability.</para>
            /// </summary>
            [NameInMap("availablePaths")]
            [Validation(Required=false)]
            public List<ListModelCardsResponseBodyDataAvailablePaths> AvailablePaths { get; set; }
            public class ListModelCardsResponseBodyDataAvailablePaths : TeaModel {
                /// <summary>
                /// <para>The request path of the API.</para>
                /// 
                /// <b>Example:</b>
                /// <para>/v1/chat/completions</para>
                /// </summary>
                [NameInMap("path")]
                [Validation(Required=false)]
                public string Path { get; set; }

                /// <summary>
                /// <para>The type identifier of the available path record. The valid values are not specified in the API definition.</para>
                /// 
                /// <b>Example:</b>
                /// <para>type-xxxxxxxx</para>
                /// </summary>
                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <para>The feature configuration of the model card in a key-value pair map structure. The set of keys is not specified in the API definition.</para>
            /// </summary>
            [NameInMap("features")]
            [Validation(Required=false)]
            public Dictionary<string, object> Features { get; set; }

            /// <summary>
            /// <para>The metadata container of the model card. Only the description member is declared in the API definition.</para>
            /// </summary>
            [NameInMap("meta")]
            [Validation(Required=false)]
            public ListModelCardsResponseBodyDataMeta Meta { get; set; }
            public class ListModelCardsResponseBodyDataMeta : TeaModel {
                /// <summary>
                /// <para>The description text of the model card.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Sample description text for the model card</para>
                /// </summary>
                [NameInMap("description")]
                [Validation(Required=false)]
                public string Description { get; set; }

            }

            /// <summary>
            /// <para>The name of the model.</para>
            /// 
            /// <b>Example:</b>
            /// <para>qwen-plus</para>
            /// </summary>
            [NameInMap("modelName")]
            [Validation(Required=false)]
            public string ModelName { get; set; }

            /// <summary>
            /// <para>The pricing information of the model card in a key-value pair map structure. The set of keys and billing criteria are not specified in the API definition.</para>
            /// </summary>
            [NameInMap("pricing")]
            [Validation(Required=false)]
            public Dictionary<string, object> Pricing { get; set; }

            /// <summary>
            /// <para>The identifier of the model provider for the model card.</para>
            /// 
            /// <b>Example:</b>
            /// <para>provider-xxxxxxxx</para>
            /// </summary>
            [NameInMap("provider")]
            [Validation(Required=false)]
            public string Provider { get; set; }

            /// <summary>
            /// <para>The list of snapshots for the model card. Array items are map structures with unspecified members. The API definition does not specify the snapshot content or generation rules.</para>
            /// </summary>
            [NameInMap("snapshots")]
            [Validation(Required=false)]
            public List<Dictionary<string, object>> Snapshots { get; set; }

            /// <summary>
            /// <para>The source identifier of the model card. The valid values are not specified in the API definition.</para>
            /// 
            /// <b>Example:</b>
            /// <para>source-xxxxxxxx</para>
            /// </summary>
            [NameInMap("source")]
            [Validation(Required=false)]
            public string Source { get; set; }

        }

        /// <summary>
        /// <para>The response message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>393E2630-DBE7-5221-AB35-9E740675491A</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
