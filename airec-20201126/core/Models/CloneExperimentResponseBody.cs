// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Airec20201126.Models
{
    public class CloneExperimentResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>E3D6FE3B-B7C2-43DA-9A13-5EA837ACED9B</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The information about the experiment.</para>
        /// </summary>
        [NameInMap("result")]
        [Validation(Required=false)]
        public CloneExperimentResponseBodyResult Result { get; set; }
        public class CloneExperimentResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>The algorithm configurations.</para>
            /// </summary>
            [NameInMap("algorithms")]
            [Validation(Required=false)]
            public List<CloneExperimentResponseBodyResultAlgorithms> Algorithms { get; set; }
            public class CloneExperimentResponseBodyResultAlgorithms : TeaModel {
                /// <summary>
                /// <para>The algorithm category. Valid values: RECALL and RANK.</para>
                /// 
                /// <b>Example:</b>
                /// <para>RECALL</para>
                /// </summary>
                [NameInMap("category")]
                [Validation(Required=false)]
                public string Category { get; set; }

                /// <summary>
                /// <para>The child configuration items.</para>
                /// </summary>
                [NameInMap("config")]
                [Validation(Required=false)]
                public List<CloneExperimentResponseBodyResultAlgorithmsConfig> Config { get; set; }
                public class CloneExperimentResponseBodyResultAlgorithmsConfig : TeaModel {
                    /// <summary>
                    /// <para>The default value of the algorithm.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>400</para>
                    /// </summary>
                    [NameInMap("defaultValue")]
                    [Validation(Required=false)]
                    public string DefaultValue { get; set; }

                    /// <summary>
                    /// <para>The custom value of the algorithm.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>swing;commoni2i;pcategory;scategory</para>
                    /// </summary>
                    [NameInMap("experimentValue")]
                    [Validation(Required=false)]
                    public string ExperimentValue { get; set; }

                    /// <summary>
                    /// <para>The algorithm key.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>I2I-truncedquantity</para>
                    /// </summary>
                    [NameInMap("key")]
                    [Validation(Required=false)]
                    public string Key { get; set; }

                    /// <summary>
                    /// <para>The algorithm name. (Note: If you use the default algorithm, the console obtains the algorithm name from Medusa. If you customize an algorithm for the experiment, the algorithm name is directly returned.)</para>
                    /// </summary>
                    [NameInMap("name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                }

                /// <summary>
                /// <para>The default value of the algorithm configuration item.</para>
                /// 
                /// <b>Example:</b>
                /// <para>i2i;u2x2i;new;hot;embedding;embedding</para>
                /// </summary>
                [NameInMap("defaultValue")]
                [Validation(Required=false)]
                public string DefaultValue { get; set; }

                /// <summary>
                /// <para>The custom value of the algorithm configuration item.</para>
                /// 
                /// <b>Example:</b>
                /// <para>300</para>
                /// </summary>
                [NameInMap("experimentValue")]
                [Validation(Required=false)]
                public string ExperimentValue { get; set; }

                /// <summary>
                /// <para>Indicates whether child configuration items exist. Valid values: true and false.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("hasConfig")]
                [Validation(Required=false)]
                public bool? HasConfig { get; set; }

                /// <summary>
                /// <para>The algorithm key. Valid values: I2I: the I2I filtering algorithm. u2X2I: the U2X2I filtering algorithm. hot: the filtering algorithm for popular items. new: the filtering algorithm for new items. embedding: the vector filtering algorithm. mtorder: the priority of the filtering algorithm. rankservice: the ranking service.</para>
                /// 
                /// <b>Example:</b>
                /// <para>I2I</para>
                /// </summary>
                [NameInMap("key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <para>The algorithm name. (Note: If you use the default algorithm, the console obtains the algorithm name from Medusa. If you customize an algorithm for the experiment, the algorithm name is directly returned.)</para>
                /// 
                /// <b>Example:</b>
                /// <para>name</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The algorithm type. Valid values: SYSTEM and CUSTOM.</para>
                /// 
                /// <b>Example:</b>
                /// <para>SYSTEM</para>
                /// </summary>
                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <para>N/A</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("base")]
            [Validation(Required=false)]
            public bool? Base { get; set; }

            /// <summary>
            /// <para>The buckets.</para>
            /// </summary>
            [NameInMap("buckets")]
            [Validation(Required=false)]
            public List<string> Buckets { get; set; }

            /// <summary>
            /// <para>The remarks.</para>
            /// 
            /// <b>Example:</b>
            /// <para>xxx</para>
            /// </summary>
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The experiment ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>12345</para>
            /// </summary>
            [NameInMap("experimentId")]
            [Validation(Required=false)]
            public string ExperimentId { get; set; }

            /// <summary>
            /// <para>The experiment name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>xxx</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The time when the experiment was unpublished.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2020-11-11T09:47:43.000Z</para>
            /// </summary>
            [NameInMap("offlineTime")]
            [Validation(Required=false)]
            public string OfflineTime { get; set; }

            /// <summary>
            /// <para>The time when the experiment was published.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2020-11-11T09:47:43.000Z</para>
            /// </summary>
            [NameInMap("onlineTime")]
            [Validation(Required=false)]
            public string OnlineTime { get; set; }

            /// <summary>
            /// <para>The experiment state.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Init</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

    }

}
