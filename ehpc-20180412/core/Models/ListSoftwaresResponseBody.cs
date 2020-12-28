// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20180412.Models
{
    public class ListSoftwaresResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Softwares")]
        [Validation(Required=false)]
        public List<ListSoftwaresResponseBodySoftwares> Softwares { get; set; }
        public class ListSoftwaresResponseBodySoftwares : TeaModel {
            [NameInMap("SchedulerType")]
            [Validation(Required=false)]
            public string SchedulerType { get; set; }

            [NameInMap("OsTag")]
            [Validation(Required=false)]
            public string OsTag { get; set; }

            [NameInMap("SchedulerVersion")]
            [Validation(Required=false)]
            public string SchedulerVersion { get; set; }

            [NameInMap("AccountVersion")]
            [Validation(Required=false)]
            public string AccountVersion { get; set; }

            [NameInMap("Applications")]
            [Validation(Required=false)]
            public List<ListSoftwaresResponseBodySoftwaresApplications> Applications { get; set; }
            public class ListSoftwaresResponseBodySoftwaresApplications : TeaModel {
                [NameInMap("Required")]
                [Validation(Required=false)]
                public bool? Required { get; set; }

                [NameInMap("Version")]
                [Validation(Required=false)]
                public string Version { get; set; }

                [NameInMap("Tag")]
                [Validation(Required=false)]
                public string Tag { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

            [NameInMap("AccountType")]
            [Validation(Required=false)]
            public string AccountType { get; set; }

            [NameInMap("EhpcVersion")]
            [Validation(Required=false)]
            public string EhpcVersion { get; set; }

        }

    }

}
