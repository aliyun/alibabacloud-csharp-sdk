// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class ListNacUserCertResponseBody : TeaModel {
        /// <summary>
        /// <para>API status or POP error code. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>2xx</b>: Success.</para>
        /// </description></item>
        /// <item><description><para><b>3xx</b>: Redirection.</para>
        /// </description></item>
        /// <item><description><para><b>4xx</b>: Request error.</para>
        /// </description></item>
        /// <item><description><para><b>5xx</b>: Server error.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public long? Code { get; set; }

        /// <summary>
        /// <para>List of onboarding user certificate statuses.</para>
        /// </summary>
        [NameInMap("DataList")]
        [Validation(Required=false)]
        public List<ListNacUserCertResponseBodyDataList> DataList { get; set; }
        public class ListNacUserCertResponseBodyDataList : TeaModel {
            /// <summary>
            /// <para>Alibaba Cloud account ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Aliuid")]
            [Validation(Required=false)]
            public string Aliuid { get; set; }

            /// <summary>
            /// <para>Department that the user belongs to.</para>
            /// 
            /// <b>Example:</b>
            /// <para>外包</para>
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
            /// <item><description><para><b>windows</b>: Windows.</para>
            /// </description></item>
            /// <item><description><para><b>macos</b>: macOS.</para>
            /// </description></item>
            /// <item><description><para><b>linux</b>: Linux.</para>
            /// </description></item>
            /// <item><description><para><b>android</b>: Android.</para>
            /// </description></item>
            /// <item><description><para><b>ios</b>: iOS.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>windows</para>
            /// </summary>
            [NameInMap("DeviceType")]
            [Validation(Required=false)]
            public string DeviceType { get; set; }

            /// <summary>
            /// <para>Expired At.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2029-06-30 09:31:54</para>
            /// </summary>
            [NameInMap("ExpiredTime")]
            [Validation(Required=false)]
            public string ExpiredTime { get; set; }

            /// <summary>
            /// <para>Endpoint device name. The value must be 1 to 128 characters in length. It can contain Chinese characters, uppercase and lowercase letters, digits, periods (.), commas (,), semicolons (;), hyphens (-), underscores (<em>), forward slashes (/), at signs (@), and spaces. If you enter only an underscore (</em>), the system returns all endpoint devices whose names contain 4-byte UTF-8 characters.</para>
            /// 
            /// <b>Example:</b>
            /// <para>MS-XU****</para>
            /// </summary>
            [NameInMap("Hostname")]
            [Validation(Required=false)]
            public string Hostname { get; set; }

            /// <summary>
            /// <para>Endpoint device MAC address.</para>
            /// 
            /// <b>Example:</b>
            /// <para>08:f8:<b>:</b>:**:5e</para>
            /// </summary>
            [NameInMap("Mac")]
            [Validation(Required=false)]
            public string Mac { get; set; }

            /// <summary>
            /// <para>Onboarding user certificate status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>Enabled</b>: Enabled.</para>
            /// </description></item>
            /// <item><description><para><b>Disabled</b>: Disabled.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Disabled</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>User ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>su_e8f218fb171edd167c2ad917d21f53148bdefc510ca1f3c3cc0249d3643d****</para>
            /// </summary>
            [NameInMap("UserId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

            /// <summary>
            /// <para>Username.</para>
            /// 
            /// <b>Example:</b>
            /// <para>zhang**</para>
            /// </summary>
            [NameInMap("Username")]
            [Validation(Required=false)]
            public string Username { get; set; }

        }

        /// <summary>
        /// <para>Additional information.</para>
        /// 
        /// <b>Example:</b>
        /// <para>successful</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>58D6B23E-E5DA-5418-8F61-51A3B5A30049</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Total number of entries that match the conditions.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalNum")]
        [Validation(Required=false)]
        public long? TotalNum { get; set; }

    }

}
