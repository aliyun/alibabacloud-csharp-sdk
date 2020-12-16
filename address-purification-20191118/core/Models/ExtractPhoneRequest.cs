// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Address_purification20191118.Models
{
    public class ExtractPhoneRequest : TeaModel {
        [NameInMap("ServiceCode")]
        [Validation(Required=true)]
        public string ServiceCode { get; set; }

        [NameInMap("Text")]
        [Validation(Required=true)]
        public string Text { get; set; }

        [NameInMap("DefaultProvince")]
        [Validation(Required=false)]
        public string DefaultProvince { get; set; }

        [NameInMap("DefaultCity")]
        [Validation(Required=false)]
        public string DefaultCity { get; set; }

        [NameInMap("DefaultDistrict")]
        [Validation(Required=false)]
        public string DefaultDistrict { get; set; }

        [NameInMap("AppKey")]
        [Validation(Required=true)]
        public string AppKey { get; set; }

    }

}
