// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OpenSearch20171225.Models
{
    public class CreateABTestExperimentResponseBody : TeaModel {
        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The experiment details.
        /// </summary>
        [NameInMap("result")]
        [Validation(Required=false)]
        public CreateABTestExperimentResponseBodyResult Result { get; set; }
        public class CreateABTestExperimentResponseBodyResult : TeaModel {
            /// <summary>
            /// The time when the experiment was created.
            /// </summary>
            [NameInMap("created")]
            [Validation(Required=false)]
            public int? Created { get; set; }

            /// <summary>
            /// The experiment ID.
            /// </summary>
            [NameInMap("id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// The experiment alias.
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// Indicates whether the experiment is in effect. Valid values:
            /// 
            /// *   true
            /// *   false
            /// </summary>
            [NameInMap("online")]
            [Validation(Required=false)]
            public bool? Online { get; set; }

            /// <summary>
            /// The experiment parameters.
            /// </summary>
            [NameInMap("params")]
            [Validation(Required=false)]
            public Dictionary<string, object> Params { get; set; }

            /// <summary>
            /// The percentage of traffic that is routed to the experiment.
            /// </summary>
            [NameInMap("traffic")]
            [Validation(Required=false)]
            public int? Traffic { get; set; }

            /// <summary>
            /// The time when the experiment was last modified.
            /// </summary>
            [NameInMap("updated")]
            [Validation(Required=false)]
            public int? Updated { get; set; }

        }

    }

}
