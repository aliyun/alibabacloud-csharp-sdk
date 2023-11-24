// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OpenSearch20171225.Models
{
    public class DescribeABTestSceneResponseBody : TeaModel {
        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The details of the test scenario.
        /// </summary>
        [NameInMap("result")]
        [Validation(Required=false)]
        public DescribeABTestSceneResponseBodyResult Result { get; set; }
        public class DescribeABTestSceneResponseBodyResult : TeaModel {
            /// <summary>
            /// The time when the test scenario was created.
            /// </summary>
            [NameInMap("created")]
            [Validation(Required=false)]
            public int? Created { get; set; }

            /// <summary>
            /// The ID of the test scenario.
            /// </summary>
            [NameInMap("id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// The name of the test scenario.
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// The status of the test scenario. Valid values:
            /// 
            /// *   0: The test is stopped.
            /// *   1: The test is started.
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            /// <summary>
            /// The time when the test was last modified.
            /// </summary>
            [NameInMap("updated")]
            [Validation(Required=false)]
            public int? Updated { get; set; }

            /// <summary>
            /// The indicators of the test scenarios.
            /// </summary>
            [NameInMap("values")]
            [Validation(Required=false)]
            public List<string> Values { get; set; }

        }

    }

}
