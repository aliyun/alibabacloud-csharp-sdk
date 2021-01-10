// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class QueryLinkeBahamutIterationaddunitRequest : TeaModel {
        [NameInMap("AppName")]
        [Validation(Required=false)]
        public string AppName { get; set; }

        [NameInMap("BranchPostfix")]
        [Validation(Required=false)]
        public string BranchPostfix { get; set; }

        [NameInMap("FromTag")]
        [Validation(Required=false)]
        public string FromTag { get; set; }

        [NameInMap("IterationId")]
        [Validation(Required=false)]
        public string IterationId { get; set; }

        [NameInMap("MembersRepeatList")]
        [Validation(Required=false)]
        public List<string> MembersRepeatList { get; set; }

        [NameInMap("SameBranch")]
        [Validation(Required=false)]
        public string SameBranch { get; set; }

        [NameInMap("Stringversion")]
        [Validation(Required=false)]
        public string Stringversion { get; set; }

        [NameInMap("WorkItemsRepeatList")]
        [Validation(Required=false)]
        public List<string> WorkItemsRepeatList { get; set; }

    }

}
