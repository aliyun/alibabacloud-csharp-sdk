// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pvtz20180101.Models
{
    public class DescribeUserVpcAuthorizationsResponseBody : TeaModel {
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
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>46973D4C-E3E4-4ABA-9190-9A9DE406C7E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("TotalItems")]
        [Validation(Required=false)]
        public int? TotalItems { get; set; }

        /// <summary>
        /// <para>The total number of returned pages.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("TotalPages")]
        [Validation(Required=false)]
        public int? TotalPages { get; set; }

        /// <summary>
        /// <para>The Alibaba Cloud accounts to which the permissions on the resources are granted.</para>
        /// </summary>
        [NameInMap("Users")]
        [Validation(Required=false)]
        public List<DescribeUserVpcAuthorizationsResponseBodyUsers> Users { get; set; }
        public class DescribeUserVpcAuthorizationsResponseBodyUsers : TeaModel {
            /// <summary>
            /// <para>The authorization scope. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>NORMAL: general authorization</description></item>
            /// <item><description>CLOUD_PRODUCT: cloud service-related authorization</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>NORMAL</para>
            /// </summary>
            [NameInMap("AuthType")]
            [Validation(Required=false)]
            public string AuthType { get; set; }

            /// <summary>
            /// <para>The name of the Alibaba Cloud account to which the permissions on the resources are granted.</para>
            /// 
            /// <b>Example:</b>
            /// <para>alidn****@test.com</para>
            /// </summary>
            [NameInMap("AuthorizedAliyunId")]
            [Validation(Required=false)]
            public string AuthorizedAliyunId { get; set; }

            /// <summary>
            /// <para>The ID of the Alibaba Cloud account to which the permissions on the resources are granted.</para>
            /// 
            /// <b>Example:</b>
            /// <para>141339776561****</para>
            /// </summary>
            [NameInMap("AuthorizedUserId")]
            [Validation(Required=false)]
            public long? AuthorizedUserId { get; set; }

            /// <summary>
            /// <para>The time when the authorization was performed. The time follows the ISO 8601 standard in the YYYY-MM-DDThh:mm:ssZ format. The time is displayed in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-05-08T02:31Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The time when the authorization was performed. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1672740294000</para>
            /// </summary>
            [NameInMap("CreateTimestamp")]
            [Validation(Required=false)]
            public long? CreateTimestamp { get; set; }

        }

    }

}
