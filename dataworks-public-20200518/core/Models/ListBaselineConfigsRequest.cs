// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class ListBaselineConfigsRequest : TeaModel {
        /// <summary>
        /// The type of the baseline. Valid values: DAILY and HOURLY. Separate multiple baseline types with commas (,).
        /// </summary>
        [NameInMap("BaselineTypes")]
        [Validation(Required=false)]
        public string BaselineTypes { get; set; }

        /// <summary>
        /// The ID of the Alibaba Cloud account used by the baseline owner.
        /// </summary>
        [NameInMap("Owner")]
        [Validation(Required=false)]
        public string Owner { get; set; }

        /// <summary>
        /// The page number. Valid values: 1 to 30. Default value: 1.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries per page. Valid values: 1 to 100. Default value: 10.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The priority of the baseline. Valid values: {1,3,5,7,8}. Separate multiple priorities with commas (,).
        /// </summary>
        [NameInMap("Priority")]
        [Validation(Required=false)]
        public string Priority { get; set; }

        /// <summary>
        /// The workspace ID. You can call the ListProjects operation to query the ID.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public long? ProjectId { get; set; }

        /// <summary>
        /// The keyword in the baseline name, which is used to search for the baseline.
        /// </summary>
        [NameInMap("SearchText")]
        [Validation(Required=false)]
        public string SearchText { get; set; }

        /// <summary>
        /// Specifies whether to enable the baseline. Valid values: true and false.
        /// </summary>
        [NameInMap("Useflag")]
        [Validation(Required=false)]
        public bool? Useflag { get; set; }

    }

}
