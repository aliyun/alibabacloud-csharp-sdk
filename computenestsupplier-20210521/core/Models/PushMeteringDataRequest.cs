// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ComputeNestSupplier20210521.Models
{
    public class PushMeteringDataRequest : TeaModel {
        /// <summary>
        /// <para>The metering data. Parameters in the example value:</para>
        /// <list type="bullet">
        /// <item><description><para>InstanceId: the ID of an instance in Alibaba Cloud Marketplace. Parameter type: STRING.</para>
        /// </description></item>
        /// <item><description><para>StartTime: the time when the metering operation started. Set the parameter to a UNIX timestamp. Unit: seconds. Parameter type: LONG.</para>
        /// </description></item>
        /// <item><description><para>EndTime: the time when the metering operation ended. Set the parameter to a UNIX timestamp. Unit: seconds. Parameter type: LONG.</para>
        /// </description></item>
        /// <item><description><para>Entities: the metering entities. Parameter type: LIST.</para>
        /// <list type="bullet">
        /// <item><description><para>Key: the name of the metering item. Parameter type: STRING.</para>
        /// <list type="bullet">
        /// <item><description>Frequency: the number of times the instance was used.</description></item>
        /// <item><description>Period: the usage duration of the instance. Unit: seconds.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// <para>Note: The metering unit is second, whereas the billing unit is hour. Therefore, when bills are generated, seconds are converted to hours. For example, the usage metered from 19:00 to 20:00 is 1800 seconds and the price is USD 1 per hour. In this case, the hourly bill for 19:00 to 20:00 is calculated by using the following formula: 1800/3600 x 1 = 0.5. If the result is a decimal, only the first two decimal places are retained.</para>
        /// <pre><c>  - Storage: The used storage space. Unit: bytes.   
        ///    Note: The metering unit is byte, whereas the billing unit is MB. Therefore, when bills are generated, bytes are converted to megabytes. For example, the usage metered from 19:00 to 20:00 is 524,288 bytes and the price is USD 1 per MB. In this case, the hourly bill for 19:00 to 20:00 is calculated by using the following formula: 524288/1024/1024 x 1 = 0.5. If the result is a decimal, only the first two decimal places are retained.  - NetworkOut: the upstream traffic consumed. Unit: bit.  
        ///    Note: The metering unit is bit, whereas the billing unit is Mbit. Therefore, when bills are generated, bits are converted to megabits. For example, the usage metered from 19:00 to 20:00 is 524,288 bits and the price is USD 1 per Mbit. In this case, the hourly bill for 19:00 to 20:00 is calculated by using the following formula: 524288/1024/1024 x 1 = 0.5. If the result is a decimal, only the first two decimal places are retained.  - NetworkIn: the downstream traffic consumed. Unit: bit.  
        ///    Note: The metering unit is bit, whereas the billing unit is Mbit. Therefore, when bills are generated, bits are converted to megabits. For example, the usage metered from 19:00 to 20:00 is 524,288 bits and the price is USD 1 per Mbit. In this case, the hourly bill for 19:00 to 20:00 is calculated by using the following formula: 524288/1024/1024 x 1 = 0.5. If the result is a decimal, only the first two decimal places are retained.  - Character: the number of characters.
        ///   - DailyActiveUser: the number of daily active users (DAU).
        ///   - PeriodMin: the usage duration of the instance. Unit: minutes.  - VirtualCpu: the number of virtual CPU cores.
        /// </c></pre>
        /// <list type="bullet">
        /// <item><description>Value: the value of the metering item. The value is equal to or greater than 0. Parameter type: INTEGER.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// <para><b>Note</b>:</para>
        /// <list type="bullet">
        /// <item><description>If bills are generated for the commodity in real time, the difference between the values of StartTime and EndTime is not limited. However, the time specified by EndTime must be later than that specified by StartTime.</description></item>
        /// <item><description>If bills are generated for the commodity by billing cycle, such as by hour, by day, or by month, the difference between the values of StartTime and EndTime must be greater than 5 minutes.</description></item>
        /// <item><description>In a request for pushing multiple metering data records, the values of InstanceId must indicate instances of the same commodity. You cannot push metering data of instances of multiple commodities at a time.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{\&quot;StartTime\&quot;:1681264800,\&quot;EndTime\&quot;:1681268400,\&quot;Entities\&quot;:[{\&quot;Key\&quot;:\&quot;Unit\&quot;,\&quot;Value\&quot;:\&quot;0\&quot;}]}]</para>
        /// </summary>
        [NameInMap("Metering")]
        [Validation(Required=false)]
        public string Metering { get; set; }

        /// <summary>
        /// <para>The service instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>si-0e6fca6a51a54420****</para>
        /// </summary>
        [NameInMap("ServiceInstanceId")]
        [Validation(Required=false)]
        public string ServiceInstanceId { get; set; }

    }

}
