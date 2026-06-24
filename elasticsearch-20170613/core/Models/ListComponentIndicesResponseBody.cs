// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class ListComponentIndicesResponseBody : TeaModel {
        /// <summary>
        /// <para>The response headers.</para>
        /// </summary>
        [NameInMap("Headers")]
        [Validation(Required=false)]
        public ListComponentIndicesResponseBodyHeaders Headers { get; set; }
        public class ListComponentIndicesResponseBodyHeaders : TeaModel {
            /// <summary>
            /// <para>The total number of entries returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("X-Total-Count")]
            [Validation(Required=false)]
            public long? XTotalCount { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>F99407AB-2FA9-489E-A259-40CF6DCC47D9</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The details of the returned results.</para>
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public List<ListComponentIndicesResponseBodyResult> Result { get; set; }
        public class ListComponentIndicesResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>The information about the index templates that reference this composable template.</para>
            /// </summary>
            [NameInMap("composed")]
            [Validation(Required=false)]
            public List<string> Composed { get; set; }

            /// <summary>
            /// <para>The content of the composable template.</para>
            /// </summary>
            [NameInMap("content")]
            [Validation(Required=false)]
            public ListComponentIndicesResponseBodyResultContent Content { get; set; }
            public class ListComponentIndicesResponseBodyResultContent : TeaModel {
                /// <summary>
                /// <para>The metadata, which is used to store information such as remarks.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{ &quot;description&quot;: &quot;set number of shards to one&quot; }</para>
                /// </summary>
                [NameInMap("_meta")]
                [Validation(Required=false)]
                public Dictionary<string, object> Meta { get; set; }

                /// <summary>
                /// <para>The composable template object.</para>
                /// </summary>
                [NameInMap("template")]
                [Validation(Required=false)]
                public ListComponentIndicesResponseBodyResultContentTemplate Template { get; set; }
                public class ListComponentIndicesResponseBodyResultContentTemplate : TeaModel {
                    /// <summary>
                    /// <para>The settings configuration of the template.</para>
                    /// </summary>
                    [NameInMap("settings")]
                    [Validation(Required=false)]
                    public ListComponentIndicesResponseBodyResultContentTemplateSettings Settings { get; set; }
                    public class ListComponentIndicesResponseBodyResultContentTemplateSettings : TeaModel {
                        /// <summary>
                        /// <para>The index information.</para>
                        /// </summary>
                        [NameInMap("index")]
                        [Validation(Required=false)]
                        public ListComponentIndicesResponseBodyResultContentTemplateSettingsIndex Index { get; set; }
                        public class ListComponentIndicesResponseBodyResultContentTemplateSettingsIndex : TeaModel {
                            /// <summary>
                            /// <para>The index compression method. Valid values:</para>
                            /// <list type="bullet">
                            /// <item><description>LZ4: the default compression algorithm of Elasticsearch. It provides fast compression and decompression but a relatively lower compression ratio.</description></item>
                            /// <item><description>best_compression: uses the best_compression algorithm for compression, which provides a higher compression ratio.</description></item>
                            /// </list>
                            /// 
                            /// <b>Example:</b>
                            /// <para>best_compression</para>
                            /// </summary>
                            [NameInMap("codec")]
                            [Validation(Required=false)]
                            public string Codec { get; set; }

                            /// <summary>
                            /// <para>The index lifecycle configuration.</para>
                            /// </summary>
                            [NameInMap("lifecycle")]
                            [Validation(Required=false)]
                            public ListComponentIndicesResponseBodyResultContentTemplateSettingsIndexLifecycle Lifecycle { get; set; }
                            public class ListComponentIndicesResponseBodyResultContentTemplateSettingsIndexLifecycle : TeaModel {
                                /// <summary>
                                /// <para>The name of the lifecycle policy.</para>
                                /// 
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
                /// <para>The version of the composable template.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("version")]
                [Validation(Required=false)]
                public long? Version { get; set; }

            }

            /// <summary>
            /// <para>The name of the composable template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>synthetics-settings</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

        }

    }

}
