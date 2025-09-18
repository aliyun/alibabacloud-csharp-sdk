// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ComputeNestSupplier20210521.Models
{
    public class GetOpsNoticeResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>{\&quot;cveId\&quot;:\&quot;CVE-2021-4034\&quot;}</para>
        /// </summary>
        [NameInMap("Attributes")]
        [Validation(Required=false)]
        public string Attributes { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Availability</para>
        /// </summary>
        [NameInMap("Category")]
        [Validation(Required=false)]
        public string Category { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>message</para>
        /// </summary>
        [NameInMap("Content")]
        [Validation(Required=false)]
        public string Content { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>notice-2338d3835bxxxxx</para>
        /// </summary>
        [NameInMap("NoticeId")]
        [Validation(Required=false)]
        public string NoticeId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1B3AD3CC-E938-5042-A771-7FD9A2FE03F3</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>service-c2d118c9193e49xxxxxx</para>
        /// </summary>
        [NameInMap("ServiceId")]
        [Validation(Required=false)]
        public string ServiceId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("ServiceInstanceCount")]
        [Validation(Required=false)]
        public string ServiceInstanceCount { get; set; }

        [NameInMap("ServiceName")]
        [Validation(Required=false)]
        public string ServiceName { get; set; }

        [NameInMap("ServiceVersions")]
        [Validation(Required=false)]
        public List<string> ServiceVersions { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Critical</para>
        /// </summary>
        [NameInMap("Severity")]
        [Validation(Required=false)]
        public string Severity { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Solutions</para>
        /// </summary>
        [NameInMap("Solutions")]
        [Validation(Required=false)]
        public string Solutions { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2024-11-18T02:05:00Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public string Success { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>ServiceInstanceUpgrade</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("UserCount")]
        [Validation(Required=false)]
        public string UserCount { get; set; }

    }

}
