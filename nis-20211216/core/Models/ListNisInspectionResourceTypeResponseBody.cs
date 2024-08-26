// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Nis20211216.Models
{
    public class ListNisInspectionResourceTypeResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResourceTypeList")]
        [Validation(Required=false)]
        public List<ListNisInspectionResourceTypeResponseBodyResourceTypeList> ResourceTypeList { get; set; }
        public class ListNisInspectionResourceTypeResponseBodyResourceTypeList : TeaModel {
            [NameInMap("ResourceType")]
            [Validation(Required=false)]
            public string ResourceType { get; set; }

        }

    }

}
