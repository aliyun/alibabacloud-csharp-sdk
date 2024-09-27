// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class ListCloudGtmAlertLogsRequest : TeaModel {
        /// <summary>
        /// <para>Alert type:</para>
        /// <list type="bullet">
        /// <item><description>ALERT</description></item>
        /// <item><description>RESUME</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ALERT</para>
        /// </summary>
        [NameInMap("ActionType")]
        [Validation(Required=false)]
        public string ActionType { get; set; }

        /// <summary>
        /// <para>The end time of the query (timestamp).</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1711328826977</para>
        /// </summary>
        [NameInMap("EndTimestamp")]
        [Validation(Required=false)]
        public long? EndTimestamp { get; set; }

        /// <summary>
        /// <para>Alarm object types:</para>
        /// <list type="bullet">
        /// <item><description>GTM_ADDRESS: Address</description></item>
        /// <item><description>GTM_ADDRESS_POOL: Address Pool</description></item>
        /// <item><description>GTM_INSTANCE: Instance</description></item>
        /// <item><description>GTM_MONITOR_TEMPLATE: Health Check Template</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>GTM_ADDRESS</para>
        /// </summary>
        [NameInMap("EntityType")]
        [Validation(Required=false)]
        public string EntityType { get; set; }

        /// <summary>
        /// <para>Search keyword, usually an address ID, address pool ID, domain information, etc.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pool-895280232254422016</para>
        /// </summary>
        [NameInMap("Keyword")]
        [Validation(Required=false)]
        public string Keyword { get; set; }

        /// <summary>
        /// <para>Language type of the returned information:</para>
        /// <list type="bullet">
        /// <item><description>zh-CN: Chinese</description></item>
        /// <item><description>en-US: English</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh-CN</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>Current page number, starting from <b>1</b>, default is <b>1</b>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of rows per page when paginating queries, with a maximum value of 100 and a default of 20.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The start time of the query (timestamp).</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1611328826977</para>
        /// </summary>
        [NameInMap("StartTimestamp")]
        [Validation(Required=false)]
        public long? StartTimestamp { get; set; }

    }

}
