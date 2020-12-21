// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vcs20200515.Models
{
    public class CreateCorpRequest : TeaModel {
        [NameInMap("CorpName")]
        [Validation(Required=false)]
        public string CorpName { get; set; }

        [NameInMap("AppName")]
        [Validation(Required=false)]
        public string AppName { get; set; }

        [NameInMap("ParentCorpId")]
        [Validation(Required=false)]
        public string ParentCorpId { get; set; }

        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("AlgorithmType")]
        [Validation(Required=false)]
        public string AlgorithmType { get; set; }

        [NameInMap("IsvSubId")]
        [Validation(Required=false)]
        public string IsvSubId { get; set; }

        [NameInMap("IconPath")]
        [Validation(Required=false)]
        public string IconPath { get; set; }

    }

}
