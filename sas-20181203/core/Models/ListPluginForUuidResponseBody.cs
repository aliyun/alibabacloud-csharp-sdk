// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ListPluginForUuidResponseBody : TeaModel {
        [NameInMap("AegisUuidTargetPluginConfigList")]
        [Validation(Required=false)]
        public List<ListPluginForUuidResponseBodyAegisUuidTargetPluginConfigList> AegisUuidTargetPluginConfigList { get; set; }
        public class ListPluginForUuidResponseBodyAegisUuidTargetPluginConfigList : TeaModel {
            [NameInMap("AegisSuspiciousConfigList")]
            [Validation(Required=false)]
            public List<ListPluginForUuidResponseBodyAegisUuidTargetPluginConfigListAegisSuspiciousConfigList> AegisSuspiciousConfigList { get; set; }
            public class ListPluginForUuidResponseBodyAegisUuidTargetPluginConfigListAegisSuspiciousConfigList : TeaModel {
                [NameInMap("Config")]
                [Validation(Required=false)]
                public bool? Config { get; set; }

                [NameInMap("Msg")]
                [Validation(Required=false)]
                public string Msg { get; set; }

                [NameInMap("OverallConfig")]
                [Validation(Required=false)]
                public bool? OverallConfig { get; set; }

                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            [NameInMap("PluginInstallCode")]
            [Validation(Required=false)]
            public string PluginInstallCode { get; set; }

            [NameInMap("PluginName")]
            [Validation(Required=false)]
            public string PluginName { get; set; }

            [NameInMap("PluginOnlineInstalled")]
            [Validation(Required=false)]
            public bool? PluginOnlineInstalled { get; set; }

            [NameInMap("PluginOnlineStatus")]
            [Validation(Required=false)]
            public bool? PluginOnlineStatus { get; set; }

            [NameInMap("PluginVersion")]
            [Validation(Required=false)]
            public string PluginVersion { get; set; }

        }

        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
