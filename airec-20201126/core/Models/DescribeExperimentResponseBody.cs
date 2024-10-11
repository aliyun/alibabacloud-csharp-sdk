// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Airec20201126.Models
{
    public class DescribeExperimentResponseBody : TeaModel {
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
        /// <para>The returned results.</para>
        /// </summary>
        [NameInMap("result")]
        [Validation(Required=false)]
        public DescribeExperimentResponseBodyResult Result { get; set; }
        public class DescribeExperimentResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>The parameters about the experiment.</para>
            /// </summary>
            [NameInMap("algorithms")]
            [Validation(Required=false)]
            public List<DescribeExperimentResponseBodyResultAlgorithms> Algorithms { get; set; }
            public class DescribeExperimentResponseBodyResultAlgorithms : TeaModel {
                /// <summary>
                /// <para>The category of the item.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("category")]
                [Validation(Required=false)]
                public string Category { get; set; }

                [NameInMap("config")]
                [Validation(Required=false)]
                public List<DescribeExperimentResponseBodyResultAlgorithmsConfig> Config { get; set; }
                public class DescribeExperimentResponseBodyResultAlgorithmsConfig : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("defaultValue")]
                    [Validation(Required=false)]
                    public string DefaultValue { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>400</para>
                    /// </summary>
                    [NameInMap("experimentValue")]
                    [Validation(Required=false)]
                    public string ExperimentValue { get; set; }

                    /// <summary>
                    /// <para>key</para>
                    /// 
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
                /// <para>None</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("defaultValue")]
                [Validation(Required=false)]
                public string DefaultValue { get; set; }

                /// <summary>
                /// <para>None</para>
                /// </summary>
                [NameInMap("experimentValue")]
                [Validation(Required=false)]
                public string ExperimentValue { get; set; }

                /// <summary>
                /// <para>None</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("hasConfig")]
                [Validation(Required=false)]
                public bool? HasConfig { get; set; }

                /// <summary>
                /// <para>The key.</para>
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
                /// <para>None</para>
                /// 
                /// <b>Example:</b>
                /// <para>SYSTEM</para>
                /// </summary>
                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <para>None</para>
            /// 
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
            /// <para>The description of the experiment.</para>
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
            /// <para>The state of the experiment.</para>
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
