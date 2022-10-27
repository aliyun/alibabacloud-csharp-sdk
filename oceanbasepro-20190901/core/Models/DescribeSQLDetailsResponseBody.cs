// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OceanBasePro20190901.Models
{
    public class DescribeSQLDetailsResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SQLDetails")]
        [Validation(Required=false)]
        public List<DescribeSQLDetailsResponseBodySQLDetails> SQLDetails { get; set; }
        public class DescribeSQLDetailsResponseBodySQLDetails : TeaModel {
            [NameInMap("DbName")]
            [Validation(Required=false)]
            public string DbName { get; set; }

            [NameInMap("SQLText")]
            [Validation(Required=false)]
            public string SQLText { get; set; }

            [NameInMap("UserName")]
            [Validation(Required=false)]
            public string UserName { get; set; }

        }

    }

}
