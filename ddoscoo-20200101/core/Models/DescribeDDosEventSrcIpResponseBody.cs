// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class DescribeDDosEventSrcIpResponseBody : TeaModel {
        /// <summary>
        /// An array that consists of information about the source IP address of the volumetric attack.
        /// </summary>
        [NameInMap("Ips")]
        [Validation(Required=false)]
        public List<DescribeDDosEventSrcIpResponseBodyIps> Ips { get; set; }
        public class DescribeDDosEventSrcIpResponseBodyIps : TeaModel {
            /// <summary>
            /// The code or ID of the source region. For more information, see [Codes of administrative regions in China and codes of countries and areas](https://help.aliyun.com/document_detail/167926.html). For example, **110000** indicates Beijing, China, and **us** indicates the United States.
            /// </summary>
            [NameInMap("AreaId")]
            [Validation(Required=false)]
            public string AreaId { get; set; }

            /// <summary>
            /// The Internet service provider (ISP) for the volumetric attack. Valid values:
            /// 
            /// *   **100017**: China Telecom
            /// *   **100026**: China Unicom
            /// *   **100025**: China Mobile
            /// *   **100027**: China Education and Research Network
            /// *   **100020**: China Mobile Tietong
            /// *   **1000143**: Dr.Peng Telecom & Media Group
            /// *   **100080**: Beijing Gehua CATV Network
            /// *   **1000139**: National Radio and Television Administration
            /// *   **100023**: Oriental Cable Network
            /// *   **100063**: Founder Broadband
            /// *   **1000337**: China Internet Exchange
            /// *   **100021**: 21Vianet Group
            /// *   **1000333**: Wasu Media Holding
            /// *   **100093**: Wangsu Science & Technology
            /// *   **1000401**: Tencent
            /// *   **100099**: Baidu
            /// *   **1000323**: Alibaba Cloud
            /// *   **100098**: Alibaba
            /// </summary>
            [NameInMap("Isp")]
            [Validation(Required=false)]
            public string Isp { get; set; }

            /// <summary>
            /// The source IP address of the volumetric attack.
            /// </summary>
            [NameInMap("SrcIp")]
            [Validation(Required=false)]
            public string SrcIp { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
