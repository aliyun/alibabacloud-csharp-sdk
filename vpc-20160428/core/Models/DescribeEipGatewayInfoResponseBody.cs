// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class DescribeEipGatewayInfoResponseBody : TeaModel {
        /// <summary>
        /// <para>The status code of the operation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("EipInfos")]
        [Validation(Required=false)]
        public DescribeEipGatewayInfoResponseBodyEipInfos EipInfos { get; set; }
        public class DescribeEipGatewayInfoResponseBodyEipInfos : TeaModel {
            [NameInMap("EipInfo")]
            [Validation(Required=false)]
            public List<DescribeEipGatewayInfoResponseBodyEipInfosEipInfo> EipInfo { get; set; }
            public class DescribeEipGatewayInfoResponseBodyEipInfosEipInfo : TeaModel {
                [NameInMap("Ip")]
                [Validation(Required=false)]
                public string Ip { get; set; }

                [NameInMap("IpGw")]
                [Validation(Required=false)]
                public string IpGw { get; set; }

                [NameInMap("IpMask")]
                [Validation(Required=false)]
                public string IpMask { get; set; }

            }

        }

        /// <summary>
        /// <para>The result of the operation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>successful</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>C0FD0EED-F90D-4479-803D-DD62335357E5</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
