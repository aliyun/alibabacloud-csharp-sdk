// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class CheckODPDbnodesPrivilegesRequest : TeaModel {
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("Dbnodes")]
        [Validation(Required=false)]
        public List<CheckODPDbnodesPrivilegesRequestDbnodes> Dbnodes { get; set; }
        public class CheckODPDbnodesPrivilegesRequestDbnodes : TeaModel {
            [NameInMap("Password")]
            [Validation(Required=false)]
            public string Password { get; set; }

            [NameInMap("NodeId")]
            [Validation(Required=false)]
            public string NodeId { get; set; }

            [NameInMap("Username")]
            [Validation(Required=false)]
            public string Username { get; set; }

        }

    }

}
