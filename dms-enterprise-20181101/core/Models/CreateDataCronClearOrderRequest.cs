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
                public string ColumnName { get; set; }
                public string FilterSQL { get; set; }
                public long? RemainDays { get; set; }
                public string TableName { get; set; }
                public string TimeUnit { get; set; }
            }
            [NameInMap("CronFormat")]
            [Validation(Required=false)]
            public string CronFormat { get; set; }
            [NameInMap("DbItemList")]
            [Validation(Required=false)]
            public List<CreateDataCronClearOrderRequestParamDbItemList> DbItemList { get; set; }
            public class CreateDataCronClearOrderRequestParamDbItemList : TeaModel {
                public long? DbId { get; set; }
                public bool? Logic { get; set; }
            }
            [NameInMap("DurationHour")]
            [Validation(Required=false)]
            public long? DurationHour { get; set; }
            [NameInMap("specifyDuration")]
            [Validation(Required=false)]
            public bool? SpecifyDuration { get; set; }
        };

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("RelatedUserList")]
        [Validation(Required=false)]
        public List<long?> RelatedUserList { get; set; }

        [NameInMap("Tid")]
        [Validation(Required=false)]
        public long? Tid { get; set; }

    }

}
