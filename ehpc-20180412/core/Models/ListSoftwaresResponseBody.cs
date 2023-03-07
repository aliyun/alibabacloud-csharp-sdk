// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20180412.Models
{
    public class ListSoftwaresResponseBody : TeaModel {
        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The list of the information about the software installed in the cluster.
        /// </summary>
        [NameInMap("Softwares")]
        [Validation(Required=false)]
        public ListSoftwaresResponseBodySoftwares Softwares { get; set; }
        public class ListSoftwaresResponseBodySoftwares : TeaModel {
            [NameInMap("SoftwareInfo")]
            [Validation(Required=false)]
            public List<ListSoftwaresResponseBodySoftwaresSoftwareInfo> SoftwareInfo { get; set; }
            public class ListSoftwaresResponseBodySoftwaresSoftwareInfo : TeaModel {
                /// <summary>
                /// The service type of the domain account. Valid values:
                /// 
                /// *   nis
                /// *   ldap
                /// </summary>
                [NameInMap("AccountType")]
                [Validation(Required=false)]
                public string AccountType { get; set; }

                /// <summary>
                /// The version of the domain account service.
                /// </summary>
                [NameInMap("AccountVersion")]
                [Validation(Required=false)]
                public string AccountVersion { get; set; }

                /// <summary>
                /// The list of the software in the cluster.
                /// </summary>
                [NameInMap("Applications")]
                [Validation(Required=false)]
                public ListSoftwaresResponseBodySoftwaresSoftwareInfoApplications Applications { get; set; }
                public class ListSoftwaresResponseBodySoftwaresSoftwareInfoApplications : TeaModel {
                    [NameInMap("ApplicationInfo")]
                    [Validation(Required=false)]
                    public List<ListSoftwaresResponseBodySoftwaresSoftwareInfoApplicationsApplicationInfo> ApplicationInfo { get; set; }
                    public class ListSoftwaresResponseBodySoftwaresSoftwareInfoApplicationsApplicationInfo : TeaModel {
                        /// <summary>
                        /// The name of the software.
                        /// </summary>
                        [NameInMap("Name")]
                        [Validation(Required=false)]
                        public string Name { get; set; }

                        /// <summary>
                        /// Indicates whether the software is required. Valid values:
                        /// 
                        /// *   false: optional
                        /// *   true: required
                        /// </summary>
                        [NameInMap("Required")]
                        [Validation(Required=false)]
                        public bool? Required { get; set; }

                        /// <summary>
                        /// The tag of the software.
                        /// </summary>
                        [NameInMap("Tag")]
                        [Validation(Required=false)]
                        public string Tag { get; set; }

                        /// <summary>
                        /// The version of the software.
                        /// </summary>
                        [NameInMap("Version")]
                        [Validation(Required=false)]
                        public string Version { get; set; }

                    }

                }

                /// <summary>
                /// The version of the E-HPC client.
                /// </summary>
                [NameInMap("EhpcVersion")]
                [Validation(Required=false)]
                public string EhpcVersion { get; set; }

                /// <summary>
                /// The image tag of the cluster.
                /// </summary>
                [NameInMap("OsTag")]
                [Validation(Required=false)]
                public string OsTag { get; set; }

                /// <summary>
                /// The type of the scheduler. Valid values:
                /// 
                /// *   pbs
                /// *   pbs19
                /// *   slurm
                /// *   slurm19
                /// *   slurm20
                /// *   opengridscheduler
                /// *   deadline
                /// *   gridengine
                /// *   cube
                /// *   custom
                /// </summary>
                [NameInMap("SchedulerType")]
                [Validation(Required=false)]
                public string SchedulerType { get; set; }

                /// <summary>
                /// The version of the scheduler.
                /// </summary>
                [NameInMap("SchedulerVersion")]
                [Validation(Required=false)]
                public string SchedulerVersion { get; set; }

            }

        }

    }

}
