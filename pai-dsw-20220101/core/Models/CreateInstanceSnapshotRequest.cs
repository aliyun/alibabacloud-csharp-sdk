// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pai_dsw20220101.Models
{
    public class CreateInstanceSnapshotRequest : TeaModel {
        [NameInMap("ExcludePaths")]
        [Validation(Required=false)]
        public List<string> ExcludePaths { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>registry.cn-shanghai.aliyuncs.com/pai_product/tensorflow:py36_cpu_tf1.12_ubuntu</para>
        /// </summary>
        [NameInMap("ImageUrl")]
        [Validation(Required=false)]
        public string ImageUrl { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{\&quot;foo\&quot;: \&quot;bar\&quot;}</para>
        /// </summary>
        [NameInMap("Labels")]
        [Validation(Required=false)]
        public List<CreateInstanceSnapshotRequestLabels> Labels { get; set; }
        public class CreateInstanceSnapshotRequestLabels : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>stsTokenOwner</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>123xxxxxxxx</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        [NameInMap("Overwrite")]
        [Validation(Required=false)]
        public bool? Overwrite { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>training_data_env</para>
        /// </summary>
        [NameInMap("SnapshotDescription")]
        [Validation(Required=false)]
        public string SnapshotDescription { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>training_data_env</para>
        /// </summary>
        [NameInMap("SnapshotName")]
        [Validation(Required=false)]
        public string SnapshotName { get; set; }

    }

}
