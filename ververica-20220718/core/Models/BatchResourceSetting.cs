// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ververica20220718.Models
{
    public class BatchResourceSetting : TeaModel {
        [NameInMap("basicResourceSetting")]
        [Validation(Required=false)]
        public BasicResourceSetting BasicResourceSetting { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("maxSlot")]
        [Validation(Required=false)]
        public long? MaxSlot { get; set; }

    }

}
