// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Brain_industrial20200920.Models
{
    public class ListPidLoopsResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("Message")]
        [Validation(Required=true)]
        public string Message { get; set; }

        [NameInMap("Code")]
        [Validation(Required=true)]
        public string Code { get; set; }

        [NameInMap("Success")]
        [Validation(Required=true)]
        public bool? Success { get; set; }

        [NameInMap("CurrentPage")]
        [Validation(Required=true)]
        public int? CurrentPage { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=true)]
        public int? PageSize { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=true)]
        public long TotalCount { get; set; }

        [NameInMap("PidLoopList")]
        [Validation(Required=true)]
        public List<ListPidLoopsResponsePidLoopList> PidLoopList { get; set; }
        public class ListPidLoopsResponsePidLoopList : TeaModel {
            [NameInMap("PidLoopId")]
            [Validation(Required=true)]
            public string PidLoopId { get; set; }

            [NameInMap("PidLoopName")]
            [Validation(Required=true)]
            public string PidLoopName { get; set; }

            [NameInMap("Crucial")]
            [Validation(Required=true)]
            public bool? Crucial { get; set; }

            [NameInMap("PidPublishStatus")]
            [Validation(Required=true)]
            public string PidPublishStatus { get; set; }

            [NameInMap("ParameterTunningId")]
            [Validation(Required=true)]
            public string ParameterTunningId { get; set; }

            [NameInMap("PidLoopDcsType")]
            [Validation(Required=true)]
            public string PidLoopDcsType { get; set; }

            [NameInMap("PidLoopType")]
            [Validation(Required=true)]
            public string PidLoopType { get; set; }

            [NameInMap("PidLoopProgress")]
            [Validation(Required=true)]
            public string PidLoopProgress { get; set; }

            [NameInMap("PidLoopReportProgress")]
            [Validation(Required=true)]
            public string PidLoopReportProgress { get; set; }

            [NameInMap("PidLoopDataProgress")]
            [Validation(Required=true)]
            public string PidLoopDataProgress { get; set; }

            [NameInMap("ParameterTunningIdList")]
            [Validation(Required=true)]
            public List<string> ParameterTunningIdList { get; set; }

        }

    }

}
