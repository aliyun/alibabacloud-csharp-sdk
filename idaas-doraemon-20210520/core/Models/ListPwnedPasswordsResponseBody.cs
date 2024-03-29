// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Idaas_doraemon20210520.Models
{
    public class ListPwnedPasswordsResponseBody : TeaModel {
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        [NameInMap("PwnedPasswordInfos")]
        [Validation(Required=false)]
        public List<ListPwnedPasswordsResponseBodyPwnedPasswordInfos> PwnedPasswordInfos { get; set; }
        public class ListPwnedPasswordsResponseBodyPwnedPasswordInfos : TeaModel {
            [NameInMap("HexPasswordSha1Hash")]
            [Validation(Required=false)]
            public string HexPasswordSha1Hash { get; set; }

            [NameInMap("PwnedCount")]
            [Validation(Required=false)]
            public long? PwnedCount { get; set; }

        }

        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
