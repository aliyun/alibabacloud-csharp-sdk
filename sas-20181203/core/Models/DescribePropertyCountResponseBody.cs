// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribePropertyCountResponseBody : TeaModel {
        [NameInMap("Autorun")]
        [Validation(Required=false)]
        public int? Autorun { get; set; }

        /// <summary>
        /// The number of middleware assets.
        /// </summary>
        [NameInMap("Cron")]
        [Validation(Required=false)]
        public int? Cron { get; set; }

        /// <summary>
        /// DescribePropertyCount
        /// </summary>
        [NameInMap("Database")]
        [Validation(Required=false)]
        public int? Database { get; set; }

        [NameInMap("Lkm")]
        [Validation(Required=false)]
        public int? Lkm { get; set; }

        /// <summary>
        /// The ID of the request, which is used to locate and troubleshoot issues.
        /// </summary>
        [NameInMap("Port")]
        [Validation(Required=false)]
        public int? Port { get; set; }

        /// <summary>
        /// The number of accounts.
        /// </summary>
        [NameInMap("Process")]
        [Validation(Required=false)]
        public int? Process { get; set; }

        /// <summary>
        /// The number of processes.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// port,process
        /// </summary>
        [NameInMap("Sca")]
        [Validation(Required=false)]
        public int? Sca { get; set; }

        /// <summary>
        /// The number of web services.
        /// </summary>
        [NameInMap("Software")]
        [Validation(Required=false)]
        public int? Software { get; set; }

        /// <summary>
        /// The number of websites.
        /// </summary>
        [NameInMap("User")]
        [Validation(Required=false)]
        public int? User { get; set; }

        /// <summary>
        /// Queries the statistics of asset fingerprints. The assets include processes, ports, software, accounts, middleware, websites, web services, scheduled tasks, startup items, and databases.
        /// </summary>
        [NameInMap("Web")]
        [Validation(Required=false)]
        public int? Web { get; set; }

        [NameInMap("Webserver")]
        [Validation(Required=false)]
        public int? Webserver { get; set; }

    }

}
