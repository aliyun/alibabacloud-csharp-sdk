// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class SLSConfig : TeaModel {
        [NameInMap("collectConfigs")]
        [Validation(Required=false)]
        public List<SLSConfigCollectConfigs> CollectConfigs { get; set; }
        public class SLSConfigCollectConfigs : TeaModel {
            [NameInMap("logPath")]
            [Validation(Required=false)]
            public string LogPath { get; set; }

            [NameInMap("logType")]
            [Validation(Required=false)]
            public string LogType { get; set; }

            [NameInMap("logstoreName")]
            [Validation(Required=false)]
            public string LogstoreName { get; set; }

            [NameInMap("logtailName")]
            [Validation(Required=false)]
            public string LogtailName { get; set; }

            [NameInMap("projectName")]
            [Validation(Required=false)]
            public string ProjectName { get; set; }

        }

    }

}
