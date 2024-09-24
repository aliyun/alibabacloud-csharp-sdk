// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ListClientUserDefineRuleTypesResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>340D7FC4-D575-1661-8ACD-CFA7BE57****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("UserDefineRuleTypes")]
        [Validation(Required=false)]
        public List<string> UserDefineRuleTypes { get; set; }

    }

}
