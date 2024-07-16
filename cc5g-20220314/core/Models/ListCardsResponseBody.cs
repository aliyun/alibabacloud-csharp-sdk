// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CC5G20220314.Models
{
    public class ListCardsResponseBody : TeaModel {
        [NameInMap("Cards")]
        [Validation(Required=false)]
        public List<ListCardsResponseBodyCards> Cards { get; set; }
        public class ListCardsResponseBodyCards : TeaModel {
            /// <summary>
            /// 代表创建时间的资源属性字段
            /// </summary>
            [NameInMap("APN")]
            [Validation(Required=false)]
            public string APN { get; set; }

            [NameInMap("ActivatedTime")]
            [Validation(Required=false)]
            public string ActivatedTime { get; set; }

            [NameInMap("BusinessStatus")]
            [Validation(Required=false)]
            public string BusinessStatus { get; set; }

            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("ISP")]
            [Validation(Required=false)]
            public string ISP { get; set; }

            /// <summary>
            /// 代表资源一级ID的资源属性字段
            /// </summary>
            [NameInMap("Iccid")]
            [Validation(Required=false)]
            public string Iccid { get; set; }

            [NameInMap("Imei")]
            [Validation(Required=false)]
            public string Imei { get; set; }

            [NameInMap("Imsi")]
            [Validation(Required=false)]
            public string Imsi { get; set; }

            [NameInMap("IpAddress")]
            [Validation(Required=false)]
            public string IpAddress { get; set; }

            [NameInMap("Lock")]
            [Validation(Required=false)]
            public bool? Lock { get; set; }

            [NameInMap("Msisdn")]
            [Validation(Required=false)]
            public string Msisdn { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// 代表资源名称的资源属性字段
            /// </summary>
            [NameInMap("NetType")]
            [Validation(Required=false)]
            public string NetType { get; set; }

            [NameInMap("OrderId")]
            [Validation(Required=false)]
            public string OrderId { get; set; }

            [NameInMap("Spec")]
            [Validation(Required=false)]
            public string Spec { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("UsageDataMonth")]
            [Validation(Required=false)]
            public long? UsageDataMonth { get; set; }

            [NameInMap("UsageDataTotal")]
            [Validation(Required=false)]
            public string UsageDataTotal { get; set; }

        }

        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public string MaxResults { get; set; }

        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public string TotalCount { get; set; }

    }

}
