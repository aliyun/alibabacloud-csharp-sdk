// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class CreateAlertContactGroupResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the alert contact group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>446*</para>
        /// </summary>
        [NameInMap("ContactGroupId")]
        [Validation(Required=false)]
        public string ContactGroupId { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>70675725-8F11-4817-8106-CFE0AD71****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
