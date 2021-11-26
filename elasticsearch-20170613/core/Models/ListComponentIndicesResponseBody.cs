// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class ListComponentIndicesResponseBody : TeaModel {
        [NameInMap("Headers")]
        [Validation(Required=false)]
        public ListComponentIndicesResponseBodyHeaders Headers { get; set; }
        public class ListComponentIndicesResponseBodyHeaders : TeaModel {
            [NameInMap("X-Total-Count")]
            [Validation(Required=false)]
            public long? XTotalCount { get; set; }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public List<ListComponentIndicesResponseBodyResult> Result { get; set; }
        public class ListComponentIndicesResponseBodyResult : TeaModel {
            [NameInMap("composed")]
            [Validation(Required=false)]
            public List<string> Composed { get; set; }

            [NameInMap("content")]
            [Validation(Required=false)]
            public ListComponentIndicesResponseBodyResultContent Content { get; set; }
            public class ListComponentIndicesResponseBodyResultContent : TeaModel {
                [NameInMap("_meta")]
                [Validation(Required=false)]
                public ListComponentIndicesResponseBodyResultContentMeta Meta { get; set; }
                public class ListComponentIndicesResponseBodyResultContentMeta : TeaModel {
                    [NameInMap("description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    [NameInMap("managed")]
                    [Validation(Required=false)]
                    public bool? Managed { get; set; }

                }
                [NameInMap("template")]
                [Validation(Required=false)]
                public ListComponentIndicesResponseBodyResultContentTemplate Template { get; set; }
                public class ListComponentIndicesResponseBodyResultContentTemplate : TeaModel {
                    [NameInMap("settings")]
                    [Validation(Required=false)]
                    public ListComponentIndicesResponseBodyResultContentTemplateSettings Settings { get; set; }
                    public class ListComponentIndicesResponseBodyResultContentTemplateSettings : TeaModel {
                        [NameInMap("index")]
                        [Validation(Required=false)]
                        public ListComponentIndicesResponseBodyResultContentTemplateSettingsIndex Index { get; set; }
                        public class ListComponentIndicesResponseBodyResultContentTemplateSettingsIndex : TeaModel {
                            [NameInMap("codec")]
                            [Validation(Required=false)]
                            public string Codec { get; set; }

                            [NameInMap("lifecycle")]
                            [Validation(Required=false)]
                            public ListComponentIndicesResponseBodyResultContentTemplateSettingsIndexLifecycle Lifecycle { get; set; }
                            public class ListComponentIndicesResponseBodyResultContentTemplateSettingsIndexLifecycle : TeaModel {
                                [NameInMap("name")]
                                [Validation(Required=false)]
                                public string Name { get; set; }
                            };

                        }
                    };

                }
                [NameInMap("version")]
                [Validation(Required=false)]
                public long? Version { get; set; }
            };

            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

        }

    }

}
