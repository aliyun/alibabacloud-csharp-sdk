// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cr20181201.Models
{
    public class ListRepoTriggerResponseBody : TeaModel {
        [NameInMap("IsSuccess")]
        [Validation(Required=false)]
        public bool? IsSuccess { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Triggers")]
        [Validation(Required=false)]
        public List<ListRepoTriggerResponseBodyTriggers> Triggers { get; set; }
        public class ListRepoTriggerResponseBodyTriggers : TeaModel {
            [NameInMap("TriggerName")]
            [Validation(Required=false)]
            public string TriggerName { get; set; }

            [NameInMap("RepoEvent")]
            [Validation(Required=false)]
            public string RepoEvent { get; set; }

            [NameInMap("TriggerId")]
            [Validation(Required=false)]
            public string TriggerId { get; set; }

            [NameInMap("TriggerUrl")]
            [Validation(Required=false)]
            public string TriggerUrl { get; set; }

            [NameInMap("TriggerType")]
            [Validation(Required=false)]
            public string TriggerType { get; set; }

            [NameInMap("TriggerTag")]
            [Validation(Required=false)]
            public string TriggerTag { get; set; }

        }

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

    }

}
