// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ivpd20190625.Models
{
    public class ListPackageDesignModelTypesResponseBody : TeaModel {
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListPackageDesignModelTypesResponseBodyData Data { get; set; }
        public class ListPackageDesignModelTypesResponseBodyData : TeaModel {
            [NameInMap("ModelTypeList")]
            [Validation(Required=false)]
            public List<ListPackageDesignModelTypesResponseBodyDataModelTypeList> ModelTypeList { get; set; }
            public class ListPackageDesignModelTypesResponseBodyDataModelTypeList : TeaModel {
                public List<ListPackageDesignModelTypesResponseBodyDataModelTypeListElements> Elements { get; set; }
                public class ListPackageDesignModelTypesResponseBodyDataModelTypeListElements : TeaModel {
                    public string SideName { get; set; }
                }
                public string ModelType { get; set; }
            }
        };

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

    }

}
