// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quickbi_public20220101.Models
{
    public class QueryWorksBloodRelationshipRequest : TeaModel {
        /// <summary>
        /// <para>Obtains the kinship of a data work, including the datasets referenced by each component and query field information. Currently, only supported data works include dashboards, workbooks, and self-service data retrieval.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>abcd****</para>
        /// </summary>
        [NameInMap("WorksId")]
        [Validation(Required=false)]
        public string WorksId { get; set; }

    }

}
