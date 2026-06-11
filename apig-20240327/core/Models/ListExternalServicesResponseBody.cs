// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class ListExternalServicesResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>Ok</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("data")]
        [Validation(Required=false)]
        public ListExternalServicesResponseBodyData Data { get; set; }
        public class ListExternalServicesResponseBodyData : TeaModel {
            [NameInMap("items")]
            [Validation(Required=false)]
            public List<ListExternalServicesResponseBodyDataItems> Items { get; set; }
            public class ListExternalServicesResponseBodyDataItems : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>PUBLIC</para>
                /// </summary>
                [NameInMap("namespace")]
                [Validation(Required=false)]
                public string Namespace { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>PUBLIC</para>
                /// </summary>
                [NameInMap("namespaceShowName")]
                [Validation(Required=false)]
                public string NamespaceShowName { get; set; }

                [NameInMap("services")]
                [Validation(Required=false)]
                public List<ListExternalServicesResponseBodyDataItemsServices> Services { get; set; }
                public class ListExternalServicesResponseBodyDataItemsServices : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>enable-slash-merge</para>
                    /// </summary>
                    [NameInMap("name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
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
