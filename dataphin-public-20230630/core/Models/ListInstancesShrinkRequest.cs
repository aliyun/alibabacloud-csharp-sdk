// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class ListInstancesShrinkRequest : TeaModel {
        /// <summary>
        /// <para>Environment identifier</para>
        /// <list type="bullet">
        /// <item><description>DEV: Development environment</description></item>
        /// <item><description>PROD (default): Production environment</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>PROD</para>
        /// </summary>
        [NameInMap("Env")]
        [Validation(Required=false)]
        public string Env { get; set; }

        /// <summary>
        /// <para>Query Request</para>
        /// </summary>
        [NameInMap("ListQuery")]
        [Validation(Required=false)]
        public string ListQueryShrink { get; set; }

        /// <summary>
        /// <para>Tenant ID</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30001011</para>
        /// </summary>
        [NameInMap("OpTenantId")]
        [Validation(Required=false)]
        public long? OpTenantId { get; set; }

    }

}
