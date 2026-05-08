// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yike20260319.Models
{
    public class UpdateYikeProductionMemberAuthRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Manage</para>
        /// </summary>
        [NameInMap("Auth")]
        [Validation(Required=false)]
        public string Auth { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pd_061716****</para>
        /// </summary>
        [NameInMap("ProductionId")]
        [Validation(Required=false)]
        public string ProductionId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("YikeUserId")]
        [Validation(Required=false)]
        public string YikeUserId { get; set; }

    }

}
