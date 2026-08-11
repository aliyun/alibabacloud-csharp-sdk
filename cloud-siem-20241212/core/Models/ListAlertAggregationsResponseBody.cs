// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20241212.Models
{
    public class ListAlertAggregationsResponseBody : TeaModel {
        [NameInMap("AlertAggregations")]
        [Validation(Required=false)]
        public List<ListAlertAggregationsResponseBodyAlertAggregations> AlertAggregations { get; set; }
        public class ListAlertAggregationsResponseBodyAlertAggregations : TeaModel {
            [NameInMap("AccountDisplayValues")]
            [Validation(Required=false)]
            public List<string> AccountDisplayValues { get; set; }

            [NameInMap("AccountIds")]
            [Validation(Required=false)]
            public List<string> AccountIds { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>vendor_product:alibaba_cloud:sas</para>
            /// </summary>
            [NameInMap("AggregationKey")]
            [Validation(Required=false)]
            public string AggregationKey { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>5m-avg</para>
            /// </summary>
            [NameInMap("AggregationType")]
            [Validation(Required=false)]
            public string AggregationType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>25</para>
            /// </summary>
            [NameInMap("AlertCount")]
            [Validation(Required=false)]
            public long? AlertCount { get; set; }

            [NameInMap("AttackStages")]
            [Validation(Required=false)]
            public List<string> AttackStages { get; set; }

            [NameInMap("DefenseActionCounts")]
            [Validation(Required=false)]
            public List<ListAlertAggregationsResponseBodyAlertAggregationsDefenseActionCounts> DefenseActionCounts { get; set; }
            public class ListAlertAggregationsResponseBodyAlertAggregationsDefenseActionCounts : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>accesstoken</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>测试-前途系统AI</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public long? Value { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1785290308</para>
            /// </summary>
            [NameInMap("FirstTime")]
            [Validation(Required=false)]
            public long? FirstTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1785293908000</para>
            /// </summary>
            [NameInMap("LatestTime")]
            [Validation(Required=false)]
            public long? LatestTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Test incident</para>
            /// </summary>
            [NameInMap("PrimaryDisplayValue")]
            [Validation(Required=false)]
            public string PrimaryDisplayValue { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>alibaba_cloud</para>
            /// </summary>
            [NameInMap("PrimaryValue")]
            [Validation(Required=false)]
            public string PrimaryValue { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>sas</para>
            /// </summary>
            [NameInMap("SecondaryValue")]
            [Validation(Required=false)]
            public string SecondaryValue { get; set; }

            [NameInMap("SourceCodes")]
            [Validation(Required=false)]
            public List<string> SourceCodes { get; set; }

            [NameInMap("StatusCounts")]
            [Validation(Required=false)]
            public List<ListAlertAggregationsResponseBodyAlertAggregationsStatusCounts> StatusCounts { get; set; }
            public class ListAlertAggregationsResponseBodyAlertAggregationsStatusCounts : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para><a href="http://domain.com/">http://domain.com/</a></para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>123.123.123.123</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public long? Value { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>AAAAAUqcj6VO4E3ECWIrFczs****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>9AAA9ED9-78F4-5021-86DC-D51C7511****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>57</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
