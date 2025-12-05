// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RdsAi20250507.Models
{
    public class GetMessagesRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>941c6f59-acf5-4e11-9adc-31e52e1f****</para>
        /// </summary>
        [NameInMap("ConversationId")]
        [Validation(Required=false)]
        public string ConversationId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>038866af-a050-4bc5-bfad-b7bfc838****</para>
        /// </summary>
        [NameInMap("FirstId")]
        [Validation(Required=false)]
        public string FirstId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("Limit")]
        [Validation(Required=false)]
        public long? Limit { get; set; }

    }

}
