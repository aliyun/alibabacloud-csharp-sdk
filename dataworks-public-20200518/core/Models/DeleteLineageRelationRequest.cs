// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class DeleteLineageRelationRequest : TeaModel {
        /// <summary>
        /// <para>The unique identifier of the destination entity.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>custom-report.report123</para>
        /// </summary>
        [NameInMap("DestEntityQualifiedName")]
        [Validation(Required=false)]
        public string DestEntityQualifiedName { get; set; }

        /// <summary>
        /// <para>The unique identifier of the lineage.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dfazcdfdfccdedd</para>
        /// </summary>
        [NameInMap("RelationshipGuid")]
        [Validation(Required=false)]
        public string RelationshipGuid { get; set; }

        [NameInMap("RelationshipType")]
        [Validation(Required=false)]
        public string RelationshipType { get; set; }

        /// <summary>
        /// <para>The unique identifier of the source entity.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>maxcompute-table.project.table</para>
        /// </summary>
        [NameInMap("SrcEntityQualifiedName")]
        [Validation(Required=false)]
        public string SrcEntityQualifiedName { get; set; }

    }

}
