// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Wyota20210420.Models
{
    public class AddTerminalsRequest : TeaModel {
        [NameInMap("AddTerminalParams")]
        [Validation(Required=false)]
        public List<AddTerminalsRequestAddTerminalParams> AddTerminalParams { get; set; }
        public class AddTerminalsRequestAddTerminalParams : TeaModel {
            [NameInMap("Alias")]
            [Validation(Required=false)]
            public string Alias { get; set; }

            [NameInMap("ClientType")]
            [Validation(Required=false)]
            public int? ClientType { get; set; }

            [NameInMap("SerialNumber")]
            [Validation(Required=false)]
            public string SerialNumber { get; set; }

            [NameInMap("TerminalGroupId")]
            [Validation(Required=false)]
            public string TerminalGroupId { get; set; }

            [NameInMap("Uuid")]
            [Validation(Required=false)]
            public string Uuid { get; set; }

        }

    }

}
