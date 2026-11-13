// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class ListAlertMessagesRequest : TeaModel {
        /// <summary>
        /// <para>The alert notification method. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>MAIL: Email.</description></item>
        /// <item><description>SMS: Text message.
        /// &lt;props=&quot;intl&quot;&gt;Text message alerts are available in the following regions: Singapore, Malaysia (Kuala Lumpur), and Germany (Frankfurt).
        /// &lt;props=&quot;china&quot;&gt;- PHONE: Phone call. This method is supported only in DataWorks Professional Edition and more advanced editions.</description></item>
        /// </list>
        /// <para>Separate multiple notification methods with commas (,).</para>
        /// 
        /// <b>Example:</b>
        /// <para>SMS,MAIL,PHONE</para>
        /// </summary>
        [NameInMap("AlertMethods")]
        [Validation(Required=false)]
        public string AlertMethods { get; set; }

        /// <summary>
        /// <para>The rule type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>GLOBAL: Global rule.</description></item>
        /// <item><description>USER_DEFINE: Custom rule.</description></item>
        /// <item><description>OTHER: Other.</description></item>
        /// </list>
        /// <para>Separate multiple rule types with commas (,).</para>
        /// 
        /// <b>Example:</b>
        /// <para>GLOBAL,USER_DEFINE,OTHER</para>
        /// </summary>
        [NameInMap("AlertRuleTypes")]
        [Validation(Required=false)]
        public string AlertRuleTypes { get; set; }

        /// <summary>
        /// <para>The Alibaba Cloud UID of the alert recipient.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12345</para>
        /// </summary>
        [NameInMap("AlertUser")]
        [Validation(Required=false)]
        public string AlertUser { get; set; }

        /// <summary>
        /// <para>The baseline ID. This parameter takes effect when AlertRuleTypes is set to GLOBAL.
        /// You can specify either this parameter or the RemindId parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1234</para>
        /// </summary>
        [NameInMap("BaselineId")]
        [Validation(Required=false)]
        public long? BaselineId { get; set; }

        /// <summary>
        /// <para>The start time of the alert. Specify the time in the yyyy-MM-dd\&quot;T\&quot;HH:mm:ssZ format. The time must be in UTC.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2020-04-02T00:00:00+0800</para>
        /// </summary>
        [NameInMap("BeginTime")]
        [Validation(Required=false)]
        public string BeginTime { get; set; }

        /// <summary>
        /// <para>The end time of the alert. Specify the time in the yyyy-MM-dd\&quot;T\&quot;HH:mm:ssZ format. The time must be in UTC.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2020-04-04T00:00:00+0800</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The page number. Default value: 1. Minimum value: 1. Maximum value: 30.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Default value: 10. Maximum value: 100.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The ID of the custom rule. This parameter takes effect when AlertRuleTypes is set to USER_DEFINE (custom rule).
        /// You can specify either this parameter or the BaselineId parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9527</para>
        /// </summary>
        [NameInMap("RemindId")]
        [Validation(Required=false)]
        public long? RemindId { get; set; }

    }

}
