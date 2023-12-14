// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GetSasContainerWebDefenseRuleCriteriaResponseBody : TeaModel {
        /// <summary>
        /// The search conditions.
        /// </summary>
        [NameInMap("CriteriaList")]
        [Validation(Required=false)]
        public List<GetSasContainerWebDefenseRuleCriteriaResponseBodyCriteriaList> CriteriaList { get; set; }
        public class GetSasContainerWebDefenseRuleCriteriaResponseBodyCriteriaList : TeaModel {
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
            /// >  If the value of **Type** is **input**, the value of this parameter is empty.
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
