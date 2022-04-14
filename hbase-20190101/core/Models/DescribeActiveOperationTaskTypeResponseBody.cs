// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.HBase20190101.Models
{
    public class DescribeActiveOperationTaskTypeResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TypeList")]
        [Validation(Required=false)]
        public List<DescribeActiveOperationTaskTypeResponseBodyTypeList> TypeList { get; set; }
        public class DescribeActiveOperationTaskTypeResponseBodyTypeList : TeaModel {
            [NameInMap("Count")]
            [Validation(Required=false)]
            public int? Count { get; set; }

            [NameInMap("TaskType")]
            [Validation(Required=false)]
            public string TaskType { get; set; }

            [NameInMap("TaskTypeInfoEn")]
            [Validation(Required=false)]
            public string TaskTypeInfoEn { get; set; }

            [NameInMap("TaskTypeInfoZh")]
            [Validation(Required=false)]
            public string TaskTypeInfoZh { get; set; }

        }

    }

}
