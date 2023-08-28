// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Searchengine20211025.Models
{
    public class GetIndexVersionResponseBody : TeaModel {
        /// <summary>
        /// id of request
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("result")]
        [Validation(Required=false)]
        public GetIndexVersionResponseBodyResult Result { get; set; }
        public class GetIndexVersionResponseBodyResult : TeaModel {
            [NameInMap("cluster")]
            [Validation(Required=false)]
            public string Cluster { get; set; }

            [NameInMap("indexVersions")]
            [Validation(Required=false)]
            public List<GetIndexVersionResponseBodyResultIndexVersions> IndexVersions { get; set; }
            public class GetIndexVersionResponseBodyResultIndexVersions : TeaModel {
                [NameInMap("buildDeployId")]
                [Validation(Required=false)]
                public string BuildDeployId { get; set; }

                [NameInMap("currentVersion")]
                [Validation(Required=false)]
                public long? CurrentVersion { get; set; }

                [NameInMap("indexName")]
                [Validation(Required=false)]
                public string IndexName { get; set; }

                [NameInMap("versions")]
                [Validation(Required=false)]
                public List<long?> Versions { get; set; }

            }

        }

    }

}
