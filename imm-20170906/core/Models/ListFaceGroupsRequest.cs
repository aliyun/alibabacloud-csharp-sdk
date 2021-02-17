// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20170906.Models
{
    public class ListFaceGroupsRequest : TeaModel {
        [NameInMap("Project")]
        [Validation(Required=false)]
        public string Project { get; set; }

        [NameInMap("SetId")]
        [Validation(Required=false)]
        public string SetId { get; set; }

        [NameInMap("Marker")]
        [Validation(Required=false)]
        public string Marker { get; set; }

        [NameInMap("Limit")]
        [Validation(Required=false)]
        public int? Limit { get; set; }

        [NameInMap("Order")]
        [Validation(Required=false)]
        public string Order { get; set; }

        [NameInMap("OrderBy")]
        [Validation(Required=false)]
        public string OrderBy { get; set; }

        [NameInMap("RemarksAQuery")]
        [Validation(Required=false)]
        public string RemarksAQuery { get; set; }

        [NameInMap("RemarksBQuery")]
        [Validation(Required=false)]
        public string RemarksBQuery { get; set; }

        [NameInMap("RemarksCQuery")]
        [Validation(Required=false)]
        public string RemarksCQuery { get; set; }

        [NameInMap("RemarksDQuery")]
        [Validation(Required=false)]
        public string RemarksDQuery { get; set; }

        [NameInMap("RemarksArrayAQuery")]
        [Validation(Required=false)]
        public string RemarksArrayAQuery { get; set; }

        [NameInMap("RemarksArrayBQuery")]
        [Validation(Required=false)]
        public string RemarksArrayBQuery { get; set; }

        [NameInMap("ExternalId")]
        [Validation(Required=false)]
        public string ExternalId { get; set; }

    }

}
