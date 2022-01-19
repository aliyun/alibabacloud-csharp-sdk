// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Clickhouse20191111.Models
{
    public class DescribeAccountAuthorityResponseBody : TeaModel {
        [NameInMap("AccountName")]
        [Validation(Required=false)]
        public string AccountName { get; set; }

        [NameInMap("AllowDatabases")]
        [Validation(Required=false)]
        public List<string> AllowDatabases { get; set; }

        [NameInMap("AllowDictionaries")]
        [Validation(Required=false)]
        public List<string> AllowDictionaries { get; set; }

        [NameInMap("DdlAuthority")]
        [Validation(Required=false)]
        public bool? DdlAuthority { get; set; }

        [NameInMap("DmlAuthority")]
        [Validation(Required=false)]
        public string DmlAuthority { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalDatabases")]
        [Validation(Required=false)]
        public List<string> TotalDatabases { get; set; }

        [NameInMap("TotalDictionaries")]
        [Validation(Required=false)]
        public List<string> TotalDictionaries { get; set; }

    }

}
