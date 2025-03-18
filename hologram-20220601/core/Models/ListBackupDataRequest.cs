// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Hologram20220601.Models
{
    public class ListBackupDataRequest : TeaModel {
        /// <summary>
        /// <para>The backup type. Specific backup data is filtered based on the type. If you leave this parameter empty, all backup data is returned.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>redundant_remote</description></item>
        /// <item><description>remote</description></item>
        /// <item><description>redundant</description></item>
        /// <item><description>full_remote</description></item>
        /// <item><description>local</description></item>
        /// <item><description>full</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>redundant</para>
        /// </summary>
        [NameInMap("backupType")]
        [Validation(Required=false)]
        public string BackupType { get; set; }

        /// <summary>
        /// <para>The instance ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>hgprecn-cn-wwoxxxxx</para>
        /// </summary>
        [NameInMap("instanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

    }

}
