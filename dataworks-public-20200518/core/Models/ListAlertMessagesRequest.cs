// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class ListAlertMessagesRequest : TeaModel {
        /// <summary>
        /// The notification method. Valid values:
        /// 
        /// *   MAIL
        /// *   SMS Alert notifications can be sent by text message only in the Singapore, Malaysia (Kuala Lumpur), and Germany (Frankfurt) regions.
        /// 
        /// You can specify multiple notification methods. Separate them with commas (,).
        /// </summary>
        [NameInMap("AlertMethods")]
        [Validation(Required=false)]
        public string AlertMethods { get; set; }

        /// <summary>
        /// The type of the alert rule. Valid values: GLOBAL, USER_DEFINE, and OTHER. The value GLOBAL indicates that the alert rule is a global alert rule. The value USER_DEFINE indicates that the alert rule is customized by a user. The value OTHER indicates that the alert rule is a rule of another type. You can specify multiple types. Separate them with commas (,).
        /// </summary>
        [NameInMap("AlertRuleTypes")]
        [Validation(Required=false)]
        public string AlertRuleTypes { get; set; }

        /// <summary>
        /// The ID of the Alibaba Cloud account used by the alert recipient.
        /// </summary>
        [NameInMap("AlertUser")]
        [Validation(Required=false)]
        public string AlertUser { get; set; }

        /// <summary>
        /// The baseline ID. This parameter takes effect if the AlertRuleTypes parameter is set to GLOBAL. You can configure either this parameter or the RemindId parameter.
        /// </summary>
        [NameInMap("BaselineId")]
        [Validation(Required=false)]
        public long? BaselineId { get; set; }

        /// <summary>
        /// The beginning of the time range to query. Specify the time in the ISO 8601 standard in the yyyy-MM-dd\\"T\\"HH:mm:ssZ format. The time must be in UTC.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("BeginTime")]
        [Validation(Required=false)]
        public string BeginTime { get; set; }

        /// <summary>
        /// The end of the time range to query. Specify the time in the ISO 8601 standard in the yyyy-MM-dd\\"T\\"HH:mm:ssZ format. The time must be in UTC.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// The page number. Default value: 1. Minimum value: 1. Maximum value: 30.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries per page. Default value: 10. Maximum value: 100.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The custom alert rule ID. This parameter takes effect if the AlertRuleTypes parameter is set to USER_DEFINE. You can configure either this parameter or the BaselineId parameter.
        /// </summary>
        [NameInMap("RemindId")]
        [Validation(Required=false)]
        public long? RemindId { get; set; }

    }

}
