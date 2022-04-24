// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20171214.Models
{
    public class QueryDPUtilizationDetailResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryDPUtilizationDetailResponseBodyData Data { get; set; }
        public class QueryDPUtilizationDetailResponseBodyData : TeaModel {
            [NameInMap("DetailList")]
            [Validation(Required=false)]
            public QueryDPUtilizationDetailResponseBodyDataDetailList DetailList { get; set; }
            public class QueryDPUtilizationDetailResponseBodyDataDetailList : TeaModel {
                [NameInMap("DetailList")]
                [Validation(Required=false)]
                public List<QueryDPUtilizationDetailResponseBodyDataDetailListDetailList> DetailList { get; set; }
                public class QueryDPUtilizationDetailResponseBodyDataDetailListDetailList : TeaModel {
                    [NameInMap("DeductDate")]
                    [Validation(Required=false)]
                    public string DeductDate { get; set; }

                    [NameInMap("DeductFactorTotal")]
                    [Validation(Required=false)]
                    public float? DeductFactorTotal { get; set; }

                    [NameInMap("DeductHours")]
                    [Validation(Required=false)]
                    public float? DeductHours { get; set; }

                    [NameInMap("DeductMeasure")]
                    [Validation(Required=false)]
                    public float? DeductMeasure { get; set; }

                    [NameInMap("DeductQuantity")]
                    [Validation(Required=false)]
                    public float? DeductQuantity { get; set; }

                    [NameInMap("DeductedCommodityCode")]
                    [Validation(Required=false)]
                    public string DeductedCommodityCode { get; set; }

                    [NameInMap("DeductedInstanceId")]
                    [Validation(Required=false)]
                    public string DeductedInstanceId { get; set; }

                    [NameInMap("DeductedProductDetail")]
                    [Validation(Required=false)]
                    public string DeductedProductDetail { get; set; }

                    [NameInMap("InstanceId")]
                    [Validation(Required=false)]
                    public string InstanceId { get; set; }

                    [NameInMap("InstanceSpec")]
                    [Validation(Required=false)]
                    public string InstanceSpec { get; set; }

                    [NameInMap("Region")]
                    [Validation(Required=false)]
                    public string Region { get; set; }

                    [NameInMap("ResCode")]
                    [Validation(Required=false)]
                    public string ResCode { get; set; }

                    [NameInMap("ShareUid")]
                    [Validation(Required=false)]
                    public long? ShareUid { get; set; }

                    [NameInMap("Uid")]
                    [Validation(Required=false)]
                    public long? Uid { get; set; }

                }

            }
            [NameInMap("NextToken")]
            [Validation(Required=false)]
            public string NextToken { get; set; }
        };

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
