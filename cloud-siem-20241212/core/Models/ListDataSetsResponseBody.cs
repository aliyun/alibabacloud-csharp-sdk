// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20241212.Models
{
    public class ListDataSetsResponseBody : TeaModel {
        [NameInMap("DataSets")]
        [Validation(Required=false)]
        public List<ListDataSetsResponseBodyDataSets> DataSets { get; set; }
        public class ListDataSetsResponseBodyDataSets : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>1713787368000</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>lmftest desc</para>
            /// </summary>
            [NameInMap("DataSetDescription")]
            [Validation(Required=false)]
            public string DataSetDescription { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ip</para>
            /// </summary>
            [NameInMap("DataSetFieldKeyName")]
            [Validation(Required=false)]
            public string DataSetFieldKeyName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>[&quot;ip&quot;,&quot;region&quot;]</para>
            /// </summary>
            [NameInMap("DataSetFieldNames")]
            [Validation(Required=false)]
            public string DataSetFieldNames { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>cloudsiem-dataset/1358117679873357_174338773****.csv</para>
            /// </summary>
            [NameInMap("DataSetFileName")]
            [Validation(Required=false)]
            public string DataSetFileName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>dataset-t8ha6p7k61rmniqw****</para>
            /// </summary>
            [NameInMap("DataSetId")]
            [Validation(Required=false)]
            public string DataSetId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>lmftest</para>
            /// </summary>
            [NameInMap("DataSetName")]
            [Validation(Required=false)]
            public string DataSetName { get; set; }

            [NameInMap("DataSetReferences")]
            [Validation(Required=false)]
            public List<ListDataSetsResponseBodyDataSetsDataSetReferences> DataSetReferences { get; set; }
            public class ListDataSetsResponseBodyDataSetsDataSetReferences : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>dataset-nhcrmjpx1zsorlaq****</para>
                /// </summary>
                [NameInMap("DataSetId")]
                [Validation(Required=false)]
                public string DataSetId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>456232</para>
                /// </summary>
                [NameInMap("DataSetReferenceId")]
                [Validation(Required=false)]
                public string DataSetReferenceId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>playbook_name</para>
                /// </summary>
                [NameInMap("DataSetReferenceName")]
                [Validation(Required=false)]
                public string DataSetReferenceName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>playbook</para>
                /// </summary>
                [NameInMap("DataSetReferenceType")]
                [Validation(Required=false)]
                public string DataSetReferenceType { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("DataSetStatus")]
            [Validation(Required=false)]
            public int? DataSetStatus { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>preset</para>
            /// </summary>
            [NameInMap("DataSetType")]
            [Validation(Required=false)]
            public string DataSetType { get; set; }

            [NameInMap("IpWhitelistRecognizers")]
            [Validation(Required=false)]
            public List<ListDataSetsResponseBodyDataSetsIpWhitelistRecognizers> IpWhitelistRecognizers { get; set; }
            public class ListDataSetsResponseBodyDataSetsIpWhitelistRecognizers : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>enabled</para>
                /// </summary>
                [NameInMap("AutoRecognizeStatus")]
                [Validation(Required=false)]
                public string AutoRecognizeStatus { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>waf_back_source_ip</para>
                /// </summary>
                [NameInMap("IpWhitelistRecognizerType")]
                [Validation(Required=false)]
                public string IpWhitelistRecognizerType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>current_account</para>
                /// </summary>
                [NameInMap("RecognizeScope")]
                [Validation(Required=false)]
                public string RecognizeScope { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1713787368000</para>
                /// </summary>
                [NameInMap("UpdateTime")]
                [Validation(Required=false)]
                public long? UpdateTime { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1713787368000</para>
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public long? UpdateTime { get; set; }

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
        /// <para>157CFBB5-B56F-566F-8991-B3C51799****</para>
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
