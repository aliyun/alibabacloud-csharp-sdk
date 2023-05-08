// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribePropertySoftwareDetailRequest : TeaModel {
        /// <summary>
        /// The name of the software.
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// 10
        /// </summary>
        [NameInMap("Extend")]
        [Validation(Required=false)]
        public string Extend { get; set; }

        /// <summary>
        /// 3.10.0
        /// </summary>
        [NameInMap("InstallTimeEnd")]
        [Validation(Required=false)]
        public long? InstallTimeEnd { get; set; }

        /// <summary>
        /// The name of the software.
        /// </summary>
        [NameInMap("InstallTimeStart")]
        [Validation(Required=false)]
        public long? InstallTimeStart { get; set; }

        /// <summary>
        /// The details of the software asset.
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// The number of entries to return on each page. Default value: **10**.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The name or IP address of the server.
        /// </summary>
        [NameInMap("Path")]
        [Validation(Required=false)]
        public string Path { get; set; }

        /// <summary>
        /// The private IP address of the server.
        /// </summary>
        [NameInMap("Remark")]
        [Validation(Required=false)]
        public string Remark { get; set; }

        /// <summary>
        /// The number of the page to return. Default value: **1**.
        /// </summary>
        [NameInMap("SoftwareVersion")]
        [Validation(Required=false)]
        public string SoftwareVersion { get; set; }

        /// <summary>
        /// The public IP address of the server.
        /// </summary>
        [NameInMap("Uuid")]
        [Validation(Required=false)]
        public string Uuid { get; set; }

    }

}
