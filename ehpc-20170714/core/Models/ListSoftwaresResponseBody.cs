// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20170714.Models
{
    public class ListSoftwaresResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Softwares")]
        [Validation(Required=false)]
        public ListSoftwaresResponseBodySoftwares Softwares { get; set; }
        public class ListSoftwaresResponseBodySoftwares : TeaModel {
            [NameInMap("SoftwareInfo")]
            [Validation(Required=false)]
            public List<ListSoftwaresResponseBodySoftwaresSoftwareInfo> SoftwareInfo { get; set; }
            public class ListSoftwaresResponseBodySoftwaresSoftwareInfo : TeaModel {
                [NameInMap("AccountType")]
                [Validation(Required=false)]
                public string AccountType { get; set; }

                [NameInMap("AccountVersion")]
                [Validation(Required=false)]
                public string AccountVersion { get; set; }

                [NameInMap("Applications")]
                [Validation(Required=false)]
                public ListSoftwaresResponseBodySoftwaresSoftwareInfoApplications Applications { get; set; }
                public class ListSoftwaresResponseBodySoftwaresSoftwareInfoApplications : TeaModel {
                    [NameInMap("ApplicationInfo")]
                    [Validation(Required=false)]
                    public List<ListSoftwaresResponseBodySoftwaresSoftwareInfoApplicationsApplicationInfo> ApplicationInfo { get; set; }
                    public class ListSoftwaresResponseBodySoftwaresSoftwareInfoApplicationsApplicationInfo : TeaModel {
                        [NameInMap("Name")]
                        [Validation(Required=false)]
                        public string Name { get; set; }

                        [NameInMap("Required")]
                        [Validation(Required=false)]
                        public bool? Required { get; set; }

                        [NameInMap("Tag")]
                        [Validation(Required=false)]
                        public string Tag { get; set; }

                        [NameInMap("Version")]
                        [Validation(Required=false)]
                        public string Version { get; set; }

                    }

                }

                [NameInMap("EhpcVersion")]
                [Validation(Required=false)]
                public string EhpcVersion { get; set; }

                [NameInMap("OsTag")]
                [Validation(Required=false)]
                public string OsTag { get; set; }

                [NameInMap("SchedulerType")]
                [Validation(Required=false)]
                public string SchedulerType { get; set; }

                [NameInMap("SchedulerVersion")]
                [Validation(Required=false)]
                public string SchedulerVersion { get; set; }

            }

        }

    }

}
