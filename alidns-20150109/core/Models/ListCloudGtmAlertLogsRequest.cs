// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class ListCloudGtmAlertLogsRequest : TeaModel {
        /// <summary>
        /// <para>The alert type.</para>
        /// <list type="bullet">
        /// <item><description><para>ALERT: An alert is triggered.</para>
        /// </description></item>
        /// <item><description><para>RESUME: The service has recovered.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ALERT</para>
        /// </summary>
        [NameInMap("ActionType")]
        [Validation(Required=false)]
        public string ActionType { get; set; }

        /// <summary>
        /// <para>The end of the time range to query. This is a UNIX timestamp.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1711328826977</para>
        /// </summary>
        [NameInMap("EndTimestamp")]
        [Validation(Required=false)]
        public long? EndTimestamp { get; set; }

        /// <summary>
        /// <para>The alert object.</para>
        /// <list type="bullet">
        /// <item><description><para>GTM_ADDRESS: Address</para>
        /// </description></item>
        /// <item><description><para>GTM_ADDRESS_POOL: Address pool</para>
        /// </description></item>
        /// <item><description><para>GTM_INSTANCE: Instance</para>
        /// </description></item>
        /// <item><description><para>GTM_MONITOR_TEMPLATE: Health check template</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>GTM_ADDRESS</para>
        /// </summary>
        [NameInMap("EntityType")]
        [Validation(Required=false)]
        public string EntityType { get; set; }

        /// <summary>
        /// <para>The keyword for the search. This is usually an address ID, address pool ID, or domain name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pool-895280232254422016</para>
        /// </summary>
        [NameInMap("Keyword")]
        [Validation(Required=false)]
        public string Keyword { get; set; }

        /// <summary>
        /// <para>The language of the response.</para>
        /// <list type="bullet">
        /// <item><description><para>zh-CN: Chinese</para>
        /// </description></item>
        /// <item><description><para>en-US: English</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh-CN</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The current page number. The value starts from <b>1</b>. The default value is <b>1</b>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries to return on each page for a paged query. The maximum value is 100. The default value is 20.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The start of the time range to query. This is a UNIX timestamp.</para>
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
