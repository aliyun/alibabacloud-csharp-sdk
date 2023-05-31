// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DeleteTagWithUuidRequest : TeaModel {
        /// <summary>
        /// The name of the tag.
        /// </summary>
        [NameInMap("TagName")]
        [Validation(Required=false)]
        public string TagName { get; set; }

        /// <summary>
        /// The UUIDs of servers.
        /// 
        /// > If the UuidList parameter is specified, Security Center removes the tag only from the servers whose UUIDs are specified by UuidList. If the UuidList parameter is not specified, Security Center removes the tag from all servers.
        /// </summary>
        [NameInMap("UuidList")]
        [Validation(Required=false)]
        public string UuidList { get; set; }

    }

}
