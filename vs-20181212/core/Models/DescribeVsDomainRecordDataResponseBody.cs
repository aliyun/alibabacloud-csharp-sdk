// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vs20181212.Models
{
    public class DescribeVsDomainRecordDataResponseBody : TeaModel {
        [NameInMap("RecordDataPerInterval")]
        [Validation(Required=false)]
        public DescribeVsDomainRecordDataResponseBodyRecordDataPerInterval RecordDataPerInterval { get; set; }
        public class DescribeVsDomainRecordDataResponseBodyRecordDataPerInterval : TeaModel {
            [NameInMap("DataModule")]
            [Validation(Required=false)]
            public List<DescribeVsDomainRecordDataResponseBodyRecordDataPerIntervalDataModule> DataModule { get; set; }
            public class DescribeVsDomainRecordDataResponseBodyRecordDataPerIntervalDataModule : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("RecordValue")]
                [Validation(Required=false)]
                public string RecordValue { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("StreamCountValue")]
                [Validation(Required=false)]
                public string StreamCountValue { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2021-11-19T15:59:59Z</para>
                /// </summary>
                [NameInMap("TimeStamp")]
                [Validation(Required=false)]
                public string TimeStamp { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>BEA5625F-8FCF-48F4-851B-CA63946DA664</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
