// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class GetClusterDataInformationResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public GetClusterDataInformationResponseBodyResult Result { get; set; }
        public class GetClusterDataInformationResponseBodyResult : TeaModel {
            [NameInMap("connectable")]
            [Validation(Required=false)]
            public bool? Connectable { get; set; }

            [NameInMap("metaInfo")]
            [Validation(Required=false)]
            public GetClusterDataInformationResponseBodyResultMetaInfo MetaInfo { get; set; }
            public class GetClusterDataInformationResponseBodyResultMetaInfo : TeaModel {
                [NameInMap("fields")]
                [Validation(Required=false)]
                public List<string> Fields { get; set; }

                [NameInMap("indices")]
                [Validation(Required=false)]
                public List<string> Indices { get; set; }

                [NameInMap("mapping")]
                [Validation(Required=false)]
                public string Mapping { get; set; }

                [NameInMap("settings")]
                [Validation(Required=false)]
                public string Settings { get; set; }

                [NameInMap("typeName")]
                [Validation(Required=false)]
                public List<string> TypeName { get; set; }

            }

        }

    }

}
