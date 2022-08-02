// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Oss20190517.Models
{
    public class ListObjectsV2Request : TeaModel {
        [NameInMap("continuation-token")]
        [Validation(Required=false)]
        public string ContinuationToken { get; set; }

        [NameInMap("delimiter")]
        [Validation(Required=false)]
        public string Delimiter { get; set; }

        [NameInMap("encoding-type")]
        [Validation(Required=false)]
        public string EncodingType { get; set; }

        [NameInMap("fetch-owner")]
        [Validation(Required=false)]
        public bool? FetchOwner { get; set; }

        [NameInMap("max-keys")]
        [Validation(Required=false)]
        public long? MaxKeys { get; set; }

        [NameInMap("prefix")]
        [Validation(Required=false)]
        public string Prefix { get; set; }

        [NameInMap("start-after")]
        [Validation(Required=false)]
        public string StartAfter { get; set; }

    }

}
