// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ComputeNestSupplier20210521.Models
{
    public class PushMeteringDataRequest : TeaModel {
        /// <summary>
        /// <para>The parameters are described as follows:</para>
        /// <list type="bullet">
        /// <item><description><para>InstanceId: The ID of the Alibaba Cloud Marketplace instance. The parameter type is String.</para>
        /// </description></item>
        /// <item><description><para>StartTime: The start time of the metering. The unit is seconds. The format is a UNIX timestamp. The parameter type is Long.</para>
        /// </description></item>
        /// <item><description><para>EndTime: The end time of the metering. The unit is seconds. The format is a UNIX timestamp. The parameter type is Long.</para>
        /// </description></item>
        /// <item><description><para><c>Entities</c>: The metering entity object. The parameter type is List\<Map>.</para>
        /// <list type="bullet">
        /// <item><description><para>Key: The name of the metering item property. The parameter type is String.</para>
        /// <list type="bullet">
        /// <item><description><para>Frequency: The number of times used.</para>
        /// </description></item>
        /// <item><description><para><c>Period</c>: The usage duration in seconds.
        /// &lt;props=&quot;intl&quot;&gt;Note: The duration in the request parameter is measured in seconds, but the billing unit is hours. The duration is converted to hours for billing. For example, if you push a usage of 1800 for the period from 19:00 to 20:00 and the price is USD 1/hour, the hourly bill for this period is 1800 / 3600 × 1 = USD 0.5. If the fee is a decimal, it is truncated to two decimal places.</para>
        /// </description></item>
        /// <item><description><para><c>Storage</c>: The storage space used, in bytes.
        /// &lt;props=&quot;intl&quot;&gt;Note: The unit in the request parameter is bytes, but the billing unit is MB. The value is converted to MB for billing. For example, if you push a usage of 524288 for the period from 19:00 to 20:00 and the price is USD 1/MB, the hourly bill for this period is 524288 / 1024 / 1024 × 1 = USD 0.5. If the fee is a decimal, it is truncated to two decimal places.</para>
        /// </description></item>
        /// <item><description><para><c>NetworkOut</c>: The outbound data transfer, in bits.
        /// &lt;props=&quot;intl&quot;&gt;Note: The unit in the request parameter is bits, but the billing unit is Mb. The value is converted to Mb for billing. For example, if you push a usage of 524288 for the period from 19:00 to 20:00 and the price is USD 1/Mb, the hourly bill for this period is 524288 / 1024 / 1024 × 1 = USD 0.5. If the fee is a decimal, it is truncated to two decimal places.</para>
        /// </description></item>
        /// <item><description><para><c>NetworkIn</c>: The inbound data transfer, in bits.
        /// &lt;props=&quot;intl&quot;&gt;Note: The unit in the request parameter is bits, but the billing unit is Mb. The value is converted to Mb for billing. For example, if you push a usage of 524288 for the period from 19:00 to 20:00 and the price is USD 1/Mb, the hourly bill for this period is 524288 / 1024 / 1024 × 1 = USD 0.5. If the fee is a decimal, it is truncated to two decimal places.</para>
        /// </description></item>
        /// <item><description><para>Character: The number of characters.</para>
        /// </description></item>
        /// <item><description><para>DailyActiveUser: The number of daily active users (DAU).</para>
        /// </description></item>
        /// <item><description><para>PeriodMin: The usage duration in minutes.</para>
        /// </description></item>
        /// <item><description><para>VirtualCpu: The number of vCPU cores.</para>
        /// <list type="bullet">
        /// <item><description><para>Unit: The number of units.</para>
        /// </description></item>
        /// <item><description><para>Memory: The memory size in GB.</para>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>Value: The metering value. The value must be greater than or equal to 0. The parameter type is Integer.</para>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// <para><b>Note</b>:</para>
        /// <list type="bullet">
        /// <item><description><para>For products with real-time billing, the interval between StartTime and EndTime can be of any length. EndTime must be later than StartTime.</para>
        /// </description></item>
        /// <item><description><para>For products that are not billed in real-time, such as those billed by the hour, day, or month, the interval between StartTime and EndTime must be longer than 5 minutes.</para>
        /// </description></item>
        /// <item><description><para>When pushing metering data in batches, the InstanceId property must be for instances of the same product. Pushing data for instances of multiple products at the same time is not supported.</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;StartTime&quot;:1711527396,&quot;EndTime&quot;:1711527397,&quot;Entities&quot;:[{&quot;Key&quot;:&quot;Unit&quot;,&quot;Value&quot;:&quot;0&quot;}]}]</para>
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
