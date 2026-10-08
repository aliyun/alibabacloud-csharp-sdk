// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class MigrateEcuRequest : TeaModel {
        /// <summary>
        /// <para>The IDs of the instances. To specify multiple instances, separate the IDs with commas (,).</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>i-2zej4i2jdf3ntwhj****</para>
        /// </summary>
        [NameInMap("InstanceIds")]
        [Validation(Required=false)]
        public string InstanceIds { get; set; }

        /// <summary>
        /// <para>The ID of the namespace.</para>
        /// <list type="bullet">
        /// <item><description><para>A custom namespace ID is in the format <c>Region ID:Namespace identifier</c>. Example: cn-beijing:tdy218.</para>
        /// </description></item>
        /// <item><description><para>A default namespace ID is the same as its region ID. Example: cn-beijing.</para>
        /// </description></item>
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
