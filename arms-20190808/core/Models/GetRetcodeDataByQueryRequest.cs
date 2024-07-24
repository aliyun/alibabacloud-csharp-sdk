// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class GetRetcodeDataByQueryRequest : TeaModel {
        /// <summary>
        /// The beginning of the time range to query. This value is a UNIX timestamp representing the number of seconds that have elapsed since the epoch time January 1, 1970, 00:00:00 UTC.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("From")]
        [Validation(Required=false)]
        public long? From { get; set; }

        /// <summary>
        /// The ID of the application.
        /// 
        /// Log on to the **ARMS console**. In the left-side navigation pane, choose **Browser Monitoring** > **Browser Monitoring**. On the Browser Monitoring page, click the name of an application. The URL in the address bar contains the process ID (PID) of the application. The PID is indicated in the pid=xxx format. The PID is usually percent encoded as xxx%40xxx. You must modify this value to remove the percent encoding. For example, if the PID in the URL is eb4zdose6v%409781be0f44d\\*\\*\\*\\*, you must replace %40 with an at sign (@) to obtain eb4zdose6v@9781be0f44d\\*\\*\\*\\*.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Pid")]
        [Validation(Required=false)]
        public string Pid { get; set; }

        /// <summary>
        /// The query statement that conforms to the query syntax of a Log Service Logstore.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Query")]
        [Validation(Required=false)]
        public string Query { get; set; }

        /// <summary>
        /// The region ID.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The end of the time range to query. This value is a UNIX timestamp representing the number of seconds that have elapsed since the epoch time January 1, 1970, 00:00:00 UTC.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("To")]
        [Validation(Required=false)]
        public long? To { get; set; }

    }

}
