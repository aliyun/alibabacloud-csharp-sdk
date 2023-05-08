// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribePropertyProcDetailRequest : TeaModel {
        /// <summary>
        /// The timestamp of last data collection. Unit: milliseconds.
        /// </summary>
        [NameInMap("Cmdline")]
        [Validation(Required=false)]
        public string Cmdline { get; set; }

        /// <summary>
        /// The timestamp when the process starts. Unit: milliseconds.
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// The name of the process.
        /// </summary>
        [NameInMap("Extend")]
        [Validation(Required=false)]
        public string Extend { get; set; }

        /// <summary>
        /// The startup parameter of the process.
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// The name or IP address of the server.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The public IP address of the server.
        /// </summary>
        [NameInMap("ProcTimeEnd")]
        [Validation(Required=false)]
        public long? ProcTimeEnd { get; set; }

        /// <summary>
        /// The number of the page to return. Default value: **1**.
        /// </summary>
        [NameInMap("ProcTimeStart")]
        [Validation(Required=false)]
        public long? ProcTimeStart { get; set; }

        /// <summary>
        /// 1648809853000
        /// </summary>
        [NameInMap("Remark")]
        [Validation(Required=false)]
        public string Remark { get; set; }

        /// <summary>
        /// The permission that is required to run the process.
        /// </summary>
        [NameInMap("User")]
        [Validation(Required=false)]
        public string User { get; set; }

        /// <summary>
        /// The private IP address of the server.
        /// </summary>
        [NameInMap("Uuid")]
        [Validation(Required=false)]
        public string Uuid { get; set; }

    }

}
