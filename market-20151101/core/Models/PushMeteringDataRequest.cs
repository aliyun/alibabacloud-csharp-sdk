// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Market20151101.Models
{
    public class PushMeteringDataRequest : TeaModel {
        /// <summary>
        /// <para>The parameters in the example are described as follows:</para>
        /// <list type="bullet">
        /// <item><description>InstanceId: The cloud marketplace instance ID. The parameter type is String.</description></item>
        /// <item><description>StartTime: The metering start time. Unit: seconds (in Unix timestamp format, e.g., 1723771200). The parameter type is Long.</description></item>
        /// <item><description>EndTime: The metering end time. Unit: seconds (in Unix timestamp format, e.g., 1723771800). The parameter type is Long.</description></item>
        /// <item><description>Entities: The metering entity objects. The parameter type is List<Map>.<list type="bullet">
        /// <item><description><para>Key: The name of the metering item attribute. The parameter type is String.</para>
        /// <list type="bullet">
        /// <item><description><para>Frequency: The number of uses (count).</para>
        /// </description></item>
        /// <item><description><para>Period: The usage duration in hours (seconds).
        ///    Note: The duration unit in the request parameter is seconds, while the billing unit is hours. Therefore, the value is converted to hours during billing. For example, if you push usage of 1800 for the period 19:00-20:00 and the billing price is 1 CNY/hour, the hourly bill for that period is 1800 / 3600 x 1 = 0.5 CNY. If the amount is a decimal, it is rounded to two decimal places with any digits beyond two truncated.</para>
        /// </description></item>
        /// <item><description><para>Storage: The storage space used (Byte).</para>
        /// </description></item>
        /// </list>
        /// <para>   Note: The unit in the request parameter is Byte, while the billing unit is MB. Therefore, the value is converted to MB during billing. For example, if you push usage of 524288 for the period 19:00-20:00 and the billing price is 1 CNY/MB, the hourly bill for that period is 524288 / 1024 / 1024 x 1 = 0.5 CNY. If the amount is a decimal, it is rounded to two decimal places with any digits beyond two truncated.</para>
        /// <list type="bullet">
        /// <item><description>NetworkOut: The outbound traffic used (Bit).</description></item>
        /// </list>
        /// <para>   Note: The unit in the request parameter is Bit, while the billing unit is Mb. Therefore, the value is converted to Mb during billing. For example, if you push usage of 524288 for the period 19:00-20:00 and the billing price is 1 CNY/Mb, the hourly bill for that period is 524288 / 1024 / 1024 x 1 = 0.5 CNY. If the amount is a decimal, it is rounded to two decimal places with any digits beyond two truncated.</para>
        /// <list type="bullet">
        /// <item><description>NetworkIn: The inbound traffic used (Bit).</description></item>
        /// </list>
        /// <para>   Note: The unit in the request parameter is Bit, while the billing unit is Mb. Therefore, the value is converted to Mb during billing. For example, if you push usage of 524288 for the period 19:00-20:00 and the billing price is 1 CNY/Mb, the hourly bill for that period is 524288 / 1024 / 1024 x 1 = 0.5 CNY. If the amount is a decimal, it is rounded to two decimal places with any digits beyond two truncated.</para>
        /// <list type="bullet">
        /// <item><description>Character: The number of characters (count).</description></item>
        /// <item><description>DailyActiveUser: The number of daily active users (DAU).</description></item>
        /// <item><description>PeriodMin: The usage duration in minutes (minutes).</description></item>
        /// <item><description>VirtualCpu: The number of virtual CPU cores.</description></item>
        /// <item><description>Unit: Unit (count).</description></item>
        /// <item><description>Memory: Memory (GB).</description></item>
        /// <item><description>KTokens: The number of tokens used (token).
        ///    Note: The unit of KTokens in the request parameter is token. You do not need to convert the value to thousands of tokens. The billing unit is thousands of tokens. Therefore, the token value in the pushed metering parameter is converted to thousands of tokens during billing. For example, if you push usage of 1500 tokens for the period 19:00-20:00, example: {&quot;Key&quot;:&quot;KTokens&quot;,&quot;Value&quot;:&quot;1500&quot;,&quot;meteringAssit&quot;:&quot;cmapi00071246-KTokens-1&quot;}, and the billing price is 1 CNY/thousand tokens, the hourly bill for that period is 1500 / 1000 x 1 = 1.5 CNY. If the amount is a decimal, it is rounded to two decimal places with any digits beyond two truncated.</description></item>
        /// <item><description>Suit: Suit (set). Note that the value passed in the parameter is in sets.</description></item>
        /// <item><description>StorageGigaByte: StorageGigaByte (storage space in GB). Note that the unit of the value passed in the parameter is directly GB, without needing to convert to Byte or other units.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>Value: The metering value (value &gt;= 0). The parameter type is Integer.</para>
        /// </description></item>
        /// <item><description><para>meteringAssit: The multi-dimensional metering item ID. The parameter type is String. This billing item ID can be found in the product publishing backend. Billing items such as Frequency may have one or more of these values. When pushing metering data for newly published products, this parameter must be included.</para>
        /// </description></item>
        /// <item><description><para>SerialNo: Specific to large model invocation scenarios. When using HTTP calls, set this to the requestId. When using WebSocket, set this to the uid of the single task. This parameter is only required when the product is billed by the minute. It is not required in other cases.</para>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// <para><b>Note</b>:</para>
        /// <list type="bullet">
        /// <item><description>Multi-dimensional metering capability: For the billing items mentioned above such as Frequency (count), Period (usage duration), PeriodMin, etc., multiple items can be supported when publishing a product. For example, a product can have multiple PeriodMin billing items, and each PeriodMin billing item generates a unique ID to identify the billing item. This billing item is generated when the product is published, and the format is like (cmapi00060317-PeriodMin-3, cmapi00060317-PeriodMin-4). When pushing metering data, the above ID must be included to enable the corresponding billing deduction. The metering data format for newly published products is as follows:
        /// [{&quot;InstanceId&quot;:&quot;1000001&quot;,&quot;StartTime&quot;:&quot;100000000&quot;,&quot;EndTime&quot;:&quot;100000010&quot;,&quot;Entities&quot;:[{&quot;Key&quot;:&quot;PeriodMin&quot;,&quot;Value&quot;:&quot;96&quot;,&quot;meteringAssit&quot;:&quot;cmapi00060317-PeriodMin-4&quot;}]}].</description></item>
        /// <item><description>The pushed metering parameters should follow the example. All parameters in the example are required. Missing data will cause the metering push to fail.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>按小时/按天推量时：
        /// [{&quot;InstanceId&quot;:&quot;1000001&quot;,&quot;StartTime&quot;:&quot;100000000&quot;,&quot;EndTime&quot;:&quot;100000010&quot;,&quot;Entities&quot;:[{&quot;Key&quot;:&quot;PeriodMin&quot;,&quot;Value&quot;:&quot;96&quot;,&quot;meteringAssit&quot;:&quot;cmapi00060317-PeriodMin-4&quot;}]}]</para>
        /// <para>大模型场景实时推量时：
        /// [{&quot;InstanceId&quot;:&quot;1000001&quot;,&quot;SerialNo&quot;:&quot;210f470417561055092582279ea052&quot;,&quot;StartTime&quot;:&quot;100000000&quot;,&quot;EndTime&quot;:&quot;100000010&quot;,&quot;Entities&quot;:[{&quot;Key&quot;:&quot;PeriodMin&quot;,&quot;Value&quot;:&quot;96&quot;,&quot;meteringAssit&quot;:&quot;cmapi00060317-PeriodMin-4&quot;}]}]</para>
        /// </summary>
        [NameInMap("Metering")]
        [Validation(Required=false)]
        public string Metering { get; set; }

    }

}
