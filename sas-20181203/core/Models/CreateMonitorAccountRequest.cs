// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class CreateMonitorAccountRequest : TeaModel {
        /// <summary>
        /// <para>The account IDs of members in the resource directory.</para>
        /// <remarks>
        /// <para> You can call the <a href="~~ListAccountsInResourceDirectory~~">ListAccountsInResourceDirectory</a> operation to obtain the account IDs. Separate multiple account IDs with commas (,). If you specify a value for this parameter, the existing list of members is replaced by the new list that you specify. Otherwise, the existing list is cleared.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1026780160******,1457515594******</para>
        /// </summary>
        [NameInMap("AccountIds")]
        [Validation(Required=false)]
        public string AccountIds { get; set; }

    }

}
