// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class UpdateLiveAudioAuditNotifyConfigRequest : TeaModel {
        /// <summary>
        /// <para>The webhook URL for receiving callback notifications about audio that contains violations.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://guide.aliyundoc.com/callback">http://guide.aliyundoc.com/callback</a></para>
        /// </summary>
        [NameInMap("Callback")]
        [Validation(Required=false)]
        public string Callback { get; set; }

        /// <summary>
        /// <para>The callback template for automated review. The value can contain the following variables:</para>
        /// <list type="bullet">
        /// <item><description><para><b>{DomainName}</b>: The streaming domain.</para>
        /// </description></item>
        /// <item><description><para><b>{AppName}</b>: The AppName of the stream.</para>
        /// </description></item>
        /// <item><description><para><b>{StreamName}</b>: The stream name.</para>
        /// </description></item>
        /// <item><description><para><b>{Timestamp}</b>: The UNIX timestamp when the callback is generated. Unit: seconds.</para>
        /// </description></item>
        /// <item><description><para><b>{Result}</b>: The detection result.</para>
        /// </description></item>
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

        /// <summary>
        /// <para>The region ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
