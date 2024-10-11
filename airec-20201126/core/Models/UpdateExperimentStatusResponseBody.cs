// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Airec20201126.Models
{
    public class UpdateExperimentStatusResponseBody : TeaModel {
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
        /// <para>The returned result.</para>
        /// </summary>
        [NameInMap("result")]
        [Validation(Required=false)]
        public UpdateExperimentStatusResponseBodyResult Result { get; set; }
        public class UpdateExperimentStatusResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>The algorithm configurations.</para>
            /// </summary>
            [NameInMap("algorithms")]
            [Validation(Required=false)]
            public List<UpdateExperimentStatusResponseBodyResultAlgorithms> Algorithms { get; set; }
            public class UpdateExperimentStatusResponseBodyResultAlgorithms : TeaModel {
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
                /// <para>The experiment configurations.</para>
                /// </summary>
                [NameInMap("config")]
                [Validation(Required=false)]
                public List<UpdateExperimentStatusResponseBodyResultAlgorithmsConfig> Config { get; set; }
                public class UpdateExperimentStatusResponseBodyResultAlgorithmsConfig : TeaModel {
                    /// <summary>
                    /// <para>The default value of the algorithm. If you set key to i2i, hot, or new, the value of this parameter is true or false. If you set key to mtorder, the value of this parameter is a list of filtering algorithms ranked by priority.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>xxx</para>
                    /// </summary>
                    [NameInMap("defaultValue")]
                    [Validation(Required=false)]
                    public string DefaultValue { get; set; }

                    /// <summary>
                    /// <para>The custom value of the algorithm.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>xxx</para>
                    /// </summary>
                    [NameInMap("experimentValue")]
                    [Validation(Required=false)]
                    public string ExperimentValue { get; set; }

                    /// <summary>
                    /// <para>The algorithm key. Valid values: i2i: the I2I filtering algorithm. u2x2i: the U2X2I filtering algorithm. hot: the filtering algorithm for popular items. new: the filtering algorithm for new items. embedding: the vector filtering algorithm. mtorder: the priority of the filtering algorithm. rankservice: the ranking service.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>hot</para>
                    /// </summary>
                    [NameInMap("key")]
                    [Validation(Required=false)]
                    public string Key { get; set; }

                    /// <summary>
                    /// <para>The algorithm name. (Note: If you use the default algorithm, the console obtains the algorithm name from Medusa. If you customize an algorithm for the experiment, the algorithm name is directly returned.)</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>xxx</para>
                    /// </summary>
                    [NameInMap("name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                }

                /// <summary>
                /// <para>The default value of the algorithm configuration item.</para>
                /// 
                /// <b>Example:</b>
                /// <para>swing</para>
                /// </summary>
                [NameInMap("defaultValue")]
                [Validation(Required=false)]
                public string DefaultValue { get; set; }

                /// <summary>
                /// <para>The custom value of the algorithm configuration item.</para>
                /// 
                /// <b>Example:</b>
                /// <para>xxx</para>
                /// </summary>
                [NameInMap("experimentValue")]
                [Validation(Required=false)]
                public string ExperimentValue { get; set; }

                /// <summary>
                /// <para>Indicates whether child configuration items exist. Valid values: true and false.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("hasConfig")]
                [Validation(Required=false)]
                public bool? HasConfig { get; set; }

                /// <summary>
                /// <para>The algorithm key. Valid values: i2i: the I2I filtering algorithm. u2x2i: the U2X2I filtering algorithm. hot: the filtering algorithm for popular items. new: the filtering algorithm for new items. embedding: the vector filtering algorithm. mtorder: the priority of the filtering algorithm. rankservice: the ranking service.</para>
                /// 
                /// <b>Example:</b>
                /// <para>hot</para>
                /// </summary>
                [NameInMap("key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <para>The algorithm name. (Note: If you use the default algorithm, the console obtains the algorithm name from Medusa. If you customize an algorithm for the experiment, the algorithm name is directly returned.)</para>
                /// 
                /// <b>Example:</b>
                /// <para>xxx</para>
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
            /// <para>Indicates whether the default configurations are used for the experiment.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("base")]
            [Validation(Required=false)]
            public bool? Base { get; set; }

            /// <summary>
            /// <para>The buckets. This parameter takes effect only when the experiment is published.</para>
            /// </summary>
            [NameInMap("buckets")]
            [Validation(Required=false)]
            public List<string> Buckets { get; set; }

            /// <summary>
            /// <para>The remarks of the experiment.</para>
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
            /// <para>123</para>
            /// </summary>
            [NameInMap("experimentId")]
            [Validation(Required=false)]
            public string ExperimentId { get; set; }

            /// <summary>
            /// <para>The experiment name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
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
            /// <para>The experiment state. Valid values: init, online, finish, and offline.</para>
            /// 
            /// <b>Example:</b>
            /// <para>init</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

    }

}
