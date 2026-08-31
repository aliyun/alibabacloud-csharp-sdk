// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class ImportKgSchemaRequest : TeaModel {
        /// <summary>
        /// <para>The command for importing the knowledge graph definition.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>f1d4559a4db044158305e2d89bccf81f</para>
        /// </summary>
        [NameInMap("ImportCommand")]
        [Validation(Required=false)]
        public ImportKgSchemaRequestImportCommand ImportCommand { get; set; }
        public class ImportKgSchemaRequestImportCommand : TeaModel {
            /// <summary>
            /// <para>The knowledge graph definition content converted based on the specified format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>name:xxx</para>
            /// </summary>
            [NameInMap("Content")]
            [Validation(Required=false)]
            public string Content { get; set; }

            /// <summary>
            /// <para>The format of the knowledge graph definition content. Valid values: json and yaml. Default value: yaml.</para>
            /// 
            /// <b>Example:</b>
            /// <para>yaml</para>
            /// </summary>
            [NameInMap("InputFormat")]
            [Validation(Required=false)]
            public string InputFormat { get; set; }

            /// <summary>
            /// <para>The merge strategy for the knowledge graph definition content. Valid values: replace and merge. Default value: replace.</para>
            /// 
            /// <b>Example:</b>
            /// <para>replace</para>
            /// </summary>
            [NameInMap("MergeStrategy")]
            [Validation(Required=false)]
            public string MergeStrategy { get; set; }

        }

        /// <summary>
        /// <para>The tenant ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30001011</para>
        /// </summary>
        [NameInMap("OpTenantId")]
        [Validation(Required=false)]
        public long? OpTenantId { get; set; }

        /// <summary>
        /// <para>The ID of the operator user.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30001011</para>
        /// </summary>
        [NameInMap("OpUserId")]
        [Validation(Required=false)]
        public string OpUserId { get; set; }

        /// <summary>
        /// <para>The workspace ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>f1d4559a4db044158305e2d89bccf81f</para>
        /// </summary>
        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
