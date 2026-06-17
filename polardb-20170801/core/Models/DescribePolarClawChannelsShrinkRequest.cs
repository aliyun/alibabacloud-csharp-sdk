// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DescribePolarClawChannelsShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The application ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pa-**************</para>
        /// </summary>
        [NameInMap("ApplicationId")]
        [Validation(Required=false)]
        public string ApplicationId { get; set; }

        /// <summary>
        /// <para>The channel IDs to query. Leave this parameter empty to return all channels.</para>
        /// 
        /// <b>Example:</b>
        /// <para>feishu,telegram</para>
        /// </summary>
        [NameInMap("ChannelList")]
        [Validation(Required=false)]
        public string ChannelListShrink { get; set; }

    }

}
