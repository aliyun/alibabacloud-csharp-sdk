// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class UpdateUninstallApplicationsStatusResponseBody : TeaModel {
        /// <summary>
        /// <para>List of uninstall requests.</para>
        /// </summary>
        [NameInMap("Applications")]
        [Validation(Required=false)]
        public List<UpdateUninstallApplicationsStatusResponseBodyApplications> Applications { get; set; }
        public class UpdateUninstallApplicationsStatusResponseBodyApplications : TeaModel {
            /// <summary>
            /// <para>Uninstall request ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>uninstall-app-6646831ac314****</para>
            /// </summary>
            [NameInMap("ApplicationId")]
            [Validation(Required=false)]
            public string ApplicationId { get; set; }

            /// <summary>
            /// <para>Time when the uninstall request was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-07-17 18:46:55</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>Department to which the user belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>测试部</para>
            /// </summary>
            [NameInMap("Department")]
            [Validation(Required=false)]
            public string Department { get; set; }

            /// <summary>
            /// <para>Endpoint device ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>36efa42d-2c32-c4dc-e3fc-8541e33a****</para>
            /// </summary>
            [NameInMap("DevTag")]
            [Validation(Required=false)]
            public string DevTag { get; set; }

            /// <summary>
            /// <para>Operating system type of the endpoint device. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>Windows</b>: Windows operating system.</para>
            /// </description></item>
            /// <item><description><para><b>macOS</b>: macOS operating system.</para>
            /// </description></item>
            /// <item><description><para><b>Linux</b>: Linux operating system.</para>
            /// </description></item>
            /// <item><description><para><b>Android</b>: Android operating system.</para>
            /// </description></item>
            /// <item><description><para><b>iOS</b>: iOS operating system.</para>
            /// </description></item>
            /// <item><description><para><b>Windows_Wuying</b>: Alibaba Cloud Desktop operating system.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Windows</para>
            /// </summary>
            [NameInMap("DevType")]
            [Validation(Required=false)]
            public string DevType { get; set; }

            /// <summary>
            /// <para>Device name of the endpoint.</para>
            /// 
            /// <b>Example:</b>
            /// <para>win10-64bit</para>
            /// </summary>
            [NameInMap("Hostname")]
            [Validation(Required=false)]
            public string Hostname { get; set; }

            /// <summary>
            /// <para>Name of the user identity source.</para>
            /// 
            /// <b>Example:</b>
            /// <para>测试身份源</para>
            /// </summary>
            [NameInMap("IdpName")]
            [Validation(Required=false)]
            public string IdpName { get; set; }

            /// <summary>
            /// <para>Indicates whether the uninstall has been executed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("IsUninstall")]
            [Validation(Required=false)]
            public bool? IsUninstall { get; set; }

            /// <summary>
            /// <para>MAC address of the endpoint device.</para>
            /// 
            /// <b>Example:</b>
            /// <para>00:16:XX:XX:7c:46</para>
            /// </summary>
            [NameInMap("Mac")]
            [Validation(Required=false)]
            public string Mac { get; set; }

            /// <summary>
            /// <para>Reason for the request.</para>
            /// 
            /// <b>Example:</b>
            /// <para>这是一个测试</para>
            /// </summary>
            [NameInMap("Reason")]
            [Validation(Required=false)]
            public string Reason { get; set; }

            /// <summary>
            /// <para>User ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>su_e8f218fb171edd167c2ad917d21f53148bdefc510ca1f3c3cc0249d3643d****</para>
            /// </summary>
            [NameInMap("SaseUserId")]
            [Validation(Required=false)]
            public string SaseUserId { get; set; }

            /// <summary>
            /// <para>Status of the uninstall request. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>Pending</b>: Pending.</para>
            /// </description></item>
            /// <item><description><para><b>Approved</b>: Approved.</para>
            /// </description></item>
            /// <item><description><para><b>Rejected</b>: Rejected.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Approved</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>Username.</para>
            /// 
            /// <b>Example:</b>
            /// <para>王先生</para>
            /// </summary>
            [NameInMap("Username")]
            [Validation(Required=false)]
            public string Username { get; set; }

        }

        /// <summary>
        /// <para>The ID of this request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9B769522-D50C-5978-8981-52BE800D6099</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
