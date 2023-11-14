// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribePropertyPortDetailRequest : TeaModel {
        /// <summary>
        /// The IP address that is bound to the listening port.
        /// </summary>
        [NameInMap("BindIp")]
        [Validation(Required=false)]
        public string BindIp { get; set; }

        /// <summary>
        /// The number of the page to return. Default value: **1**.
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// Specifies whether fuzzy search by port number is supported. If you want to use fuzzy search, set the parameter to **1**. If you set the parameter to a different value or leave the parameter empty, fuzzy search is not supported.
        /// </summary>
        [NameInMap("Extend")]
        [Validation(Required=false)]
        public string Extend { get; set; }

        /// <summary>
        /// The number of entries to return on each page. Default value: **10**.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The listening port of the server.
        /// </summary>
        [NameInMap("Port")]
        [Validation(Required=false)]
        public string Port { get; set; }

        /// <summary>
        /// The name of the server process.
        /// </summary>
        [NameInMap("ProcName")]
        [Validation(Required=false)]
        public string ProcName { get; set; }

        /// <summary>
        /// The name or IP address of the server.
        /// </summary>
        [NameInMap("Remark")]
        [Validation(Required=false)]
        public string Remark { get; set; }

        [NameInMap("ResourceDirectoryAccountId")]
        [Validation(Required=false)]
        public long? ResourceDirectoryAccountId { get; set; }

        /// <summary>
        /// The UUID of the server.
        /// </summary>
        [NameInMap("Uuid")]
        [Validation(Required=false)]
        public string Uuid { get; set; }

    }

}
