// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cdn20180510.Models
{
    public class DescribeDomainCcActivityLogRequest : TeaModel {
        /// <summary>
        /// <para>The accelerated domain name. You can specify multiple domain names and separate them with commas (,).</para>
        /// <para>If you do not specify this parameter, data of all accelerated domain names under your account is queried.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example.com</para>
        /// </summary>
        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        /// <summary>
        /// <para>The end of the time range to query. Specify the time in the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time must be in UTC.</para>
        /// <para>The end time must be later than the start time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2018-12-10T21:00:00Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The page number of the page to return. Default value: <b>1</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries to return on each page. Default value: <b>30</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// <para>A custom rule name. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>default_normal: rule for the normal mode</description></item>
        /// <item><description>default_attack: rule for the emergency mode</description></item>
        /// </list>
        /// <para>If you leave this parameter empty, events that triggered rate limiting based on all rules are queried.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test2</para>
        /// </summary>
        [NameInMap("RuleName")]
        [Validation(Required=false)]
        public string RuleName { get; set; }

        /// <summary>
        /// <para>The beginning of the time range to query. Specify the time in the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time must be in UTC.</para>
        /// <para>The minimum time granularity of data collection is 5 minutes.</para>
        /// <para>If you leave this parameter empty, the data collected over the last 24 hours is queried.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2018-12-10T20:00:00Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// <para>The trigger of rate limiting by which you want to query data.</para>
        /// <para>If you leave this parameter empty, all events that triggered rate limiting are queried.</para>
        /// 
        /// <b>Example:</b>
        /// <para>IP</para>
        /// </summary>
        [NameInMap("TriggerObject")]
        [Validation(Required=false)]
        public string TriggerObject { get; set; }

        /// <summary>
        /// <para>The value of the trigger.</para>
        /// <para>If you leave this parameter empty, all events recorded for the trigger are queried.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1.2.3.4</para>
        /// </summary>
        [NameInMap("Value")]
        [Validation(Required=false)]
        public string Value { get; set; }

    }

}
