// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.HBase20190101.Models
{
    public class DescribeRestoreSummaryResponseBody : TeaModel {
        /// <summary>
        /// <para>Indicates whether there is a next page. This parameter is currently not used.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("HasMoreRestoreRecord")]
        [Validation(Required=false)]
        public int? HasMoreRestoreRecord { get; set; }

        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The page size.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
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
                [NameInMap("BulkLoadProcess")]
                [Validation(Required=false)]
                public string BulkLoadProcess { get; set; }

                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                [NameInMap("FinishTime")]
                [Validation(Required=false)]
                public string FinishTime { get; set; }

                [NameInMap("HfileRestoreProcess")]
                [Validation(Required=false)]
                public string HfileRestoreProcess { get; set; }

                [NameInMap("LogProcess")]
                [Validation(Required=false)]
                public string LogProcess { get; set; }

                [NameInMap("RecordId")]
                [Validation(Required=false)]
                public string RecordId { get; set; }

                [NameInMap("SchemaProcess")]
                [Validation(Required=false)]
                public string SchemaProcess { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

        }

        /// <summary>
        /// <para>The total number of records.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

    }

}
