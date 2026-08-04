// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class GetApprovalSchemaRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the approval template. Call <a href="~~ListApprovalSchemas~~">ListApprovalSchemas</a> to list approval templates.</para>
        /// <list type="bullet">
        /// <item><description><a href="~~ListApprovalSchemas~~">ListApprovalSchemas</a>: List approval templates in batches.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>approval-schema-090134f1ebff****</para>
        /// </summary>
        [NameInMap("SchemaId")]
        [Validation(Required=false)]
        public string SchemaId { get; set; }

    }

}
