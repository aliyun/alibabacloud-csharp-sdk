// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MarketplaceIntl20221230.Models
{
    public class NoticeInstanceUserRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>5000000264872</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public long? InstanceId { get; set; }

        [NameInMap("NoticeParam")]
        [Validation(Required=false)]
        public string NoticeParam { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("NoticeType")]
        [Validation(Required=false)]
        public long? NoticeType { get; set; }

    }

}
