// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam20211201.Models
{
    public class ExecuteInstanceFailoverRequest : TeaModel {
        /// <summary>
        /// <para>The failover status. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>inactive: The primary instance is active.</description></item>
        /// <item><description>active: The replica instance is active.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>active</para>
        /// </summary>
        [NameInMap("InstanceFailoverStatus")]
        [Validation(Required=false)]
        public string InstanceFailoverStatus { get; set; }

        /// <summary>
        /// <para>The replica instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>idaas_xxx</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

    }

}
