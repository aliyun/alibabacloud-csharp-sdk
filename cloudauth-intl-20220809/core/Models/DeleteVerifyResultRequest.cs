// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth_intl20220809.Models
{
    public class DeleteVerifyResultRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>Y / N</para>
        /// </summary>
        [NameInMap("DeleteAfterQuery")]
        [Validation(Required=false)]
        public string DeleteAfterQuery { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Img / Text / All</para>
        /// </summary>
        [NameInMap("DeleteType")]
        [Validation(Required=false)]
        public string DeleteType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>4ab0b***cbde97</para>
        /// </summary>
        [NameInMap("TransactionId")]
        [Validation(Required=false)]
        public string TransactionId { get; set; }

    }

}
