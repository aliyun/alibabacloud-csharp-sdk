// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class SetMessageCallbackRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the application. If you leave this parameter empty, the default value <b>app-1000000</b> is used.</para>
        /// 
        /// <b>Example:</b>
        /// <para>app-1000000</para>
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// <para>The authentication key. The key can be up to 32 characters in length and must contain uppercase letters, lowercase letters, and digits. This parameter takes effect only when you set CallbackType to <b>HTTP</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Dsf346dvet</para>
        /// </summary>
        [NameInMap("AuthKey")]
        [Validation(Required=false)]
        public string AuthKey { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable callback authentication. This parameter takes effect only when you set CallbackType to <b>HTTP</b>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>on</b></description></item>
        /// <item><description><b>off</b></description></item>
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
        /// <item><description><b>Simple Message Queue(formerly MNS)</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>HTTP</para>
        /// </summary>
        [NameInMap("CallbackType")]
        [Validation(Required=false)]
        public string CallbackType { get; set; }

        /// <summary>
        /// <para>The callback URL. This parameter is required if you set CallbackType to <b>HTTP</b>. The callback URL cannot exceed 256 bytes in length. You can specify only one callback URL.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://developer.aliyundoc.com">http://developer.aliyundoc.com</a></para>
        /// </summary>
        [NameInMap("CallbackURL")]
        [Validation(Required=false)]
        public string CallbackURL { get; set; }

        /// <summary>
        /// <para>The type of the callback event. If you do not set this parameter, notifications for all types of events are disabled. If you set this parameter to <b>ALL</b>, notifications for all types of events are enabled. You can specify the event types for which notifications are enabled. Separate multiple event types with commas (,). For more information about the valid values of this parameter, see <a href="https://help.aliyun.com/document_detail/55627.html">Overview</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>FileUploadComplete</para>
        /// </summary>
        [NameInMap("EventTypeList")]
        [Validation(Required=false)]
        public string EventTypeList { get; set; }

        /// <summary>
        /// <para>The public endpoint of Message Service (MNS). This parameter only takes effect when the CallbackType parameter is set to <b>Simple Message Queue(formerly MNS)</b>. To obtain the public endpoint, log on to the <a href="https://account.aliyun.com/login/login.html">Simple Message Queue(formerly MNS) console</a> and click <b>Get Endpoint</b> in the upper-right corner of the Topics page. For more information, see <a href="https://help.aliyun.com/document_detail/27480.html">Endpoint</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>http://****.mns.cn-shanghai.aliyuncs.com/</para>
        /// </summary>
        [NameInMap("MnsEndpoint")]
        [Validation(Required=false)]
        public string MnsEndpoint { get; set; }

        /// <summary>
        /// <para>The name of the Simple Message Queue(formerly MNS). You can obtain the name of the Simple Message Queue(formerly MNS) on the <b>Queues</b> page in the <a href="https://account.aliyun.com/login/login.html">Simple Message Queue(formerly MNS) console</a>. This parameter is required when you set CallbackType to <b>Simple Message Queue(formerly MNS)</b>.</para>
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
