// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Chatbot20220408.Models
{
    public class UpdateUserSayResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>2356fg3wf34634vdt23wef2</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>34512323</para>
        /// </summary>
        [NameInMap("UserSayId")]
        [Validation(Required=false)]
        public long? UserSayId { get; set; }

    }

}
