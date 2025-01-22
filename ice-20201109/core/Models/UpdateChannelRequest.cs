// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class UpdateChannelRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("AccessPolicy")]
        [Validation(Required=false)]
        public bool? AccessPolicy { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>xxxxx</para>
        /// </summary>
        [NameInMap("AccessToken")]
        [Validation(Required=false)]
        public string AccessToken { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MyChannel</para>
        /// </summary>
        [NameInMap("ChannelName")]
        [Validation(Required=false)]
        public string ChannelName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>MySourceLocation</para>
        /// </summary>
        [NameInMap("FillerSourceLocationName")]
        [Validation(Required=false)]
        public string FillerSourceLocationName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>MySource</para>
        /// </summary>
        [NameInMap("FillerSourceName")]
        [Validation(Required=false)]
        public string FillerSourceName { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{
        ///     &quot;ManifestName&quot;: &quot;manifest-1&quot;,
        ///     &quot;Format&quot;: &quot;HLS&quot;,
        ///     &quot;SourceGroupName&quot;: &quot;source-group-1&quot;,
        ///     &quot;ManifestSettings&quot;: {
        ///         &quot;WindowDuration&quot;: 60,
        ///         &quot;AdMarkType&quot;: &quot;Daterange&quot;
        ///     }
        /// }]</para>
        /// </summary>
        [NameInMap("OutPutConfigList")]
        [Validation(Required=false)]
        public string OutPutConfigList { get; set; }

    }

}
