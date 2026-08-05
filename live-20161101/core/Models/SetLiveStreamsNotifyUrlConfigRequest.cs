// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class SetLiveStreamsNotifyUrlConfigRequest : TeaModel {
        /// <summary>
        /// <para>The ingest domain.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>demo.aliyundoc.com</para>
        /// </summary>
        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        /// <summary>
        /// <para>The callback URL for exception events.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://4a7e5f08.r37.cpolar.top/live/Rsssd/call-back/streamStart">https://4a7e5f08.r37.cpolar.top/live/Rsssd/call-back/streamStart</a></para>
        /// </summary>
        [NameInMap("ExceptionNotifyUrl")]
        [Validation(Required=false)]
        public string ExceptionNotifyUrl { get; set; }

        /// <summary>
        /// <para>The authentication key.</para>
        /// <remarks>
        /// <para>This parameter is required when the NotifyReqAuth request parameter is set to <b>yes</b>.</para>
        /// </remarks>
        /// <para>Value requirements:</para>
        /// <list type="bullet">
        /// <item><description><para>16 to 64 characters in length.</para>
        /// </description></item>
        /// <item><description><para>Supports uppercase letters, lowercase letters, and digits.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>123456</para>
        /// </summary>
        [NameInMap("NotifyAuthKey")]
        [Validation(Required=false)]
        public string NotifyAuthKey { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable authentication. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>yes</b>: Enabled. If you set this parameter to <b>yes</b>, you must also set the NotifyAuthKey request parameter.</description></item>
        /// <item><description><b>no</b>: Disabled.</description></item>
        /// </list>
        /// <remarks>
        /// <para>If this parameter is not specified, the default value is <b>no</b>.</para>
        /// </remarks>
        /// <para>For the authentication logic, see <b>Stream ingest callback authentication description</b> below.</para>
        /// 
        /// <b>Example:</b>
        /// <para>yes</para>
        /// </summary>
        [NameInMap("NotifyReqAuth")]
        [Validation(Required=false)]
        public string NotifyReqAuth { get; set; }

        /// <summary>
        /// <para>The URL to which live stream information is pushed.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://guide.aliyundoc.com/notify">http://guide.aliyundoc.com/notify</a></para>
        /// </summary>
        [NameInMap("NotifyUrl")]
        [Validation(Required=false)]
        public string NotifyUrl { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The callback URL for stream switching information.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://guide.aliyundoc.com/switchnotify">http://guide.aliyundoc.com/switchnotify</a></para>
        /// </summary>
        [NameInMap("SwitchNotifyUrl")]
        [Validation(Required=false)]
        public string SwitchNotifyUrl { get; set; }

    }

}
