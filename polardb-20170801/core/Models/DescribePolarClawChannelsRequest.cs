// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DescribePolarClawChannelsRequest : TeaModel {
        /// <summary>
        /// <para>The PolarClaw application ID. First call DescribeApplications to filter applications where ApplicationType is polardb_polarclaw and Status is Activated, and then use the returned ApplicationId to query channels.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pa-**************</para>
        /// </summary>
        [NameInMap("ApplicationId")]
        [Validation(Required=false)]
        public string ApplicationId { get; set; }

        /// <summary>
        /// <para>The list of channel IDs to query. If this parameter is left empty, all channels are returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>feishu,telegram</para>
        /// </summary>
        [NameInMap("ChannelList")]
        [Validation(Required=false)]
        public List<string> ChannelList { get; set; }

    }

}
