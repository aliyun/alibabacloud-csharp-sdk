// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class CommonApplyQueryRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>1003366164</para>
        /// </summary>
        [NameInMap("apply_id")]
        [Validation(Required=false)]
        public long? ApplyId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("biz_category")]
        [Validation(Required=false)]
        public int? BizCategory { get; set; }

        [NameInMap("business_instance_id")]
        [Validation(Required=false)]
        public string BusinessInstanceId { get; set; }

        [NameInMap("user_id")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
