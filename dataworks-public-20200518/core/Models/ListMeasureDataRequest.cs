// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class ListMeasureDataRequest : TeaModel {
        /// <summary>
        /// <para>The measurement component.</para>
        /// <list type="bullet">
        /// <item><description>This parameter is set to Count if the DomainCode parameter is set to DideAlarmPhone or DideAlarmSms. In this case, statistics on the number of phone calls or text messages that are used to send alert notifications are collected.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Count</para>
        /// </summary>
        [NameInMap("ComponentCode")]
        [Validation(Required=false)]
        public string ComponentCode { get; set; }

        /// <summary>
        /// <para>The item to be measured. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>DideAlarmPhone: phone call-based alerts</description></item>
        /// <item><description>DideAlarmSms: text message-based alerts</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DideAlarmPhone</para>
        /// </summary>
        [NameInMap("DomainCode")]
        [Validation(Required=false)]
        public string DomainCode { get; set; }

        /// <summary>
        /// <para>The end timestamp of the measurement period, in milliseconds. The measurement period is calculated in days. You can query only the data within the last 30 days.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1717430400000</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        /// <summary>
        /// <para>The start timestamp of the measurement period, in milliseconds. The measurement period is calculated in days. You can query only the data within the last 30 days.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1717344000000</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

    }

}
