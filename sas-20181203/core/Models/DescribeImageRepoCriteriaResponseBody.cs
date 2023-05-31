// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeImageRepoCriteriaResponseBody : TeaModel {
        /// <summary>
        /// An array consisting of the filter conditions that are supported by the image repository.
        /// </summary>
        [NameInMap("CriteriaList")]
        [Validation(Required=false)]
        public List<DescribeImageRepoCriteriaResponseBodyCriteriaList> CriteriaList { get; set; }
        public class DescribeImageRepoCriteriaResponseBodyCriteriaList : TeaModel {
            /// <summary>
            /// The name of the filter condition. Valid values:
            /// 
            /// *   **instanceId**: the ID of the image instance.
            /// *   **repoName**: the name of the image repository.
            /// *   **repoId**: the ID of the image repository.
            /// *   **repoNamespace**: the namespace of the image repository.
            /// *   **regionId**: the region of the image.
            /// *   **vulStatus**: indicates whether vulnerabilities exist.
            /// *   **alarmStatus**: indicates whether security alerts exist.
            /// *   **hcStatus**: indicates whether baseline risks exist.
            /// *   **riskStatus**: indicates whether risks exist.
            /// *   **registryType**: the type of the image repository.
            /// *   **ImageId**: the ID of the image.
            /// *   **tag**: the tag of the image
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// The type of the filter condition. Valid values:
            /// 
            /// *   **input**: The filter condition needs to be specified.
            /// *   **select**: The filter condition is an option that can be selected from the drop-down list.
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// The value of the filter condition. This parameter is returned only if the value of **Type** is **select**.
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
