// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dysms20170620.Models
{
    public class ExportCardSmsHistoryRequest : TeaModel {
        [NameInMap("ApiSend")]
        [Validation(Required=false)]
        public long? ApiSend { get; set; }

        [NameInMap("CardTemplateType")]
        [Validation(Required=false)]
        public string CardTemplateType { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("GmtCreate")]
        [Validation(Required=false)]
        public string GmtCreate { get; set; }

        [NameInMap("ReceiveState")]
        [Validation(Required=false)]
        public long? ReceiveState { get; set; }

        [NameInMap("Receiver")]
        [Validation(Required=false)]
        public string Receiver { get; set; }

        [NameInMap("RenderState")]
        [Validation(Required=false)]
        public long? RenderState { get; set; }

        [NameInMap("SignName")]
        [Validation(Required=false)]
        public string SignName { get; set; }

        [NameInMap("TmpCode")]
        [Validation(Required=false)]
        public string TmpCode { get; set; }

    }

}
