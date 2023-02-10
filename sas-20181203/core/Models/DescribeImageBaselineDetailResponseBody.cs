// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeImageBaselineDetailResponseBody : TeaModel {
        /// <summary>
        /// The details about the image baseline.
        /// </summary>
        [NameInMap("BaselineDetail")]
        [Validation(Required=false)]
        public DescribeImageBaselineDetailResponseBodyBaselineDetail BaselineDetail { get; set; }
        public class DescribeImageBaselineDetailResponseBodyBaselineDetail : TeaModel {
            /// <summary>
            /// The suggestion for the management of the risk item.
            /// </summary>
            [NameInMap("Advice")]
            [Validation(Required=false)]
            public string Advice { get; set; }

            /// <summary>
            /// The alias of the baseline type.
            /// </summary>
            [NameInMap("BaselineClassAlias")]
            [Validation(Required=false)]
            public string BaselineClassAlias { get; set; }

            /// <summary>
            /// The alias of the baseline check item.
            /// </summary>
            [NameInMap("BaselineItemAlias")]
            [Validation(Required=false)]
            public string BaselineItemAlias { get; set; }

            /// <summary>
            /// The key of the baseline check item.
            /// </summary>
            [NameInMap("BaselineItemKey")]
            [Validation(Required=false)]
            public string BaselineItemKey { get; set; }

            /// <summary>
            /// The alias of the baseline.
            /// </summary>
            [NameInMap("BaselineNameAlias")]
            [Validation(Required=false)]
            public string BaselineNameAlias { get; set; }

            /// <summary>
            /// The description of the risk item.
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// The risk level of the baseline check item. Valid values:
            /// 
            /// *   **high**
            /// *   **medium**
            /// *   **low**
            /// </summary>
            [NameInMap("Level")]
            [Validation(Required=false)]
            public string Level { get; set; }

            /// <summary>
            /// The issue that is detected by using the baseline.
            /// </summary>
            [NameInMap("Prompt")]
            [Validation(Required=false)]
            public string Prompt { get; set; }

            /// <summary>
            /// The ID of the asynchronous request.
            /// </summary>
            [NameInMap("ResultId")]
            [Validation(Required=false)]
            public string ResultId { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
