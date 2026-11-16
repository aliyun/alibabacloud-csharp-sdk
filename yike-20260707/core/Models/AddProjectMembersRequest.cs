// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yike20260707.Models
{
    public class AddProjectMembersRequest : TeaModel {
        /// <summary>
        /// <para>The project ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pd_061716****</para>
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public string ProjectId { get; set; }

        /// <summary>
        /// <para>The Yike user IDs to be added. Separate multiple IDs with commas. The users must belong to the current Alibaba Cloud account. By default, the Edit permission is granted.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10001,10002</para>
        /// </summary>
        [NameInMap("YikeUserIds")]
        [Validation(Required=false)]
        public string YikeUserIds { get; set; }

    }

}
