// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AIWorkSpace20210204.Models
{
    public class LineageRelation : TeaModel {
        /// <summary>
        /// <para>The unique qualified name of the destination lineage entity.</para>
        /// 
        /// <b>Example:</b>
        /// <para>maxcompute-table.demo_project.training_output</para>
        /// </summary>
        [NameInMap("DestEntityQualifiedName")]
        [Validation(Required=false)]
        public string DestEntityQualifiedName { get; set; }

        /// <summary>
        /// <para>The globally unique identifier of the lineage relationship.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0f94c587-e926-48c8-9efe-bf9f8d9aa5c2</para>
        /// </summary>
        [NameInMap("RelationshipGuid")]
        [Validation(Required=false)]
        public string RelationshipGuid { get; set; }

        /// <summary>
        /// <para>The unique qualified name of the source lineage entity.</para>
        /// 
        /// <b>Example:</b>
        /// <para>maxcompute-table.demo_project.training_data</para>
        /// </summary>
        [NameInMap("SrcEntityQualifiedName")]
        [Validation(Required=false)]
        public string SrcEntityQualifiedName { get; set; }

    }

}
