// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class ListRemindsRequest : TeaModel {
        /// <summary>
        /// The ID of the Alibaba Cloud account that is used to receive alert notifications.
        /// </summary>
        [NameInMap("AlertTarget")]
        [Validation(Required=false)]
        public string AlertTarget { get; set; }

        /// <summary>
        /// The ID of the Alibaba Cloud account that is used to create the custom alert rules.
        /// </summary>
        [NameInMap("Founder")]
        [Validation(Required=false)]
        public string Founder { get; set; }

        /// <summary>
        /// The ID of the node to which the custom alert rules are applied. You can use the ID to search for the custom alert rules that are applied to the node.
        /// </summary>
        [NameInMap("NodeId")]
        [Validation(Required=false)]
        public long? NodeId { get; set; }

        /// <summary>
        /// The number of the page to return. Valid values: 1 to 30. Default value: 1.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries to return on each page. Default value: 10. Maximum value: 100.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The conditions that trigger an alert for the node. Valid values: FINISHED, UNFINISHED, ERROR, CYCLE_UNFINISHED, and TIMEOUT. The value FINISHED indicates that the node finishes running. The value UNFINISHED indicates that the node is still running at the specified point in time. The value ERROR indicates that an error occurs when the node is running. The value CYCLE_UNFINISHED indicates that the node does not finish running in the specified scheduling cycle. The value TIMEOUT indicates that the node times out. You can specify multiple conditions for a custom alert rule. If you specify multiple condition, separate them with commas (,).
        /// </summary>
        [NameInMap("RemindTypes")]
        [Validation(Required=false)]
        public string RemindTypes { get; set; }

        /// <summary>
        /// The keyword in a rule name that is used to search for the rule. Fuzzy search is supported.
        /// </summary>
        [NameInMap("SearchText")]
        [Validation(Required=false)]
        public string SearchText { get; set; }

    }

}
