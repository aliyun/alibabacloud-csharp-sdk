// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Starrocks20221019.Models
{
    public class RollbackConfigModificationRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the configuration modification history.</para>
        /// 
        /// <b>Example:</b>
        /// <para>187291</para>
        /// </summary>
        [NameInMap("ConfigHistoryId")]
        [Validation(Required=false)]
        public long? ConfigHistoryId { get; set; }

        /// <summary>
        /// <para>The instance ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>c-b25e21e24388****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>Specifies whether to restart the instance after the configuration is changed. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: Restart the instance.</para>
        /// </description></item>
        /// <item><description><para><b>false</b>: Do not restart the instance.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Restart")]
        [Validation(Required=false)]
        public bool? Restart { get; set; }

    }

}
