// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class AddLiveRecordNotifyConfigRequest : TeaModel {
        /// <summary>
        /// <para>The streamer streaming domain.</para>
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
        /// <item><description>true: Required. If NeedStatusNotify is set to <b>true</b>, the response includes a recording status callback example.</description></item>
        /// <item><description>false (default): Not required.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("NeedStatusNotify")]
        [Validation(Required=false)]
        public bool? NeedStatusNotify { get; set; }

        /// <summary>
        /// <para>The callback authentication key. The key must be 16 to 32 characters in length and can contain only letters and digits.</para>
        /// <remarks>
        /// <para>This parameter is required when the NotifyReqAuth parameter is set to true.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>chenhuanxin249088</para>
        /// </summary>
        [NameInMap("NotifyAuthKey")]
        [Validation(Required=false)]
        public string NotifyAuthKey { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable callback authentication. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>true: Enabled.</para>
        /// </description></item>
        /// <item><description><para>false (default): Disabled.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>When this parameter is set to true, the NotifyAuthKey parameter is required.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("NotifyReqAuth")]
        [Validation(Required=false)]
        public bool? NotifyReqAuth { get; set; }

        /// <summary>
        /// <para>The callback URL for recording events and status callbacks.</para>
        /// <remarks>
        /// <para>The URL must start with <c>http://</c> or <c>https://</c>. For more information, see <a href="https://help.aliyun.com/document_detail/55016.html">Recording event callback</a>.</para>
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
        /// <para>The callback URL for on-demand recording.</para>
        /// <remarks>
        /// <para>The URL must start with <c>http://</c> or <c>https://</c>. For more information, see <a href="https://help.aliyun.com/document_detail/85910.html">On-demand recording callback</a>.</para>
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
