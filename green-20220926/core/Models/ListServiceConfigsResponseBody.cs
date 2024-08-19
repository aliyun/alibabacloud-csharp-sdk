// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Green20220926.Models
{
    public class ListServiceConfigsResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListServiceConfigsResponseBodyData> Data { get; set; }
        public class ListServiceConfigsResponseBodyData : TeaModel {
            [NameInMap("Classify")]
            [Validation(Required=false)]
            public string Classify { get; set; }

            [NameInMap("CopyFrom")]
            [Validation(Required=false)]
            public string CopyFrom { get; set; }

            [NameInMap("CustomServiceConf")]
            [Validation(Required=false)]
            public ListServiceConfigsResponseBodyDataCustomServiceConf CustomServiceConf { get; set; }
            public class ListServiceConfigsResponseBodyDataCustomServiceConf : TeaModel {
                [NameInMap("AudioService")]
                [Validation(Required=false)]
                public string AudioService { get; set; }

                [NameInMap("ImageService")]
                [Validation(Required=false)]
                public List<string> ImageService { get; set; }

                [NameInMap("KeywordFilterLibs")]
                [Validation(Required=false)]
                public List<string> KeywordFilterLibs { get; set; }

                [NameInMap("KeywordHitLibs")]
                [Validation(Required=false)]
                public List<string> KeywordHitLibs { get; set; }

                [NameInMap("Rules")]
                [Validation(Required=false)]
                public List<ListServiceConfigsResponseBodyDataCustomServiceConfRules> Rules { get; set; }
                public class ListServiceConfigsResponseBodyDataCustomServiceConfRules : TeaModel {
                    [NameInMap("ImageScanRule")]
                    [Validation(Required=false)]
                    public ListServiceConfigsResponseBodyDataCustomServiceConfRulesImageScanRule ImageScanRule { get; set; }
                    public class ListServiceConfigsResponseBodyDataCustomServiceConfRulesImageScanRule : TeaModel {
                        [NameInMap("Services")]
                        [Validation(Required=false)]
                        public List<string> Services { get; set; }

                    }

                    [NameInMap("Index")]
                    [Validation(Required=false)]
                    public int? Index { get; set; }

                    [NameInMap("TextScanRule")]
                    [Validation(Required=false)]
                    public ListServiceConfigsResponseBodyDataCustomServiceConfRulesTextScanRule TextScanRule { get; set; }
                    public class ListServiceConfigsResponseBodyDataCustomServiceConfRulesTextScanRule : TeaModel {
                        [NameInMap("Services")]
                        [Validation(Required=false)]
                        public List<string> Services { get; set; }

                    }

                }

                [NameInMap("SimilarTextHitLibs")]
                [Validation(Required=false)]
                public List<string> SimilarTextHitLibs { get; set; }

            }

            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            [NameInMap("Option")]
            [Validation(Required=false)]
            public Dictionary<string, object> Option { get; set; }

            [NameInMap("ResourceType")]
            [Validation(Required=false)]
            public string ResourceType { get; set; }

            [NameInMap("ServiceCode")]
            [Validation(Required=false)]
            public string ServiceCode { get; set; }

            [NameInMap("ServiceDesc")]
            [Validation(Required=false)]
            public string ServiceDesc { get; set; }

            [NameInMap("ServiceName")]
            [Validation(Required=false)]
            public string ServiceName { get; set; }

            [NameInMap("ServiceType")]
            [Validation(Required=false)]
            public string ServiceType { get; set; }

            /// <summary>
            /// UID。
            /// </summary>
            [NameInMap("Uid")]
            [Validation(Required=false)]
            public string Uid { get; set; }

            [NameInMap("UseStatus")]
            [Validation(Required=false)]
            public string UseStatus { get; set; }

        }

        [NameInMap("Msg")]
        [Validation(Required=false)]
        public string Msg { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
