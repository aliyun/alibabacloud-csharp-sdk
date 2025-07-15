// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class ModifyLiveMessageAppCallbackResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the interactive messaging application.</para>
        /// 
        /// <b>Example:</b>
        /// <para>demo</para>
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// <para>The signature of the interactive messaging application. It is required by the interactive messaging SDK.</para>
        /// 
        /// <b>Example:</b>
        /// <hr>
        /// </summary>
        [NameInMap("AppSign")]
        [Validation(Required=false)]
        public string AppSign { get; set; }

        /// <summary>
        /// <para>Indicates whether authentication is required for event callbacks. Default value: true.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("EventCallbackNeedAuthentication")]
        [Validation(Required=false)]
        public bool? EventCallbackNeedAuthentication { get; set; }

        /// <summary>
        /// <para>The callback URL for events such as user logon, logoff, joining a group, and leaving a group. This parameter is not returned if it has an empty value.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://example.aliyundoc.com/examplecallback">http://example.aliyundoc.com/examplecallback</a></para>
        /// </summary>
        [NameInMap("EventCallbackUrl")]
        [Validation(Required=false)]
        public string EventCallbackUrl { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1F0FFEAD-B7D5-1D4A-A6B9-8C63ADF6****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
