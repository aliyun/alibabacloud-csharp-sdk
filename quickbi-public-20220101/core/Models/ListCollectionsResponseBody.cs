// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quickbi_public20220101.Models
{
    public class ListCollectionsResponseBody : TeaModel {
        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public List<ListCollectionsResponseBodyResult> Result { get; set; }
        public class ListCollectionsResponseBodyResult : TeaModel {
            [NameInMap("FavoriteId")]
            [Validation(Required=false)]
            public int? FavoriteId { get; set; }

            [NameInMap("OwnerId")]
            [Validation(Required=false)]
            public string OwnerId { get; set; }

            [NameInMap("WorksId")]
            [Validation(Required=false)]
            public string WorksId { get; set; }

            [NameInMap("WorksName")]
            [Validation(Required=false)]
            public string WorksName { get; set; }

            [NameInMap("WorksType")]
            [Validation(Required=false)]
            public string WorksType { get; set; }

            [NameInMap("WorkspaceId")]
            [Validation(Required=false)]
            public string WorkspaceId { get; set; }

            [NameInMap("WorkspaceName")]
            [Validation(Required=false)]
            public string WorkspaceName { get; set; }

        }

        /// <summary>
        /// The primary key ID of the favorite record.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
