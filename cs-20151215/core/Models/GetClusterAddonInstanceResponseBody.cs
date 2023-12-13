// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class GetClusterAddonInstanceResponseBody : TeaModel {
        [NameInMap("config")]
        [Validation(Required=false)]
        public string Config { get; set; }

        [NameInMap("logging")]
        [Validation(Required=false)]
        public GetClusterAddonInstanceResponseBodyLogging Logging { get; set; }
        public class GetClusterAddonInstanceResponseBodyLogging : TeaModel {
            [NameInMap("capable")]
            [Validation(Required=false)]
            public bool? Capable { get; set; }

            [NameInMap("enabled")]
            [Validation(Required=false)]
            public bool? Enabled { get; set; }

            [NameInMap("log_project")]
            [Validation(Required=false)]
            public string LogProject { get; set; }

            [NameInMap("logstore")]
            [Validation(Required=false)]
            public string Logstore { get; set; }

        }

        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("state")]
        [Validation(Required=false)]
        public string State { get; set; }

        [NameInMap("version")]
        [Validation(Required=false)]
        public string Version { get; set; }

    }

}
