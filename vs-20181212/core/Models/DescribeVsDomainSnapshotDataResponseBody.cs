// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vs20181212.Models
{
    public class DescribeVsDomainSnapshotDataResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>BEA5625F-8FCF-48F4-851B-CA63946DA664</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SnapshotDataPerInterval")]
        [Validation(Required=false)]
        public DescribeVsDomainSnapshotDataResponseBodySnapshotDataPerInterval SnapshotDataPerInterval { get; set; }
        public class DescribeVsDomainSnapshotDataResponseBodySnapshotDataPerInterval : TeaModel {
            [NameInMap("DataModule")]
            [Validation(Required=false)]
            public List<DescribeVsDomainSnapshotDataResponseBodySnapshotDataPerIntervalDataModule> DataModule { get; set; }
            public class DescribeVsDomainSnapshotDataResponseBodySnapshotDataPerIntervalDataModule : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("SnapshotValue")]
                [Validation(Required=false)]
                public string SnapshotValue { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2015-12-10T20:00:00Z</para>
                /// </summary>
                [NameInMap("TimeStamp")]
                [Validation(Required=false)]
                public string TimeStamp { get; set; }

            }

        }

    }

}
