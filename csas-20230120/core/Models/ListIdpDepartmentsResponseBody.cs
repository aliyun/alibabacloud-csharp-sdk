// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class ListIdpDepartmentsResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListIdpDepartmentsResponseBodyData Data { get; set; }
        public class ListIdpDepartmentsResponseBodyData : TeaModel {
            [NameInMap("DataList")]
            [Validation(Required=false)]
            public List<ListIdpDepartmentsResponseBodyDataDataList> DataList { get; set; }
            public class ListIdpDepartmentsResponseBodyDataDataList : TeaModel {
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                [NameInMap("IdpConfigId")]
                [Validation(Required=false)]
                public string IdpConfigId { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

            [NameInMap("TotalNum")]
            [Validation(Required=false)]
            public long? TotalNum { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
