// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class RunServiceScheduleRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the application.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>474bdef0-d149-4695-abfb-52912d9143f0</para>
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// <para>The IP address of the client.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>180.166.45.146</para>
        /// </summary>
        [NameInMap("ClientIp")]
        [Validation(Required=false)]
        public string ClientIp { get; set; }

        /// <summary>
        /// <para>The directory to which the data file is mounted. The value must be a full path and cannot be \&quot;/../\&quot;. Example: [&quot;/data/app01&quot;, &quot;/data/user&quot;]. Specify the relative path of the virtual device for this parameter. For example, specify /data for this parameter when the actual path of the virtual device is /data/{input path}.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[\&quot;/data/app01\&quot;, \&quot;/data/user\&quot;]</para>
        /// </summary>
        [NameInMap("Directorys")]
        [Validation(Required=false)]
        public string Directorys { get; set; }

        /// <summary>
        /// <para>The parameter does not take effect.</para>
        /// 
        /// <b>Example:</b>
        /// <para>android</para>
        /// </summary>
        [NameInMap("PodConfigName")]
        [Validation(Required=false)]
        public string PodConfigName { get; set; }

        /// <summary>
        /// <para>The maximum duration for locking an idle device. Unit: seconds. This parameter takes effect only if you set ServiceAction to PreSchedule. Default value: 300.</para>
        /// 
        /// <b>Example:</b>
        /// <para>300</para>
        /// </summary>
        [NameInMap("PreLockedTimeout")]
        [Validation(Required=false)]
        public int? PreLockedTimeout { get; set; }

        /// <summary>
        /// <para>The scheduling policy of the device. The value must be a JSON string.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{\&quot;selectLevel\&quot;: \&quot;RegionId\&quot;, \&quot;values\&quot;: [\&quot;cn-chengdu-telecom-2\&quot;]  }</para>
        /// </summary>
        [NameInMap("ScheduleStrategy")]
        [Validation(Required=false)]
        public string ScheduleStrategy { get; set; }

        /// <summary>
        /// <para>The scheduling operation. The value must be of the enumeration type. Valid values:</para>
        /// <para>Container scenario:</para>
        /// <list type="bullet">
        /// <item><description>Start: selects and activates an idle cloud device.</description></item>
        /// <item><description>Stop: stops and releases the cloud device.</description></item>
        /// <item><description>Console: performs the scheduling operation when the device is in the scheduling state.</description></item>
        /// </list>
        /// <para>Bare metal instance or virtual machine scenario:</para>
        /// <list type="bullet">
        /// <item><description>PreSchedule: locks a virtual machine instance for scheduling.</description></item>
        /// <item><description>Confirm: confirms the scheduling operation.</description></item>
        /// <item><description>Cancel: cancels the scheduling operation.</description></item>
        /// <item><description>Console: performs the scheduling operation when the device is in the scheduling state.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Start</para>
        /// </summary>
        [NameInMap("ServiceAction")]
        [Validation(Required=false)]
        public string ServiceAction { get; set; }

        /// <summary>
        /// <para>The service commands. The value must be a JSON string.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{\&quot;containerName\&quot;: \&quot;android\&quot;,       \&quot;commands\&quot;:[\&quot;cat /tmp/token.json\&quot;]    },    {      \&quot;commands\&quot;:[\&quot;ls -l /data/data\&quot;]    }]</para>
        /// </summary>
        [NameInMap("ServiceCommands")]
        [Validation(Required=false)]
        public string ServiceCommands { get; set; }

        /// <summary>
        /// <para>The UUID of the device.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>hdm_d4f1059a8e1afc0956bd71b497faa433</para>
        /// </summary>
        [NameInMap("Uuid")]
        [Validation(Required=false)]
        public string Uuid { get; set; }

    }

}
