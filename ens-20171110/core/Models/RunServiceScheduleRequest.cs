// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class RunServiceScheduleRequest : TeaModel {
        /// <summary>
        /// <para>The application ID.</para>
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
        /// <para>The list of directories of user data files to be mounted. The directories must be absolute paths, and the \&quot;/../\&quot; format is not supported. Example: [&quot;/data/app01&quot;, &quot;/data/user&quot;]. Note: The input directory path is relative to the /data directory of the virtual device. The actual path on the virtual device is /data/{input path}.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[\&quot;/data/app01\&quot;, \&quot;/data/user\&quot;]</para>
        /// </summary>
        [NameInMap("Directorys")]
        [Validation(Required=false)]
        public string Directorys { get; set; }

        /// <summary>
        /// <para>Invalid parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>android</para>
        /// </summary>
        [NameInMap("PodConfigName")]
        [Validation(Required=false)]
        public string PodConfigName { get; set; }

        /// <summary>
        /// <para>The maximum time to lock an idle device, in seconds. This parameter takes effect only when ServiceAction is set to PreSchedule. Default value: 300.</para>
        /// 
        /// <b>Example:</b>
        /// <para>300</para>
        /// </summary>
        [NameInMap("PreLockedTimeout")]
        [Validation(Required=false)]
        public int? PreLockedTimeout { get; set; }

        /// <summary>
        /// <para>The device scheduling policy. The value is a string in JSON format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{\&quot;selectLevel\&quot;: \&quot;RegionId\&quot;, \&quot;values\&quot;: [\&quot;cn-chengdu-telecom-2\&quot;]  }</para>
        /// </summary>
        [NameInMap("ScheduleStrategy")]
        [Validation(Required=false)]
        public string ScheduleStrategy { get; set; }

        /// <summary>
        /// <para>The scheduling service operation. Valid values:</para>
        /// <para>Container scenarios:</para>
        /// <list type="bullet">
        /// <item><description>Start: Selects and activates a schedulable cloud device and starts the service.</description></item>
        /// <item><description>Stop: Stops and releases the cloud device.</description></item>
        /// <item><description>Console: Interacts with the device by using commands when the UUID is in the scheduling state.</description></item>
        /// </list>
        /// <para>Bare metal or virtual machine scenarios:</para>
        /// <list type="bullet">
        /// <item><description>PreSchedule: Pre-schedules and locks a virtual machine instance.</description></item>
        /// <item><description>Confirm: Confirms the scheduling.</description></item>
        /// <item><description>Cancel: Cancels the scheduling.</description></item>
        /// <item><description>Console: Interacts with the device by using commands when the UUID is in the scheduling state.</description></item>
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
        /// <para>The list of container service commands. The value is a string in JSON array format.</para>
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
