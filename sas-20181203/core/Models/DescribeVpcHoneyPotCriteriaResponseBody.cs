// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeVpcHoneyPotCriteriaResponseBody : TeaModel {
        /// <summary>
        /// An array that consists of the search conditions.
        /// </summary>
        [NameInMap("CriteriaList")]
        [Validation(Required=false)]
        public List<DescribeVpcHoneyPotCriteriaResponseBodyCriteriaList> CriteriaList { get; set; }
        public class DescribeVpcHoneyPotCriteriaResponseBodyCriteriaList : TeaModel {
            /// <summary>
            /// The name of the search condition.
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// The type of the search condition. Valid values:
            /// 
            /// *   **input**: You must manually enter the search condition.
            /// *   **select**: You must select a search condition from the **Values** drop-down list.
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// The values of the search condition. This parameter is returned only if the value of **Type** is **select**.
            /// 
            /// > If the value of **Type** is **input**, the value of this parameter is an empty string.
            /// </summary>
            [NameInMap("Values")]
            [Validation(Required=false)]
            public string Values { get; set; }

        }

        /// <summary>
        /// The ID of the request, which is used to locate and troubleshoot issues.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
