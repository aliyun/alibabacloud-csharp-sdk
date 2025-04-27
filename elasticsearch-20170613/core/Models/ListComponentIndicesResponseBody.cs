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
            /// <summary>
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("X-Total-Count")]
            [Validation(Required=false)]
            public long? XTotalCount { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>F99407AB-2FA9-489E-A259-40CF6DCC47D9</para>
        /// </summary>
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
                /// <summary>
                /// <b>Example:</b>
                /// <para>{ &quot;description&quot;: &quot;set number of shards to one&quot; }</para>
                /// </summary>
                [NameInMap("_meta")]
                [Validation(Required=false)]
                public Dictionary<string, object> Meta { get; set; }

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
                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>best_compression</para>
                            /// </summary>
                            [NameInMap("codec")]
                            [Validation(Required=false)]
                            public string Codec { get; set; }

                            [NameInMap("lifecycle")]
                            [Validation(Required=false)]
                            public ListComponentIndicesResponseBodyResultContentTemplateSettingsIndexLifecycle Lifecycle { get; set; }
                            public class ListComponentIndicesResponseBodyResultContentTemplateSettingsIndexLifecycle : TeaModel {
                                /// <summary>
                                /// <b>Example:</b>
                                /// <para>synthetics</para>
                                /// </summary>
                                [NameInMap("name")]
                                [Validation(Required=false)]
                                public string Name { get; set; }

                            }

                        }

                    }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("version")]
                [Validation(Required=false)]
                public long? Version { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>synthetics-settings</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

        }

    }

}
