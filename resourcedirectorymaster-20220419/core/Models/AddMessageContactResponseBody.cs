// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceDirectoryMaster20220419.Models
{
    public class AddMessageContactResponseBody : TeaModel {
        /// <summary>
        /// The information about the contact.
        /// </summary>
        [NameInMap("Contact")]
        [Validation(Required=false)]
        public AddMessageContactResponseBodyContact Contact { get; set; }
        public class AddMessageContactResponseBodyContact : TeaModel {
            /// <summary>
            /// The ID of the contact.
            /// </summary>
            [NameInMap("ContactId")]
            [Validation(Required=false)]
            public string ContactId { get; set; }

            /// <summary>
            /// The time when the contact was created.
            /// </summary>
            [NameInMap("CreateDate")]
            [Validation(Required=false)]
            public string CreateDate { get; set; }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
