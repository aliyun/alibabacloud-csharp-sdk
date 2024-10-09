// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Marketing_event20210101.Models
{
    public class FindGuestCredentialsRecordRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>34429</para>
        /// </summary>
        [NameInMap("ActivityId")]
        [Validation(Required=false)]
        public string ActivityId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2023-08-07 12:00:00</para>
        /// </summary>
        [NameInMap("DateTimeString")]
        [Validation(Required=false)]
        public string DateTimeString { get; set; }

        [NameInMap("EndDateTime")]
        [Validation(Required=false)]
        public string EndDateTime { get; set; }

        [NameInMap("StartDateTime")]
        [Validation(Required=false)]
        public string StartDateTime { get; set; }

    }

}
