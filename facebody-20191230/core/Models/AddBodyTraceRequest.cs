/**
 *
 */
// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Facebody20191230.Models
{
    public class AddBodyTraceRequest : TeaModel {
        [NameInMap("DbId")]
        [Validation(Required=false)]
        public long? DbId { get; set; }

        [NameInMap("ExtraData")]
        [Validation(Required=false)]
        public string ExtraData { get; set; }

        [NameInMap("Images")]
        [Validation(Required=false)]
        public List<AddBodyTraceRequestImages> Images { get; set; }
        public class AddBodyTraceRequestImages : TeaModel {
            [NameInMap("ImageData")]
            [Validation(Required=false)]
            public byte[] ImageData { get; set; }

            [NameInMap("ImageURL")]
            [Validation(Required=false)]
            public string ImageURL { get; set; }

        }

        [NameInMap("PersonId")]
        [Validation(Required=false)]
        public long? PersonId { get; set; }

    }

}
