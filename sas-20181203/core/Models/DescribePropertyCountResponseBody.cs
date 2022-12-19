// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribePropertyCountResponseBody : TeaModel {
        /// <summary>
        /// The number of startup items.
        /// </summary>
        [NameInMap("Autorun")]
        [Validation(Required=false)]
        public int? Autorun { get; set; }

        /// <summary>
        /// The number of scheduled tasks.
        /// </summary>
        [NameInMap("Cron")]
        [Validation(Required=false)]
        public int? Cron { get; set; }

        /// <summary>
        /// The number of databases.
        /// </summary>
        [NameInMap("Database")]
        [Validation(Required=false)]
        public int? Database { get; set; }

        /// <summary>
        /// The number of kernel modules.
        /// </summary>
        [NameInMap("Lkm")]
        [Validation(Required=false)]
        public int? Lkm { get; set; }

        /// <summary>
        /// The number of ports.
        /// </summary>
        [NameInMap("Port")]
        [Validation(Required=false)]
        public int? Port { get; set; }

        /// <summary>
        /// The number of processes.
        /// </summary>
        [NameInMap("Process")]
        [Validation(Required=false)]
        public int? Process { get; set; }

        /// <summary>
        /// The ID of the request, which is used to locate and troubleshoot issues.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The number of middleware assets.
        /// </summary>
        [NameInMap("Sca")]
        [Validation(Required=false)]
        public int? Sca { get; set; }

        /// <summary>
        /// The number of software assets.
        /// </summary>
        [NameInMap("Software")]
        [Validation(Required=false)]
        public int? Software { get; set; }

        /// <summary>
        /// The number of accounts.
        /// </summary>
        [NameInMap("User")]
        [Validation(Required=false)]
        public int? User { get; set; }

        /// <summary>
        /// The number of websites.
        /// </summary>
        [NameInMap("Web")]
        [Validation(Required=false)]
        public int? Web { get; set; }

        /// <summary>
        /// The number of web services.
        /// </summary>
        [NameInMap("Webserver")]
        [Validation(Required=false)]
        public int? Webserver { get; set; }

    }

}
