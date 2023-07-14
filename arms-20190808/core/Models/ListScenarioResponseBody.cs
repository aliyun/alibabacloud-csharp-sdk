// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class ListScenarioResponseBody : TeaModel {
        /// <summary>
        /// The detailed information of the business monitoring job.
        /// </summary>
        [NameInMap("ArmsScenarios")]
        [Validation(Required=false)]
        public List<ListScenarioResponseBodyArmsScenarios> ArmsScenarios { get; set; }
        public class ListScenarioResponseBodyArmsScenarios : TeaModel {
            /// <summary>
            /// The ID of the application.
            /// </summary>
            [NameInMap("AppId")]
            [Validation(Required=false)]
            public string AppId { get; set; }

            /// <summary>
            /// The time when the business monitoring job was created.
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// The extended information. The value is a JSON string.
            /// </summary>
            [NameInMap("Extensions")]
            [Validation(Required=false)]
            public string Extensions { get; set; }

            /// <summary>
            /// The ID of the business monitoring job.
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// The name of the business monitoring job.
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// The ID of the region.
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// The code of the business monitoring job.
            /// </summary>
            [NameInMap("Sign")]
            [Validation(Required=false)]
            public string Sign { get; set; }

            /// <summary>
            /// The time when the business monitoring job was updated.
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

            /// <summary>
            /// The ID of the user.
            /// </summary>
            [NameInMap("UserId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
