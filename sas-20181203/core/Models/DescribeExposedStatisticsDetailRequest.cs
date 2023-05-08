// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeExposedStatisticsDetailRequest : TeaModel {
        /// <summary>
        /// The number of entries returned on the current page.
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// The ID of the gateway asset. This parameter is required when the **StatisticsType** parameter is set to **exposureType**.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The number of entries to return on each page. Default value: 20. If you leave this parameter empty, 20 entries are returned on each page.
        /// 
        /// >  We recommend that you do not leave this parameter empty.
        /// </summary>
        [NameInMap("StatisticsType")]
        [Validation(Required=false)]
        public string StatisticsType { get; set; }

        /// <summary>
        /// The system component that is exposed on the Internet.
        /// </summary>
        [NameInMap("StatisticsTypeGatewayType")]
        [Validation(Required=false)]
        public string StatisticsTypeGatewayType { get; set; }

        /// <summary>
        /// The pagination information.
        /// </summary>
        [NameInMap("StatisticsTypeInstanceValue")]
        [Validation(Required=false)]
        public string StatisticsTypeInstanceValue { get; set; }

    }

}
