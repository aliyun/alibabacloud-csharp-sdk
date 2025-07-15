// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class RemoveTerminalsRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the application. You can specify only one application ID in each request.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>aec****</para>
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// <para>The ID of the channel. You can specify only one channel ID in each request.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testId</para>
        /// </summary>
        [NameInMap("ChannelId")]
        [Validation(Required=false)]
        public string ChannelId { get; set; }

        /// <summary>
        /// <para>The IDs of the users that you want to remove.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("TerminalIds")]
        [Validation(Required=false)]
        public List<string> TerminalIds { get; set; }

    }

}
