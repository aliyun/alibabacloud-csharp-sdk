// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class CreateDataCronClearOrderRequest : TeaModel {
        [NameInMap("AttachmentKey")]
        [Validation(Required=false)]
        public string AttachmentKey { get; set; }

        [NameInMap("Comment")]
        [Validation(Required=false)]
        public string Comment { get; set; }

        [NameInMap("Param")]
        [Validation(Required=false)]
        public CreateDataCronClearOrderRequestParam Param { get; set; }
        public class CreateDataCronClearOrderRequestParam : TeaModel {
            [NameInMap("Classify")]
            [Validation(Required=false)]
            public string Classify { get; set; }

            [NameInMap("CronClearItemList")]
            [Validation(Required=false)]
            public List<CreateDataCronClearOrderRequestParamCronClearItemList> CronClearItemList { get; set; }
            public class CreateDataCronClearOrderRequestParamCronClearItemList : TeaModel {
                [NameInMap("ColumnName")]
                [Validation(Required=false)]
                public string ColumnName { get; set; }

                [NameInMap("FilterSQL")]
                [Validation(Required=false)]
                public string FilterSQL { get; set; }

                [NameInMap("RemainDays")]
                [Validation(Required=false)]
                public long? RemainDays { get; set; }

                [NameInMap("TableName")]
                [Validation(Required=false)]
                public string TableName { get; set; }

                [NameInMap("TimeUnit")]
                [Validation(Required=false)]
                public string TimeUnit { get; set; }

            }

            [NameInMap("CronFormat")]
            [Validation(Required=false)]
            public string CronFormat { get; set; }

            [NameInMap("DbItemList")]
            [Validation(Required=false)]
            public List<CreateDataCronClearOrderRequestParamDbItemList> DbItemList { get; set; }
            public class CreateDataCronClearOrderRequestParamDbItemList : TeaModel {
                [NameInMap("DbId")]
                [Validation(Required=false)]
                public long? DbId { get; set; }

                [NameInMap("Logic")]
                [Validation(Required=false)]
                public bool? Logic { get; set; }

            }

            [NameInMap("DurationHour")]
            [Validation(Required=false)]
            public long? DurationHour { get; set; }

            [NameInMap("specifyDuration")]
            [Validation(Required=false)]
            public bool? SpecifyDuration { get; set; }

        }

        [NameInMap("RelatedUserList")]
        [Validation(Required=false)]
        public List<long?> RelatedUserList { get; set; }

        [NameInMap("Tid")]
        [Validation(Required=false)]
        public long? Tid { get; set; }

    }

}
