// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cr20181201.Models
{
    public class DiagnosisTarget : TeaModel {
        /// <summary>
        /// <para>The end of the diagnostic time window, in ISO 8601 format. Must be after <c>StartTime</c>.</para>
        /// <para>Use the UTC time format: yyyy-MM-ddTHH:mm:ssZ</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-01-01T00:30:00+08:00</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>A map of key-value pairs providing additional context for the diagnosis.</para>
        /// </summary>
        [NameInMap("Extra")]
        [Validation(Required=false)]
        public Dictionary<string, string> Extra { get; set; }

        /// <summary>
        /// <para>The namespace that contains the repository.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test_namespace</para>
        /// </summary>
        [NameInMap("Namespace")]
        [Validation(Required=false)]
        public string Namespace { get; set; }

        /// <summary>
        /// <para>The ID of a related operation, such as a previous diagnostic task.</para>
        /// </summary>
        [NameInMap("RelatedId")]
        [Validation(Required=false)]
        public string RelatedId { get; set; }

        /// <summary>
        /// <para>The name of the repository.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test_repo</para>
        /// </summary>
        [NameInMap("Repository")]
        [Validation(Required=false)]
        public string Repository { get; set; }

        /// <summary>
        /// <para>The start of the diagnostic time window, in ISO 8601 format.</para>
        /// <para>Use the UTC time format: yyyy-MM-ddTHH:mm:ssZ</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-01-01T00:00:00+08:00</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// <para>The container image tag.</para>
        /// 
        /// <b>Example:</b>
        /// <para>latest</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public string Tag { get; set; }

    }

}
