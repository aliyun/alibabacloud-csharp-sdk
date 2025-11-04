// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class UpdateLiveRecordNotifyConfigRequest : TeaModel {
        /// <summary>
        /// <para>The main streaming domain.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example.com</para>
        /// </summary>
        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable callbacks for recording status. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b></description></item>
        /// <item><description><b>false</b> (default)</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("NeedStatusNotify")]
        [Validation(Required=false)]
        public bool? NeedStatusNotify { get; set; }

        [NameInMap("NotifyAuthKey")]
        [Validation(Required=false)]
        public string NotifyAuthKey { get; set; }

        [NameInMap("NotifyReqAuth")]
        [Validation(Required=false)]
        public bool? NotifyReqAuth { get; set; }

        /// <summary>
        /// <para>The callback URL that is used to receive notifications about recording events and status.</para>
        /// <remarks>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description><para>The URL must start with <c>http://</c> or <c>https://</c>.</para>
        /// </description></item>
        /// <item><description><para>You must use URLEncoder for encoding. This way, the system can identify Chinese characters, spaces, and special characters.</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://learn.aliyundoc.com/examplecallback.action">http://learn.aliyundoc.com/examplecallback.action</a></para>
        /// </summary>
        [NameInMap("NotifyUrl")]
        [Validation(Required=false)]
        public string NotifyUrl { get; set; }

        /// <summary>
        /// <para>The callback URL for on-demand recordings.</para>
        /// <remarks>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description><para>The URL must start with <c>http://</c> or <c>https://</c>.</para>
        /// </description></item>
        /// <item><description><para>You must use URLEncoder for encoding. This way, the system can identify Chinese characters, spaces, and special characters.</para>
        /// </description></item>
        /// </list>
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
