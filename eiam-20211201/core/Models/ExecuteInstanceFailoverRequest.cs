// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam20211201.Models
{
    public class ExecuteInstanceFailoverRequest : TeaModel {
        /// <summary>
        /// <para>故障转移状态</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>active</para>
        /// </summary>
        [NameInMap("InstanceFailoverStatus")]
        [Validation(Required=false)]
        public string InstanceFailoverStatus { get; set; }

        /// <summary>
        /// <para>IDaaS 的副本实例 ID</para>
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
