// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ListUnknownThreatDetectProcessRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>white</para>
        /// </summary>
        [NameInMap("AnalyzeResult")]
        [Validation(Required=false)]
        public string AnalyzeResult { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1768891966345</para>
        /// </summary>
        [NameInMap("FirstTimeEnd")]
        [Validation(Required=false)]
        public long? FirstTimeEnd { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1768891966344</para>
        /// </summary>
        [NameInMap("FirstTimeStart")]
        [Validation(Required=false)]
        public long? FirstTimeStart { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0552c44e243abdea1729d4507bce****</para>
        /// </summary>
        [NameInMap("Md5")]
        [Validation(Required=false)]
        public string Md5 { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>/etc/test</para>
        /// </summary>
        [NameInMap("Path")]
        [Validation(Required=false)]
        public string Path { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>/bin/rm</para>
        /// </summary>
        [NameInMap("ProcessPath")]
        [Validation(Required=false)]
        public string ProcessPath { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>172.20.XX.XX</para>
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

        /// <summary>
        /// <b>Example:</b>
        /// <para>50d213b4-3a35-427a-b8a5-04b0c7e1****</para>
        /// </summary>
        [NameInMap("Uuid")]
        [Validation(Required=false)]
        public string Uuid { get; set; }

    }

}
