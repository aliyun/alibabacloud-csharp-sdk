// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribePropertySoftwareDetailRequest : TeaModel {
        /// <summary>
        /// The page number. Default value: **1**.
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// Specifies whether fuzzy search by software name is supported. If you want to use fuzzy search, set the parameter to 1. If you set the parameter to a different value or leave the parameter empty, fuzzy search is not supported.
        /// </summary>
        [NameInMap("Extend")]
        [Validation(Required=false)]
        public string Extend { get; set; }

        /// <summary>
        /// The timestamp generated when the software update ends. Unit: milliseconds.
        /// </summary>
        [NameInMap("InstallTimeEnd")]
        [Validation(Required=false)]
        public long? InstallTimeEnd { get; set; }

        /// <summary>
        /// The timestamp generated when the software update starts. Unit: milliseconds.
        /// </summary>
        [NameInMap("InstallTimeStart")]
        [Validation(Required=false)]
        public long? InstallTimeStart { get; set; }

        /// <summary>
        /// The name of the software.
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// The number of entries per page. Default value: **10**.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The installation path of the software.
        /// </summary>
        [NameInMap("Path")]
        [Validation(Required=false)]
        public string Path { get; set; }

        /// <summary>
        /// The name or IP address of the server.
        /// </summary>
        [NameInMap("Remark")]
        [Validation(Required=false)]
        public string Remark { get; set; }

        /// <summary>
        /// The version of the software.
        /// </summary>
        [NameInMap("SoftwareVersion")]
        [Validation(Required=false)]
        public string SoftwareVersion { get; set; }

        /// <summary>
        /// The UUID of the server.
        /// </summary>
        [NameInMap("Uuid")]
        [Validation(Required=false)]
        public string Uuid { get; set; }

    }

}
