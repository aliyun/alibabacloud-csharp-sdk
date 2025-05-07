// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Buss20220822.Models
{
    public class SearchPunishRecordsShrinkRequest : TeaModel {
        [NameInMap("ActionCodes")]
        [Validation(Required=false)]
        public string ActionCodesShrink { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("AliUid")]
        [Validation(Required=false)]
        public string AliUid { get; set; }

        [NameInMap("BussinessCodes")]
        [Validation(Required=false)]
        public string BussinessCodes { get; set; }

        [NameInMap("CaseCodes")]
        [Validation(Required=false)]
        public string CaseCodesShrink { get; set; }

        [NameInMap("Domain")]
        [Validation(Required=false)]
        public string Domain { get; set; }

        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        [NameInMap("EventCodes")]
        [Validation(Required=false)]
        public string EventCodesShrink { get; set; }

        [NameInMap("Ip")]
        [Validation(Required=false)]
        public string Ip { get; set; }

        [NameInMap("Page")]
        [Validation(Required=false)]
        public string Page { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public string PageSize { get; set; }

        [NameInMap("PunishStatus")]
        [Validation(Required=false)]
        public string PunishStatusShrink { get; set; }

        [NameInMap("ResourceId")]
        [Validation(Required=false)]
        public string ResourceId { get; set; }

        [NameInMap("SourceCodes")]
        [Validation(Required=false)]
        public string SourceCodesShrink { get; set; }

        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

        [NameInMap("Url")]
        [Validation(Required=false)]
        public string Url { get; set; }

        [NameInMap("UrlFuzzy")]
        [Validation(Required=false)]
        public string UrlFuzzy { get; set; }

    }

}
