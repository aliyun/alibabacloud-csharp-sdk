// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Buss20220822.Models
{
    public class PunishResourceSearchShrinkRequest : TeaModel {
        [NameInMap("ActionCodes")]
        [Validation(Required=false)]
        public string ActionCodesShrink { get; set; }

        [NameInMap("BussinessCodes")]
        [Validation(Required=false)]
        public string BussinessCodesShrink { get; set; }

        [NameInMap("Class")]
        [Validation(Required=false)]
        public string Class { get; set; }

        [NameInMap("Domain")]
        [Validation(Required=false)]
        public string Domain { get; set; }

        [NameInMap("EndDate")]
        [Validation(Required=false)]
        public long? EndDate { get; set; }

        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("Ip")]
        [Validation(Required=false)]
        public string Ip { get; set; }

        [NameInMap("Page")]
        [Validation(Required=false)]
        public long? Page { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        [NameInMap("SourceCodes")]
        [Validation(Required=false)]
        public string SourceCodesShrink { get; set; }

        [NameInMap("StartDate")]
        [Validation(Required=false)]
        public long? StartDate { get; set; }

        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        [NameInMap("Url")]
        [Validation(Required=false)]
        public string Url { get; set; }

        [NameInMap("UserIds")]
        [Validation(Required=false)]
        public string UserIdsShrink { get; set; }

    }

}
