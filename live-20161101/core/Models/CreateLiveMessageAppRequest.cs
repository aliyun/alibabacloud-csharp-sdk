// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class CreateLiveMessageAppRequest : TeaModel {
        /// <summary>
        /// <para>The name of the application. The name must be 2 to 16 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testApp</para>
        /// </summary>
        [NameInMap("AppName")]
        [Validation(Required=false)]
        public string AppName { get; set; }

        /// <summary>
        /// <para>The content moderation method. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>0 (default): disables content moderation.</description></item>
        /// <item><description>1: uses built-in content moderation.</description></item>
        /// <item><description>2: uses custom content moderation.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("AuditType")]
        [Validation(Required=false)]
        public int? AuditType { get; set; }

        /// <summary>
        /// <para>The URL for content moderation. If you set AuditType to 2, you must specify this parameter. The URL must start with http:// or https:// and cannot contain a private IP address or a port number. For more information about custom content moderation, see the &quot;Custom content moderation&quot; section of this topic.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://demo.aliyundoc.com/exampleaudit">http://demo.aliyundoc.com/exampleaudit</a></para>
        /// </summary>
        [NameInMap("AuditUrl")]
        [Validation(Required=false)]
        public string AuditUrl { get; set; }

        /// <summary>
        /// <para>The data center. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>cn-shanghai (default)</description></item>
        /// <item><description>ap-southeast-1: Singapore</description></item>
        /// </list>
        /// <remarks>
        /// <para> When you call other operations to manage the interactive messaging application, you must specify the same data center in which the application is created.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai</para>
        /// </summary>
        [NameInMap("DataCenter")]
        [Validation(Required=false)]
        public string DataCenter { get; set; }

        /// <summary>
        /// <para>The callback URL for events, such as logon, logoff, and joining and leaving a group. If you leave this parameter empty, event callbacks are disabled. <a href="~~2672836~~"></a>The callback URL must start with http:// or https:// and cannot contain a private IP address or a port number. For information about the callback message format and authentication logic, see the &quot;Event callbacks&quot; and &quot;Callback authentication&quot; sections of this topic.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://demo.aliyundoc.com/examplecallback">http://demo.aliyundoc.com/examplecallback</a></para>
        /// </summary>
        [NameInMap("EventCallbackUrl")]
        [Validation(Required=false)]
        public string EventCallbackUrl { get; set; }

        /// <summary>
        /// <para>The retention period of group messages in the application. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>0 (default): 30 days.</description></item>
        /// <item><description>1: 90 days.</description></item>
        /// <item><description>2: 180 days.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("MsgLifeCycle")]
        [Validation(Required=false)]
        public int? MsgLifeCycle { get; set; }

    }

}
