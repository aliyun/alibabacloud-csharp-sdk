// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class ListExcessiveDeviceRegistrationApplicationsResponseBody : TeaModel {
        /// <summary>
        /// <para>A list of excessive device registration applications.</para>
        /// </summary>
        [NameInMap("Applications")]
        [Validation(Required=false)]
        public List<ListExcessiveDeviceRegistrationApplicationsResponseBodyApplications> Applications { get; set; }
        public class ListExcessiveDeviceRegistrationApplicationsResponseBodyApplications : TeaModel {
            /// <summary>
            /// <para>The application ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>reg-application-0f4a127b7e78****</para>
            /// </summary>
            [NameInMap("ApplicationId")]
            [Validation(Required=false)]
            public string ApplicationId { get; set; }

            /// <summary>
            /// <para>The creation time of the excessive device registration application.</para>
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
            /// <para>The reason for the excessive device registration application.</para>
            /// 
            /// <b>Example:</b>
            /// <para>这是一条超额注册申请</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The device ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>36efa42d-2c32-c4dc-e3fc-8541e33a****</para>
            /// </summary>
            [NameInMap("DeviceTag")]
            [Validation(Required=false)]
            public string DeviceTag { get; set; }

            /// <summary>
            /// <para>The operating system of the device. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>Windows</b>: The Windows operating system.</para>
            /// </description></item>
            /// <item><description><para><b>macOS</b>: The macOS operating system.</para>
            /// </description></item>
            /// <item><description><para><b>Linux</b>: The Linux operating system.</para>
            /// </description></item>
            /// <item><description><para><b>Android</b>: The Android operating system.</para>
            /// </description></item>
            /// <item><description><para><b>iOS</b>: The iOS operating system.</para>
            /// </description></item>
            /// <item><description><para><b>Windows_Wuying</b>: Wuying Workspace.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Windows</para>
            /// </summary>
            [NameInMap("DeviceType")]
            [Validation(Required=false)]
            public string DeviceType { get; set; }

            /// <summary>
            /// <para>A list of full department paths.</para>
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
            /// <para>Specifies whether the excessive device registration application has been used. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>true</b>: The application has been used.</para>
            /// </description></item>
            /// <item><description><para><b>false</b>: The application has not been used.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("IsUsed")]
            [Validation(Required=false)]
            public bool? IsUsed { get; set; }

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
            /// <para>The user ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>su_e8f218fb171edd167c2ad917d21f53148bdefc510ca1f3c3cc0249d3643d****</para>
            /// </summary>
            [NameInMap("SaseUserId")]
            [Validation(Required=false)]
            public string SaseUserId { get; set; }

            /// <summary>
            /// <para>The status of the excessive device registration application. Valid values:</para>
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
        /// <para>The total number of excessive device registration applications.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalNum")]
        [Validation(Required=false)]
        public long? TotalNum { get; set; }

    }

}
