// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class DescribeDevicesResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about devices that you queried.</para>
        /// </summary>
        [NameInMap("Devices")]
        [Validation(Required=false)]
        public List<DescribeDevicesResponseBodyDevices> Devices { get; set; }
        public class DescribeDevicesResponseBodyDevices : TeaModel {
            /// <summary>
            /// <para>The ID of the device. The serial number (SN) of the hardware client or the UUID of the software client.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5F52817BE267A43C608D245070D2****</para>
            /// </summary>
            [NameInMap("DeviceId")]
            [Validation(Required=false)]
            public string DeviceId { get; set; }

            /// <summary>
            /// <para>The users who are bound to the device.</para>
            /// </summary>
            [NameInMap("EndUserList")]
            [Validation(Required=false)]
            public List<DescribeDevicesResponseBodyDevicesEndUserList> EndUserList { get; set; }
            public class DescribeDevicesResponseBodyDevicesEndUserList : TeaModel {
                /// <summary>
                /// <para>The address of the AD office network.</para>
                /// 
                /// <b>Example:</b>
                /// <para>xn--0zw****</para>
                /// </summary>
                [NameInMap("AdDomain")]
                [Validation(Required=false)]
                public string AdDomain { get; set; }

                /// <summary>
                /// <para>The ID of the convenient office network.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-hangzhou+dir-jedbpr4sl9l37****</para>
                /// </summary>
                [NameInMap("DirectoryId")]
                [Validation(Required=false)]
                public string DirectoryId { get; set; }

                /// <summary>
                /// <para>The ID of the user.</para>
                /// 
                /// <b>Example:</b>
                /// <para>moli</para>
                /// </summary>
                [NameInMap("EndUserId")]
                [Validation(Required=false)]
                public string EndUserId { get; set; }

                /// <summary>
                /// <para>The account type of the user.</para>
                /// <para>Valid values:</para>
                /// <list type="bullet">
                /// <item><description>AD: enterprise AD account.</description></item>
                /// <item><description>SIMPLE: convenience account</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>SIMPLE</para>
                /// </summary>
                [NameInMap("UserType")]
                [Validation(Required=false)]
                public string UserType { get; set; }

            }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5BEFE642-A383-4A18-8939-FB7DE452****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
