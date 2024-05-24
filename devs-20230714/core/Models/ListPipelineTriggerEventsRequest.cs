// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devs20230714.Models
{
    public class ListPipelineTriggerEventsRequest : TeaModel {
        [NameInMap("keyword")]
        [Validation(Required=false)]
        public string Keyword { get; set; }

        [NameInMap("labelSelector")]
        [Validation(Required=false)]
        public List<string> LabelSelector { get; set; }

        [NameInMap("pageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

    }

}
