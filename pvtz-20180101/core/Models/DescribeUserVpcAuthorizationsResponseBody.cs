// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pvtz20180101.Models
{
    public class DescribeUserVpcAuthorizationsResponseBody : TeaModel {
        /// <summary>
        /// <para>The page number of the returned data.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries returned per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The unique request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>46973D4C-E3E4-4ABA-9190-9A9DE406C7E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of authorizations.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("TotalItems")]
        [Validation(Required=false)]
        public int? TotalItems { get; set; }

        /// <summary>
        /// <para>The total number of pages returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("TotalPages")]
        [Validation(Required=false)]
        public int? TotalPages { get; set; }

        /// <summary>
        /// <para>The information about the Alibaba Cloud accounts that own the authorized resources.</para>
        /// </summary>
        [NameInMap("Users")]
        [Validation(Required=false)]
        public List<DescribeUserVpcAuthorizationsResponseBodyUsers> Users { get; set; }
        public class DescribeUserVpcAuthorizationsResponseBodyUsers : TeaModel {
            /// <summary>
            /// <para>The authorization type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>NORMAL: A regular authorization.</para>
            /// </description></item>
            /// <item><description><para>CLOUD_PRODUCT: An authorization for an Alibaba Cloud service.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>NORMAL</para>
            /// </summary>
            [NameInMap("AuthType")]
            [Validation(Required=false)]
            public string AuthType { get; set; }

            /// <summary>
            /// <para>The name of the Alibaba Cloud account that owns the authorized resources.</para>
            /// 
            /// <b>Example:</b>
            /// <para>alidn****@test.com</para>
            /// </summary>
            [NameInMap("AuthorizedAliyunId")]
            [Validation(Required=false)]
            public string AuthorizedAliyunId { get; set; }

            /// <summary>
            /// <para>The ID of the Alibaba Cloud account that owns the authorized resources.</para>
            /// 
            /// <b>Example:</b>
            /// <para>141339776561****</para>
            /// </summary>
            [NameInMap("AuthorizedUserId")]
            [Validation(Required=false)]
            public long? AuthorizedUserId { get; set; }

            /// <summary>
            /// <para>The time when the authorization was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-05-08T02:31Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The timestamp that indicates when the authorization was created.</para>
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
