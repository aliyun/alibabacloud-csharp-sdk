// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Airec20201126.Models
{
    public class DescribeDefaultAlgorithmsResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>F60021C4-57AF-5F46-9B3E-FCEF1C7A1459</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The returned result.</para>
        /// </summary>
        [NameInMap("result")]
        [Validation(Required=false)]
        public List<DescribeDefaultAlgorithmsResponseBodyResult> Result { get; set; }
        public class DescribeDefaultAlgorithmsResponseBodyResult : TeaModel {
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
            /// <para>The information about the child configuration item.</para>
            /// </summary>
            [NameInMap("config")]
            [Validation(Required=false)]
            public List<DescribeDefaultAlgorithmsResponseBodyResultConfig> Config { get; set; }
            public class DescribeDefaultAlgorithmsResponseBodyResultConfig : TeaModel {
                /// <summary>
                /// <para>The default value of the algorithm configuration item.</para>
                /// 
                /// <b>Example:</b>
                /// <para>swing;commoni2i;pcategory;scategory</para>
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
                /// <para>The key of the algorithm configuration item.</para>
                /// 
                /// <b>Example:</b>
                /// <para>I2I-truncedquantity</para>
                /// </summary>
                [NameInMap("key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <para>The name of the algorithm configuration item. (Note: If you use the default algorithm, the console obtains the algorithm name from Medusa. If you customize an algorithm for the experiment, the algorithm name is directly returned.)</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

            /// <summary>
            /// <para>The default value of the algorithm. If you set key to i2i, hot, or new, the value of this parameter is true or false. If you set key to mtorder, the value of this parameter is a list of filtering algorithms ranked by priority.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("defaultValue")]
            [Validation(Required=false)]
            public string DefaultValue { get; set; }

            /// <summary>
            /// <para>The custom value of the algorithm.</para>
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
            /// <para>The algorithm key. Valid values: i2i: the I2I filtering algorithm. u2x2i: the U2X2I filtering algorithm. hot: the filtering algorithm for popular items. new: the filtering algorithm for new items. embedding: the vector filtering algorithm. mtorder: the priority of the filtering algorithm. rankservice: the ranking service.</para>
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

    }

}
