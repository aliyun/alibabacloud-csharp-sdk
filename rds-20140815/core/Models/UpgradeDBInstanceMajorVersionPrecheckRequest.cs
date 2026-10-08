// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class UpgradeDBInstanceMajorVersionPrecheckRequest : TeaModel {
        /// <summary>
        /// <para>The instance ID. You can call DescribeDBInstances to query the instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pgm-bp1c808s731l****</para>
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The major engine version of the target instance. The version must be later than the current major engine version of the instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>17.0</para>
        /// </summary>
        [NameInMap("TargetMajorVersion")]
        [Validation(Required=false)]
        public string TargetMajorVersion { get; set; }

        /// <summary>
        /// <para>The upgrade mode. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>zeroDownTimeUpgrade</b>: zero-downtime upgrade.</description></item>
        /// <item><description><b>inPlaceUpgrade</b>: in-place upgrade.</description></item>
        /// <item><description><b>greenBlueDeployment</b>: blue-green deployment.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zeroDownTimeUpgrade</para>
        /// </summary>
        [NameInMap("UpgradeMode")]
        [Validation(Required=false)]
        public string UpgradeMode { get; set; }

    }

}
