// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeImageCriteriaResponseBody : TeaModel {
        /// <summary>
        /// The list of the search conditions.
        /// </summary>
        [NameInMap("CriteriaList")]
        [Validation(Required=false)]
        public List<DescribeImageCriteriaResponseBodyCriteriaList> CriteriaList { get; set; }
        public class DescribeImageCriteriaResponseBodyCriteriaList : TeaModel {
            /// <summary>
            /// The name of the search condition.
            /// - **tag**: the tag of the image
            /// - **digest**: the digest of the image
            /// - **vulStatus**: the status of the vulnerability
            /// - **alarmStatus**: the status of the alert
            /// - **riskStatus**: the status of the risk
            /// - **registryType**: the type of the image repository
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// The type of the search condition. Valid values:
            /// - **input**: The search condition needs to be specified.
            /// - **select**: The search condition is an option that can be selected from the drop-down list.
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// The values of the search condition. This parameter is returned only if the value of Type is select.
            /// > If the value of **Type** is **input**, the value of this parameter is an empty string.
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
