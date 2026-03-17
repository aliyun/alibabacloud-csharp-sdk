// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Smartag20180313.Models
{
    public class ModifyDeviceAutoUpgradePolicyRequest : TeaModel {
        /// <summary>
        /// <para>The time when upgrades start. Valid values: Set the parameter in a cron expression.</para>
        /// <para>For example, you can use <c>0 0 4 1/1 * ?</c> to specify 04:00:00 (UTC+8) on the first day of each month.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0 0 4 1/1 * ?</para>
        /// </summary>
        [NameInMap("CronExpression")]
        [Validation(Required=false)]
        public string CronExpression { get; set; }

        /// <summary>
        /// <para>The time period during which upgrades are performed. Valid values: <b>30 to 120</b>.</para>
        /// <para>Unit: minutes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("Duration")]
        [Validation(Required=false)]
        public int? Duration { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The ID of the region where the SAG instance is deployed.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The serial number of the SAG device.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sage62x022502****</para>
        /// </summary>
        [NameInMap("SerialNumber")]
        [Validation(Required=false)]
        public string SerialNumber { get; set; }

        /// <summary>
        /// <para>The ID of the SAG instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sag-1um5x5nwhilymw****</para>
        /// </summary>
        [NameInMap("SmartAGId")]
        [Validation(Required=false)]
        public string SmartAGId { get; set; }

        /// <summary>
        /// <para>The time zone. Valid values:</para>
        /// <para><b>Asia/Shanghai</b>: UTC+8 (Beijing)</para>
        /// <para><b>Asia/Hong_Kong</b>: UTC+8 (Hong Kong)</para>
        /// <para><b>Asia/Tokyo</b>: UTC+9 (Tokyo)</para>
        /// <para><b>Australia/Sydney</b>: UTC+10 (Sydney)</para>
        /// <para><b>Asia/Kuala_Lumpur</b>: UTC+8 (Kuala Lumpur)</para>
        /// <para><b>Europe/Berli</b>: UTC+1 (Berlin)</para>
        /// <para><b>Asia/Singapore</b>: UTC+8 (Singapore)</para>
        /// <para><b>Asia/Jakarta</b>: UTC+7 (Jakarta)</para>
        /// 
        /// <b>Example:</b>
        /// <para>Asia/Shanghai</para>
        /// </summary>
        [NameInMap("TimeZone")]
        [Validation(Required=false)]
        public string TimeZone { get; set; }

        /// <summary>
        /// <para>The update type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>scheduled</b>: scheduled upgrade.</description></item>
        /// <item><description><b>boot</b>: automatic upgrade upon device startup.</description></item>
        /// <item><description><b>manual</b>: manual upgrade.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>scheduled</para>
        /// </summary>
        [NameInMap("UpgradeType")]
        [Validation(Required=false)]
        public string UpgradeType { get; set; }

        /// <summary>
        /// <para>The type of software for which you want to modify the upgrade policy. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Device</b>: The operating system run by the SAG device.</description></item>
        /// <item><description><b>Dpi</b>: The signature database used by the SAG device.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Device</para>
        /// </summary>
        [NameInMap("VersionType")]
        [Validation(Required=false)]
        public string VersionType { get; set; }

    }

}
