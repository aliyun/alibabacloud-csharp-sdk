// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeSearchConditionResponseBody : TeaModel {
        /// <summary>
        /// An array that consists of the filter conditions.
        /// </summary>
        [NameInMap("ConditionList")]
        [Validation(Required=false)]
        public List<DescribeSearchConditionResponseBodyConditionList> ConditionList { get; set; }
        public class DescribeSearchConditionResponseBodyConditionList : TeaModel {
            /// <summary>
            /// The type of the filter condition. Valid values:
            /// 
            /// *   **system**: default filter condition
            /// *   **user**: custom filter condition
            /// </summary>
            [NameInMap("ConditionType")]
            [Validation(Required=false)]
            public string ConditionType { get; set; }

            /// <summary>
            /// The filter condition. The value of this parameter is in the JSON format and contains the following fields:
            /// 
            /// *   **filterParams**: the parameters of the filter condition. The value of this field is in the JSON format and contains the following fields:
            /// 
            ///     *   **labelKey**: the key for rendering.
            /// 
            ///     *   **label**: the display name.
            /// 
            ///     *   **value**: the value of the filter condition. The value of this field is in the JSON format and contains the following fields:
            /// 
            ///         *   **name**: the name of the filter item.
            ///         *   **value**: the value of the filter item.
            /// 
            /// *   **LogicalExp**: the logical relationship among the filter conditions. Valid values:
            /// 
            ///     *   **AND**: The filter conditions are evaluated by using a logical **AND**.
            ///     *   **OR**: The filter conditions are evaluated by using a logical **OR**.
            /// 
            /// >  If the value of **ConditionType** is **system**, **labelKey** is returned. The labelKey field is used only for internationalization rendering.
            /// </summary>
            [NameInMap("FilterConditions")]
            [Validation(Required=false)]
            public string FilterConditions { get; set; }

            /// <summary>
            /// The name of the filter condition.
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// The key of the filter condition name.
            /// </summary>
            [NameInMap("NameKey")]
            [Validation(Required=false)]
            public string NameKey { get; set; }

        }

        /// <summary>
        /// The ID of the request, which is used to locate and troubleshoot issues.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
