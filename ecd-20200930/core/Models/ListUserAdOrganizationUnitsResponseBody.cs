// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class ListUserAdOrganizationUnitsResponseBody : TeaModel {
        [NameInMap("OUNames")]
        [Validation(Required=false)]
        public List<ListUserAdOrganizationUnitsResponseBodyOUNames> OUNames { get; set; }
        public class ListUserAdOrganizationUnitsResponseBodyOUNames : TeaModel {
            [NameInMap("OUName")]
            [Validation(Required=false)]
            public string OUName { get; set; }

            [NameInMap("OfficeSiteId")]
            [Validation(Required=false)]
            public string OfficeSiteId { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
