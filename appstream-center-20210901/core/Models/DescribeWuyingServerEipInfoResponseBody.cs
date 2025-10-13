// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appstream_center20210901.Models
{
    public class DescribeWuyingServerEipInfoResponseBody : TeaModel {
        [NameInMap("EipInfoModel")]
        [Validation(Required=false)]
        public DescribeWuyingServerEipInfoResponseBodyEipInfoModel EipInfoModel { get; set; }
        public class DescribeWuyingServerEipInfoResponseBodyEipInfoModel : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>171.xxx.xxx.221</para>
            /// </summary>
            [NameInMap("IpAddress")]
            [Validation(Required=false)]
            public string IpAddress { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>eni-bp174p2xxxxxbyh02ix</para>
            /// </summary>
            [NameInMap("NetworkInterfaceId")]
            [Validation(Required=false)]
            public string NetworkInterfaceId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>6606/6607</para>
            /// </summary>
            [NameInMap("ServerPortRange")]
            [Validation(Required=false)]
            public string ServerPortRange { get; set; }

        }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>1CBAFFAB-B697-4049-A9B1-67E1FC5F****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
