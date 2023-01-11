/**
 *
 */
// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Linkcard20210520.Models
{
    public class AddCardToDirectionalGroupRequest : TeaModel {
        [NameInMap("AddType")]
        [Validation(Required=false)]
        public string AddType { get; set; }

        /// <summary>
        /// Linkcard
        /// </summary>
        [NameInMap("ApiProduct")]
        [Validation(Required=false)]
        public string ApiProduct { get; set; }

        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public string GroupId { get; set; }

        [NameInMap("IccidList")]
        [Validation(Required=false)]
        public List<string> IccidList { get; set; }

        [NameInMap("MsgNotify")]
        [Validation(Required=false)]
        public bool? MsgNotify { get; set; }

        [NameInMap("SerialNo")]
        [Validation(Required=false)]
        public string SerialNo { get; set; }

    }

}
