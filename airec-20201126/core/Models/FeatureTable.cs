// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Airec20201126.Models
{
    public class FeatureTable : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>30E70118-FC7C-4438-9287-583CE47266A9</para>
        /// </summary>
        [NameInMap("FeatureTableId")]
        [Validation(Required=false)]
        public string FeatureTableId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2021-12-10T02:59:54.000Z</para>
        /// </summary>
        [NameInMap("GmtCreate")]
        [Validation(Required=false)]
        public string GmtCreate { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2021-12-10T02:59:54.000Z</para>
        /// </summary>
        [NameInMap("GmtModified")]
        [Validation(Required=false)]
        public string GmtModified { get; set; }

        [NameInMap("Meta")]
        [Validation(Required=false)]
        public FeatureTableMeta Meta { get; set; }
        public class FeatureTableMeta : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>907648f5-abae-44fd-a4c4-525cc25947e9</para>
            /// </summary>
            [NameInMap("DataSourceId")]
            [Validation(Required=false)]
            public string DataSourceId { get; set; }

            [NameInMap("FeatureList")]
            [Validation(Required=false)]
            public List<FeatureTableMetaFeatureList> FeatureList { get; set; }
            public class FeatureTableMetaFeatureList : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>com11</para>
                /// </summary>
                [NameInMap("Comment")]
                [Validation(Required=false)]
                public string Comment { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>fn11</para>
                /// </summary>
                [NameInMap("FeatureName")]
                [Validation(Required=false)]
                public string FeatureName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>fieldName11</para>
                /// </summary>
                [NameInMap("FieldName")]
                [Validation(Required=false)]
                public string FieldName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>NotApplied 未应用 Applied 已应用</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Internal")]
            [Validation(Required=false)]
            public bool? Internal { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>FeatureTable</para>
            /// </summary>
            [NameInMap("MetaType")]
            [Validation(Required=false)]
            public string MetaType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>test_project.test_table</para>
            /// </summary>
            [NameInMap("Source")]
            [Validation(Required=false)]
            public string Source { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>86400</para>
            /// </summary>
            [NameInMap("UpdateFrequency")]
            [Validation(Required=false)]
            public long? UpdateFrequency { get; set; }

        }

        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>ItemFeatureTable 物品特征表 UserFeatureTable 用户特征表</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
