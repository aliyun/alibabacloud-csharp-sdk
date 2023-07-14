// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class CreateOrUpdateContactGroupResponseBody : TeaModel {
        /// <summary>
        /// The information about the alert contact group.
        /// </summary>
        [NameInMap("AlertContactGroup")]
        [Validation(Required=false)]
        public CreateOrUpdateContactGroupResponseBodyAlertContactGroup AlertContactGroup { get; set; }
        public class CreateOrUpdateContactGroupResponseBodyAlertContactGroup : TeaModel {
            /// <summary>
            /// The ID of the alert contact group.
            /// </summary>
            [NameInMap("ContactGroupId")]
            [Validation(Required=false)]
            public float? ContactGroupId { get; set; }

            /// <summary>
            /// The name of the alert contact group.
            /// </summary>
            [NameInMap("ContactGroupName")]
            [Validation(Required=false)]
            public string ContactGroupName { get; set; }

            /// <summary>
            /// The IDs of the contacts that are included in the alert contact group.
            /// </summary>
            [NameInMap("ContactIds")]
            [Validation(Required=false)]
            public string ContactIds { get; set; }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
