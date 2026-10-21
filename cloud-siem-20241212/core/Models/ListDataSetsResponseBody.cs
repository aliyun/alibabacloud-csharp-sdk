// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20241212.Models
{
    public class ListDataSetsResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of datasets.</para>
        /// </summary>
        [NameInMap("DataSets")]
        [Validation(Required=false)]
        public List<ListDataSetsResponseBodyDataSets> DataSets { get; set; }
        public class ListDataSetsResponseBodyDataSets : TeaModel {
            /// <summary>
            /// <para>The creation time. This value is a UNIX timestamp in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1713787368000</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            /// <summary>
            /// <para>The dataset description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>lmftest desc</para>
            /// </summary>
            [NameInMap("DataSetDescription")]
            [Validation(Required=false)]
            public string DataSetDescription { get; set; }

            /// <summary>
            /// <para>The unique key name of the dataset.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ip</para>
            /// </summary>
            [NameInMap("DataSetFieldKeyName")]
            [Validation(Required=false)]
            public string DataSetFieldKeyName { get; set; }

            /// <summary>
            /// <para>The field names of the dataset.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[&quot;ip&quot;,&quot;region&quot;]</para>
            /// </summary>
            [NameInMap("DataSetFieldNames")]
            [Validation(Required=false)]
            public string DataSetFieldNames { get; set; }

            /// <summary>
            /// <para>The name of the uploaded dataset file.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cloudsiem-dataset/1358117679873357_174338773****.csv</para>
            /// </summary>
            [NameInMap("DataSetFileName")]
            [Validation(Required=false)]
            public string DataSetFileName { get; set; }

            /// <summary>
            /// <para>The dataset ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>dataset-t8ha6p7k61rmniqw****</para>
            /// </summary>
            [NameInMap("DataSetId")]
            [Validation(Required=false)]
            public string DataSetId { get; set; }

            /// <summary>
            /// <para>The dataset name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>lmftest</para>
            /// </summary>
            [NameInMap("DataSetName")]
            [Validation(Required=false)]
            public string DataSetName { get; set; }

            /// <summary>
            /// <para>The dataset reference data.</para>
            /// </summary>
            [NameInMap("DataSetReferences")]
            [Validation(Required=false)]
            public List<ListDataSetsResponseBodyDataSetsDataSetReferences> DataSetReferences { get; set; }
            public class ListDataSetsResponseBodyDataSetsDataSetReferences : TeaModel {
                /// <summary>
                /// <para>The dataset ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>dataset-nhcrmjpx1zsorlaq****</para>
                /// </summary>
                [NameInMap("DataSetId")]
                [Validation(Required=false)]
                public string DataSetId { get; set; }

                /// <summary>
                /// <para>The ID of the rule or playbook associated with the dataset.</para>
                /// 
                /// <b>Example:</b>
                /// <para>456232</para>
                /// </summary>
                [NameInMap("DataSetReferenceId")]
                [Validation(Required=false)]
                public string DataSetReferenceId { get; set; }

                /// <summary>
                /// <para>The name of the rule or playbook associated with the dataset.</para>
                /// 
                /// <b>Example:</b>
                /// <para>playbook_name</para>
                /// </summary>
                [NameInMap("DataSetReferenceName")]
                [Validation(Required=false)]
                public string DataSetReferenceName { get; set; }

                /// <summary>
                /// <para>The type of service associated with the dataset. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>custom_rule: custom rule.</description></item>
                /// <item><description>playbook: playbook.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>playbook</para>
                /// </summary>
                [NameInMap("DataSetReferenceType")]
                [Validation(Required=false)]
                public string DataSetReferenceType { get; set; }

            }

            /// <summary>
            /// <para>The dataset status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>0: deleted.</description></item>
            /// <item><description>1: enabled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("DataSetStatus")]
            [Validation(Required=false)]
            public int? DataSetStatus { get; set; }

            /// <summary>
            /// <para>The dataset type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>custom: custom dataset.</description></item>
            /// <item><description>preset: predefined dataset.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>preset</para>
            /// </summary>
            [NameInMap("DataSetType")]
            [Validation(Required=false)]
            public string DataSetType { get; set; }

            /// <summary>
            /// <para>The list of recognizers.</para>
            /// </summary>
            [NameInMap("IpWhitelistRecognizers")]
            [Validation(Required=false)]
            public List<ListDataSetsResponseBodyDataSetsIpWhitelistRecognizers> IpWhitelistRecognizers { get; set; }
            public class ListDataSetsResponseBodyDataSetsIpWhitelistRecognizers : TeaModel {
                /// <summary>
                /// <para>The automatic recognition status. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>enabled: enabled.</description></item>
                /// <item><description>disabled: disabled.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>enabled</para>
                /// </summary>
                [NameInMap("AutoRecognizeStatus")]
                [Validation(Required=false)]
                public string AutoRecognizeStatus { get; set; }

                /// <summary>
                /// <para>The IP type identified by the recognizer. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>sas_vulnerability_scanner_ip: IP addresses of the Security Center vulnerability web scanner.</description></item>
                /// <item><description>waf_back_source_ip: back-to-origin IP addresses of Web Application Firewall (WAF).</description></item>
                /// <item><description>ddos_back_source_ip: back-to-origin IP addresses of Anti-DDoS.</description></item>
                /// <item><description>esa_back_source_ip: back-to-origin node IP addresses of Edge Security Acceleration (ESA).</description></item>
                /// <item><description>ecs_public_ip: public IP addresses of Elastic Compute Service (ECS) instances.</description></item>
                /// <item><description>slb_public_ip: public IP addresses of Server Load Balancer (SLB) instances.</description></item>
                /// <item><description>vpc_eip: elastic IP addresses (EIPs).</description></item>
                /// <item><description>cdn_back_source_ip: back-to-origin IP addresses of Content Delivery Network (CDN).</description></item>
                /// <item><description>ga_back_source_ip: back-to-origin IP addresses of Global Accelerator (GA).</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>waf_back_source_ip</para>
                /// </summary>
                [NameInMap("IpWhitelistRecognizerType")]
                [Validation(Required=false)]
                public string IpWhitelistRecognizerType { get; set; }

                /// <summary>
                /// <para>The recognition scope. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>current_account: current account only.</description></item>
                /// <item><description>rd_accounts: multi-account enabled.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>current_account</para>
                /// </summary>
                [NameInMap("RecognizeScope")]
                [Validation(Required=false)]
                public string RecognizeScope { get; set; }

                /// <summary>
                /// <para>The update time. This value is a UNIX timestamp in milliseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1713787368000</para>
                /// </summary>
                [NameInMap("UpdateTime")]
                [Validation(Required=false)]
                public long? UpdateTime { get; set; }

            }

            /// <summary>
            /// <para>The update time. This value is a UNIX timestamp in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1713787368000</para>
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public long? UpdateTime { get; set; }

        }

        /// <summary>
        /// <para>The maximum number of results to return when you use the NextToken-based pagination method. Valid values: 1 to 100. Default value: 50.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The pagination token for the next query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AAAAAUqcj6VO4E3ECWIrFczs****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

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
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>157CFBB5-B56F-566F-8991-B3C51799****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of records.</para>
        /// 
        /// <b>Example:</b>
        /// <para>57</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
