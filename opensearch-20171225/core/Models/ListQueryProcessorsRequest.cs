// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OpenSearch20171225.Models
{
    public class ListQueryProcessorsRequest : TeaModel {
        /// <summary>
        /// <para>The scope of query analysis rules to be queried. Default value: 0. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>0: queries all query analysis rules.</description></item>
        /// <item><description>1: queries the default query analysis rules.</description></item>
        /// <item><description>2: queries the query analysis rules that are not the default rules.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("isActive")]
        [Validation(Required=false)]
        public int? IsActive { get; set; }

    }

}
