// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class Spec : TeaModel {
        [NameInMap("Backbone")]
        [Validation(Required=false)]
        public CustomParams Backbone { get; set; }

        [NameInMap("ClassNum")]
        [Validation(Required=false)]
        public long? ClassNum { get; set; }

        [NameInMap("Head")]
        [Validation(Required=false)]
        public CustomParams Head { get; set; }

        [NameInMap("InputChannel")]
        [Validation(Required=false)]
        public long? InputChannel { get; set; }

        [NameInMap("Loss")]
        [Validation(Required=false)]
        public CustomParams Loss { get; set; }

        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("Neck")]
        [Validation(Required=false)]
        public CustomParams Neck { get; set; }

        [NameInMap("NumLandmarks")]
        [Validation(Required=false)]
        public long? NumLandmarks { get; set; }

        [NameInMap("PretrainedPath")]
        [Validation(Required=false)]
        public string PretrainedPath { get; set; }

    }

}
