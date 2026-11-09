// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Wss20211221.Models
{
    public class DescribeInstanceAutoRenewalAttributeResponseBody : TeaModel {
        /// <summary>
        /// <para>The total number of entries that meet the query conditions.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("Count")]
        [Validation(Required=false)]
        public int? Count { get; set; }

        /// <summary>
        /// <para>The list of instances and their auto-renewal status.</para>
        /// </summary>
        [NameInMap("InstanceAttribute")]
        [Validation(Required=false)]
        public List<DescribeInstanceAutoRenewalAttributeResponseBodyInstanceAttribute> InstanceAttribute { get; set; }
        public class DescribeInstanceAutoRenewalAttributeResponseBodyInstanceAttribute : TeaModel {
            /// <summary>
            /// <para>The ID of the Alibaba Cloud account to which the resource belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123456789012****</para>
            /// </summary>
            [NameInMap("AliUid")]
            [Validation(Required=false)]
            public long? AliUid { get; set; }

            /// <summary>
            /// <para>The auto-renewal status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true: Auto-renewal is enabled.</description></item>
            /// <item><description>false: Auto-renewal is disabled.</description></item>
            /// </list>
            /// </summary>
            [NameInMap("AutoRenewal")]
            [Validation(Required=false)]
            public bool? AutoRenewal { get; set; }

            /// <summary>
            /// <para>The instance ID, which identifies the purchased instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cp-0bw2ew49****</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

        }

        /// <summary>
        /// <para>The maximum number of entries to return per query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The mark for paging. Leave this parameter empty for the first query. For subsequent paging, pass the NextToken value returned in the previous response as is. Do not construct or decode the value.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AAAAAV3MpHK1AP0pfERHZN5pu6k=</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The page number of the paging query, starting from 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNo")]
        [Validation(Required=false)]
        public int? PageNo { get; set; }

        /// <summary>
        /// <para>The maximum number of entries returned per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The unique identifier of the request. You can use this ID to troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>72481C12-69AB-5CE1-8A35-A8EFA921****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
