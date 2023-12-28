// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Oosops20190601.Models
{
    public class ListActionsResponseBody : TeaModel {
        [NameInMap("Actions")]
        [Validation(Required=false)]
        public List<ListActionsResponseBodyActions> Actions { get; set; }
        public class ListActionsResponseBodyActions : TeaModel {
            [NameInMap("ActionType")]
            [Validation(Required=false)]
            public string ActionType { get; set; }

            [NameInMap("CreatedDate")]
            [Validation(Required=false)]
            public string CreatedDate { get; set; }

            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("OOSActionName")]
            [Validation(Required=false)]
            public string OOSActionName { get; set; }

            [NameInMap("Popularity")]
            [Validation(Required=false)]
            public int? Popularity { get; set; }

            [NameInMap("Properties")]
            [Validation(Required=false)]
            public string Properties { get; set; }

            [NameInMap("TemplateVersion")]
            [Validation(Required=false)]
            public string TemplateVersion { get; set; }

            [NameInMap("UpdateDate")]
            [Validation(Required=false)]
            public string UpdateDate { get; set; }

        }

        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
