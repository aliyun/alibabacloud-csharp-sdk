// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AIWorkSpace20210204.Models
{
    public class ListFeaturesRequest : TeaModel {
        /// <summary>
        /// <para>Feature names, separated by commas.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PaiConsole:IntegrateWithWorkspace</para>
        /// </summary>
        [NameInMap("Names")]
        [Validation(Required=false)]
        public string Names { get; set; }

    }

}
