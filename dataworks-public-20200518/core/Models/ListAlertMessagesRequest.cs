// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class ListAlertMessagesRequest : TeaModel {
        /// <summary>
        /// <para>The notification method. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>MAIL</description></item>
        /// <item><description>SMS Alert notifications can be sent by text message only in the Singapore, Malaysia (Kuala Lumpur), and Germany (Frankfurt) regions.</description></item>
        /// </list>
        /// <para>You can specify multiple notification methods. Separate them with commas (,).</para>
        /// 
        /// <b>Example:</b>
        /// <para>SMS,MAIL,PHONE</para>
        /// </summary>
        [NameInMap("AlertMethods")]
        [Validation(Required=false)]
        public string AlertMethods { get; set; }

        /// <summary>
        /// <para>The type of the alert rule. Valid values: GLOBAL, USER_DEFINE, and OTHER. The value GLOBAL indicates that the alert rule is a global alert rule. The value USER_DEFINE indicates that the alert rule is customized by a user. The value OTHER indicates that the alert rule is a rule of another type. You can specify multiple types. Separate them with commas (,).</para>
        /// 
        /// <b>Example:</b>
        /// <para>GLOBAL,USER_DEFINE,OTHER</para>
        /// </summary>
        [NameInMap("AlertRuleTypes")]
        [Validation(Required=false)]
        public string AlertRuleTypes { get; set; }

        /// <summary>
        /// <para>The ID of the Alibaba Cloud account used by the alert recipient.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123456</para>
        /// </summary>
        [NameInMap("AlertUser")]
        [Validation(Required=false)]
        public string AlertUser { get; set; }

        /// <summary>
        /// <para>The baseline ID. This parameter takes effect if the AlertRuleTypes parameter is set to GLOBAL. You can configure either this parameter or the RemindId parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1234</para>
        /// </summary>
        [NameInMap("BaselineId")]
        [Validation(Required=false)]
        public long? BaselineId { get; set; }

        /// <summary>
        /// <para>The beginning of the time range to query. Specify the time in the ISO 8601 standard in the yyyy-MM-dd\&quot;T\&quot;HH:mm:ssZ format. The time must be in UTC.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2020-04-02T00:00:00+0800</para>
        /// </summary>
        [NameInMap("BeginTime")]
        [Validation(Required=false)]
        public string BeginTime { get; set; }

        /// <summary>
        /// <para>The end of the time range to query. Specify the time in the ISO 8601 standard in the yyyy-MM-dd\&quot;T\&quot;HH:mm:ssZ format. The time must be in UTC.</para>
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
        /// <para>The custom alert rule ID. This parameter takes effect if the AlertRuleTypes parameter is set to USER_DEFINE. You can configure either this parameter or the BaselineId parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9527</para>
        /// </summary>
        [NameInMap("RemindId")]
        [Validation(Required=false)]
        public long? RemindId { get; set; }

    }

}
