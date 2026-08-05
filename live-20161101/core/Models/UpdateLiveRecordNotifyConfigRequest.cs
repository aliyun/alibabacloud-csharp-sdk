// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class UpdateLiveRecordNotifyConfigRequest : TeaModel {
        /// <summary>
        /// <para>The streaming domain of the streamer.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example.com</para>
        /// </summary>
        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        /// <summary>
        /// <para>Specifies whether recording task status callbacks are required. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: Recording task status callbacks are required.</description></item>
        /// <item><description><b>false</b> (default): Recording task status callbacks are not required.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("NeedStatusNotify")]
        [Validation(Required=false)]
        public bool? NeedStatusNotify { get; set; }

        /// <summary>
        /// <para>The callback authentication key. The key is 16 to 32 characters in length and can contain only letters and digits.</para>
        /// <remarks>
        /// <para>This parameter is required when the NotifyReqAuth parameter is set to <b>true</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>testkeyyourkey12</para>
        /// </summary>
        [NameInMap("NotifyAuthKey")]
        [Validation(Required=false)]
        public string NotifyAuthKey { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable callback authentication. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: Enabled.</para>
        /// </description></item>
        /// <item><description><para><b>false</b>: Disabled.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>Default value: <b>false</b>. If this parameter is set to <b>true</b>, the NotifyAuthKey parameter is required.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("NotifyReqAuth")]
        [Validation(Required=false)]
        public bool? NotifyReqAuth { get; set; }

        /// <summary>
        /// <para>The callback URL for recording events, including event callbacks and status callbacks.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>The URL must start with <c>http://</c> or <c>https://</c>.</description></item>
        /// <item><description>To properly identify Chinese characters, spaces, and other special characters in the input, perform URL encoding.</description></item>
        /// </list>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://learn.aliyundoc.com/examplecallback.action">http://learn.aliyundoc.com/examplecallback.action</a></para>
        /// </summary>
        [NameInMap("NotifyUrl")]
        [Validation(Required=false)]
        public string NotifyUrl { get; set; }

        /// <summary>
        /// <para>The on-demand recording callback URL.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>The URL must start with <c>http://</c> or <c>https://</c>.</description></item>
        /// <item><description>To properly identify Chinese characters, spaces, and other special characters in the input, perform URL encoding.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://guide.aliyundoc.com/ondemandcallback.action">http://guide.aliyundoc.com/ondemandcallback.action</a></para>
        /// </summary>
        [NameInMap("OnDemandUrl")]
        [Validation(Required=false)]
        public string OnDemandUrl { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

    }

}
