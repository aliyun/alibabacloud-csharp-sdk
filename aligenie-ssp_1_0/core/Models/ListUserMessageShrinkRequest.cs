// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AliGeniessp_1_0.Models
{
    public class ListUserMessageShrinkRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>2022-07-27 14:06:55.984</para>
        /// </summary>
        [NameInMap("BeforeTime")]
        [Validation(Required=false)]
        public string BeforeTime { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("UserInfo")]
        [Validation(Required=false)]
        public string UserInfoShrink { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("limit")]
        [Validation(Required=false)]
        public int? Limit { get; set; }

    }

}
