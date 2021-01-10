// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class QueryMsSgServiceSubRelationsResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResultCode")]
        [Validation(Required=false)]
        public string ResultCode { get; set; }

        [NameInMap("ResultMessage")]
        [Validation(Required=false)]
        public string ResultMessage { get; set; }

        [NameInMap("ServiceRelations")]
        [Validation(Required=false)]
        public List<QueryMsSgServiceSubRelationsResponseBodyServiceRelations> ServiceRelations { get; set; }
        public class QueryMsSgServiceSubRelationsResponseBodyServiceRelations : TeaModel {
            [NameInMap("AppName")]
            [Validation(Required=false)]
            public string AppName { get; set; }

            [NameInMap("DataId")]
            [Validation(Required=false)]
            public string DataId { get; set; }

        }

    }

}
