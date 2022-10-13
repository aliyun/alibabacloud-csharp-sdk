// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.UniMkt20181212.Models
{
    public class SearchAdvertisingShrinkRequest : TeaModel {
        [NameInMap("App")]
        [Validation(Required=false)]
        public string AppShrink { get; set; }

        [NameInMap("Device")]
        [Validation(Required=false)]
        public string DeviceShrink { get; set; }

        [NameInMap("Ext")]
        [Validation(Required=false)]
        public string ExtShrink { get; set; }

        [NameInMap("Id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        [NameInMap("Imp")]
        [Validation(Required=false)]
        public string ImpShrink { get; set; }

        [NameInMap("Test")]
        [Validation(Required=false)]
        public int? Test { get; set; }

        [NameInMap("User")]
        [Validation(Required=false)]
        public string UserShrink { get; set; }

    }

}
