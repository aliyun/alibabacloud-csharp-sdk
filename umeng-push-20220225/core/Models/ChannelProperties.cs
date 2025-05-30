// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Umeng_push20220225.Models
{
    public class ChannelProperties : TeaModel {
        [NameInMap("channelActivity")]
        [Validation(Required=false)]
        public string ChannelActivity { get; set; }

        [NameInMap("channelFcm")]
        [Validation(Required=false)]
        public string ChannelFcm { get; set; }

        [NameInMap("harmonyChannelCategory")]
        [Validation(Required=false)]
        public string HarmonyChannelCategory { get; set; }

        [NameInMap("huaweiChannelCategory")]
        [Validation(Required=false)]
        public string HuaweiChannelCategory { get; set; }

        [NameInMap("huaweiChannelImportance")]
        [Validation(Required=false)]
        public string HuaweiChannelImportance { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>取值为&quot;NORMAL&quot;和&quot;HIGH&quot;,默认为”NORMAL”</para>
        /// </summary>
        [NameInMap("huaweiMessageUrgency")]
        [Validation(Required=false)]
        public string HuaweiMessageUrgency { get; set; }

        [NameInMap("mainActivity")]
        [Validation(Required=false)]
        public string MainActivity { get; set; }

        [NameInMap("oppoCategory")]
        [Validation(Required=false)]
        public string OppoCategory { get; set; }

        [NameInMap("oppoChannelId")]
        [Validation(Required=false)]
        public string OppoChannelId { get; set; }

        [NameInMap("oppoNotifyLevel")]
        [Validation(Required=false)]
        public string OppoNotifyLevel { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>&quot;true&quot; ,默认为&quot;false&quot;，可不填</para>
        /// </summary>
        [NameInMap("useHuaweiMessage")]
        [Validation(Required=false)]
        public string UseHuaweiMessage { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("useHuaweiPlainMessage")]
        [Validation(Required=false)]
        public string UseHuaweiPlainMessage { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>&quot;true&quot;,默认&quot;false&quot;</para>
        /// </summary>
        [NameInMap("vivoAddBadge")]
        [Validation(Required=false)]
        public string VivoAddBadge { get; set; }

        [NameInMap("vivoCategory")]
        [Validation(Required=false)]
        public string VivoCategory { get; set; }

        [NameInMap("vivoPushMode")]
        [Validation(Required=false)]
        public string VivoPushMode { get; set; }

        [NameInMap("xiaomiChannelId")]
        [Validation(Required=false)]
        public string XiaomiChannelId { get; set; }

    }

}
