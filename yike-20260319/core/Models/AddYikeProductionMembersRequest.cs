// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yike20260319.Models
{
    public class AddYikeProductionMembersRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pd_061716***</para>
        /// </summary>
        [NameInMap("ProductionId")]
        [Validation(Required=false)]
        public string ProductionId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>21*****</para>
        /// </summary>
        [NameInMap("YikeUserIds")]
        [Validation(Required=false)]
        public string YikeUserIds { get; set; }

    }

}
