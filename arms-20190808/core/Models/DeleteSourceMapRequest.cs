// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class DeleteSourceMapRequest : TeaModel {
        /// <summary>
        /// The ID of the SourceMap file.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("FidList")]
        [Validation(Required=false)]
        public List<string> FidList { get; set; }

        /// <summary>
        /// The process ID (PID) of the application.
        /// 
        /// Log on to the ARMS console. In the left-side navigation pane, choose **Browser Monitoring** > **Browser Monitoring**. On the **Browser Monitoring** page, click the name of an application. The URL in the browser address bar contains the PID of this application in the format of `pid=xxx`. As the browser is encoded, the PID needs to be modified. Assume that the PID contained is `xxx%4074xxx`. You need to **replace** \\*\\*%40 with @\\*\\* and change the PID to `xxx@74xxx`.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Pid")]
        [Validation(Required=false)]
        public string Pid { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
