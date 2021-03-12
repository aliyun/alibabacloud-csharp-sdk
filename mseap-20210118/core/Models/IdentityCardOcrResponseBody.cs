// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mseap20210118.Models
{
    public class IdentityCardOcrResponseBody : TeaModel {
        [NameInMap("Issue")]
        [Validation(Required=false)]
        public string Issue { get; set; }

        [NameInMap("ValidDate")]
        [Validation(Required=false)]
        public string ValidDate { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Address")]
        [Validation(Required=false)]
        public string Address { get; set; }

        [NameInMap("IdNumber")]
        [Validation(Required=false)]
        public string IdNumber { get; set; }

        [NameInMap("Gender")]
        [Validation(Required=false)]
        public string Gender { get; set; }

        [NameInMap("Nationality")]
        [Validation(Required=false)]
        public string Nationality { get; set; }

        [NameInMap("BirthDate")]
        [Validation(Required=false)]
        public string BirthDate { get; set; }

        [NameInMap("TrackId")]
        [Validation(Required=false)]
        public string TrackId { get; set; }

        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

    }

}
