// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Hbr20170908.Models
{
    public class GetTempFileDownloadLinkRequest : TeaModel {
        /// <summary>
        /// <para>The key that is used to download a file.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>temp/1797733170015112/report/r-000jdzknbp39cnf9hs99/r-000jdzknbp39cnf9hs99-total.csv</para>
        /// </summary>
        [NameInMap("TempFileKey")]
        [Validation(Required=false)]
        public string TempFileKey { get; set; }

    }

}
