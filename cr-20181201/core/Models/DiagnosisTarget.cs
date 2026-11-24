// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cr20181201.Models
{
    public class DiagnosisTarget : TeaModel {
        /// <summary>
        /// <para>The end time of the diagnostic.</para>
        /// <para>Use the UTC time format: yyyy-MM-ddTHH:mm:ssZ</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-01-01T00:30:00+08:00</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The extra parameters.</para>
        /// </summary>
        [NameInMap("Extra")]
        [Validation(Required=false)]
        public Dictionary<string, string> Extra { get; set; }

        /// <summary>
        /// <para>The namespace name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test_namespace</para>
        /// </summary>
        [NameInMap("Namespace")]
        [Validation(Required=false)]
        public string Namespace { get; set; }

        /// <summary>
        /// <para>The ID of the diagnosed item.</para>
        /// </summary>
        [NameInMap("RelatedId")]
        [Validation(Required=false)]
        public string RelatedId { get; set; }

        /// <summary>
        /// <para>The repository name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test_repo</para>
        /// </summary>
        [NameInMap("Repository")]
        [Validation(Required=false)]
        public string Repository { get; set; }

        /// <summary>
        /// <para>The start time of the diagnostic.</para>
        /// <para>Use the UTC time format: yyyy-MM-ddTHH:mm:ssZ</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-01-01T00:00:00+08:00</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// <para>The image tag.</para>
        /// 
        /// <b>Example:</b>
        /// <para>latest</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public string Tag { get; set; }

    }

}
