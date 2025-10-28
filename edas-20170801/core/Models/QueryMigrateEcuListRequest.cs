// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class QueryMigrateEcuListRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the namespace.</para>
        /// <list type="bullet">
        /// <item><description>The ID of a custom namespace is in the <c>region ID:namespace identifier</c> format. Example: <c>cn-beijing:test</c>.</description></item>
        /// <item><description>The ID of the default namespace is in the <c>region ID</c> format. Example: <c>cn-beijing</c>.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou or cn-hangzhou:test</para>
        /// </summary>
        [NameInMap("LogicalRegionId")]
        [Validation(Required=false)]
        public string LogicalRegionId { get; set; }

    }

}
