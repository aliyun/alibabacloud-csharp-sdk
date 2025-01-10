// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dm20151123.Models
{
    public class QueryDomainByParamResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>8C90CCD3-627C-4F87-AD8C-2F03146071EB</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        [NameInMap("data")]
        [Validation(Required=false)]
        public QueryDomainByParamResponseBodyData Data { get; set; }
        public class QueryDomainByParamResponseBodyData : TeaModel {
            [NameInMap("domain")]
            [Validation(Required=false)]
            public List<QueryDomainByParamResponseBodyDataDomain> Domain { get; set; }
            public class QueryDomainByParamResponseBodyDataDomain : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("CnameAuthStatus")]
                [Validation(Required=false)]
                public string CnameAuthStatus { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("ConfirmStatus")]
                [Validation(Required=false)]
                public string ConfirmStatus { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2019-09-29T13:28Z</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>158923</para>
                /// </summary>
                [NameInMap("DomainId")]
                [Validation(Required=false)]
                public string DomainId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>vmeixme.com</para>
                /// </summary>
                [NameInMap("DomainName")]
                [Validation(Required=false)]
                public string DomainName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>6bd86901b9fe4618a046</para>
                /// </summary>
                [NameInMap("DomainRecord")]
                [Validation(Required=false)]
                public string DomainRecord { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("DomainStatus")]
                [Validation(Required=false)]
                public string DomainStatus { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("IcpStatus")]
                [Validation(Required=false)]
                public string IcpStatus { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("MxAuthStatus")]
                [Validation(Required=false)]
                public string MxAuthStatus { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("SpfAuthStatus")]
                [Validation(Required=false)]
                public string SpfAuthStatus { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1569734892</para>
                /// </summary>
                [NameInMap("UtcCreateTime")]
                [Validation(Required=false)]
                public long? UtcCreateTime { get; set; }

            }

        }

    }

}
