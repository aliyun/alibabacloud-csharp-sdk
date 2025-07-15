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
        /// <para>Exception event callback URL.</para>
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
        /// <para> This parameter is required if you set the NotifyReqAuth parameter to <b>yes</b>.</para>
        /// </remarks>
        /// <para>Value requirements:</para>
        /// <list type="bullet">
        /// <item><description>The key must be 16 to 64 characters in length.</description></item>
        /// <item><description>The key can contain letters and digits.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>123456</para>
        /// </summary>
        [NameInMap("NotifyAuthKey")]
        [Validation(Required=false)]
        public string NotifyAuthKey { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable callback authentication. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>yes</b>: enables callback authentication. If you set this parameter to <b>yes</b>, you must also specify the NotifyAuthKey parameter.</description></item>
        /// <item><description><b>no</b>: disables callback authentication.</description></item>
        /// </list>
        /// <remarks>
        /// <para> If you do not specify this parameter, the default value <b>no</b> is used.</para>
        /// </remarks>
        /// <para>For information about the authentication logic, see <b>Authentication for stream ingest callbacks</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>yes</para>
        /// </summary>
        [NameInMap("NotifyReqAuth")]
        [Validation(Required=false)]
        public string NotifyReqAuth { get; set; }

        /// <summary>
        /// <para>The URL to which the stream ingest callbacks are sent.</para>
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

        [NameInMap("SwitchNotifyUrl")]
        [Validation(Required=false)]
        public string SwitchNotifyUrl { get; set; }

    }

}
