// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class ListShiftSchedulesRequest : TeaModel {
        /// <summary>
        /// The ID of your Alibaba Cloud account. You can log on to the DataWorks console and move the pointer over the profile picture in the upper-right corner to view the ID.
        /// </summary>
        [NameInMap("Owner")]
        [Validation(Required=false)]
        public string Owner { get; set; }

        /// <summary>
        /// The page number. Minimum value:1. Maximum value: 100. Default value: 1.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries per page. Default value: 10. Maximum value: 100.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The keyword used to perform a fuzzy search on shift schedules.
        /// </summary>
        [NameInMap("ShiftScheduleName")]
        [Validation(Required=false)]
        public string ShiftScheduleName { get; set; }

    }

}
