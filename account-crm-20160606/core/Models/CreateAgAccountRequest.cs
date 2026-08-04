// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Account_crm20160606.Models
{
    public class CreateAgAccountRequest : TeaModel {
        [NameInMap("LoginEmail")]
        [Validation(Required=false)]
        public string LoginEmail { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Mpk")]
        [Validation(Required=false)]
        public string Mpk { get; set; }

        [NameInMap("NationCode")]
        [Validation(Required=false)]
        public string NationCode { get; set; }

        [NameInMap("Own")]
        [Validation(Required=false)]
        public string Own { get; set; }

        [NameInMap("RealParentPk")]
        [Validation(Required=false)]
        public string RealParentPk { get; set; }

        [NameInMap("SecurityMobile")]
        [Validation(Required=false)]
        public string SecurityMobile { get; set; }

        [NameInMap("ShowNickName")]
        [Validation(Required=false)]
        public string ShowNickName { get; set; }

        [NameInMap("SiteNick")]
        [Validation(Required=false)]
        public string SiteNick { get; set; }

        [NameInMap("srcAccountInfo")]
        [Validation(Required=false)]
        public string SrcAccountInfo { get; set; }

    }

}
