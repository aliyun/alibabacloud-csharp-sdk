// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class GetMetaEntityDefRequest : TeaModel {
        /// <summary>
        /// <para>The entity type. The value must match the regular expression <c>^custom_(?:entity-[A-Za-z0-9_]+|[A-Za-z0-9_]+-(?:database|table|column))$</c>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>custom_entity-customer_api</para>
        /// </summary>
        [NameInMap("EntityType")]
        [Validation(Required=false)]
        public string EntityType { get; set; }

    }

}
