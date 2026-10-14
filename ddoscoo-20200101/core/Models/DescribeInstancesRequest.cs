// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class DescribeInstancesRequest : TeaModel {
        /// <summary>
        /// <para>The mitigation plan edition of the Anti-DDoS Pro or Anti-DDoS Premium instance to query. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: Anti-DDoS Pro and Anti-DDoS Premium (outside the Chinese mainland) Insurance edition.</description></item>
        /// <item><description><b>1</b>: Anti-DDoS Pro and Anti-DDoS Premium (outside the Chinese mainland) Unlimited edition.</description></item>
        /// <item><description><b>2</b>: Anti-DDoS Pro and Anti-DDoS Premium (outside the Chinese mainland) acceleration line.</description></item>
        /// <item><description><b>9</b>: Anti-DDoS Pro and Anti-DDoS Premium (the Chinese mainland) Professional Edition.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>9</para>
        /// </summary>
        [NameInMap("Edition")]
        [Validation(Required=false)]
        public int? Edition { get; set; }

        /// <summary>
        /// <para>The service traffic forwarding status of the Anti-DDoS Pro or Anti-DDoS Premium instance to query. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: Service traffic forwarding is stopped.</description></item>
        /// <item><description><b>1</b>: Service traffic forwarding is normal.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Enabled")]
        [Validation(Required=false)]
        public int? Enabled { get; set; }

        /// <summary>
        /// <para>The latest expiration time of the Anti-DDoS Pro or Anti-DDoS Premium instances to query. This means that only instances whose expiration time is earlier than the value of <b>ExpireEndTime</b> are queried. The value is a UNIX timestamp in milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1640361700000</para>
        /// </summary>
        [NameInMap("ExpireEndTime")]
        [Validation(Required=false)]
        public long? ExpireEndTime { get; set; }

        /// <summary>
        /// <para>The earliest expiration time of the Anti-DDoS Pro or Anti-DDoS Premium instances to query. This means that only instances whose expiration time is later than the value of <b>ExpireStartTime</b> are queried. The value is a UNIX timestamp in milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1640361500000</para>
        /// </summary>
        [NameInMap("ExpireStartTime")]
        [Validation(Required=false)]
        public long? ExpireStartTime { get; set; }

        /// <summary>
        /// <para>The IDs of the Anti-DDoS Pro or Anti-DDoS Premium instances to query. You can specify up to 200 Anti-DDoS Pro or Anti-DDoS Premium instances.</para>
        /// </summary>
        [NameInMap("InstanceIds")]
        [Validation(Required=false)]
        public List<string> InstanceIds { get; set; }

        /// <summary>
        /// <para>The IP address of the Anti-DDoS Pro or Anti-DDoS Premium instance to query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>203.107.XX.XX</para>
        /// </summary>
        [NameInMap("Ip")]
        [Validation(Required=false)]
        public string Ip { get; set; }

        /// <summary>
        /// <para>The page number for paging.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public string PageNumber { get; set; }

        /// <summary>
        /// <para>The number of instances per page for paging. Valid values: 1 to 50.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public string PageSize { get; set; }

        /// <summary>
        /// <para>The remark of the Anti-DDoS Pro or Anti-DDoS Premium instance to query. Fuzzy match is supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>doc-test</para>
        /// </summary>
        [NameInMap("Remark")]
        [Validation(Required=false)]
        public string Remark { get; set; }

        /// <summary>
        /// <para>The ID of the resource group to which the Anti-DDoS Pro or Anti-DDoS Premium instance belongs in Resource Management.</para>
        /// <para>If you do not specify this parameter, the default resource group is used.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfm2pz25js****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The statuses of the Anti-DDoS Pro or Anti-DDoS Premium instances to query. You can specify up to 2 Anti-DDoS Pro or Anti-DDoS Premium instance statuses.</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public List<int?> Status { get; set; }

        /// <summary>
        /// <para>The tags attached to the Anti-DDoS Pro or Anti-DDoS Premium instances to query.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<DescribeInstancesRequestTag> Tag { get; set; }
        public class DescribeInstancesRequestTag : TeaModel {
            /// <summary>
            /// <para>The tag key attached to the Anti-DDoS Pro or Anti-DDoS Premium instance to query. Maximum value of N: 200, which means you can specify up to 200 tag keys. The configuration rules are as follows:</para>
            /// <list type="bullet">
            /// <item><description>Each tag consists of a tag key (<b>Key</b>) and a tag value (<b>Value</b>), separated by a comma (,).</description></item>
            /// <item><description>Tags are separated by commas (,).</description></item>
            /// </list>
            /// <remarks>
            /// <para>The tag key (<b>Key</b>) and tag value (<b>Value</b>) must appear in pairs.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>test-key</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value attached to the Anti-DDoS Pro or Anti-DDoS Premium instance to query. Maximum value of N: 200, which means you can specify up to 200 tag values. The configuration rules are as follows:</para>
            /// <list type="bullet">
            /// <item><description>Each tag consists of a tag key (<b>Key</b>) and a tag value (<b>Value</b>), separated by a comma (,).</description></item>
            /// <item><description>Tags are separated by commas (,).</description></item>
            /// </list>
            /// <remarks>
            /// <para>The tag key (<b>Key</b>) and tag value (<b>Value</b>) must appear in pairs.</para>
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
