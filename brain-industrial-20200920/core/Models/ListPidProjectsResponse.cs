// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Brain_industrial20200920.Models
{
    public class ListPidProjectsResponse : TeaModel {
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

        [NameInMap("PageSize")]
        [Validation(Required=true)]
        public int? PageSize { get; set; }

        [NameInMap("CurrentPage")]
        [Validation(Required=true)]
        public int? CurrentPage { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=true)]
        public long TotalCount { get; set; }

        [NameInMap("PidProjectList")]
        [Validation(Required=true)]
        public List<ListPidProjectsResponsePidProjectList> PidProjectList { get; set; }
        public class ListPidProjectsResponsePidProjectList : TeaModel {
            [NameInMap("PidProjectId")]
            [Validation(Required=true)]
            public string PidProjectId { get; set; }

            [NameInMap("PidProjectName")]
            [Validation(Required=true)]
            public string PidProjectName { get; set; }

            [NameInMap("PidProjectDesc")]
            [Validation(Required=true)]
            public string PidProjectDesc { get; set; }

            [NameInMap("PidOrganisationId")]
            [Validation(Required=true)]
            public string PidOrganisationId { get; set; }

        }

    }

}
