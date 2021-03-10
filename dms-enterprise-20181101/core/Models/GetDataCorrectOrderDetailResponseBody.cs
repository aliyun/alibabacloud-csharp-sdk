// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class GetDataCorrectOrderDetailResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("DataCorrectOrderDetail")]
        [Validation(Required=false)]
        public GetDataCorrectOrderDetailResponseBodyDataCorrectOrderDetail DataCorrectOrderDetail { get; set; }
        public class GetDataCorrectOrderDetailResponseBodyDataCorrectOrderDetail : TeaModel {
            [NameInMap("PreCheckDetail")]
            [Validation(Required=false)]
            public GetDataCorrectOrderDetailResponseBodyDataCorrectOrderDetailPreCheckDetail PreCheckDetail { get; set; }
            public class GetDataCorrectOrderDetailResponseBodyDataCorrectOrderDetailPreCheckDetail : TeaModel {
                [NameInMap("TaskCheckDO")]
                [Validation(Required=false)]
                public List<GetDataCorrectOrderDetailResponseBodyDataCorrectOrderDetailPreCheckDetailTaskCheckDO> TaskCheckDO { get; set; }
                public class GetDataCorrectOrderDetailResponseBodyDataCorrectOrderDetailPreCheckDetailTaskCheckDO : TeaModel {
                    [NameInMap("UserTip")]
                    [Validation(Required=false)]
                    public string UserTip { get; set; }

                    [NameInMap("CheckStatus")]
                    [Validation(Required=false)]
                    public string CheckStatus { get; set; }

                    [NameInMap("CheckStep")]
                    [Validation(Required=false)]
                    public string CheckStep { get; set; }

                }

            }
            [NameInMap("OrderDetail")]
            [Validation(Required=false)]
            public GetDataCorrectOrderDetailResponseBodyDataCorrectOrderDetailOrderDetail OrderDetail { get; set; }
            public class GetDataCorrectOrderDetailResponseBodyDataCorrectOrderDetailOrderDetail : TeaModel {
                [NameInMap("RbSQL")]
                [Validation(Required=false)]
                public string RbSQL { get; set; }

                [NameInMap("RbAttachmentName")]
                [Validation(Required=false)]
                public string RbAttachmentName { get; set; }

                [NameInMap("Classify")]
                [Validation(Required=false)]
                public string Classify { get; set; }

                [NameInMap("ExeSQL")]
                [Validation(Required=false)]
                public string ExeSQL { get; set; }

                [NameInMap("EstimateAffectRows")]
                [Validation(Required=false)]
                public long? EstimateAffectRows { get; set; }

                [NameInMap("RbSQLType")]
                [Validation(Required=false)]
                public string RbSQLType { get; set; }

                [NameInMap("ActualAffectRows")]
                [Validation(Required=false)]
                public long? ActualAffectRows { get; set; }

                [NameInMap("IgnoreAffectRows")]
                [Validation(Required=false)]
                public bool? IgnoreAffectRows { get; set; }

                [NameInMap("AttachmentName")]
                [Validation(Required=false)]
                public string AttachmentName { get; set; }

                [NameInMap("SqlType")]
                [Validation(Required=false)]
                public string SqlType { get; set; }

                [NameInMap("IgnoreAffectRowsReason")]
                [Validation(Required=false)]
                public string IgnoreAffectRowsReason { get; set; }

            }
            [NameInMap("DatabaseList")]
            [Validation(Required=false)]
            public GetDataCorrectOrderDetailResponseBodyDataCorrectOrderDetailDatabaseList DatabaseList { get; set; }
            public class GetDataCorrectOrderDetailResponseBodyDataCorrectOrderDetailDatabaseList : TeaModel {
                [NameInMap("Database")]
                [Validation(Required=false)]
                public List<GetDataCorrectOrderDetailResponseBodyDataCorrectOrderDetailDatabaseListDatabase> Database { get; set; }
                public class GetDataCorrectOrderDetailResponseBodyDataCorrectOrderDetailDatabaseListDatabase : TeaModel {
                    [NameInMap("DbId")]
                    [Validation(Required=false)]
                    public int? DbId { get; set; }

                    [NameInMap("DbType")]
                    [Validation(Required=false)]
                    public string DbType { get; set; }

                    [NameInMap("Logic")]
                    [Validation(Required=false)]
                    public bool? Logic { get; set; }

                    [NameInMap("SearchName")]
                    [Validation(Required=false)]
                    public string SearchName { get; set; }

                    [NameInMap("EnvType")]
                    [Validation(Required=false)]
                    public string EnvType { get; set; }

                }

            }
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }
        };

        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
