// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class AddUnknownThreatDetectProcessRequest : TeaModel {
        [NameInMap("EventIdList")]
        [Validation(Required=false)]
        public List<long?> EventIdList { get; set; }

        [NameInMap("ProcessList")]
        [Validation(Required=false)]
        public List<AddUnknownThreatDetectProcessRequestProcessList> ProcessList { get; set; }
        public class AddUnknownThreatDetectProcessRequestProcessList : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>e59b63ae983377f131ab20ec0d******</para>
            /// </summary>
            [NameInMap("Md5")]
            [Validation(Required=false)]
            public string Md5 { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>/bin/rm</para>
            /// </summary>
            [NameInMap("ProcessPath")]
            [Validation(Required=false)]
            public string ProcessPath { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1330</para>
            /// </summary>
            [NameInMap("Remark")]
            [Validation(Required=false)]
            public string Remark { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>f204693a7d2ce99d6c4434e550d985ee1c7be7cb5dd9a76094369af0d2******</para>
            /// </summary>
            [NameInMap("Sha256")]
            [Validation(Required=false)]
            public string Sha256 { get; set; }

        }

        [NameInMap("UuidList")]
        [Validation(Required=false)]
        public List<string> UuidList { get; set; }

    }

}
