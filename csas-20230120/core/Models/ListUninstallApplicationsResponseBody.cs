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
            /// <para>The user\&quot;s department.</para>
            /// 
            /// <b>Example:</b>
            /// <para>测试部</para>
            /// </summary>
            [NameInMap("Department")]
            [Validation(Required=false)]
            public string Department { get; set; }

            /// <summary>
            /// <para>The device ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>36efa42d-2c32-c4dc-e3fc-8541e33a****</para>
            /// </summary>
            [NameInMap("DevTag")]
            [Validation(Required=false)]
            public string DevTag { get; set; }

            /// <summary>
            /// <para>The operating system of the device. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>Windows</b></para>
            /// </description></item>
            /// <item><description><para><b>macOS</b></para>
            /// </description></item>
            /// <item><description><para><b>Linux</b></para>
            /// </description></item>
            /// <item><description><para><b>Android</b></para>
            /// </description></item>
            /// <item><description><para><b>iOS</b></para>
            /// </description></item>
            /// <item><description><para><b>Windows_Wuying</b>: Elastic Desktop Service.</para>
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
            /// <para>The list of full department paths.</para>
            /// </summary>
            [NameInMap("FullDepartment")]
            [Validation(Required=false)]
            public List<string> FullDepartment { get; set; }

            /// <summary>
            /// <para>The hostname of the device.</para>
            /// 
            /// <b>Example:</b>
            /// <para>win10-64bit</para>
            /// </summary>
            [NameInMap("Hostname")]
            [Validation(Required=false)]
            public string Hostname { get; set; }

            /// <summary>
            /// <para>The name of the Identity Provider (IdP).</para>
            /// 
            /// <b>Example:</b>
            /// <para>测试身份源</para>
            /// </summary>
            [NameInMap("IdpName")]
            [Validation(Required=false)]
            public string IdpName { get; set; }

            /// <summary>
            /// <para>Indicates whether the application has been uninstalled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("IsUninstall")]
            [Validation(Required=false)]
            public bool? IsUninstall { get; set; }

            /// <summary>
            /// <para>The MAC address of the device.</para>
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
            /// <para>这是一个测试</para>
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
            /// <para>The status of the uninstall application. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>Pending</b></para>
            /// </description></item>
            /// <item><description><para><b>Approved</b></para>
            /// </description></item>
            /// <item><description><para><b>Rejected</b></para>
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
            /// <para>The username.</para>
            /// 
            /// <b>Example:</b>
            /// <para>王先生</para>
            /// </summary>
            [NameInMap("Username")]
            [Validation(Required=false)]
            public string Username { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
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
