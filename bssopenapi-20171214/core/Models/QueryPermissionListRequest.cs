// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20171214.Models
{
    public class QueryPermissionListRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the relationship. Set this parameter to the value of the RelationId response parameter returned by calling the QueryRelationList operation.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>51463</para>
        /// </summary>
        [NameInMap("RelationId")]
        [Validation(Required=false)]
        public long? RelationId { get; set; }

    }

}
