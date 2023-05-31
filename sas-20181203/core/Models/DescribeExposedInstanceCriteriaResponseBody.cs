// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeExposedInstanceCriteriaResponseBody : TeaModel {
        /// <summary>
        /// The search conditions that are used to search for exposed assets.
        /// </summary>
        [NameInMap("CriteriaList")]
        [Validation(Required=false)]
        public List<DescribeExposedInstanceCriteriaResponseBodyCriteriaList> CriteriaList { get; set; }
        public class DescribeExposedInstanceCriteriaResponseBodyCriteriaList : TeaModel {
            /// <summary>
            /// The name of the search condition.
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// The type of the search condition. Valid values:
            /// 
            /// *   **input**: You must configure the search condition.
            /// *   **select**: You must select a search condition from the **Values** list.
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// The value of the search condition. This parameter is returned only when the value of the **Type** parameter is **select**.
            /// 
            /// >  If the value of the **Type** parameter is **input**, this parameter is empty.
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
