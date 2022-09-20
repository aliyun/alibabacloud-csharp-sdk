// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OpenITag20220616.Models
{
    public class ViewPlugin : TeaModel {
        [NameInMap("BindField")]
        [Validation(Required=false)]
        public string BindField { get; set; }

        [NameInMap("Convertor")]
        [Validation(Required=false)]
        public string Convertor { get; set; }

        [NameInMap("CorsProxy")]
        [Validation(Required=false)]
        public bool? CorsProxy { get; set; }

        [NameInMap("DisplayOriImg")]
        [Validation(Required=false)]
        public bool? DisplayOriImg { get; set; }

        [NameInMap("Exif")]
        [Validation(Required=false)]
        public Dictionary<string, object> Exif { get; set; }

        [NameInMap("Hide")]
        [Validation(Required=false)]
        public bool? Hide { get; set; }

        [NameInMap("Plugins")]
        [Validation(Required=false)]
        public Dictionary<string, object> Plugins { get; set; }

        [NameInMap("RelationQuestionIds")]
        [Validation(Required=false)]
        public List<string> RelationQuestionIds { get; set; }

        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        [NameInMap("VisitInfo")]
        [Validation(Required=false)]
        public ViewPluginVisitInfo VisitInfo { get; set; }
        public class ViewPluginVisitInfo : TeaModel {
            [NameInMap("aftsConf")]
            [Validation(Required=false)]
            public Dictionary<string, object> AftsConf { get; set; }

            [NameInMap("ossConf")]
            [Validation(Required=false)]
            public Dictionary<string, object> OssConf { get; set; }

        }

    }

}
