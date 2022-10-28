// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class ListDAGVersionsResponseBody : TeaModel {
        [NameInMap("DagVersionList")]
        [Validation(Required=false)]
        public ListDAGVersionsResponseBodyDagVersionList DagVersionList { get; set; }
        public class ListDAGVersionsResponseBodyDagVersionList : TeaModel {
            [NameInMap("DagVersion")]
            [Validation(Required=false)]
            public List<ListDAGVersionsResponseBodyDagVersionListDagVersion> DagVersion { get; set; }
            public class ListDAGVersionsResponseBodyDagVersionListDagVersion : TeaModel {
                [NameInMap("DagName")]
                [Validation(Required=false)]
                public string DagName { get; set; }

                [NameInMap("DagOwnerId")]
                [Validation(Required=false)]
                public string DagOwnerId { get; set; }

                [NameInMap("DagOwnerNickName")]
                [Validation(Required=false)]
                public string DagOwnerNickName { get; set; }

                [NameInMap("LastVersionId")]
                [Validation(Required=false)]
                public long? LastVersionId { get; set; }

                [NameInMap("VersionComments")]
                [Validation(Required=false)]
                public string VersionComments { get; set; }

                [NameInMap("VersionId")]
                [Validation(Required=false)]
                public long? VersionId { get; set; }

            }

        }

        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
