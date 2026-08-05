// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class CreateLiveMessageAppRequest : TeaModel {
        /// <summary>
        /// <para>The application name. The name must be 2 to 16 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testApp</para>
        /// </summary>
        [NameInMap("AppName")]
        [Validation(Required=false)]
        public string AppName { get; set; }

        /// <summary>
        /// <para>The security audit mode. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>0: default value. Security audit is disabled.</description></item>
        /// <item><description>1: built-in security audit.</description></item>
        /// <item><description>2: custom security audit.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("AuditType")]
        [Validation(Required=false)]
        public int? AuditType { get; set; }

        /// <summary>
        /// <para>The URL for custom security audit. This parameter is required when custom security audit is selected (AuditType=2). The URL must start with http:// or https://, must not contain private IP addresses, and must not include port numbers. For the format of custom security audit content, see the following section.</para>
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
        /// <item><description>cn-shanghai: default value. Shanghai.</description></item>
        /// <item><description>ap-southeast-1: Singapore.</description></item>
        /// </list>
        /// <remarks>
        /// <para>When calling other interactive messaging API operations, the data center must be the same as the one specified when creating the interactive messaging application.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai</para>
        /// </summary>
        [NameInMap("DataCenter")]
        [Validation(Required=false)]
        public string DataCenter { get; set; }

        /// <summary>
        /// <para>The event callback URL for client logon, logout, join group, and leave group events. If this parameter is empty, event callbacks are disabled. For the callback API operations that are triggered, see <a href="https://help.aliyun.com/document_detail/2672836.html">Client access</a>. The event callback URL must start with http:// or https://, must not contain private IP addresses, and must not include port numbers. For the event callback format and callback authentication logic, see the following section.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://demo.aliyundoc.com/examplecallback">http://demo.aliyundoc.com/examplecallback</a></para>
        /// </summary>
        [NameInMap("EventCallbackUrl")]
        [Validation(Required=false)]
        public string EventCallbackUrl { get; set; }

        /// <summary>
        /// <para>The storage duration tier for group messages within the application. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>0: default value. Messages are stored for 30 days.</description></item>
        /// <item><description>1: messages are stored for 90 days.</description></item>
        /// <item><description>2: messages are stored for 180 days.</description></item>
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
