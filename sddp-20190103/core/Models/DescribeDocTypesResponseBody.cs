// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sddp20190103.Models
{
    public class DescribeDocTypesResponseBody : TeaModel {
        [NameInMap("DocTypeList")]
        [Validation(Required=false)]
        public List<DescribeDocTypesResponseBodyDocTypeList> DocTypeList { get; set; }
        public class DescribeDocTypesResponseBodyDocTypeList : TeaModel {
            [NameInMap("Code")]
            [Validation(Required=false)]
            public long? Code { get; set; }

            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
