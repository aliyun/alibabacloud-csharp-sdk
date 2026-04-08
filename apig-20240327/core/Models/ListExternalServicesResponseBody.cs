// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class ListExternalServicesResponseBody : TeaModel {
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
                [NameInMap("namespace")]
                [Validation(Required=false)]
                public string Namespace { get; set; }

                [NameInMap("namespaceShowName")]
                [Validation(Required=false)]
                public string NamespaceShowName { get; set; }

                [NameInMap("services")]
                [Validation(Required=false)]
                public List<ListExternalServicesResponseBodyDataItemsServices> Services { get; set; }
                public class ListExternalServicesResponseBodyDataItemsServices : TeaModel {
                    [NameInMap("name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    [NameInMap("namespace")]
                    [Validation(Required=false)]
                    public string Namespace { get; set; }

                }

            }

        }

        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
