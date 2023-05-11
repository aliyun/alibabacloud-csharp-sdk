// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class QueryEdgeDriverRequest : TeaModel {
        /// <summary>
        /// The number of the page to return. Default value: 1. If you specify a value smaller than 1, pages start from page 1.
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// The name of the driver whose information is to be queried. If you want to query information about drivers with a specific name, set this parameter.
        /// </summary>
        [NameInMap("DriverName")]
        [Validation(Required=false)]
        public string DriverName { get; set; }

        /// <summary>
        /// The ID of the Internet of Things (IoT) service instance. This parameter is not required for public instances. However, this parameter is required for the instances that you have purchased.
        /// </summary>
        [NameInMap("IotInstanceId")]
        [Validation(Required=false)]
        public string IotInstanceId { get; set; }

        /// <summary>
        /// The number of entries to return on each page. Maximum value: 30. Default value: 10. If you specify a value smaller than 1, a maximum of 10 entries are displayed on each page.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The type of the driver whose information is to be queried. Valid values:
        /// 
        /// *   0: official driver
        /// *   1: custom driver
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public int? Type { get; set; }

    }

}
