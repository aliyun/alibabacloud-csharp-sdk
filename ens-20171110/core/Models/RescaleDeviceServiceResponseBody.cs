// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class RescaleDeviceServiceResponseBody : TeaModel {
        /// <summary>
        /// <para>The IDs of the devices.</para>
        /// </summary>
        [NameInMap("DeviceIds")]
        [Validation(Required=false)]
        public List<string> DeviceIds { get; set; }

        /// <summary>
        /// <para>The ID of the order.</para>
        /// 
        /// <b>Example:</b>
        /// <para>b3b5bb9a-4e0b-4cac-8ebf-e5e015726723</para>
        /// </summary>
        [NameInMap("OrderId")]
        [Validation(Required=false)]
        public string OrderId { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3F3F3570-E721-53F6-853F-37B7725AC6CB</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The key properties of the device.</para>
        /// </summary>
        [NameInMap("ResourceDetailInfos")]
        [Validation(Required=false)]
        public List<RescaleDeviceServiceResponseBodyResourceDetailInfos> ResourceDetailInfos { get; set; }
        public class RescaleDeviceServiceResponseBodyResourceDetailInfos : TeaModel {
            /// <summary>
            /// <para>The ID of the device.</para>
            /// 
            /// <b>Example:</b>
            /// <para>h-uf6009zoa6hdbjyqxcn1</para>
            /// </summary>
            [NameInMap("ID")]
            [Validation(Required=false)]
            public string ID { get; set; }

            /// <summary>
            /// <para>The IP address of the device.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10.152.196.36</para>
            /// </summary>
            [NameInMap("IP")]
            [Validation(Required=false)]
            public string IP { get; set; }

            /// <summary>
            /// <para>The Internet service provider (ISP) to which the device belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>telecom</para>
            /// </summary>
            [NameInMap("ISP")]
            [Validation(Required=false)]
            public string ISP { get; set; }

            /// <summary>
            /// <para>The media access control (MAC) address of the device.</para>
            /// 
            /// <b>Example:</b>
            /// <para>24:0B:88:04:71:E0</para>
            /// </summary>
            [NameInMap("Mac")]
            [Validation(Required=false)]
            public string Mac { get; set; }

            /// <summary>
            /// <para>The ID of the edge node to which the device belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-chongqing-1</para>
            /// </summary>
            [NameInMap("RegionID")]
            [Validation(Required=false)]
            public string RegionID { get; set; }

            /// <summary>
            /// <para>The name of the server on which the device is deployed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ens-nc2</para>
            /// </summary>
            [NameInMap("Server")]
            [Validation(Required=false)]
            public string Server { get; set; }

            /// <summary>
            /// <para>The status of the device.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Running</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The type of the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ens.ac6.large</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

    }

}
