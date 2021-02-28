// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Chatbot20171011.Models
{
    public class QuerySystemEntitiesResponseBody : TeaModel {
        [NameInMap("SystemEntities")]
        [Validation(Required=false)]
        public List<QuerySystemEntitiesResponseBodySystemEntities> SystemEntities { get; set; }
        public class QuerySystemEntitiesResponseBodySystemEntities : TeaModel {
            [NameInMap("DefaultQuestion")]
            [Validation(Required=false)]
            public string DefaultQuestion { get; set; }

            [NameInMap("EntityCode")]
            [Validation(Required=false)]
            public string EntityCode { get; set; }

            [NameInMap("EntityName")]
            [Validation(Required=false)]
            public string EntityName { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
