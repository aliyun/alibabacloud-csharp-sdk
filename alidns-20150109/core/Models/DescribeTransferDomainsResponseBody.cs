// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class DescribeTransferDomainsResponseBody : TeaModel {
        [NameInMap("DomainTransfers")]
        [Validation(Required=false)]
        public DescribeTransferDomainsResponseBodyDomainTransfers DomainTransfers { get; set; }
        public class DescribeTransferDomainsResponseBodyDomainTransfers : TeaModel {
            [NameInMap("DomainTransfer")]
            [Validation(Required=false)]
            public List<DescribeTransferDomainsResponseBodyDomainTransfersDomainTransfer> DomainTransfer { get; set; }
            public class DescribeTransferDomainsResponseBodyDomainTransfersDomainTransfer : TeaModel {
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                [NameInMap("CreateTimestamp")]
                [Validation(Required=false)]
                public long? CreateTimestamp { get; set; }

                [NameInMap("DomainName")]
                [Validation(Required=false)]
                public string DomainName { get; set; }

                [NameInMap("FromUserId")]
                [Validation(Required=false)]
                public long? FromUserId { get; set; }

                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                [NameInMap("TargetUserId")]
                [Validation(Required=false)]
                public long? TargetUserId { get; set; }

            }

        }

        /// <summary>
        /// <para>The page number. The value starts from <b>1</b>. The default value is <b>1</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page. The maximum value is 100. The default value is 20.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// <para>The unique request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>536E9CAD-DB30-4647-AC87-AA5CC38C5382</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
