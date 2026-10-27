// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class ScheduleValue : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>testId</para>
        /// </summary>
        [NameInMap("contactId")]
        [Validation(Required=false)]
        public string ContactId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>testName</para>
        /// </summary>
        [NameInMap("contactName")]
        [Validation(Required=false)]
        public string ContactName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2024-10-01 02:00:00</para>
        /// </summary>
        [NameInMap("end")]
        [Validation(Required=false)]
        public string End { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2024-10-01 22:00:00</para>
        /// </summary>
        [NameInMap("start")]
        [Validation(Required=false)]
        public string Start { get; set; }

    }

}
