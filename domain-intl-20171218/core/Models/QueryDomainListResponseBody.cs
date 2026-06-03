// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Domain_intl20171218.Models
{
    public class QueryDomainListResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPageNum")]
        [Validation(Required=false)]
        public int? CurrentPageNum { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryDomainListResponseBodyData Data { get; set; }
        public class QueryDomainListResponseBodyData : TeaModel {
            [NameInMap("Domain")]
            [Validation(Required=false)]
            public List<QueryDomainListResponseBodyDataDomain> Domain { get; set; }
            public class QueryDomainListResponseBodyDataDomain : TeaModel {
                [NameInMap("DomainAuditStatus")]
                [Validation(Required=false)]
                public string DomainAuditStatus { get; set; }

                [NameInMap("DomainName")]
                [Validation(Required=false)]
                public string DomainName { get; set; }

                [NameInMap("DomainStatus")]
                [Validation(Required=false)]
                public string DomainStatus { get; set; }

                [NameInMap("DomainType")]
                [Validation(Required=false)]
                public string DomainType { get; set; }

                [NameInMap("ExpirationCurrDateDiff")]
                [Validation(Required=false)]
                public int? ExpirationCurrDateDiff { get; set; }

                [NameInMap("ExpirationDate")]
                [Validation(Required=false)]
                public string ExpirationDate { get; set; }

                [NameInMap("ExpirationDateLong")]
                [Validation(Required=false)]
                public long? ExpirationDateLong { get; set; }

                [NameInMap("ExpirationDateStatus")]
                [Validation(Required=false)]
                public string ExpirationDateStatus { get; set; }

                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                [NameInMap("Premium")]
                [Validation(Required=false)]
                public bool? Premium { get; set; }

                [NameInMap("ProductId")]
                [Validation(Required=false)]
                public string ProductId { get; set; }

                [NameInMap("RegistrantType")]
                [Validation(Required=false)]
                public string RegistrantType { get; set; }

                [NameInMap("RegistrationDate")]
                [Validation(Required=false)]
                public string RegistrationDate { get; set; }

                [NameInMap("RegistrationDateLong")]
                [Validation(Required=false)]
                public long? RegistrationDateLong { get; set; }

                [NameInMap("Remark")]
                [Validation(Required=false)]
                public string Remark { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>False</para>
        /// </summary>
        [NameInMap("NextPage")]
        [Validation(Required=false)]
        public bool? NextPage { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>True</para>
        /// </summary>
        [NameInMap("PrePage")]
        [Validation(Required=false)]
        public bool? PrePage { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>AF7D4DCE-0776-47F2-A9B2-6FB85A87AA60</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("TotalItemNum")]
        [Validation(Required=false)]
        public int? TotalItemNum { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("TotalPageNum")]
        [Validation(Required=false)]
        public int? TotalPageNum { get; set; }

    }

}
