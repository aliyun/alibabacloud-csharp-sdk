// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WebPlus20190320.Models
{
    public class DescribeApplicationsResponseBody : TeaModel {
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("Applications")]
        [Validation(Required=false)]
        public DescribeApplicationsResponseBodyApplications Applications { get; set; }
        public class DescribeApplicationsResponseBodyApplications : TeaModel {
            [NameInMap("Application")]
            [Validation(Required=false)]
            public List<DescribeApplicationsResponseBodyApplicationsApplication> Application { get; set; }
            public class DescribeApplicationsResponseBodyApplicationsApplication : TeaModel {
                public int? TotalEnvs { get; set; }
                public long? UpdateTime { get; set; }
                public string UpdateUsername { get; set; }
                public int? RunningEnvs { get; set; }
                public long? CreateTime { get; set; }
                public string CategoryName { get; set; }
                public string UsingSharedStorage { get; set; }
                public string CreateUsername { get; set; }
                public string AppName { get; set; }
                public string AppId { get; set; }
                public int? TerminatedEnvs { get; set; }
                public string AppDescription { get; set; }
            }
        };

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

    }

}
