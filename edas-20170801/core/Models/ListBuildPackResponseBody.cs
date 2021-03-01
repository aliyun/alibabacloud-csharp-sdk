// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class ListBuildPackResponseBody : TeaModel {
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("BuildPackList")]
        [Validation(Required=false)]
        public ListBuildPackResponseBodyBuildPackList BuildPackList { get; set; }
        public class ListBuildPackResponseBodyBuildPackList : TeaModel {
            [NameInMap("BuildPack")]
            [Validation(Required=false)]
            public List<ListBuildPackResponseBodyBuildPackListBuildPack> BuildPack { get; set; }
            public class ListBuildPackResponseBodyBuildPackListBuildPack : TeaModel {
                public long? ConfigId { get; set; }
                public string PandoraVersion { get; set; }
                public string PandoraDesc { get; set; }
                public string Feature { get; set; }
                public string PluginInfo { get; set; }
                public string TengineDownloadUrl { get; set; }
                public bool? Disabled { get; set; }
                public string TomcatPath { get; set; }
                public string TomcatDesc { get; set; }
                public string SupportFeatures { get; set; }
                public string TomcatDownloadUrl { get; set; }
                public string TomcatVersion { get; set; }
                public string PandoraDownloadUrl { get; set; }
                public string PackVersion { get; set; }
                public bool? MultipleTenant { get; set; }
                public string TengineImageId { get; set; }
                public bool? WithTengine { get; set; }
                public string ImageId { get; set; }
                public string ScriptName { get; set; }
                public string ScriptVersion { get; set; }
            }
        };

        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

    }

}
