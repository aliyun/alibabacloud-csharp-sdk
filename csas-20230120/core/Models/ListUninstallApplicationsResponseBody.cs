// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class ListUninstallApplicationsResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of uninstall applications.</para>
        /// </summary>
        [NameInMap("Applications")]
        [Validation(Required=false)]
        public List<ListUninstallApplicationsResponseBodyApplications> Applications { get; set; }
        public class ListUninstallApplicationsResponseBodyApplications : TeaModel {
            /// <summary>
            /// <para>The uninstall application ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>uninstall-app-6646831ac314****</para>
            /// </summary>
            [NameInMap("ApplicationId")]
            [Validation(Required=false)]
            public string ApplicationId { get; set; }

            /// <summary>
            /// <para>The time when the uninstall application was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-07-17 18:46:55</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The department to which the user belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Testing Department</para>
            /// </summary>
            [NameInMap("Department")]
            [Validation(Required=false)]
            public string Department { get; set; }

            /// <summary>
            /// <para>The ID of the terminal device.</para>
            /// 
            /// <b>Example:</b>
            /// <para>36efa42d-2c32-c4dc-e3fc-8541e33a****</para>
            /// </summary>
            [NameInMap("DevTag")]
            [Validation(Required=false)]
            public string DevTag { get; set; }

            /// <summary>
            /// <para>The operating system type of the terminal device. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Windows</b>: Windows.</description></item>
            /// <item><description><b>macOS</b>: macOS.</description></item>
            /// <item><description><b>Linux</b>: Linux.</description></item>
            /// <item><description><b>Android</b>: Android.</description></item>
            /// <item><description><b>iOS</b>: iOS.</description></item>
            /// <item><description><b>Windows_Wuying</b>: WUYING Workspace.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Windows</para>
            /// </summary>
            [NameInMap("DevType")]
            [Validation(Required=false)]
            public string DevType { get; set; }

            /// <summary>
            /// <para>The list of full department paths.</para>
            /// </summary>
            [NameInMap("FullDepartment")]
            [Validation(Required=false)]
            public List<string> FullDepartment { get; set; }

            /// <summary>
            /// <para>The name of the terminal device.</para>
            /// 
            /// <b>Example:</b>
            /// <para>win10-64bit</para>
            /// </summary>
            [NameInMap("Hostname")]
            [Validation(Required=false)]
            public string Hostname { get; set; }

            /// <summary>
            /// <para>The name of the user identity source.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Test identity source</para>
            /// </summary>
            [NameInMap("IdpName")]
            [Validation(Required=false)]
            public string IdpName { get; set; }

            /// <summary>
            /// <para>Indicates whether the uninstallation has been performed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("IsUninstall")]
            [Validation(Required=false)]
            public bool? IsUninstall { get; set; }

            /// <summary>
            /// <para>The MAC address of the terminal device.</para>
            /// 
            /// <b>Example:</b>
            /// <para>00:16:XX:XX:7c:46</para>
            /// </summary>
            [NameInMap("Mac")]
            [Validation(Required=false)]
            public string Mac { get; set; }

            /// <summary>
            /// <para>The reason for the application.</para>
            /// 
            /// <b>Example:</b>
            /// <para>This is a test</para>
            /// </summary>
            [NameInMap("Reason")]
            [Validation(Required=false)]
            public string Reason { get; set; }

            /// <summary>
            /// <para>The user ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>su_e8f218fb171edd167c2ad917d21f53148bdefc510ca1f3c3cc0249d3643d****</para>
            /// </summary>
            [NameInMap("SaseUserId")]
            [Validation(Required=false)]
            public string SaseUserId { get; set; }

            /// <summary>
            /// <para>The uninstall application status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Pending</b>: Pending processing.</description></item>
            /// <item><description><b>Approved</b>: Approved.</description></item>
            /// <item><description><b>Rejected</b>: Rejected.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Approved</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The username.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Mr. Wang</para>
            /// </summary>
            [NameInMap("Username")]
            [Validation(Required=false)]
            public string Username { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>58D6B23E-E5DA-5418-8F61-51A3B5A30049</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of uninstall applications.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalNum")]
        [Validation(Required=false)]
        public long? TotalNum { get; set; }

    }

}
