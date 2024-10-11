// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Airec20201126.Models
{
    public class UpdateExperimentConfigResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>829F38F6-E2D6-4109-90A6-888160BD16C2</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("result")]
        [Validation(Required=false)]
        public UpdateExperimentConfigResponseBodyResult Result { get; set; }
        public class UpdateExperimentConfigResponseBodyResult : TeaModel {
            [NameInMap("algorithms")]
            [Validation(Required=false)]
            public List<UpdateExperimentConfigResponseBodyResultAlgorithms> Algorithms { get; set; }
            public class UpdateExperimentConfigResponseBodyResultAlgorithms : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>RECALL</para>
                /// </summary>
                [NameInMap("category")]
                [Validation(Required=false)]
                public string Category { get; set; }

                [NameInMap("config")]
                [Validation(Required=false)]
                public List<UpdateExperimentConfigResponseBodyResultAlgorithmsConfig> Config { get; set; }
                public class UpdateExperimentConfigResponseBodyResultAlgorithmsConfig : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("defaultValue")]
                    [Validation(Required=false)]
                    public string DefaultValue { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("experimentValue")]
                    [Validation(Required=false)]
                    public string ExperimentValue { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>I2I</para>
                    /// </summary>
                    [NameInMap("key")]
                    [Validation(Required=false)]
                    public string Key { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>xxx</para>
                    /// </summary>
                    [NameInMap("name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>400</para>
                /// </summary>
                [NameInMap("defaultValue")]
                [Validation(Required=false)]
                public string DefaultValue { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>300</para>
                /// </summary>
                [NameInMap("experimentValue")]
                [Validation(Required=false)]
                public string ExperimentValue { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("hasConfig")]
                [Validation(Required=false)]
                public bool? HasConfig { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>I2I</para>
                /// </summary>
                [NameInMap("key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>xxx</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>SYSTEM</para>
                /// </summary>
                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("base")]
            [Validation(Required=false)]
            public bool? Base { get; set; }

            [NameInMap("buckets")]
            [Validation(Required=false)]
            public List<string> Buckets { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>demo1</para>
            /// </summary>
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>xxx</para>
            /// </summary>
            [NameInMap("experimentId")]
            [Validation(Required=false)]
            public string ExperimentId { get; set; }

            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2020-12-07T06:47:30.000Z</para>
            /// </summary>
            [NameInMap("offlineTime")]
            [Validation(Required=false)]
            public string OfflineTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2020-12-07T06:47:30.000Z</para>
            /// </summary>
            [NameInMap("onlineTime")]
            [Validation(Required=false)]
            public string OnlineTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Online</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

    }

}
