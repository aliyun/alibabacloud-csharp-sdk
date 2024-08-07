// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class DeleteLineageRelationRequest : TeaModel {
        /// <summary>
        /// The unique identifier of the destination entity.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("DestEntityQualifiedName")]
        [Validation(Required=false)]
        public string DestEntityQualifiedName { get; set; }

        /// <summary>
        /// The unique identifier of the lineage.
        /// </summary>
        [NameInMap("RelationshipGuid")]
        [Validation(Required=false)]
        public string RelationshipGuid { get; set; }

        /// <summary>
        /// The unique identifier of the source entity.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("SrcEntityQualifiedName")]
        [Validation(Required=false)]
        public string SrcEntityQualifiedName { get; set; }

    }

}
