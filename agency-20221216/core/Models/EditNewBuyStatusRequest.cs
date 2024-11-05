// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Agency20221216.Models
{
    public class EditNewBuyStatusRequest : TeaModel {
        /// <summary>
        /// <para>New Purchase Status</br></para>
        /// <list type="bullet">
        /// <item><description><para>cancelBan: Cancel the restriction for New Purchase request</br></para>
        /// </description></item>
        /// <item><description><para>ban: ban the New Purchase request</br></para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>cancelBan</para>
        /// </summary>
        [NameInMap("NewBuyStatus")]
        [Validation(Required=false)]
        public string NewBuyStatus { get; set; }

        /// <summary>
        /// <para>Customer UID</para>
        /// 
        /// <b>Example:</b>
        /// <para>1133166938931507</para>
        /// </summary>
        [NameInMap("Uid")]
        [Validation(Required=false)]
        public long? Uid { get; set; }

    }

}
