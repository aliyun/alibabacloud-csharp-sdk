// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeAlarmEventListRequest : TeaModel {
        /// <summary>
        /// The name of the alert event.
        /// 
        /// >  You can call the [DescribeNsasSuspEventType](~~DescribeNsasSuspEventType~~) operation to query the names of alert events.
        /// </summary>
        [NameInMap("AlarmEventName")]
        [Validation(Required=false)]
        public string AlarmEventName { get; set; }

        /// <summary>
        /// The type of the alert event.
        /// 
        /// >  You can call the [DescribeNsasSuspEventType](~~DescribeNsasSuspEventType~~) operation to query the types of alert events.
        /// </summary>
        [NameInMap("AlarmEventType")]
        [Validation(Required=false)]
        public string AlarmEventType { get; set; }

        /// <summary>
        /// The number of the page to return. Pages start from page **1**. Default value: **1**.
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// Specifies whether the alert event is handled. Valid values:
        /// 
        /// *   **N**: unhandled
        /// *   **Y**: handled
        /// </summary>
        [NameInMap("Dealed")]
        [Validation(Required=false)]
        public string Dealed { get; set; }

        /// <summary>
        /// The ID of the request source. Set the value to **sas**, which indicates that the request is sent from Security Center.
        /// </summary>
        [NameInMap("From")]
        [Validation(Required=false)]
        public string From { get; set; }

        /// <summary>
        /// The ID of the asset group to which the affected asset belongs.
        /// </summary>
        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public string GroupId { get; set; }

        /// <summary>
        /// The ID of the alert event.
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        /// <summary>
        /// The language of the content within the request and response. Default value: **zh**. Valid values:
        /// 
        /// *   **zh**: Chinese
        /// *   **en**: English
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// The severity of the alert event. Separate multiple severities with commas (,). Valid values:
        /// 
        /// *   **serious**
        /// *   **suspicious**
        /// *   **remind**
        /// </summary>
        [NameInMap("Levels")]
        [Validation(Required=false)]
        public string Levels { get; set; }

        /// <summary>
        /// An array that consists of the handling result codes of alert events.
        /// </summary>
        [NameInMap("OperateErrorCodeList")]
        [Validation(Required=false)]
        public List<string> OperateErrorCodeList { get; set; }

        /// <summary>
        /// The time when the handling operation ends.
        /// </summary>
        [NameInMap("OperateTimeEnd")]
        [Validation(Required=false)]
        public string OperateTimeEnd { get; set; }

        /// <summary>
        /// The time when the handing operation starts.
        /// </summary>
        [NameInMap("OperateTimeStart")]
        [Validation(Required=false)]
        public string OperateTimeStart { get; set; }

        /// <summary>
        /// The number of entries to return on each page. Default value: **20**.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public string PageSize { get; set; }

        /// <summary>
        /// The name of the alert or the information about the asset.
        /// </summary>
        [NameInMap("Remark")]
        [Validation(Required=false)]
        public string Remark { get; set; }

        /// <summary>
        /// The custom sorting field. Default value: **operateTime**. Valid values:
        /// 
        /// *   **lastTime**: the latest occurrence time
        /// *   **operateTime**: the handling time
        /// 
        /// >  This parameter takes effect if you set the **Dealed** parameter to Y.
        /// </summary>
        [NameInMap("SortColumn")]
        [Validation(Required=false)]
        public string SortColumn { get; set; }

        /// <summary>
        /// The custom sorting order. Default value: **desc**. Valid values:
        /// 
        /// *   **asc**: the ascending order
        /// *   **desc**: the descending order
        /// 
        /// >  This parameter takes effect if you set the **Dealed** parameter to Y.
        /// </summary>
        [NameInMap("SortType")]
        [Validation(Required=false)]
        public string SortType { get; set; }

        /// <summary>
        /// The source IP address of the request.
        /// </summary>
        [NameInMap("SourceIp")]
        [Validation(Required=false)]
        public string SourceIp { get; set; }

        /// <summary>
        /// The tactic ID of ATT\&CK.
        /// </summary>
        [NameInMap("TacticId")]
        [Validation(Required=false)]
        public string TacticId { get; set; }

        /// <summary>
        /// The end time when the alert event was last detected.
        /// </summary>
        [NameInMap("TimeEnd")]
        [Validation(Required=false)]
        public string TimeEnd { get; set; }

        /// <summary>
        /// The start time when the alert event was last detected.
        /// </summary>
        [NameInMap("TimeStart")]
        [Validation(Required=false)]
        public string TimeStart { get; set; }

        /// <summary>
        /// The ID of the alert event.
        /// </summary>
        [NameInMap("UniqueInfo")]
        [Validation(Required=false)]
        public string UniqueInfo { get; set; }

        /// <summary>
        /// The UUIDs of the assets. Separate multiple UUIDs with commas (,).
        /// </summary>
        [NameInMap("Uuids")]
        [Validation(Required=false)]
        public string Uuids { get; set; }

    }

}
