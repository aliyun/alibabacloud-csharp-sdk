// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20171214.Models
{
    public class QueryRIUtilizationDetailResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryRIUtilizationDetailResponseBodyData Data { get; set; }
        public class QueryRIUtilizationDetailResponseBodyData : TeaModel {
            [NameInMap("DetailList")]
            [Validation(Required=false)]
            public QueryRIUtilizationDetailResponseBodyDataDetailList DetailList { get; set; }
            public class QueryRIUtilizationDetailResponseBodyDataDetailList : TeaModel {
                [NameInMap("DetailList")]
                [Validation(Required=false)]
                public List<QueryRIUtilizationDetailResponseBodyDataDetailListDetailList> DetailList { get; set; }
                public class QueryRIUtilizationDetailResponseBodyDataDetailListDetailList : TeaModel {
                    [NameInMap("DeductDate")]
                    [Validation(Required=false)]
                    public string DeductDate { get; set; }

                    [NameInMap("DeductFactorTotal")]
                    [Validation(Required=false)]
                    public float? DeductFactorTotal { get; set; }

                    [NameInMap("DeductHours")]
                    [Validation(Required=false)]
                    public string DeductHours { get; set; }

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

                    [NameInMap("InstanceSpec")]
                    [Validation(Required=false)]
                    public string InstanceSpec { get; set; }

                    [NameInMap("RIInstanceId")]
                    [Validation(Required=false)]
                    public string RIInstanceId { get; set; }

                }

            }
            [NameInMap("PageNum")]
            [Validation(Required=false)]
            public long? PageNum { get; set; }
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public long? PageSize { get; set; }
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public long? TotalCount { get; set; }
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
