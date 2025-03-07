// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Openanalytics_open20180619.Models
{
    public class ListSparkJobResponseBody : TeaModel {
        [NameInMap("DataResult")]
        [Validation(Required=false)]
        public ListSparkJobResponseBodyDataResult DataResult { get; set; }
        public class ListSparkJobResponseBodyDataResult : TeaModel {
            [NameInMap("JobList")]
            [Validation(Required=false)]
            public List<ListSparkJobResponseBodyDataResultJobList> JobList { get; set; }
            public class ListSparkJobResponseBodyDataResultJobList : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>2020-10-27 17:51:05</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1603792267000</para>
                /// </summary>
                [NameInMap("CreateTimeValue")]
                [Validation(Required=false)]
                public string CreateTimeValue { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>{&quot;args&quot;:[&quot;100&quot;],&quot;name&quot;:...}</para>
                /// </summary>
                [NameInMap("Detail")]
                [Validation(Required=false)]
                public string Detail { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>small</para>
                /// </summary>
                [NameInMap("DriverResourceSpec")]
                [Validation(Required=false)]
                public string DriverResourceSpec { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("ExecutorInstances")]
                [Validation(Required=false)]
                public string ExecutorInstances { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>small</para>
                /// </summary>
                [NameInMap("ExecutorResourceSpec")]
                [Validation(Required=false)]
                public string ExecutorResourceSpec { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>j202010271750hangzhouf742a4330000950</para>
                /// </summary>
                [NameInMap("JobId")]
                [Validation(Required=false)]
                public string JobId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>SparkPi</para>
                /// </summary>
                [NameInMap("JobName")]
                [Validation(Required=false)]
                public string JobName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para><a href="https://dlaui-cn-hangzhou.aliyuncs.com/?token=xxx">https://dlaui-cn-hangzhou.aliyuncs.com/?token=xxx</a></para>
                /// </summary>
                [NameInMap("SparkUI")]
                [Validation(Required=false)]
                public string SparkUI { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>running</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2020-10-27 17:51:05</para>
                /// </summary>
                [NameInMap("SubmitTime")]
                [Validation(Required=false)]
                public string SubmitTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1603792267000</para>
                /// </summary>
                [NameInMap("SubmitTimeValue")]
                [Validation(Required=false)]
                public string SubmitTimeValue { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2020-10-27 17:51:05</para>
                /// </summary>
                [NameInMap("UpdateTime")]
                [Validation(Required=false)]
                public string UpdateTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1603792267000</para>
                /// </summary>
                [NameInMap("UpdateTimeValue")]
                [Validation(Required=false)]
                public string UpdateTimeValue { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>MyCluster</para>
                /// </summary>
                [NameInMap("VcName")]
                [Validation(Required=false)]
                public string VcName { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public string PageNumber { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public string PageSize { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>4998</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public string TotalCount { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>E18B0634-F003-486A-90B9-4AA6932DA3AA</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
