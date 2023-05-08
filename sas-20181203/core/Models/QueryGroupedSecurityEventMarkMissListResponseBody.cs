// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class QueryGroupedSecurityEventMarkMissListResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The subtype of the alert event.
        /// </summary>
        [NameInMap("List")]
        [Validation(Required=false)]
        public List<QueryGroupedSecurityEventMarkMissListResponseBodyList> List { get; set; }
        public class QueryGroupedSecurityEventMarkMissListResponseBodyList : TeaModel {
            /// <summary>
            /// The handling method. Valid values:
            /// 
            /// *   **1**: Automatically Added to Whitelist
            /// *   **2**: Defense Without Notification
            /// </summary>
            [NameInMap("AliUid")]
            [Validation(Required=false)]
            public long? AliUid { get; set; }

            /// <summary>
            /// The alias of the field.
            /// </summary>
            [NameInMap("DisposalWay")]
            [Validation(Required=false)]
            public string DisposalWay { get; set; }

            /// <summary>
            /// The number of entries returned on the current page.
            /// </summary>
            [NameInMap("EventName")]
            [Validation(Required=false)]
            public string EventName { get; set; }

            /// <summary>
            /// The handling method. Valid values:
            /// 
            /// *   **auto_add_white**: Automatically Added to Whitelist
            /// *   **defense_not_notification**: Defense Without Notification
            /// </summary>
            [NameInMap("EventNameOriginal")]
            [Validation(Required=false)]
            public string EventNameOriginal { get; set; }

            /// <summary>
            /// The condition that is used to query alert events by asset. You can specify a value of the following types:
            /// 
            /// *   The IP address of the asset.
            /// *   The public IP address of the asset.
            /// *   The private IP address of the asset.
            /// *   The name of the asset.
            /// </summary>
            [NameInMap("EventType")]
            [Validation(Required=false)]
            public string EventType { get; set; }

            /// <summary>
            /// The language of the content within the request and response. Default value: **zh**. Valid values:
            /// 
            /// *   **zh**: Chinese
            /// *   **en**: English
            /// </summary>
            [NameInMap("EventTypeOriginal")]
            [Validation(Required=false)]
            public string EventTypeOriginal { get; set; }

            /// <summary>
            /// Unusual logon
            /// </summary>
            [NameInMap("Field")]
            [Validation(Required=false)]
            public string Field { get; set; }

            /// <summary>
            /// The name of the alert event. The value indicates a subtype.
            /// </summary>
            [NameInMap("FieldValue")]
            [Validation(Required=false)]
            public string FieldValue { get; set; }

            /// <summary>
            /// The number of the page to return. Default value: **1**.
            /// </summary>
            [NameInMap("FiledAliasName")]
            [Validation(Required=false)]
            public string FiledAliasName { get; set; }

            /// <summary>
            /// The number of entries returned per page. Default value: **20**.
            /// </summary>
            [NameInMap("Operate")]
            [Validation(Required=false)]
            public string Operate { get; set; }

            /// <summary>
            /// The pagination information.
            /// </summary>
            [NameInMap("Uuids")]
            [Validation(Required=false)]
            public string Uuids { get; set; }

        }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The ID of the request, which is used to locate and troubleshoot issues.
        /// </summary>
        [NameInMap("PageInfo")]
        [Validation(Required=false)]
        public QueryGroupedSecurityEventMarkMissListResponseBodyPageInfo PageInfo { get; set; }
        public class QueryGroupedSecurityEventMarkMissListResponseBodyPageInfo : TeaModel {
            [NameInMap("Count")]
            [Validation(Required=false)]
            public int? Count { get; set; }

            /// <summary>
            /// Queries whitelist rules.
            /// </summary>
            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public int? CurrentPage { get; set; }

            /// <summary>
            /// QueryGroupedSecurityEventMarkMissList
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
