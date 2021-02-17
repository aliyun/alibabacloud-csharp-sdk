// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dds20151201.Models
{
    public class DescribeActiveOperationTaskTypeResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TypeList")]
        [Validation(Required=false)]
        public List<DescribeActiveOperationTaskTypeResponseBodyTypeList> TypeList { get; set; }
        public class DescribeActiveOperationTaskTypeResponseBodyTypeList : TeaModel {
            [NameInMap("TaskType")]
            [Validation(Required=false)]
            public string TaskType { get; set; }

            [NameInMap("Count")]
            [Validation(Required=false)]
            public int? Count { get; set; }

        }

    }

}
