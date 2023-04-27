// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class GetDataExportOrderDetailResponseBody : TeaModel {
        [NameInMap("DataExportOrderDetail")]
        [Validation(Required=false)]
        public GetDataExportOrderDetailResponseBodyDataExportOrderDetail DataExportOrderDetail { get; set; }
        public class GetDataExportOrderDetailResponseBodyDataExportOrderDetail : TeaModel {
            [NameInMap("KeyInfo")]
            [Validation(Required=false)]
            public GetDataExportOrderDetailResponseBodyDataExportOrderDetailKeyInfo KeyInfo { get; set; }
            public class GetDataExportOrderDetailResponseBodyDataExportOrderDetailKeyInfo : TeaModel {
                [NameInMap("JobStatus")]
                [Validation(Required=false)]
                public string JobStatus { get; set; }

                [NameInMap("PreCheckId")]
                [Validation(Required=false)]
                public long? PreCheckId { get; set; }

            }

            [NameInMap("OrderDetail")]
            [Validation(Required=false)]
            public GetDataExportOrderDetailResponseBodyDataExportOrderDetailOrderDetail OrderDetail { get; set; }
            public class GetDataExportOrderDetailResponseBodyDataExportOrderDetailOrderDetail : TeaModel {
                [NameInMap("ActualAffectRows")]
                [Validation(Required=false)]
                public long? ActualAffectRows { get; set; }

                [NameInMap("Classify")]
                [Validation(Required=false)]
                public string Classify { get; set; }

                [NameInMap("Database")]
                [Validation(Required=false)]
                public string Database { get; set; }

                [NameInMap("DbId")]
                [Validation(Required=false)]
                public int? DbId { get; set; }

                [NameInMap("EnvType")]
                [Validation(Required=false)]
                public string EnvType { get; set; }

                [NameInMap("ExeSQL")]
                [Validation(Required=false)]
                public string ExeSQL { get; set; }

                [NameInMap("IgnoreAffectRows")]
                [Validation(Required=false)]
                public bool? IgnoreAffectRows { get; set; }

                [NameInMap("IgnoreAffectRowsReason")]
                [Validation(Required=false)]
                public string IgnoreAffectRowsReason { get; set; }

                [NameInMap("Logic")]
                [Validation(Required=false)]
                public bool? Logic { get; set; }

            }

        }

        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
