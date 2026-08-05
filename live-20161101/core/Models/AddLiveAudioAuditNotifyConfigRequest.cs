// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class AddLiveAudioAuditNotifyConfigRequest : TeaModel {
        /// <summary>
        /// <para>The URL used to receive callbacks for audio that contains problematic content.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://demo.aliyundoc.com/callback">https://demo.aliyundoc.com/callback</a></para>
        /// </summary>
        [NameInMap("Callback")]
        [Validation(Required=false)]
        public string Callback { get; set; }

        /// <summary>
        /// <para>The callback template for automated reviews. The value is a JSON string that can contain the following variables:</para>
        /// <list type="bullet">
        /// <item><description><para><b>{DomainName}</b>: The streaming domain.</para>
        /// </description></item>
        /// <item><description><para><b>{AppName}</b>: The AppName of the live stream.</para>
        /// </description></item>
        /// <item><description><para><b>{StreamName}</b>: The stream name.</para>
        /// </description></item>
        /// <item><description><para><b>{Timestamp}</b>: The UNIX timestamp of the callback. Unit: seconds.</para>
        /// </description></item>
        /// <item><description><para><b>{Result}</b>: The review result.</para>
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
