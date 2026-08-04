// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class UpdateExcessiveDeviceRegistrationApplicationsStatusResponseBody : TeaModel {
        /// <summary>
        /// <para>List of device registration applications that exceed your quota.</para>
        /// </summary>
        [NameInMap("Applications")]
        [Validation(Required=false)]
        public List<UpdateExcessiveDeviceRegistrationApplicationsStatusResponseBodyApplications> Applications { get; set; }
        public class UpdateExcessiveDeviceRegistrationApplicationsStatusResponseBodyApplications : TeaModel {
            /// <summary>
            /// <para>ID of the device registration application.</para>
            /// 
            /// <b>Example:</b>
            /// <para>reg-application-0f4a127b7e78****</para>
            /// </summary>
            [NameInMap("ApplicationId")]
            [Validation(Required=false)]
            public string ApplicationId { get; set; }

            /// <summary>
            /// <para>Time when the device registration application was created.</para>
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
            /// <para>This field indicates the reason for the excessive device registration request.</para>
            /// 
            /// <b>Example:</b>
            /// <para>这是一条超额注册申请</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>ID of the endpoint device.</para>
            /// 
            /// <b>Example:</b>
            /// <para>36efa42d-2c32-c4dc-e3fc-8541e33a****</para>
            /// </summary>
            [NameInMap("DeviceTag")]
            [Validation(Required=false)]
            public string DeviceTag { get; set; }

            /// <summary>
            /// <para>Operating system of the endpoint device. Valid values:</para>
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
            /// <item><description><para><b>Windows_Wuying</b>: Alibaba Cloud Cloud Desktop operating system.</para>
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
            /// <para>Name of the endpoint device.</para>
            /// 
            /// <b>Example:</b>
            /// <para>win10-64bit</para>
            /// </summary>
            [NameInMap("Hostname")]
            [Validation(Required=false)]
            public string Hostname { get; set; }

            /// <summary>
            /// <para>Indicates whether the device registration application has been used. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>true</b>: Used.</para>
            /// </description></item>
            /// <item><description><para><b>false</b>: Not used.</para>
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
            /// <para>MAC address of the endpoint device.</para>
            /// 
            /// <b>Example:</b>
            /// <para>00:16:XX:XX:7c:46</para>
            /// </summary>
            [NameInMap("Mac")]
            [Validation(Required=false)]
            public string Mac { get; set; }

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
            /// <para>Status of the device registration application. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>Pending</b>: Pending review.</para>
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
        /// <para>ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>102350E7-1A20-58F5-9D63-ABEA820AE6E1</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
