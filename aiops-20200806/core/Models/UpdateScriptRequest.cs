// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aiops20200806.Models
{
    public class UpdateScriptRequest : TeaModel {
        [NameInMap("HandleSuggestDesc")]
        [Validation(Required=false)]
        public string HandleSuggestDesc { get; set; }

        [NameInMap("Id")]
        [Validation(Required=false)]
        public int? Id { get; set; }

        [NameInMap("MetricName")]
        [Validation(Required=false)]
        public string MetricName { get; set; }

        [NameInMap("OperaUid")]
        [Validation(Required=false)]
        public string OperaUid { get; set; }

        [NameInMap("ProductCode")]
        [Validation(Required=false)]
        public string ProductCode { get; set; }

        [NameInMap("RootCauseDesc")]
        [Validation(Required=false)]
        public string RootCauseDesc { get; set; }

        [NameInMap("RootCausesLog")]
        [Validation(Required=false)]
        public string RootCausesLog { get; set; }

        [NameInMap("SceneId")]
        [Validation(Required=false)]
        public string SceneId { get; set; }

        [NameInMap("Script")]
        [Validation(Required=false)]
        public string Script { get; set; }

        [NameInMap("ScriptLanguage")]
        [Validation(Required=false)]
        public string ScriptLanguage { get; set; }

        [NameInMap("ScriptName")]
        [Validation(Required=false)]
        public string ScriptName { get; set; }

        [NameInMap("Status")]
        [Validation(Required=false)]
        public int? Status { get; set; }

        [NameInMap("Type")]
        [Validation(Required=false)]
        public int? Type { get; set; }

    }

}
