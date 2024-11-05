// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Agency20221216.Models
{
    public class EditEndUserStatusRequest : TeaModel {
        /// <summary>
        /// <para>Shutdown Status</br></para>
        /// <list type="bullet">
        /// <item><description><para>postPayFreeze, the account have been blocked</br></para>
        /// </description></item>
        /// <item><description><para>postPayThaw, the account have been unlocked</br></para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>postPayFreeze</para>
        /// </summary>
        [NameInMap("CreditStatus")]
        [Validation(Required=false)]
        public string CreditStatus { get; set; }

        /// <summary>
        /// <para>UID</para>
        /// 
        /// <b>Example:</b>
        /// <para>1792155717328010</para>
        /// </summary>
        [NameInMap("Uid")]
        [Validation(Required=false)]
        public long? Uid { get; set; }

    }

}
