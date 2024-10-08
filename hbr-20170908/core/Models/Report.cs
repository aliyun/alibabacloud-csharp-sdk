// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Hbr20170908.Models
{
    public class Report : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>temp/report/r-0000dnz7p4pk31u6madf_failed.csv</para>
        /// </summary>
        [NameInMap("FailedFiles")]
        [Validation(Required=false)]
        public string FailedFiles { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>temp/report/r-0000dnz7p4pk31u6madf_skipped.csv</para>
        /// </summary>
        [NameInMap("SkippedFiles")]
        [Validation(Required=false)]
        public string SkippedFiles { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>temp/report/r-0000dnz7p4pk31u6madf_success.csv</para>
        /// </summary>
        [NameInMap("SuccessFiles")]
        [Validation(Required=false)]
        public string SuccessFiles { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>temp/report/r-0000dnz7p4pk31u6madf_total.csv</para>
        /// </summary>
        [NameInMap("TotalFiles")]
        [Validation(Required=false)]
        public string TotalFiles { get; set; }

    }

}
