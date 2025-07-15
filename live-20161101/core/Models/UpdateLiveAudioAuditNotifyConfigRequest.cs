// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class UpdateLiveAudioAuditNotifyConfigRequest : TeaModel {
        /// <summary>
        /// <para>The callback URL. This URL is used to receive callback notifications about violations in audio.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://guide.aliyundoc.com/callback">http://guide.aliyundoc.com/callback</a></para>
        /// </summary>
        [NameInMap("Callback")]
        [Validation(Required=false)]
        public string Callback { get; set; }

        /// <summary>
        /// <para>The callback template. Configure the following fields:</para>
        /// <list type="bullet">
        /// <item><description><b>{DomainName}</b>: the streaming domain.</description></item>
        /// <item><description><b>{AppName}</b>: the name of the application to which the live stream belongs.</description></item>
        /// <item><description><b>{StreamName}</b>: the name of the live stream.</description></item>
        /// <item><description><b>{Timestamp}</b>: the time when the callback is returned. The value of this field is a UNIX timestamp. Unit: seconds.</description></item>
        /// <item><description><b>{Result}</b>: the moderation results.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;domain&quot;:{DomainName},&quot;app&quot;:{AppName},&quot;stream&quot;:{StreamName},&quot;timestamp&quot;:{Timestamp},&quot;result&quot;:{Result}}</para>
        /// </summary>
        [NameInMap("CallbackTemplate")]
        [Validation(Required=false)]
        public string CallbackTemplate { get; set; }

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

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
