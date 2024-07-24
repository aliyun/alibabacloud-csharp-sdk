// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.HBase20190101.Models
{
    public class DescribeRestoreSummaryResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("HasMoreRestoreRecord")]
        [Validation(Required=false)]
        public int? HasMoreRestoreRecord { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>AE639ED7-F0F3-4A71-911E-CF8EC088816E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Rescords")]
        [Validation(Required=false)]
        public DescribeRestoreSummaryResponseBodyRescords Rescords { get; set; }
        public class DescribeRestoreSummaryResponseBodyRescords : TeaModel {
            [NameInMap("Rescord")]
            [Validation(Required=false)]
            public List<DescribeRestoreSummaryResponseBodyRescordsRescord> Rescord { get; set; }
            public class DescribeRestoreSummaryResponseBodyRescordsRescord : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>1/1</para>
                /// </summary>
                [NameInMap("BulkLoadProcess")]
                [Validation(Required=false)]
                public string BulkLoadProcess { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2020-11-05T06:45:14Z</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2020-11-05T06:45:51Z</para>
                /// </summary>
                [NameInMap("FinishTime")]
                [Validation(Required=false)]
                public string FinishTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1/1</para>
                /// </summary>
                [NameInMap("HfileRestoreProcess")]
                [Validation(Required=false)]
                public string HfileRestoreProcess { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0/0</para>
                /// </summary>
                [NameInMap("LogProcess")]
                [Validation(Required=false)]
                public string LogProcess { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>20201105144514</para>
                /// </summary>
                [NameInMap("RecordId")]
                [Validation(Required=false)]
                public string RecordId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1/1</para>
                /// </summary>
                [NameInMap("SchemaProcess")]
                [Validation(Required=false)]
                public string SchemaProcess { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>SUCCEEDED</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

    }

}
