// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DeregisterManagedInstanceResponseBody : TeaModel {
        /// <summary>
        /// <para>The managed instance.</para>
        /// </summary>
        [NameInMap("Instance")]
        [Validation(Required=false)]
        public DeregisterManagedInstanceResponseBodyInstance Instance { get; set; }
        public class DeregisterManagedInstanceResponseBodyInstance : TeaModel {
            /// <summary>
            /// <para>The activation code ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>4ECEEE12-56F1-4FBC-9AB1-890F7494****</para>
            /// </summary>
            [NameInMap("ActivationId")]
            [Validation(Required=false)]
            public string ActivationId { get; set; }

            /// <summary>
            /// <para>The version number of Cloud Assistant Agent.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2.2.0.102</para>
            /// </summary>
            [NameInMap("AgentVersion")]
            [Validation(Required=false)]
            public string AgentVersion { get; set; }

            /// <summary>
            /// <para>The hostname of the managed instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test-Hostname</para>
            /// </summary>
            [NameInMap("Hostname")]
            [Validation(Required=false)]
            public string Hostname { get; set; }

            /// <summary>
            /// <para>The managed instance ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>mi-hz01axdfas****</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The name of the managed instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test-InstanceName-001</para>
            /// </summary>
            [NameInMap("InstanceName")]
            [Validation(Required=false)]
            public string InstanceName { get; set; }

            /// <summary>
            /// <para>The public IP address of the managed instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para><c>47.8.**.**</c></para>
            /// </summary>
            [NameInMap("InternetIp")]
            [Validation(Required=false)]
            public string InternetIp { get; set; }

            /// <summary>
            /// <para>The internal IP address of the managed instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para><c>10.0.**.**</c></para>
            /// </summary>
            [NameInMap("IntranetIp")]
            [Validation(Required=false)]
            public string IntranetIp { get; set; }

            /// <summary>
            /// <para>The number of times that Cloud Assistant tasks were executed on the managed instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("InvocationCount")]
            [Validation(Required=false)]
            public long? InvocationCount { get; set; }

            /// <summary>
            /// <para>The time when the Cloud Assistant task was last executed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-01-20T09:00:40Z</para>
            /// </summary>
            [NameInMap("LastInvokedTime")]
            [Validation(Required=false)]
            public string LastInvokedTime { get; set; }

            /// <summary>
            /// <para>The machine code of the managed instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>e03231b37ab14e53b5795ad625fc****</para>
            /// </summary>
            [NameInMap("MachineId")]
            [Validation(Required=false)]
            public string MachineId { get; set; }

            /// <summary>
            /// <para>The operating system type of the managed instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>linux</para>
            /// </summary>
            [NameInMap("OsType")]
            [Validation(Required=false)]
            public string OsType { get; set; }

            /// <summary>
            /// <para>The version information about the operating system.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Linux_#38~18.04.1-Ubuntu SMP Wed Jan 6 18:26:30 UTC 2021_x86_64</para>
            /// </summary>
            [NameInMap("OsVersion")]
            [Validation(Required=false)]
            public string OsVersion { get; set; }

            /// <summary>
            /// <para>The time when the managed instance was registered.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-01-20T08:57:56Z</para>
            /// </summary>
            [NameInMap("RegistrationTime")]
            [Validation(Required=false)]
            public string RegistrationTime { get; set; }

            /// <summary>
            /// <para>The ID of the resource group to which the managed instance belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rg-123******</para>
            /// </summary>
            [NameInMap("ResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4ECEEE12-56F1-4FBC-9AB1-890F74942176</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
