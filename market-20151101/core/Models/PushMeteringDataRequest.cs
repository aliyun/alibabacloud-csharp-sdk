// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Market20151101.Models
{
    public class PushMeteringDataRequest : TeaModel {
        /// <summary>
        /// <para>The metric description in the example is as follows:</para>
        /// <list type="bullet">
        /// <item><description>InstanceId: instance ID of the Alibaba Cloud Marketplace instance. The parameter type is String.</description></item>
        /// <item><description>StartTime: the start time of the metering period. Unit: seconds. The value is a UNIX timestamp, such as 1723771200. The parameter type is Long.</description></item>
        /// <item><description>EndTime: the end time of the metering period. Unit: seconds. The value is a UNIX timestamp, such as 1723771800. The parameter type is Long.</description></item>
        /// <item><description>Entities: the metering entity objects. The parameter type is List<Map>.<list type="bullet">
        /// <item><description><para>Key: the name of the metering item property. The parameter type is String.</para>
        /// <list type="bullet">
        /// <item><description><para>Frequency: the number of uses (times).</para>
        /// </description></item>
        /// <item><description><para>Period: the usage duration in hours (seconds).
        ///    Note: The unit of duration in the request parameter is seconds, while the billing unit is hours. Therefore, the duration is transformed to hours during billing. For example, if the pushed usage for 19:00 to 20:00 is 1800 and the billing price is 1 CNY/hour, the fee for this period billed hourly is 1800 / 3600 x 1 = 0.5 CNY. If the fee is a decimal, two decimal places are retained, and the excess is discarded.</para>
        /// </description></item>
        /// <item><description><para>Storage: the used storage space (bytes).</para>
        /// </description></item>
        /// </list>
        /// <para>   Note: The unit in the request parameter is bytes, while the billing unit is MB. Therefore, the value is transformed to MB during billing. For example, if the pushed usage for 19:00 to 20:00 is 524288 and the billing price is 1 CNY/MB, the fee for this period billed hourly is 524288 / 1024 / 1024 x 1 = 0.5 CNY. If the fee is a decimal, two decimal places are retained, and the excess is discarded.</para>
        /// <list type="bullet">
        /// <item><description>NetworkOut: the outbound traffic used (bits).</description></item>
        /// </list>
        /// <para>   Note: The unit in the request parameter is bits, while the billing unit is Mbit. Therefore, the value is transformed to Mbit during billing. For example, if the pushed usage for 19:00 to 20:00 is 524288 and the billing price is 1 CNY/Mbit, the fee for this period billed hourly is 524288 / 1024 / 1024 x 1 = 0.5 CNY. If the fee is a decimal, two decimal places are retained, and the excess is discarded.</para>
        /// <list type="bullet">
        /// <item><description>NetworkIn: the inbound traffic used (bits).</description></item>
        /// </list>
        /// <para>   Note: The unit in the request parameter is bits, while the billing unit is Mbit. Therefore, the value is transformed to Mbit during billing. For example, if the pushed usage for 19:00 to 20:00 is 524288 and the billing price is 1 CNY/Mbit, the fee for this period billed hourly is 524288 / 1024 / 1024 x 1 = 0.5 CNY. If the fee is a decimal, two decimal places are retained, and the excess is discarded.</para>
        /// <list type="bullet">
        /// <item><description>Character: the number of characters.</description></item>
        /// <item><description>DailyActiveUser: the number of daily active users (DAU).</description></item>
        /// <item><description>PeriodMin: the usage duration in minutes (minutes).</description></item>
        /// <item><description>VirtualCpu: the number of virtual CPU cores.</description></item>
        /// <item><description>Unit: the number of units.</description></item>
        /// <item><description>Memory: the memory size (GB).</description></item>
        /// <item><description>KTokens: the number of tokens used (tokens).
        ///    Note: The unit of KTokens in the request parameter is tokens, and it does not need to be transformed to thousands of tokens. However, the billing unit is thousands of tokens. Therefore, the token value in the pushed metering parameter is transformed to thousands of tokens during billing. For example, if the pushed usage for 19:00 to 20:00 is 1500 tokens, example: {&quot;Key&quot;:&quot;KTokens&quot;,&quot;Value&quot;:&quot;1500&quot;,&quot;meteringAssit&quot;:&quot;cmapi00071246-KTokens-1&quot;}, and the billing price is 1 CNY per thousand tokens, the fee for this period billed hourly is 1500 / 1000 x 1 = 1.5 CNY. If the fee is a decimal, two decimal places are retained, and the excess is discarded.</description></item>
        /// <item><description>Suit: the number of suites. Note that the value passed in the parameter is the number of suites.</description></item>
        /// <item><description>StorageGigaByte: the storage space in GB. Note that the unit of the value directly passed in the parameter is GB, and it does not need to be transformed to bytes or other units.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>Value: the metering value (value &gt;= 0). The parameter type is Integer.</para>
        /// </description></item>
        /// <item><description><para>meteringAssit: instance ID of the multi-dimensional metering item. The parameter type is String. You can view this billing item ID in the product publish backend. Billing items such as Frequency have this value whether there is one or more. When pushing metering data for newly published products, you must pass this parameter.</para>
        /// </description></item>
        /// <item><description><para>SerialNo: specific to large model invoke scenarios. When it is an HTTP invoke, the Settings is requestId. When it is a WebSocket invoke, the Settings is the UID of a single node. This parameter needs to be passed only when the product is billed by the minute. It is not required in other cases.</para>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// <para><b>Note</b>:</para>
        /// <list type="bullet">
        /// <item><description>The multi-dimensional metering capability allows multiple billing items such as Frequency (times), Period (usage duration), and PeriodMin to be configured when publishing a product. For example, a product can have multiple PeriodMin billing items, and each PeriodMin billing item generates a unique ID as the identity of the billing item. This billing item is generated when the product is published, and the format is such as (cmapi00060317-PeriodMin-3, cmapi00060317-PeriodMin-4). When pushing metering data, you need to pass the above ID to perform the corresponding billing deduction. The format of the metering data pushed for newly published products is as follows:</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>When pushing data hourly or daily:
        /// [{&quot;InstanceId&quot;:&quot;1000001&quot;,&quot;StartTime&quot;:&quot;100000000&quot;,&quot;EndTime&quot;:&quot;100000010&quot;,&quot;Entities&quot;:[{&quot;Key&quot;:&quot;PeriodMin&quot;,&quot;Value&quot;:&quot;96&quot;,&quot;meteringAssit&quot;:&quot;cmapi00060317-PeriodMin-4&quot;}]}]</para>
        /// <para>When pushing metering data in real time in LLM scenarios:
        /// [{&quot;InstanceId&quot;:&quot;1000001&quot;,&quot;SerialNo&quot;:&quot;210f470417561055092582279ea052&quot;,&quot;StartTime&quot;:&quot;100000000&quot;,&quot;EndTime&quot;:&quot;100000010&quot;,&quot;Entities&quot;:[{&quot;Key&quot;:&quot;PeriodMin&quot;,&quot;Value&quot;:&quot;96&quot;,&quot;meteringAssit&quot;:&quot;cmapi00060317-PeriodMin-4&quot;}]}]</para>
        /// </summary>
        [NameInMap("Metering")]
        [Validation(Required=false)]
        public string Metering { get; set; }

    }

}
