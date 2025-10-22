// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Domain20180208.Models
{
    public class CheckPushReceiverRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>破天荒的土豆</para>
        /// </summary>
        [NameInMap("ReceiverAccount")]
        [Validation(Required=false)]
        public string ReceiverAccount { get; set; }

    }

}
