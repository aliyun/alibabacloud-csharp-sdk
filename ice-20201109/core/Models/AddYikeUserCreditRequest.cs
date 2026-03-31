// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class AddYikeUserCreditRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("Credit")]
        [Validation(Required=false)]
        public int? Credit { get; set; }

        /// <summary>
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
