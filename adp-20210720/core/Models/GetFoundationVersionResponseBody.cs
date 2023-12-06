// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adp20210720.Models
{
    public class GetFoundationVersionResponseBody : TeaModel {
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("data")]
        [Validation(Required=false)]
        public GetFoundationVersionResponseBodyData Data { get; set; }
        public class GetFoundationVersionResponseBodyData : TeaModel {
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("features")]
            [Validation(Required=false)]
            public List<string> Features { get; set; }

            [NameInMap("isDefault")]
            [Validation(Required=false)]
            public bool? IsDefault { get; set; }

            [NameInMap("labels")]
            [Validation(Required=false)]
            public string Labels { get; set; }

            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("platforms")]
            [Validation(Required=false)]
            public List<Platform> Platforms { get; set; }

            [NameInMap("siteSurveyTool")]
            [Validation(Required=false)]
            public GetFoundationVersionResponseBodyDataSiteSurveyTool SiteSurveyTool { get; set; }
            public class GetFoundationVersionResponseBodyDataSiteSurveyTool : TeaModel {
                [NameInMap("clusterCheckerURL")]
                [Validation(Required=false)]
                public string ClusterCheckerURL { get; set; }

                [NameInMap("clusterInfoBrief")]
                [Validation(Required=false)]
                public string ClusterInfoBrief { get; set; }

            }

            [NameInMap("specName")]
            [Validation(Required=false)]
            public string SpecName { get; set; }

            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            [NameInMap("uid")]
            [Validation(Required=false)]
            public string Uid { get; set; }

            /// <summary>
            /// version
            /// </summary>
            [NameInMap("version")]
            [Validation(Required=false)]
            public string Version { get; set; }

        }

        [NameInMap("msg")]
        [Validation(Required=false)]
        public string Msg { get; set; }

    }

}
