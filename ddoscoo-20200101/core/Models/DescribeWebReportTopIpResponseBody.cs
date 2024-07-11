// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class DescribeWebReportTopIpResponseBody : TeaModel {
        /// <summary>
        /// The response parameters.
        /// </summary>
        [NameInMap("DataList")]
        [Validation(Required=false)]
        public List<DescribeWebReportTopIpResponseBodyDataList> DataList { get; set; }
        public class DescribeWebReportTopIpResponseBodyDataList : TeaModel {
            /// <summary>
            /// The ID of the location.
            /// </summary>
            [NameInMap("AreaId")]
            [Validation(Required=false)]
            public string AreaId { get; set; }

            /// <summary>
            /// The number of entries returned.
            /// </summary>
            [NameInMap("Count")]
            [Validation(Required=false)]
            public long? Count { get; set; }

            /// <summary>
            /// The Internet service provider (ISP) for the attack. Valid values:
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
            /// The source IP address.
            /// </summary>
            [NameInMap("SourceIp")]
            [Validation(Required=false)]
            public string SourceIp { get; set; }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
