// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class ListRoutineCodeVersionsResponseBody : TeaModel {
        [NameInMap("CodeVersions")]
        [Validation(Required=false)]
        public List<ListRoutineCodeVersionsResponseBodyCodeVersions> CodeVersions { get; set; }
        public class ListRoutineCodeVersionsResponseBodyCodeVersions : TeaModel {
            [NameInMap("BuildId")]
            [Validation(Required=false)]
            public long? BuildId { get; set; }

            [NameInMap("CodeDescription")]
            [Validation(Required=false)]
            public string CodeDescription { get; set; }

            [NameInMap("CodeVersion")]
            [Validation(Required=false)]
            public string CodeVersion { get; set; }

            [NameInMap("ConfOptions")]
            [Validation(Required=false)]
            public ListRoutineCodeVersionsResponseBodyCodeVersionsConfOptions ConfOptions { get; set; }
            public class ListRoutineCodeVersionsResponseBodyCodeVersionsConfOptions : TeaModel {
                [NameInMap("NotFoundStrategy")]
                [Validation(Required=false)]
                public string NotFoundStrategy { get; set; }

            }

            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            [NameInMap("ExtraInfo")]
            [Validation(Required=false)]
            public string ExtraInfo { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
