// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Smartag20180313.Models
{
    public class DescribeDeviceAutoUpgradePolicyResponseBody : TeaModel {
        /// <summary>
        /// <para>The time when upgrades start. The time was configured by using a cron expression.</para>
        /// <para>Example value: <c>0 0 4 1/1 * ?</c>. The example value indicates that upgrades start at 04:00:00 (UTC+8) on the first day of each month.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0 0 4 1/1 * ?</para>
        /// </summary>
        [NameInMap("CronExpression")]
        [Validation(Required=false)]
        public string CronExpression { get; set; }

        /// <summary>
        /// <para>The time period during which upgrades are performed.</para>
        /// <para>Valid values: <b>30 to 120</b>.</para>
        /// <para>Unit: minutes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>60</para>
        /// </summary>
        [NameInMap("Duration")]
        [Validation(Required=false)]
        public string Duration { get; set; }

        /// <summary>
        /// <para>The time differences between upgrades. Unit: minutes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("Jitter")]
        [Validation(Required=false)]
        public string Jitter { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0E20FBB8-BCFC-4F5E-BD94-77FF6A2133D0</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The serial number of the SAG instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sage62x022502****</para>
        /// </summary>
        [NameInMap("SerialNumber")]
        [Validation(Required=false)]
        public string SerialNumber { get; set; }

        /// <summary>
        /// <para>The ID of the SAG instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sag-kxe2cv7hot7qrv****</para>
        /// </summary>
        [NameInMap("SmartAGId")]
        [Validation(Required=false)]
        public string SmartAGId { get; set; }

        /// <summary>
        /// <para>The time zone in which the trigger period takes effect.</para>
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
        /// <item><description><b>boot</b>: automatic upgrade upon instance startup.</description></item>
        /// <item><description><b>manual</b>: manual upgrade.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>scheduled</para>
        /// </summary>
        [NameInMap("UpgradeType")]
        [Validation(Required=false)]
        public string UpgradeType { get; set; }

    }

}
