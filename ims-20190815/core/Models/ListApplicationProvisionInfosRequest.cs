// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ims20190815.Models
{
    public class ListApplicationProvisionInfosRequest : TeaModel {
        /// <summary>
        /// <para>The source of the applications. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>inner: The applications are from the current account.</description></item>
        /// <item><description>external: The applications are from other accounts.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>external</para>
        /// </summary>
        [NameInMap("SourceType")]
        [Validation(Required=false)]
        public string SourceType { get; set; }

    }

}
