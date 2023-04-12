// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceDirectoryMaster20220419.Models
{
    public class AddMessageContactResponseBody : TeaModel {
        [NameInMap("Contact")]
        [Validation(Required=false)]
        public AddMessageContactResponseBodyContact Contact { get; set; }
        public class AddMessageContactResponseBodyContact : TeaModel {
            [NameInMap("ContactId")]
            [Validation(Required=false)]
            public string ContactId { get; set; }

            [NameInMap("CreateDate")]
            [Validation(Required=false)]
            public string CreateDate { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
