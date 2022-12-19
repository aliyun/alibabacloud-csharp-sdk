// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeRiskItemTypeResponseBody : TeaModel {
        /// <summary>
        /// An array that consists of the types of check items.
        /// </summary>
        [NameInMap("List")]
        [Validation(Required=false)]
        public List<DescribeRiskItemTypeResponseBodyList> List { get; set; }
        public class DescribeRiskItemTypeResponseBodyList : TeaModel {
            /// <summary>
            /// The ID of the check item.
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// The name of the check item type. Example: Identity authentication and permissions.
            /// </summary>
            [NameInMap("Title")]
            [Validation(Required=false)]
            public string Title { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
