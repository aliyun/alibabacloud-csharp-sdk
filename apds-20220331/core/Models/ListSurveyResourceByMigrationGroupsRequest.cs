// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Apds20220331.Models
{
    public class ListSurveyResourceByMigrationGroupsRequest : TeaModel {
        [NameInMap("body")]
        [Validation(Required=false)]
        public ListSurveyResourceByMigrationGroupsRequestBody Body { get; set; }
        public class ListSurveyResourceByMigrationGroupsRequestBody : TeaModel {
            [NameInMap("ids")]
            [Validation(Required=false)]
            public List<int?> Ids { get; set; }

        }

    }

}
