// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Agency20221216.Models
{
    public class EditNewBuyStatusRequest : TeaModel {
        /// <summary>
        /// <para>The new purchase status. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>cancelBan: allows new purchases</description></item>
        /// <item><description>ban: prohibits new purchases.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>cancelBan</para>
        /// </summary>
        [NameInMap("NewBuyStatus")]
        [Validation(Required=false)]
        public string NewBuyStatus { get; set; }

        /// <summary>
        /// <para>The UID of the customer.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1133166938931507</para>
        /// </summary>
        [NameInMap("Uid")]
        [Validation(Required=false)]
        public long? Uid { get; set; }

    }

}
