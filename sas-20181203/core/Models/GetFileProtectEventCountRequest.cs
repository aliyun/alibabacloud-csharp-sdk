// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GetFileProtectEventCountRequest : TeaModel {
        /// <summary>
        /// <para>The event filter status. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>0: Unhandled.</para>
        /// </description></item>
        /// <item><description><para>1: Handled.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public int? Status { get; set; }

    }

}
