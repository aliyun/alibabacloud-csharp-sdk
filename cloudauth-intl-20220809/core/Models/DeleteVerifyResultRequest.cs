// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth_intl20220809.Models
{
    public class DeleteVerifyResultRequest : TeaModel {
        /// <summary>
        /// <para>Whether to depend on the query interface when deleting data</para>
        /// 
        /// <b>Example:</b>
        /// <para>Y / N</para>
        /// </summary>
        [NameInMap("DeleteAfterQuery")]
        [Validation(Required=false)]
        public string DeleteAfterQuery { get; set; }

        /// <summary>
        /// <para>Type of data to be deleted</para>
        /// 
        /// <b>Example:</b>
        /// <para>Img / Text / All</para>
        /// </summary>
        [NameInMap("DeleteType")]
        [Validation(Required=false)]
        public string DeleteType { get; set; }

        /// <summary>
        /// <para>Unique identifier of the authentication request</para>
        /// 
        /// <b>Example:</b>
        /// <para>4ab0b***cbde97</para>
        /// </summary>
        [NameInMap("TransactionId")]
        [Validation(Required=false)]
        public string TransactionId { get; set; }

    }

}
