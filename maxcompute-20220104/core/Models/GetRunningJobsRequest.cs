// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MaxCompute20220104.Models
{
    public class GetRunningJobsRequest : TeaModel {
        [NameInMap("from")]
        [Validation(Required=false)]
        public long? From { get; set; }

        [NameInMap("jobOwnerList")]
        [Validation(Required=false)]
        public List<string> JobOwnerList { get; set; }

        [NameInMap("pageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        [NameInMap("quotaNicknameList")]
        [Validation(Required=false)]
        public List<string> QuotaNicknameList { get; set; }

        [NameInMap("to")]
        [Validation(Required=false)]
        public long? To { get; set; }

    }

}
