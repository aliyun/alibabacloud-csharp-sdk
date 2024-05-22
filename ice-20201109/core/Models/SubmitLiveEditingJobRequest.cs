// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class SubmitLiveEditingJobRequest : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("Clips")]
        [Validation(Required=false)]
        public string Clips { get; set; }

        [NameInMap("LiveStreamConfig")]
        [Validation(Required=false)]
        public string LiveStreamConfig { get; set; }

        [NameInMap("MediaProduceConfig")]
        [Validation(Required=false)]
        public string MediaProduceConfig { get; set; }

        [NameInMap("OutputMediaConfig")]
        [Validation(Required=false)]
        public string OutputMediaConfig { get; set; }

        [NameInMap("OutputMediaTarget")]
        [Validation(Required=false)]
        public string OutputMediaTarget { get; set; }

        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public string ProjectId { get; set; }

        [NameInMap("UserData")]
        [Validation(Required=false)]
        public string UserData { get; set; }

    }

}
