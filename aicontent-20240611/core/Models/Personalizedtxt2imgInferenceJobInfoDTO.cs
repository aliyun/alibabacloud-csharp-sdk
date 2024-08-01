// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiContent20240611.Models
{
    public class Personalizedtxt2imgInferenceJobInfoDTO : TeaModel {
        [NameInMap("createUserId")]
        [Validation(Required=false)]
        public string CreateUserId { get; set; }

        [NameInMap("id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        [NameInMap("jobStatus")]
        [Validation(Required=false)]
        public string JobStatus { get; set; }

        [NameInMap("modelId")]
        [Validation(Required=false)]
        public string ModelId { get; set; }

        [NameInMap("resultImageUrl")]
        [Validation(Required=false)]
        public List<string> ResultImageUrl { get; set; }

    }

}
