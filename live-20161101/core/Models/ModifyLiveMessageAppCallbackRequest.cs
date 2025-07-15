// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class ModifyLiveMessageAppCallbackRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the interactive messaging application whose callback settings you want to modify.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>demo</para>
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// <para>The data center. It must be the same as the data center that was specified when you called the <a href="https://help.aliyun.com/document_detail/2848162.html">CreateLiveMessageApp</a> operation to create the interactive messaging application. Valid values: cn-shanghai and ap-southeast-1 (Singapore).</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai</para>
        /// </summary>
        [NameInMap("DataCenter")]
        [Validation(Required=false)]
        public string DataCenter { get; set; }

        /// <summary>
        /// <para>The callback URL for events such as user logon, logoff, joining a group, and leaving a group. If you leave this parameter empty, callbacks are disabled. The callback URL must start with http:// or https:// and cannot contain a private IP address or a port number.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://example.aliyundoc.com/examplecallback">http://example.aliyundoc.com/examplecallback</a></para>
        /// </summary>
        [NameInMap("EventCallbackUrl")]
        [Validation(Required=false)]
        public string EventCallbackUrl { get; set; }

    }

}
