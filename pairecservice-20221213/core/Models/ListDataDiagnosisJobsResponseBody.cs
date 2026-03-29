// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiRecService20221213.Models
{
    public class ListDataDiagnosisJobsResponseBody : TeaModel {
        [NameInMap("DataDiagnosisJobs")]
        [Validation(Required=false)]
        public List<ListDataDiagnosisJobsResponseBodyDataDiagnosisJobs> DataDiagnosisJobs { get; set; }
        public class ListDataDiagnosisJobsResponseBodyDataDiagnosisJobs : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>2023-05-28</para>
            /// </summary>
            [NameInMap("BizDate")]
            [Validation(Required=false)]
            public string BizDate { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>{}</para>
            /// </summary>
            [NameInMap("Config")]
            [Validation(Required=false)]
            public string Config { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("DataDiagnosisConfigId")]
            [Validation(Required=false)]
            public string DataDiagnosisConfigId { get; set; }

            [NameInMap("DataDiagnosisConfigName")]
            [Validation(Required=false)]
            public string DataDiagnosisConfigName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("DataDiagnosisJobId")]
            [Validation(Required=false)]
            public string DataDiagnosisJobId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2021-12-15T23:24:33.132+08:00</para>
            /// </summary>
            [NameInMap("GmtCreateTime")]
            [Validation(Required=false)]
            public string GmtCreateTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2021-12-15T23:24:33.132+08:00</para>
            /// </summary>
            [NameInMap("GmtStartTime")]
            [Validation(Required=false)]
            public string GmtStartTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Cycle</para>
            /// </summary>
            [NameInMap("JobSource")]
            [Validation(Required=false)]
            public string JobSource { get; set; }

            [NameInMap("Logs")]
            [Validation(Required=false)]
            public List<string> Logs { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Initializing</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ChangeRate</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>728C5E01-ABF6-5AA8-B9FC-B3BA05DECC77</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
