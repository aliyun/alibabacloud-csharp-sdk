// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeHoneyPotSuspStatisticsRequest : TeaModel {
        /// <summary>
        /// <para>The source of the request. Set the value to <b>honeypot</b>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>honeypot</para>
        /// </summary>
        [NameInMap("From")]
        [Validation(Required=false)]
        public string From { get; set; }

        /// <summary>
        /// <para>The language of the content within the request and response. Default value: <b>zh</b>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>zh</b>: Chinese.</description></item>
        /// <item><description><b>en</b>: English.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The time range of the data to query. Unit: days.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("StatisticsDays")]
        [Validation(Required=false)]
        public int? StatisticsDays { get; set; }

        /// <summary>
        /// <para>The type of the asset to query. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>vpcInstanceId</b>: VPC</description></item>
        /// <item><description><b>uuid</b>: server</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpcInstanceId</para>
        /// </summary>
        [NameInMap("StatisticsKeyType")]
        [Validation(Required=false)]
        public string StatisticsKeyType { get; set; }

    }

}
