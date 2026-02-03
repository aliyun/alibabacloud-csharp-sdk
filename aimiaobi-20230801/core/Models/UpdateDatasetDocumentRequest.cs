// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiMiaoBi20230801.Models
{
    public class UpdateDatasetDocumentRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("DatasetId")]
        [Validation(Required=false)]
        public long? DatasetId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>数据集名称</para>
        /// </summary>
        [NameInMap("DatasetName")]
        [Validation(Required=false)]
        public string DatasetName { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Document")]
        [Validation(Required=false)]
        public UpdateDatasetDocumentRequestDocument Document { get; set; }
        public class UpdateDatasetDocumentRequestDocument : TeaModel {
            [NameInMap("CategoryUuid")]
            [Validation(Required=false)]
            public string CategoryUuid { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>用户指定的文档唯一ID</para>
            /// </summary>
            [NameInMap("DocId")]
            [Validation(Required=false)]
            public string DocId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>内部文档唯一ID</para>
            /// </summary>
            [NameInMap("DocUuid")]
            [Validation(Required=false)]
            public string DocUuid { get; set; }

            [NameInMap("Extend1")]
            [Validation(Required=false)]
            public string Extend1 { get; set; }

            [NameInMap("Extend2")]
            [Validation(Required=false)]
            public string Extend2 { get; set; }

            [NameInMap("Extend3")]
            [Validation(Required=false)]
            public string Extend3 { get; set; }

            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<string> Tags { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>xx</para>
            /// </summary>
            [NameInMap("Title")]
            [Validation(Required=false)]
            public string Title { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>xxxx</para>
        /// </summary>
        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
