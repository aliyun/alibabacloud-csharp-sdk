// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quickbi_public20220101.Models
{
    public class QueryWorksBloodRelationshipRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the data work.</para>
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
