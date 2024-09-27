// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class DescribeTransferDomainsResponseBody : TeaModel {
        /// <summary>
        /// <para>The domain names that were transferred between accounts.</para>
        /// </summary>
        [NameInMap("DomainTransfers")]
        [Validation(Required=false)]
        public DescribeTransferDomainsResponseBodyDomainTransfers DomainTransfers { get; set; }
        public class DescribeTransferDomainsResponseBodyDomainTransfers : TeaModel {
            [NameInMap("DomainTransfer")]
            [Validation(Required=false)]
            public List<DescribeTransferDomainsResponseBodyDomainTransfersDomainTransfer> DomainTransfer { get; set; }
            public class DescribeTransferDomainsResponseBodyDomainTransfersDomainTransfer : TeaModel {
                /// <summary>
                /// <para>The time when the domain name was created. The time follows the ISO 8601 standard in the YYYY-MM-DDThh:mm:ss format. The time is displayed in UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2019-10-30T07:16Z</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// <para>The time when the domain name was created. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1572419764000</para>
                /// </summary>
                [NameInMap("CreateTimestamp")]
                [Validation(Required=false)]
                public long? CreateTimestamp { get; set; }

                /// <summary>
                /// <para>The domain name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test.com</para>
                /// </summary>
                [NameInMap("DomainName")]
                [Validation(Required=false)]
                public string DomainName { get; set; }

                /// <summary>
                /// <para>The user ID from which the domain name was transferred.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2222</para>
                /// </summary>
                [NameInMap("FromUserId")]
                [Validation(Required=false)]
                public long? FromUserId { get; set; }

                /// <summary>
                /// <para>The ID of the domain name that was transferred.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// <para>The user ID to which the domain name was transferred.</para>
                /// 
                /// <b>Example:</b>
                /// <para>111111</para>
                /// </summary>
                [NameInMap("TargetUserId")]
                [Validation(Required=false)]
                public long? TargetUserId { get; set; }

            }

        }

        /// <summary>
        /// <para>The page number. Pages start from page <b>1</b>. Default value: <b>1</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Valid values: 1 to 100. Default value: 20.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>536E9CAD-DB30-4647-AC87-AA5CC38C5382</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
