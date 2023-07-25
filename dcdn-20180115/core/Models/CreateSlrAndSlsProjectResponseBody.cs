// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class CreateSlrAndSlsProjectResponseBody : TeaModel {
        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The information about Log Service.
        /// </summary>
        [NameInMap("SlsInfo")]
        [Validation(Required=false)]
        public CreateSlrAndSlsProjectResponseBodySlsInfo SlsInfo { get; set; }
        public class CreateSlrAndSlsProjectResponseBodySlsInfo : TeaModel {
            /// <summary>
            /// The endpoint of Log Service.
            /// </summary>
            [NameInMap("EndPoint")]
            [Validation(Required=false)]
            public string EndPoint { get; set; }

            /// <summary>
            /// The Logstore of Log Service.
            /// </summary>
            [NameInMap("LogStore")]
            [Validation(Required=false)]
            public string LogStore { get; set; }

            /// <summary>
            /// The project of Log Service.
            /// </summary>
            [NameInMap("Project")]
            [Validation(Required=false)]
            public string Project { get; set; }

            /// <summary>
            /// The region where Log Service resides.
            /// </summary>
            [NameInMap("Region")]
            [Validation(Required=false)]
            public string Region { get; set; }

        }

    }

}
