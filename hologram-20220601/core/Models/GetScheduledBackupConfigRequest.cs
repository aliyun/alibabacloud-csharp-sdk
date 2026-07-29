// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Hologram20220601.Models
{
    public class GetScheduledBackupConfigRequest : TeaModel {
        /// <summary>
        /// <para>The region ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shenzhen</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The instance ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>hgprecn-cn-9lb3bjg1n003</para>
        /// </summary>
        [NameInMap("instanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The backup type. By default, the operation returns periodical and manual backup configurations. To retrieve the remote backup configuration, set this parameter to \&quot;remote\&quot;.</para>
        /// 
        /// <b>Example:</b>
        /// <para>remote</para>
        /// </summary>
        [NameInMap("scheduleType")]
        [Validation(Required=false)]
        public string ScheduleType { get; set; }

    }

}
