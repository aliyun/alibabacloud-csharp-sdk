// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appstream_center20210901.Models
{
    public class ListModelProviderEndpointsResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListModelProviderEndpointsResponseBodyData> Data { get; set; }
        public class ListModelProviderEndpointsResponseBodyData : TeaModel {
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("Endpoints")]
            [Validation(Required=false)]
            public List<ListModelProviderEndpointsResponseBodyDataEndpoints> Endpoints { get; set; }
            public class ListModelProviderEndpointsResponseBodyDataEndpoints : TeaModel {
                [NameInMap("ApiType")]
                [Validation(Required=false)]
                public string ApiType { get; set; }

                [NameInMap("BaseUrl")]
                [Validation(Required=false)]
                public string BaseUrl { get; set; }

                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("ProviderUrl")]
                [Validation(Required=false)]
                public string ProviderUrl { get; set; }

                [NameInMap("Tags")]
                [Validation(Required=false)]
                public List<string> Tags { get; set; }

            }

            [NameInMap("ProviderName")]
            [Validation(Required=false)]
            public string ProviderName { get; set; }

            [NameInMap("ProviderUrl")]
            [Validation(Required=false)]
            public string ProviderUrl { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>XXXXXXXX-XXXX-XXXX-XXXX-XXXXXXXXXXXX</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
