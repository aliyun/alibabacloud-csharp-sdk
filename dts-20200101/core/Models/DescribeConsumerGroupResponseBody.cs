// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dts20200101.Models
{
    public class DescribeConsumerGroupResponseBody : TeaModel {
        [NameInMap("ConsumerChannels")]
        [Validation(Required=false)]
        public DescribeConsumerGroupResponseBodyConsumerChannels ConsumerChannels { get; set; }
        public class DescribeConsumerGroupResponseBodyConsumerChannels : TeaModel {
            [NameInMap("DescribeConsumerChannel")]
            [Validation(Required=false)]
            public List<DescribeConsumerGroupResponseBodyConsumerChannelsDescribeConsumerChannel> DescribeConsumerChannel { get; set; }
            public class DescribeConsumerGroupResponseBodyConsumerChannelsDescribeConsumerChannel : TeaModel {
                [NameInMap("ConsumerGroupID")]
                [Validation(Required=false)]
                public string ConsumerGroupID { get; set; }

                [NameInMap("ConsumerGroupName")]
                [Validation(Required=false)]
                public string ConsumerGroupName { get; set; }

                [NameInMap("ConsumerGroupUserName")]
                [Validation(Required=false)]
                public string ConsumerGroupUserName { get; set; }

                [NameInMap("ConsumptionCheckpoint")]
                [Validation(Required=false)]
                public string ConsumptionCheckpoint { get; set; }

                [NameInMap("MessageDelay")]
                [Validation(Required=false)]
                public long? MessageDelay { get; set; }

                [NameInMap("UnconsumedData")]
                [Validation(Required=false)]
                public long? UnconsumedData { get; set; }

            }

        }

        /// <summary>
        /// <para>The error code returned if the call failed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>InternalError</para>
        /// </summary>
        [NameInMap("ErrCode")]
        [Validation(Required=false)]
        public string ErrCode { get; set; }

        /// <summary>
        /// <para>The error message returned if the call failed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>The request processing has failed due to some unknown error.</para>
        /// </summary>
        [NameInMap("ErrMessage")]
        [Validation(Required=false)]
        public string ErrMessage { get; set; }

        /// <summary>
        /// <para>The page number of the returned page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The maximum number of consumer groups that can be displayed on one page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("PageRecordCount")]
        [Validation(Required=false)]
        public int? PageRecordCount { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4204E899-8193-4D7D-A4FB-3A7F9063****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the call was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public string Success { get; set; }

        /// <summary>
        /// <para>The total number of consumer groups.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalRecordCount")]
        [Validation(Required=false)]
        public int? TotalRecordCount { get; set; }

    }

}
