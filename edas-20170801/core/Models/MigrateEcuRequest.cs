// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class MigrateEcuRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the ECS instance. Separate multiple IDs with commas (,).</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>i-2zej4i2jdf3ntwhj****</para>
        /// </summary>
        [NameInMap("InstanceIds")]
        [Validation(Required=false)]
        public string InstanceIds { get; set; }

        /// <summary>
        /// <para>The ID of the custom namespace.</para>
        /// <list type="bullet">
        /// <item><description>The ID of a custom namespace is in the <c>region ID:custom namespace ID</c> format. Example: cn-beijing:tdy218.</description></item>
        /// <item><description>The ID of the default namespace is in the <c>region ID</c> format. Example: cn-beijing.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou:test_region</para>
        /// </summary>
        [NameInMap("LogicalRegionId")]
        [Validation(Required=false)]
        public string LogicalRegionId { get; set; }

    }

}
