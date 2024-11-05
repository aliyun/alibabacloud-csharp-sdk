// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vs20181212.Models
{
    public class DescribeVsDomainReqTrafficDataResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>3600</para>
        /// </summary>
        [NameInMap("DataInterval")]
        [Validation(Required=false)]
        public string DataInterval { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>example.aliyundoc.com</para>
        /// </summary>
        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2021-09-22T03:40:41Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        [NameInMap("ReqTrafficDataPerInterval")]
        [Validation(Required=false)]
        public DescribeVsDomainReqTrafficDataResponseBodyReqTrafficDataPerInterval ReqTrafficDataPerInterval { get; set; }
        public class DescribeVsDomainReqTrafficDataResponseBodyReqTrafficDataPerInterval : TeaModel {
            [NameInMap("DataModule")]
            [Validation(Required=false)]
            public List<DescribeVsDomainReqTrafficDataResponseBodyReqTrafficDataPerIntervalDataModule> DataModule { get; set; }
            public class DescribeVsDomainReqTrafficDataResponseBodyReqTrafficDataPerIntervalDataModule : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>10000</para>
                /// </summary>
                [NameInMap("ReqTrafficValue")]
                [Validation(Required=false)]
                public string ReqTrafficValue { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2021-09-22T03:40:41Z</para>
                /// </summary>
                [NameInMap("TimeStamp")]
                [Validation(Required=false)]
                public string TimeStamp { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>9BEC5E85-C76B-56EF-A922-860EFDB8B64B</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2021-09-21T16:00:00Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
