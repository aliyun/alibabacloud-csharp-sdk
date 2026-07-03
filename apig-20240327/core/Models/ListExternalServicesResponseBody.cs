// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class ListExternalServicesResponseBody : TeaModel {
        /// <summary>
        /// <para>The response code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Ok</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The list of APIs.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public ListExternalServicesResponseBodyData Data { get; set; }
        public class ListExternalServicesResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The service information.</para>
            /// </summary>
            [NameInMap("items")]
            [Validation(Required=false)]
            public List<ListExternalServicesResponseBodyDataItems> Items { get; set; }
            public class ListExternalServicesResponseBodyDataItems : TeaModel {
                /// <summary>
                /// <para>The namespace.</para>
                /// 
                /// <b>Example:</b>
                /// <para>PUBLIC</para>
                /// </summary>
                [NameInMap("namespace")]
                [Validation(Required=false)]
                public string Namespace { get; set; }

                /// <summary>
                /// <para>The display name of the namespace.</para>
                /// 
                /// <b>Example:</b>
                /// <para>PUBLIC</para>
                /// </summary>
                [NameInMap("namespaceShowName")]
                [Validation(Required=false)]
                public string NamespaceShowName { get; set; }

                /// <summary>
                /// <para>The backend services.</para>
                /// </summary>
                [NameInMap("services")]
                [Validation(Required=false)]
                public List<ListExternalServicesResponseBodyDataItemsServices> Services { get; set; }
                public class ListExternalServicesResponseBodyDataItemsServices : TeaModel {
                    /// <summary>
                    /// <para>The name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>enable-slash-merge</para>
                    /// </summary>
                    [NameInMap("name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <para>The namespace.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>public</para>
                    /// </summary>
                    [NameInMap("namespace")]
                    [Validation(Required=false)]
                    public string Namespace { get; set; }

                }

            }

        }

        /// <summary>
        /// <para>The response message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Failed to upload data. Please try again</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>D9B03B59-B2D6-51B0-A7E9-AF8466E320CA</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
