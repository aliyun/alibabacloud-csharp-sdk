// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20180412.Models
{
    public class ListSoftwaresResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>04F0F334-1335-436C-A1D7-6C044FE7****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The list of the information about the software installed in the cluster.</para>
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
                /// <para>The service type of the domain account. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>nis</description></item>
                /// <item><description>ldap</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>nis</para>
                /// </summary>
                [NameInMap("AccountType")]
                [Validation(Required=false)]
                public string AccountType { get; set; }

                /// <summary>
                /// <para>The version of the domain account service.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2.31</para>
                /// </summary>
                [NameInMap("AccountVersion")]
                [Validation(Required=false)]
                public string AccountVersion { get; set; }

                /// <summary>
                /// <para>The list of the software in the cluster.</para>
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
                        /// <para>The name of the software.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>cudnnt</para>
                        /// </summary>
                        [NameInMap("Name")]
                        [Validation(Required=false)]
                        public string Name { get; set; }

                        /// <summary>
                        /// <para>Indicates whether the software is required. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description>false: optional</description></item>
                        /// <item><description>true: required</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>true</para>
                        /// </summary>
                        [NameInMap("Required")]
                        [Validation(Required=false)]
                        public bool? Required { get; set; }

                        /// <summary>
                        /// <para>The tag of the software.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>CUDNN_9.0</para>
                        /// </summary>
                        [NameInMap("Tag")]
                        [Validation(Required=false)]
                        public string Tag { get; set; }

                        /// <summary>
                        /// <para>The version of the software.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>9.0</para>
                        /// </summary>
                        [NameInMap("Version")]
                        [Validation(Required=false)]
                        public string Version { get; set; }

                    }

                }

                /// <summary>
                /// <para>The version of the E-HPC client.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1.0.0</para>
                /// </summary>
                [NameInMap("EhpcVersion")]
                [Validation(Required=false)]
                public string EhpcVersion { get; set; }

                /// <summary>
                /// <para>The image tag of the cluster.</para>
                /// 
                /// <b>Example:</b>
                /// <para>CentOS_7.2_64</para>
                /// </summary>
                [NameInMap("OsTag")]
                [Validation(Required=false)]
                public string OsTag { get; set; }

                /// <summary>
                /// <para>The type of the scheduler. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>pbs</description></item>
                /// <item><description>pbs19</description></item>
                /// <item><description>slurm</description></item>
                /// <item><description>slurm19</description></item>
                /// <item><description>slurm20</description></item>
                /// <item><description>opengridscheduler</description></item>
                /// <item><description>deadline</description></item>
                /// <item><description>gridengine</description></item>
                /// <item><description>cube</description></item>
                /// <item><description>custom</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>pbs</para>
                /// </summary>
                [NameInMap("SchedulerType")]
                [Validation(Required=false)]
                public string SchedulerType { get; set; }

                /// <summary>
                /// <para>The version of the scheduler.</para>
                /// 
                /// <b>Example:</b>
                /// <para>18.1.1</para>
                /// </summary>
                [NameInMap("SchedulerVersion")]
                [Validation(Required=false)]
                public string SchedulerVersion { get; set; }

            }

        }

    }

}
