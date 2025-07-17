// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class GetRetcodeShareUrlRequest : TeaModel {
        /// <summary>
        /// <para>The project ID (PID) of the application.</para>
        /// <para>To obtain the application PID, log on to the Application Real-Time Monitoring Service (ARMS) console. In the left-side navigation pane, choose <b>Browser Monitoring</b>&gt;<b>Browser Monitoring</b>. Then, click the name of the application. The URL in the address bar contains the application PID, in the xxx format. As the browser is encoded, you must modify the PID. For example, if the PID in the URL is xxx%4074xxx, you must replace %40 with an at sign (@) to obtain xxx@74xxx.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>iioe7jcnuk@582846f37******</para>
        /// </summary>
        [NameInMap("Pid")]
        [Validation(Required=false)]
        public string Pid { get; set; }

    }

}
