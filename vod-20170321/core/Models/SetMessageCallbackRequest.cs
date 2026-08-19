// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class SetMessageCallbackRequest : TeaModel {
        /// <summary>
        /// <para>The application ID. If this parameter is not specified, the ID of the default application is used, which is the fixed value: <b>app-1000000</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>app-1000000</para>
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// <para>The authentication key. The key can be up to 32 characters in length and must contain uppercase letters, lowercase letters, and digits. This parameter can be set when the callback method is <b>HTTP</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Dsf346dvet</para>
        /// </summary>
        [NameInMap("AuthKey")]
        [Validation(Required=false)]
        public string AuthKey { get; set; }

        /// <summary>
        /// <para>The authentication switch for HTTP callbacks. This parameter takes effect only when the callback method is set to <b>HTTP</b>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>on</b>: enabled.</description></item>
        /// <item><description><b>off</b>: disabled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>on</para>
        /// </summary>
        [NameInMap("AuthSwitch")]
        [Validation(Required=false)]
        public string AuthSwitch { get; set; }

        /// <summary>
        /// <para>The callback method. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>HTTP</b></description></item>
        /// <item><description><b>Simple Message Queue (formerly MNS)</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>HTTP</para>
        /// </summary>
        [NameInMap("CallbackType")]
        [Validation(Required=false)]
        public string CallbackType { get; set; }

        /// <summary>
        /// <para>The callback URL. This parameter is required when the callback method is set to <b>HTTP</b>.
        /// The callback URL cannot exceed 256 bytes in length. Multiple callback URLs are not supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://developer.aliyundoc.com">http://developer.aliyundoc.com</a></para>
        /// </summary>
        [NameInMap("CallbackURL")]
        [Validation(Required=false)]
        public string CallbackURL { get; set; }

        /// <summary>
        /// <para>The event types for callbacks. If this parameter is left empty, all notifications are disabled. If this parameter is set to <b>ALL</b>, all notifications are enabled. You can also specify specific event types, separated by commas (,). For the valid event types, see <a href="https://help.aliyun.com/document_detail/55627.html">Event types</a>.</para>
        /// <para>&lt;props=&quot;china&quot;&gt;</para>
        /// <remarks>
        /// <para>All AI-related events such as AIMediaAuditComplete and AIMediaDNAComplete use the value <b>AIComplete</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>FileUploadComplete</para>
        /// </summary>
        [NameInMap("EventTypeList")]
        [Validation(Required=false)]
        public string EventTypeList { get; set; }

        /// <summary>
        /// <para>The public endpoint of Simple Message Queue (formerly MNS). This parameter is required when the callback method is set to <b>Simple Message Queue (formerly MNS)</b>. Log on to the <a href="https://account.aliyun.com/login/login.html">Simple Message Queue (formerly MNS) console</a> and click the <b>Get Endpoint</b> button in the upper-right corner to obtain the endpoint. For more information, see <a href="https://help.aliyun.com/document_detail/27480.html">Endpoint</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>http://****.mns.cn-shanghai.aliyuncs.com/</para>
        /// </summary>
        [NameInMap("MnsEndpoint")]
        [Validation(Required=false)]
        public string MnsEndpoint { get; set; }

        /// <summary>
        /// <para>The name of the message queue. Log on to the <a href="https://account.aliyun.com/login/login.html">Simple Message Queue (formerly MNS) console</a> and view the queue in the <b>Queue List</b>. This parameter is required when the callback method is set to <b>Simple Message Queue (formerly MNS)</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>quene_name</para>
        /// </summary>
        [NameInMap("MnsQueueName")]
        [Validation(Required=false)]
        public string MnsQueueName { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

    }

}
