// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ListCheckInstanceResultRequest : TeaModel {
        /// <summary>
        /// The ID of the check item.
        /// </summary>
        [NameInMap("CheckId")]
        [Validation(Required=false)]
        public long? CheckId { get; set; }

        /// <summary>
        /// The number of the page to return.
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// The ID of the instance.
        /// </summary>
        [NameInMap("InstanceIdKey")]
        [Validation(Required=false)]
        public string InstanceIdKey { get; set; }

        /// <summary>
        /// The instance IDs of cloud services.
        /// </summary>
        [NameInMap("InstanceIds")]
        [Validation(Required=false)]
        public List<string> InstanceIds { get; set; }

        /// <summary>
        /// The name of the instance.
        /// </summary>
        [NameInMap("InstanceNameKey")]
        [Validation(Required=false)]
        public string InstanceNameKey { get; set; }

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
        /// The number of entries to return on each page.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The region ID of the instance.
        /// </summary>
        [NameInMap("RegionIdKey")]
        [Validation(Required=false)]
        public string RegionIdKey { get; set; }

        /// <summary>
        /// The sort type of the instances.
        /// </summary>
        [NameInMap("SortTypes")]
        [Validation(Required=false)]
        public List<string> SortTypes { get; set; }

        /// <summary>
        /// The statuses of check items.
        /// </summary>
        [NameInMap("Statuses")]
        [Validation(Required=false)]
        public List<string> Statuses { get; set; }

    }

}
