// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class CommonApplyQueryRequest : TeaModel {
        /// <summary>
        /// <para>The business travel approval ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1003366164</para>
        /// </summary>
        [NameInMap("apply_id")]
        [Validation(Required=false)]
        public long? ApplyId { get; set; }

        /// <summary>
        /// <para>The business type.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6</para>
        /// </summary>
        [NameInMap("biz_category")]
        [Validation(Required=false)]
        public int? BizCategory { get; set; }

        /// <summary>
        /// <para>Either this parameter or apply_id is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2024060510000003300006205</para>
        /// </summary>
        [NameInMap("business_instance_id")]
        [Validation(Required=false)]
        public string BusinessInstanceId { get; set; }

        /// <summary>
        /// <para>The third-party user ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>第三方用户id</para>
        /// </summary>
        [NameInMap("user_id")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
