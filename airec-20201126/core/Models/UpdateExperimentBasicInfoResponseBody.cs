// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Airec20201126.Models
{
    public class UpdateExperimentBasicInfoResponseBody : TeaModel {
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
        public UpdateExperimentBasicInfoResponseBodyResult Result { get; set; }
        public class UpdateExperimentBasicInfoResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>The parameters of the experiment.</para>
            /// </summary>
            [NameInMap("algorithms")]
            [Validation(Required=false)]
            public List<UpdateExperimentBasicInfoResponseBodyResultAlgorithms> Algorithms { get; set; }
            public class UpdateExperimentBasicInfoResponseBodyResultAlgorithms : TeaModel {
                /// <summary>
                /// <para>The category of the algorithm.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("category")]
                [Validation(Required=false)]
                public string Category { get; set; }

                /// <summary>
                /// <para>The information about the child configuration item.</para>
                /// </summary>
                [NameInMap("config")]
                [Validation(Required=false)]
                public List<UpdateExperimentBasicInfoResponseBodyResultAlgorithmsConfig> Config { get; set; }
                public class UpdateExperimentBasicInfoResponseBodyResultAlgorithmsConfig : TeaModel {
                    /// <summary>
                    /// <para>The default value of the algorithm configuration item.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("defaultValue")]
                    [Validation(Required=false)]
                    public string DefaultValue { get; set; }

                    /// <summary>
                    /// <para>The custom value of the algorithm configuration item.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>400</para>
                    /// </summary>
                    [NameInMap("experimentValue")]
                    [Validation(Required=false)]
                    public string ExperimentValue { get; set; }

                    /// <summary>
                    /// <para>The key of the algorithm configuration item.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>I2I</para>
                    /// </summary>
                    [NameInMap("key")]
                    [Validation(Required=false)]
                    public string Key { get; set; }

                    /// <summary>
                    /// <para>The name of the algorithm configuration item.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>I2I filtering algorithm</para>
                    /// </summary>
                    [NameInMap("name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                }

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
                /// <para>400</para>
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
                /// <para>The key of the algorithm.</para>
                /// 
                /// <b>Example:</b>
                /// <para>I2I</para>
                /// </summary>
                [NameInMap("key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <para>The name of the experiment.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The type of the algorithm.</para>
                /// 
                /// <b>Example:</b>
                /// <para>SYSTEM</para>
                /// </summary>
                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <para>Indicates whether the experiment uses default configurations.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("base")]
            [Validation(Required=false)]
            public bool? Base { get; set; }

            /// <summary>
            /// <para>The traffic buckets.</para>
            /// </summary>
            [NameInMap("buckets")]
            [Validation(Required=false)]
            public List<string> Buckets { get; set; }

            /// <summary>
            /// <para>The description of the experiment.</para>
            /// 
            /// <b>Example:</b>
            /// <para>demo1</para>
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
            /// <para>The name of the experiment.</para>
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
            /// <para>The status of the experiment.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

    }

}
