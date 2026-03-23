// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeModifyPGHbaConfigLogResponseBody : TeaModel {
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        [NameInMap("HbaLogItems")]
        [Validation(Required=false)]
        public DescribeModifyPGHbaConfigLogResponseBodyHbaLogItems HbaLogItems { get; set; }
        public class DescribeModifyPGHbaConfigLogResponseBodyHbaLogItems : TeaModel {
            [NameInMap("HbaLogItem")]
            [Validation(Required=false)]
            public List<DescribeModifyPGHbaConfigLogResponseBodyHbaLogItemsHbaLogItem> HbaLogItem { get; set; }
            public class DescribeModifyPGHbaConfigLogResponseBodyHbaLogItemsHbaLogItem : TeaModel {
                [NameInMap("AfterHbaItems")]
                [Validation(Required=false)]
                public DescribeModifyPGHbaConfigLogResponseBodyHbaLogItemsHbaLogItemAfterHbaItems AfterHbaItems { get; set; }
                public class DescribeModifyPGHbaConfigLogResponseBodyHbaLogItemsHbaLogItemAfterHbaItems : TeaModel {
                    [NameInMap("HbaItem")]
                    [Validation(Required=false)]
                    public List<DescribeModifyPGHbaConfigLogResponseBodyHbaLogItemsHbaLogItemAfterHbaItemsHbaItem> HbaItem { get; set; }
                    public class DescribeModifyPGHbaConfigLogResponseBodyHbaLogItemsHbaLogItemAfterHbaItemsHbaItem : TeaModel {
                        [NameInMap("Address")]
                        [Validation(Required=false)]
                        public string Address { get; set; }

                        [NameInMap("Database")]
                        [Validation(Required=false)]
                        public string Database { get; set; }

                        [NameInMap("Mask")]
                        [Validation(Required=false)]
                        public string Mask { get; set; }

                        [NameInMap("Method")]
                        [Validation(Required=false)]
                        public string Method { get; set; }

                        [NameInMap("Option")]
                        [Validation(Required=false)]
                        public string Option { get; set; }

                        [NameInMap("PriorityId")]
                        [Validation(Required=false)]
                        public int? PriorityId { get; set; }

                        [NameInMap("Type")]
                        [Validation(Required=false)]
                        public string Type { get; set; }

                        [NameInMap("User")]
                        [Validation(Required=false)]
                        public string User { get; set; }

                    }

                }

                [NameInMap("BeforeHbaItems")]
                [Validation(Required=false)]
                public DescribeModifyPGHbaConfigLogResponseBodyHbaLogItemsHbaLogItemBeforeHbaItems BeforeHbaItems { get; set; }
                public class DescribeModifyPGHbaConfigLogResponseBodyHbaLogItemsHbaLogItemBeforeHbaItems : TeaModel {
                    [NameInMap("HbaItem")]
                    [Validation(Required=false)]
                    public List<DescribeModifyPGHbaConfigLogResponseBodyHbaLogItemsHbaLogItemBeforeHbaItemsHbaItem> HbaItem { get; set; }
                    public class DescribeModifyPGHbaConfigLogResponseBodyHbaLogItemsHbaLogItemBeforeHbaItemsHbaItem : TeaModel {
                        [NameInMap("Address")]
                        [Validation(Required=false)]
                        public string Address { get; set; }

                        [NameInMap("Database")]
                        [Validation(Required=false)]
                        public string Database { get; set; }

                        [NameInMap("Mask")]
                        [Validation(Required=false)]
                        public string Mask { get; set; }

                        [NameInMap("Method")]
                        [Validation(Required=false)]
                        public string Method { get; set; }

                        [NameInMap("Option")]
                        [Validation(Required=false)]
                        public string Option { get; set; }

                        [NameInMap("PriorityId")]
                        [Validation(Required=false)]
                        public int? PriorityId { get; set; }

                        [NameInMap("Type")]
                        [Validation(Required=false)]
                        public string Type { get; set; }

                        [NameInMap("User")]
                        [Validation(Required=false)]
                        public string User { get; set; }

                    }

                }

                [NameInMap("ModifyStatus")]
                [Validation(Required=false)]
                public string ModifyStatus { get; set; }

                [NameInMap("ModifyTime")]
                [Validation(Required=false)]
                public string ModifyTime { get; set; }

                [NameInMap("StatusReason")]
                [Validation(Required=false)]
                public string StatusReason { get; set; }

            }

        }

        [NameInMap("LogItemCount")]
        [Validation(Required=false)]
        public int? LogItemCount { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
