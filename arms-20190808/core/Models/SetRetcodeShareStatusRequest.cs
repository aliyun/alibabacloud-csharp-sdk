// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class SetRetcodeShareStatusRequest : TeaModel {
        /// <summary>
        /// <para>The name of the application that is monitored by Browser Monitoring.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test-app</para>
        /// </summary>
        [NameInMap("AppName")]
        [Validation(Required=false)]
        public string AppName { get; set; }

        /// <summary>
        /// <para>The process identifier (PID) of the application. </para>
        /// <para>Log on to the <b>ARMS console</b>. In the left-side navigation pane, choose <b>Browser Monitoring</b> &gt; <b>Browser Monitoring</b>. On the Browser Monitoring page, click the name of an application. The URL in the address bar contains the process ID (PID) of the application. The PID is indicated in the <c>pid=xxx</c> format. The PID is usually percent encoded as <c>xxx%40xxx</c>. You must modify this value to remove the percent encoding. For example, if the PID in the URL is <c>eb4zdose6v%409781be0f44d****</c>, you must replace <c>%40</c> with @ to obtain <c>eb4zdose6v@9781be0f44d****</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>atc889zkcf@d8deedfa9bf****</para>
        /// </summary>
        [NameInMap("Pid")]
        [Validation(Required=false)]
        public string Pid { get; set; }

        /// <summary>
        /// <para>Specifies whether to turn on or turn off the logon-free sharing switch. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>true</c>: Turn on the switch.</description></item>
        /// <item><description><c>false</c>: Turn off the switch.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public bool? Status { get; set; }

    }

}
