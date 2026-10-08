// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeUpgradeMajorVersionPrecheckTaskRequest : TeaModel {
        /// <summary>
        /// <para>The instance ID. You can call DescribeDBInstances to obtain the instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pgm-bp1c808s731l****</para>
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The page number of the pre-upgrade check report.</para>
        /// <para>Valid values: a value greater than 0 that does not exceed the maximum value of the Integer data type. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of records per page in the major engine version upgrade check report.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>30 (default)</description></item>
        /// <item><description>50</description></item>
        /// <item><description>100</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The target instance version. The value must be greater than the current major engine version of the instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12.0</para>
        /// </summary>
        [NameInMap("TargetMajorVersion")]
        [Validation(Required=false)]
        public string TargetMajorVersion { get; set; }

        /// <summary>
        /// <para>The ID of the pre-upgrade check task. You can obtain this value from the <b>TaskId</b> response parameter after you call the UpgradeDBInstanceMajorVersionPrecheck operation to perform a pre-upgrade check.</para>
        /// 
        /// <b>Example:</b>
        /// <para>416980000</para>
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public int? TaskId { get; set; }

    }

}
