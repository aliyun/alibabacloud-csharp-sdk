// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Chatbot20220408.Models
{
    public class SearchFaqRequest : TeaModel {
        [NameInMap("AgentKey")]
        [Validation(Required=false)]
        public string AgentKey { get; set; }

        [NameInMap("CategoryIds")]
        [Validation(Required=false)]
        public List<long?> CategoryIds { get; set; }

        [NameInMap("CreateTimeBegin")]
        [Validation(Required=false)]
        public string CreateTimeBegin { get; set; }

        [NameInMap("CreateTimeEnd")]
        [Validation(Required=false)]
        public string CreateTimeEnd { get; set; }

        [NameInMap("CreateUserName")]
        [Validation(Required=false)]
        public string CreateUserName { get; set; }

        [NameInMap("EndTimeBegin")]
        [Validation(Required=false)]
        public string EndTimeBegin { get; set; }

        [NameInMap("EndTimeEnd")]
        [Validation(Required=false)]
        public string EndTimeEnd { get; set; }

        [NameInMap("Keyword")]
        [Validation(Required=false)]
        public string Keyword { get; set; }

        [NameInMap("ModifyTimeBegin")]
        [Validation(Required=false)]
        public string ModifyTimeBegin { get; set; }

        [NameInMap("ModifyTimeEnd")]
        [Validation(Required=false)]
        public string ModifyTimeEnd { get; set; }

        [NameInMap("ModifyUserName")]
        [Validation(Required=false)]
        public string ModifyUserName { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("SearchScope")]
        [Validation(Required=false)]
        public int? SearchScope { get; set; }

        [NameInMap("StartTimeBegin")]
        [Validation(Required=false)]
        public string StartTimeBegin { get; set; }

        [NameInMap("StartTimeEnd")]
        [Validation(Required=false)]
        public string StartTimeEnd { get; set; }

        [NameInMap("Status")]
        [Validation(Required=false)]
        public int? Status { get; set; }

    }

}
