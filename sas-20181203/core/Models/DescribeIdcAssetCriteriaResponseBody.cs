// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeIdcAssetCriteriaResponseBody : TeaModel {
        /// <summary>
        /// The information about the asset search conditions.
        /// </summary>
        [NameInMap("CriteriaList")]
        [Validation(Required=false)]
        public List<DescribeIdcAssetCriteriaResponseBodyCriteriaList> CriteriaList { get; set; }
        public class DescribeIdcAssetCriteriaResponseBodyCriteriaList : TeaModel {
            /// <summary>
            /// The name of the search condition.
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// The type of the search condition. Valid values:
            /// 
            /// *   **input**: The search condition needs to be specified.
            /// *   **select**: The search condition is an option that can be selected from the drop-down list.
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// The attribute values of the assets that match the keyword.
            /// </summary>
            [NameInMap("Values")]
            [Validation(Required=false)]
            public string Values { get; set; }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
