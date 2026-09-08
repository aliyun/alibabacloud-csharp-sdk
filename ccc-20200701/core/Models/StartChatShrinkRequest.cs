// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CCC20200701.Models
{
    public class StartChatShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the web service channel.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cf584733-<em><b>-</b></em>-9699-cb77aa3b7aa6</para>
        /// </summary>
        [NameInMap("AccessChannelId")]
        [Validation(Required=false)]
        public string AccessChannelId { get; set; }

        /// <summary>
        /// <para>The instance ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ccc-test</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The channel token for the web service.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9XYGTGWtq2wFi_Bpg7aUnIoYi_vG_rO3bjEn0YtsxbHRHrYHlz1LDBLJAyZcLxieRQR4h_6AnWvTjJeNU5jg************Hwej7WgWrmA=</para>
        /// </summary>
        [NameInMap("Token")]
        [Validation(Required=false)]
        public string Token { get; set; }

        /// <summary>
        /// <para>The information about chat members.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("UserList")]
        [Validation(Required=false)]
        public string UserListShrink { get; set; }

    }

}
