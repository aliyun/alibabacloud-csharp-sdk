// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alinlp20200629.Models
{
    public class PostMSSearchEnhanceRequest : TeaModel {
        [NameInMap("Body")]
        [Validation(Required=false)]
        public string Body { get; set; }

        [NameInMap("CustomConfigInfo")]
        [Validation(Required=false)]
        public Dictionary<string, object> CustomConfigInfo { get; set; }

        [NameInMap("Debug")]
        [Validation(Required=false)]
        public bool? Debug { get; set; }

        [NameInMap("Fields")]
        [Validation(Required=false)]
        public List<string> Fields { get; set; }

        [NameInMap("Filters")]
        [Validation(Required=false)]
        public string Filters { get; set; }

        [NameInMap("MinScore")]
        [Validation(Required=false)]
        public double? MinScore { get; set; }

        [NameInMap("Page")]
        [Validation(Required=false)]
        public int? Page { get; set; }

        [NameInMap("Queries")]
        [Validation(Required=false)]
        public string Queries { get; set; }

        [NameInMap("RankModelInfo")]
        [Validation(Required=false)]
        public Dictionary<string, object> RankModelInfo { get; set; }

        [NameInMap("Rows")]
        [Validation(Required=false)]
        public int? Rows { get; set; }

        [NameInMap("ServiceId")]
        [Validation(Required=false)]
        public long? ServiceId { get; set; }

        [NameInMap("Sort")]
        [Validation(Required=false)]
        public List<string> Sort { get; set; }

        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        [NameInMap("Uq")]
        [Validation(Required=false)]
        public string Uq { get; set; }

    }

}
