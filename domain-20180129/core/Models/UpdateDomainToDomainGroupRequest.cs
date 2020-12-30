// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Domain20180129.Models
{
    public class UpdateDomainToDomainGroupRequest : TeaModel {
        [NameInMap("UserClientIp")]
        [Validation(Required=false)]
        public string UserClientIp { get; set; }

        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        [NameInMap("FileToUpload")]
        [Validation(Required=false)]
        public string FileToUpload { get; set; }

        [NameInMap("DomainGroupId")]
        [Validation(Required=false)]
        public long? DomainGroupId { get; set; }

        [NameInMap("Replace")]
        [Validation(Required=false)]
        public bool? Replace { get; set; }

        [NameInMap("DataSource")]
        [Validation(Required=false)]
        public int? DataSource { get; set; }

        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public List<string> DomainName { get; set; }

    }

}
