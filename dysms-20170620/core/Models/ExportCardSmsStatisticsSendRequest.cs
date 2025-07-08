// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dysms20170620.Models
{
    public class ExportCardSmsStatisticsSendRequest : TeaModel {
        [NameInMap("CustomTmpCode")]
        [Validation(Required=false)]
        public string CustomTmpCode { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("SendDateEnd")]
        [Validation(Required=false)]
        public string SendDateEnd { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("SendDateStart")]
        [Validation(Required=false)]
        public string SendDateStart { get; set; }

        [NameInMap("SignName")]
        [Validation(Required=false)]
        public string SignName { get; set; }

        [NameInMap("TmpCode")]
        [Validation(Required=false)]
        public string TmpCode { get; set; }

    }

}
