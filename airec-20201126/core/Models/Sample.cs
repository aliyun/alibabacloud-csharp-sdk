// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Airec20201126.Models
{
    public class Sample : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>2021-12-07T12:28:52.000Z</para>
        /// </summary>
        [NameInMap("GmtCreate")]
        [Validation(Required=false)]
        public string GmtCreate { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2021-12-07T12:28:52.000Z</para>
        /// </summary>
        [NameInMap("GmtModified")]
        [Validation(Required=false)]
        public string GmtModified { get; set; }

        [NameInMap("Meta")]
        [Validation(Required=false)]
        public SampleMeta Meta { get; set; }
        public class SampleMeta : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("AutoUpdate")]
            [Validation(Required=false)]
            public bool? AutoUpdate { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>86400</para>
            /// </summary>
            [NameInMap("AutoUpdateFrequency")]
            [Validation(Required=false)]
            public long? AutoUpdateFrequency { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1638877561147</para>
            /// </summary>
            [NameInMap("ClonedId")]
            [Validation(Required=false)]
            public string ClonedId { get; set; }

            [NameInMap("Config")]
            [Validation(Required=false)]
            public SampleMetaConfig Config { get; set; }
            public class SampleMetaConfig : TeaModel {
                [NameInMap("BhvTableSourceIds")]
                [Validation(Required=false)]
                public List<string> BhvTableSourceIds { get; set; }

                [NameInMap("FeatureConfig")]
                [Validation(Required=false)]
                public SampleMetaConfigFeatureConfig FeatureConfig { get; set; }
                public class SampleMetaConfigFeatureConfig : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>物品特征，支持多值，逗号分隔。</para>
                    /// </summary>
                    [NameInMap("ItemFeatures")]
                    [Validation(Required=false)]
                    public string ItemFeatures { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>用户特征，支持多值，逗号分隔。</para>
                    /// </summary>
                    [NameInMap("UserFeatures")]
                    [Validation(Required=false)]
                    public string UserFeatures { get; set; }

                }

                [NameInMap("LabelLogic")]
                [Validation(Required=false)]
                public SampleMetaConfigLabelLogic LabelLogic { get; set; }
                public class SampleMetaConfigLabelLogic : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>86400</para>
                    /// </summary>
                    [NameInMap("BhvTimeWindow")]
                    [Validation(Required=false)]
                    public long? BhvTimeWindow { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>click,expose</para>
                    /// </summary>
                    [NameInMap("NegativeBhvTypes")]
                    [Validation(Required=false)]
                    public string NegativeBhvTypes { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>like</para>
                    /// </summary>
                    [NameInMap("PositiveBhvTypes")]
                    [Validation(Required=false)]
                    public string PositiveBhvTypes { get; set; }

                }

                [NameInMap("WeightLogicList")]
                [Validation(Required=false)]
                public List<SampleMetaConfigWeightLogicList> WeightLogicList { get; set; }
                public class SampleMetaConfigWeightLogicList : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>click</para>
                    /// </summary>
                    [NameInMap("Bhv")]
                    [Validation(Required=false)]
                    public string Bhv { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1.01</para>
                    /// </summary>
                    [NameInMap("Weight")]
                    [Validation(Required=false)]
                    public string Weight { get; set; }

                }

            }

            [NameInMap("ExtendParams")]
            [Validation(Required=false)]
            public SampleMetaExtendParams ExtendParams { get; set; }
            public class SampleMetaExtendParams : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>0 没有任务 1 正常 2 异常</para>
                /// </summary>
                [NameInMap("LatestTaskStatus")]
                [Validation(Required=false)]
                public long? LatestTaskStatus { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("SampleCount")]
                [Validation(Required=false)]
                public long? SampleCount { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Sample</para>
            /// </summary>
            [NameInMap("MetaType")]
            [Validation(Required=false)]
            public string MetaType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>12345</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>projectName.tableName</para>
            /// </summary>
            [NameInMap("StoreConfig")]
            [Validation(Required=false)]
            public string StoreConfig { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Cloned 复制的 System 系统的 Custom 自定义的</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1638880131873</para>
        /// </summary>
        [NameInMap("SampleId")]
        [Validation(Required=false)]
        public string SampleId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>样本状态 Unready 未完成配置  Ready   配置完成  Generating 样本生成中  Success  样本生成成功  Failed 样本生成失败  Formatting 格式化中  Formatted 格式化完成  FormatFailed 格式化失败  Applied 已应用到模型中</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
