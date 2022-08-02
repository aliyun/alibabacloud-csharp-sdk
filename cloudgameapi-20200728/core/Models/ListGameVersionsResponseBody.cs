// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudGameAPI20200728.Models
{
    public class ListGameVersionsResponseBody : TeaModel {
        [NameInMap("Count")]
        [Validation(Required=false)]
        public long? Count { get; set; }

        [NameInMap("DataList")]
        [Validation(Required=false)]
        public List<ListGameVersionsResponseBodyDataList> DataList { get; set; }
        public class ListGameVersionsResponseBodyDataList : TeaModel {
            [NameInMap("VersionId")]
            [Validation(Required=false)]
            public string VersionId { get; set; }

            [NameInMap("VersionName")]
            [Validation(Required=false)]
            public string VersionName { get; set; }

            [NameInMap("VersionNumber")]
            [Validation(Required=false)]
            public string VersionNumber { get; set; }

        }

        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
