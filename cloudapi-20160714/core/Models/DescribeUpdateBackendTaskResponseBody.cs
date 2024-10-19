// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class DescribeUpdateBackendTaskResponseBody : TeaModel {
        [NameInMap("ApiUpdateBackendResults")]
        [Validation(Required=false)]
        public DescribeUpdateBackendTaskResponseBodyApiUpdateBackendResults ApiUpdateBackendResults { get; set; }
        public class DescribeUpdateBackendTaskResponseBodyApiUpdateBackendResults : TeaModel {
            [NameInMap("ApiUpdateBackendResult")]
            [Validation(Required=false)]
            public List<DescribeUpdateBackendTaskResponseBodyApiUpdateBackendResultsApiUpdateBackendResult> ApiUpdateBackendResult { get; set; }
            public class DescribeUpdateBackendTaskResponseBodyApiUpdateBackendResultsApiUpdateBackendResult : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>checkin_linechart_today</para>
                /// </summary>
                [NameInMap("ApiName")]
                [Validation(Required=false)]
                public string ApiName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>14faa7ba0572445685866ddb6a6f19da</para>
                /// </summary>
                [NameInMap("ApiUid")]
                [Validation(Required=false)]
                public string ApiUid { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>c09b078bcb8f4ade9677bd8b18cdf43f</para>
                /// </summary>
                [NameInMap("BackendId")]
                [Validation(Required=false)]
                public string BackendId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>Failed</para>
                /// </summary>
                [NameInMap("ErrorMsg")]
                [Validation(Required=false)]
                public string ErrorMsg { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>3013a55c0c44483f984d26df27120513</para>
                /// </summary>
                [NameInMap("GroupId")]
                [Validation(Required=false)]
                public string GroupId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>imotob1</para>
                /// </summary>
                [NameInMap("GroupName")]
                [Validation(Required=false)]
                public string GroupName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>d8f2f54f3309458b8aaceb36c01c2dd9</para>
                /// </summary>
                [NameInMap("StageId")]
                [Validation(Required=false)]
                public string StageId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>RELEASE</para>
                /// </summary>
                [NameInMap("StageName")]
                [Validation(Required=false)]
                public string StageName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>OVER</para>
                /// </summary>
                [NameInMap("UpdateStatus")]
                [Validation(Required=false)]
                public string UpdateStatus { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>CEF72CEB-54B6-4AE8-B225-F876FF7BZ016</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
