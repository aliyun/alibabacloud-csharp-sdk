// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class GetClriskDataNodeResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResultCode")]
        [Validation(Required=false)]
        public string ResultCode { get; set; }

        [NameInMap("ResultMessage")]
        [Validation(Required=false)]
        public string ResultMessage { get; set; }

        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("Id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("OdpsProject")]
        [Validation(Required=false)]
        public string OdpsProject { get; set; }

        [NameInMap("TableAuthDescription")]
        [Validation(Required=false)]
        public string TableAuthDescription { get; set; }

        [NameInMap("TableName")]
        [Validation(Required=false)]
        public string TableName { get; set; }

        [NameInMap("UpdateTime")]
        [Validation(Required=false)]
        public string UpdateTime { get; set; }

        [NameInMap("UpdateUser")]
        [Validation(Required=false)]
        public string UpdateUser { get; set; }

        [NameInMap("RelatedEntranceList")]
        [Validation(Required=false)]
        public List<GetClriskDataNodeResponseBodyRelatedEntranceList> RelatedEntranceList { get; set; }
        public class GetClriskDataNodeResponseBodyRelatedEntranceList : TeaModel {
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            [NameInMap("ModelCode")]
            [Validation(Required=false)]
            public string ModelCode { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("Url")]
            [Validation(Required=false)]
            public string Url { get; set; }

        }

    }

}
