// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WinNexo20260512.Models
{
    public class MoveKnowledgeBaseResourceRequest : TeaModel {
        /// <summary>
        /// <para>Not supported. This parameter is ignored.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>exampleKnowledgeId</para>
        /// </summary>
        [NameInMap("knowledgeId")]
        [Validation(Required=false)]
        public string KnowledgeId { get; set; }

        /// <summary>
        /// <para>The source directory ID. This is the enterprise knowledge base directory where the resource currently resides.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>exampleSourceDirectoryId</para>
        /// </summary>
        [NameInMap("sourceDirectoryId")]
        [Validation(Required=false)]
        public string SourceDirectoryId { get; set; }

        /// <summary>
        /// <para>The data source ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2000627</para>
        /// </summary>
        [NameInMap("sourceId")]
        [Validation(Required=false)]
        public string SourceId { get; set; }

        /// <summary>
        /// <para>The target directory ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>exampleTargetDirectoryId</para>
        /// </summary>
        [NameInMap("targetDirectoryId")]
        [Validation(Required=false)]
        public string TargetDirectoryId { get; set; }

        /// <summary>
        /// <para>The tenant ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1729094555111072</para>
        /// </summary>
        [NameInMap("tenantId")]
        [Validation(Required=false)]
        public string TenantId { get; set; }

    }

}
