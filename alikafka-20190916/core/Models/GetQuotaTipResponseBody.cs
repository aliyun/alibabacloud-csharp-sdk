// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alikafka20190916.Models
{
    public class GetQuotaTipResponseBody : TeaModel {
        /// <summary>
        /// <para>The HTTP status code returned. The HTTP status code 200 indicates that the request is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <para>The additional message. This message is typically used to describe API call failures for troubleshooting.</para>
        /// 
        /// <b>Example:</b>
        /// <para>operation success.</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The quota.</para>
        /// </summary>
        [NameInMap("QuotaData")]
        [Validation(Required=false)]
        public GetQuotaTipResponseBodyQuotaData QuotaData { get; set; }
        public class GetQuotaTipResponseBodyQuotaData : TeaModel {
            /// <summary>
            /// <para>The number of available groups.</para>
            /// 
            /// <b>Example:</b>
            /// <para>50</para>
            /// </summary>
            [NameInMap("GroupLeft")]
            [Validation(Required=false)]
            public int? GroupLeft { get; set; }

            /// <summary>
            /// <para>The number of used groups.</para>
            /// 
            /// <b>Example:</b>
            /// <para>50</para>
            /// </summary>
            [NameInMap("GroupUsed")]
            [Validation(Required=false)]
            public int? GroupUsed { get; set; }

            /// <summary>
            /// <para>The method that you use to purchase partitions. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>0: indicates that the instance is purchased based on topics.</description></item>
            /// <item><description>1: indicates that the instance is purchased based on partitions.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("IsPartitionBuy")]
            [Validation(Required=false)]
            public int? IsPartitionBuy { get; set; }

            /// <summary>
            /// <para>The number of available partitions.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1050</para>
            /// </summary>
            [NameInMap("PartitionLeft")]
            [Validation(Required=false)]
            public int? PartitionLeft { get; set; }

            /// <summary>
            /// <para>The number of purchased partitions.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("PartitionNumOfBuy")]
            [Validation(Required=false)]
            public int? PartitionNumOfBuy { get; set; }

            /// <summary>
            /// <para>The quota of partitions.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1100</para>
            /// </summary>
            [NameInMap("PartitionQuota")]
            [Validation(Required=false)]
            public int? PartitionQuota { get; set; }

            /// <summary>
            /// <para>The number of used partitions.</para>
            /// 
            /// <b>Example:</b>
            /// <para>50</para>
            /// </summary>
            [NameInMap("PartitionUsed")]
            [Validation(Required=false)]
            public int? PartitionUsed { get; set; }

            /// <summary>
            /// <para>The number of available topics.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("TopicLeft")]
            [Validation(Required=false)]
            public int? TopicLeft { get; set; }

            /// <summary>
            /// <para>The number of purchased topics.</para>
            /// 
            /// <b>Example:</b>
            /// <para>50</para>
            /// </summary>
            [NameInMap("TopicNumOfBuy")]
            [Validation(Required=false)]
            public int? TopicNumOfBuy { get; set; }

            /// <summary>
            /// <para>The quota of topics.</para>
            /// 
            /// <b>Example:</b>
            /// <para>50</para>
            /// </summary>
            [NameInMap("TopicQuota")]
            [Validation(Required=false)]
            public int? TopicQuota { get; set; }

            /// <summary>
            /// <para>The number of used topics.</para>
            /// 
            /// <b>Example:</b>
            /// <para>30</para>
            /// </summary>
            [NameInMap("TopicUsed")]
            [Validation(Required=false)]
            public int? TopicUsed { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0178A3A7-E87B-5E50-A16F-3E62F534****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>True</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
