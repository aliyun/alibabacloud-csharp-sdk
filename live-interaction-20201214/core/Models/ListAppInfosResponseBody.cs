// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live_interaction20201214.Models
{
    public class ListAppInfosResponseBody : TeaModel {
        /// <summary>
        /// desc
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// requestId
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// httpStatusCode
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// code
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// success
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// result
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public ListAppInfosResponseBodyResult Result { get; set; }
        public class ListAppInfosResponseBodyResult : TeaModel {
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }
            [NameInMap("AppInfos")]
            [Validation(Required=false)]
            public List<ListAppInfosResponseBodyResultAppInfos> AppInfos { get; set; }
            public class ListAppInfosResponseBodyResultAppInfos : TeaModel {
                public string AppId { get; set; }
                public string AppName { get; set; }
                public string CreateTime { get; set; }
                public int? AppStatus { get; set; }
                public string ProdVersion { get; set; }
            }
        };

    }

}
