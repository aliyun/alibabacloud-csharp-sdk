// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class ListEcuByRegionRequest : TeaModel {
        /// <summary>
        /// <para>Set the value to <c>pop-query</c>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pop-query</para>
        /// </summary>
        [NameInMap("Act")]
        [Validation(Required=false)]
        public string Act { get; set; }

        /// <summary>
        /// <para>The ID of the namespace.</para>
        /// <list type="bullet">
        /// <item><description>The ID of a custom namespace is in the <c>region ID:namespace identifier</c> format. Example: cn-beijing:tdy218.</description></item>
        /// <item><description>The ID of the default namespace is in the <c>region ID</c> format. Example: cn-beijing.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>cn-beijing or cn-beijing:tdy218</para>
        /// </summary>
        [NameInMap("LogicalRegionId")]
        [Validation(Required=false)]
        public string LogicalRegionId { get; set; }

    }

}
