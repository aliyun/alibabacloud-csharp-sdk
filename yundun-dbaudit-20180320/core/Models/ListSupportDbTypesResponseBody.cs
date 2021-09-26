// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yundun_dbaudit20180320.Models
{
    public class ListSupportDbTypesResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TypeList")]
        [Validation(Required=false)]
        public List<ListSupportDbTypesResponseBodyTypeList> TypeList { get; set; }
        public class ListSupportDbTypesResponseBodyTypeList : TeaModel {
            [NameInMap("DbType")]
            [Validation(Required=false)]
            public int? DbType { get; set; }

            [NameInMap("DbTypeName")]
            [Validation(Required=false)]
            public string DbTypeName { get; set; }

            [NameInMap("DbVersions")]
            [Validation(Required=false)]
            public List<ListSupportDbTypesResponseBodyTypeListDbVersions> DbVersions { get; set; }
            public class ListSupportDbTypesResponseBodyTypeListDbVersions : TeaModel {
                [NameInMap("DbVersionName")]
                [Validation(Required=false)]
                public string DbVersionName { get; set; }

                [NameInMap("DbVersion")]
                [Validation(Required=false)]
                public int? DbVersion { get; set; }

            }

        }

    }

}
