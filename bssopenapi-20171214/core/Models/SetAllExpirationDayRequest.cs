// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20171214.Models
{
    public class SetAllExpirationDayRequest : TeaModel {
        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The current unified expiration date settings only support unexpired ECS instances. Expired instances cannot be aligned to the unified expiration date. After the settings are complete, you can align the renewal time with the configured unified expiration time.</para>
        /// <para>Valid values: 1 to 28, representing the 1st to the 28th day of each month.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("UnifyExpireDay")]
        [Validation(Required=false)]
        public string UnifyExpireDay { get; set; }

    }

}
