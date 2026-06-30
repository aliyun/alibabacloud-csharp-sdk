// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yike20260319.Models
{
    public class SubYikeUserCreditRequest : TeaModel {
        /// <summary>
        /// <para>The number of credits to reclaim. The value must be greater than 0 and cannot exceed the sub-account credit balance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("Credit")]
        [Validation(Required=false)]
        public int? Credit { get; set; }

        /// <summary>
        /// <para>The sub-account user ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>id</para>
        /// </summary>
        [NameInMap("YikeUserId")]
        [Validation(Required=false)]
        public string YikeUserId { get; set; }

    }

}
