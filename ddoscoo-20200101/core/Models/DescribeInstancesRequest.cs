// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class DescribeInstancesRequest : TeaModel {
        /// <summary>
        /// <para>The mitigation plan of the instance to query. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: Anti-DDoS Proxy (Outside Chinese Mainland) instance of the Insurance mitigation plan</description></item>
        /// <item><description><b>1</b>: Anti-DDoS Proxy (Outside Chinese Mainland) instance of the Unlimited mitigation plan</description></item>
        /// <item><description><b>2</b>: Anti-DDoS Proxy (Outside Chinese Mainland) instance of the Chinese Mainland Acceleration (CMA) mitigation plan</description></item>
        /// <item><description><b>9</b>: Anti-DDoS Proxy (Chinese Mainland) instance of the Profession mitigation plan</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>9</para>
        /// </summary>
        [NameInMap("Edition")]
        [Validation(Required=false)]
        public int? Edition { get; set; }

        /// <summary>
        /// <para>The traffic forwarding status of the instance to query. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: The instance no longer forwards service traffic.</description></item>
        /// <item><description><b>1</b>: The instance forwards service traffic as expected.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Enabled")]
        [Validation(Required=false)]
        public int? Enabled { get; set; }

        /// <summary>
        /// <para>The end of the time range to query. Instances whose expiration time is earlier than the point in time are queried. This value is a UNIX timestamp. Unit: milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1640361700000</para>
        /// </summary>
        [NameInMap("ExpireEndTime")]
        [Validation(Required=false)]
        public long? ExpireEndTime { get; set; }

        /// <summary>
        /// <para>The beginning of the time range to query. Instances whose expiration time is later than the point in time are queried. This value is a UNIX timestamp. Unit: milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1640361500000</para>
        /// </summary>
        [NameInMap("ExpireStartTime")]
        [Validation(Required=false)]
        public long? ExpireStartTime { get; set; }

        /// <summary>
        /// <para>The IDs of the instances to query. You can specify up to 200 instance IDs.</para>
        /// </summary>
        [NameInMap("InstanceIds")]
        [Validation(Required=false)]
        public List<string> InstanceIds { get; set; }

        /// <summary>
        /// <para>The IP address of the instance to query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>203.107.XX.XX</para>
        /// </summary>
        [NameInMap("Ip")]
        [Validation(Required=false)]
        public string Ip { get; set; }

        /// <summary>
        /// <para>The number of the page to return.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public string PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries to return on each page.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public string PageSize { get; set; }

        /// <summary>
        /// <para>The remarks of the instance to query. Fuzzy match is supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>doc-test</para>
        /// </summary>
        [NameInMap("Remark")]
        [Validation(Required=false)]
        public string Remark { get; set; }

        /// <summary>
        /// <para>The ID of the resource group to which the instance belongs in Resource Management.</para>
        /// <para>If you do not specify this parameter, the instance belongs to the default resource group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfm2pz25js****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The states of the instances to query. You can specify up to two states.</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public List<int?> Status { get; set; }

        /// <summary>
        /// <para>The tags that are added to the instances to query.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<DescribeInstancesRequestTag> Tag { get; set; }
        public class DescribeInstancesRequestTag : TeaModel {
            /// <summary>
            /// <para>The key of the tag that is added to the instance to query. You can specify up to 200 tag keys. When you specify tags, take note of the following rules:</para>
            /// <list type="bullet">
            /// <item><description>Each tag consists of a key (<b>Key</b>) and a value (<b>Value</b>), which are separated with a comma (,).</description></item>
            /// <item><description>Separate multiple tags with commas (,).</description></item>
            /// </list>
            /// <remarks>
            /// <para> The tag key (<b>Key</b>) and tag value (<b>Value</b>) must be specified in pairs.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>test-key</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The value of the tag that is added to the instance to query. You can specify up to 200 tag values. When you specify tags, take note of the following rules:</para>
            /// <list type="bullet">
            /// <item><description>Each tag consists of a key (<b>Key</b>) and a value (<b>Value</b>), which are separated with a comma (,).</description></item>
            /// <item><description>Separate multiple tags with commas (,).</description></item>
            /// </list>
            /// <remarks>
            /// <para> The tag key (<b>Key</b>) and tag value (<b>Value</b>) must be specified in pairs.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>test-value</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
