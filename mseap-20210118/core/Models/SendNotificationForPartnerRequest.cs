// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mseap20210118.Models
{
    public class SendNotificationForPartnerRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>DMP</para>
        /// </summary>
        [NameInMap("BizId")]
        [Validation(Required=false)]
        public string BizId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("ChannelType")]
        [Validation(Required=false)]
        public string ChannelType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>MESSAGE</para>
        /// </summary>
        [NameInMap("NotifyType")]
        [Validation(Required=false)]
        public string NotifyType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>dmp_website_xxx</para>
        /// </summary>
        [NameInMap("NotifycationEventType")]
        [Validation(Required=false)]
        public string NotifycationEventType { get; set; }

        [NameInMap("ParamMap")]
        [Validation(Required=false)]
        public Dictionary<string, string> ParamMap { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>12312212312</para>
        /// </summary>
        [NameInMap("SendTarget")]
        [Validation(Required=false)]
        public string SendTarget { get; set; }

        [NameInMap("SmartSubChannels")]
        [Validation(Required=false)]
        public List<string> SmartSubChannels { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>5b29647n-a172-4ccd-ba33-73669896c287</para>
        /// </summary>
        [NameInMap("TrackId")]
        [Validation(Required=false)]
        public string TrackId { get; set; }

    }

}
