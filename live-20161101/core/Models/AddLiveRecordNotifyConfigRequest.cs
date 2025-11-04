// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class AddLiveRecordNotifyConfigRequest : TeaModel {
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
        /// <item><description>true: enables callbacks for recording status. If you set this parameter to <b>true</b>, an example of recording status callback is returned.</description></item>
        /// <item><description>false (default): disables callbacks for recording status.</description></item>
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
        /// <para> The URL must start with <c>http://</c> or <c>https://</c>. For more information, see <a href="https://help.aliyun.com/document_detail/55016.html">Callbacks for live stream recording</a>.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://demo.aliyundoc.com/examplecallback.action">http://demo.aliyundoc.com/examplecallback.action</a></para>
        /// </summary>
        [NameInMap("NotifyUrl")]
        [Validation(Required=false)]
        public string NotifyUrl { get; set; }

        /// <summary>
        /// <para>The callback URL for on-demand recordings.</para>
        /// <remarks>
        /// <para> The URL must start with <c>http://</c> or <c>https://</c>. For more information, see <a href="https://help.aliyun.com/document_detail/85910.html">On-demand recording</a>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://learn.aliyundoc.com/ondemandcallback.action">http://learn.aliyundoc.com/ondemandcallback.action</a></para>
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
