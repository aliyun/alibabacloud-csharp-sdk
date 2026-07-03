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
            /// <para>The time when the dataset was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1713787368000</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            /// <summary>
            /// <para>The description of the dataset.</para>
            /// 
            /// <b>Example:</b>
            /// <para>lmftest desc</para>
            /// </summary>
            [NameInMap("DataSetDescription")]
            [Validation(Required=false)]
            public string DataSetDescription { get; set; }

            /// <summary>
            /// <para>The name of the unique key for the dataset.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ip</para>
            /// </summary>
            [NameInMap("DataSetFieldKeyName")]
            [Validation(Required=false)]
            public string DataSetFieldKeyName { get; set; }

            /// <summary>
            /// <para>The names of the fields in the dataset.</para>
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
            /// <para>The ID of the dataset.</para>
            /// 
            /// <b>Example:</b>
            /// <para>dataset-t8ha6p7k61rmniqw****</para>
            /// </summary>
            [NameInMap("DataSetId")]
            [Validation(Required=false)]
            public string DataSetId { get; set; }

            /// <summary>
            /// <para>The name of the dataset.</para>
            /// 
            /// <b>Example:</b>
            /// <para>lmftest</para>
            /// </summary>
            [NameInMap("DataSetName")]
            [Validation(Required=false)]
            public string DataSetName { get; set; }

            /// <summary>
            /// <para>The dataset references.</para>
            /// </summary>
            [NameInMap("DataSetReferences")]
            [Validation(Required=false)]
            public List<ListDataSetsResponseBodyDataSetsDataSetReferences> DataSetReferences { get; set; }
            public class ListDataSetsResponseBodyDataSetsDataSetReferences : TeaModel {
                /// <summary>
                /// <para>The ID of the dataset.</para>
                /// 
                /// <b>Example:</b>
                /// <para>dataset-nhcrmjpx1zsorlaq****</para>
                /// </summary>
                [NameInMap("DataSetId")]
                [Validation(Required=false)]
                public string DataSetId { get; set; }

                /// <summary>
                /// <para>The ID of the rule or playbook that is associated with the dataset.</para>
                /// 
                /// <b>Example:</b>
                /// <para>456232</para>
                /// </summary>
                [NameInMap("DataSetReferenceId")]
                [Validation(Required=false)]
                public string DataSetReferenceId { get; set; }

                /// <summary>
                /// <para>The name of the rule or playbook that is associated with the dataset.</para>
                /// 
                /// <b>Example:</b>
                /// <para>playbook_name</para>
                /// </summary>
                [NameInMap("DataSetReferenceName")]
                [Validation(Required=false)]
                public string DataSetReferenceName { get; set; }

                /// <summary>
                /// <para>The type of the service that is associated with the dataset. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para>custom_rule: custom rule.</para>
                /// </description></item>
                /// <item><description><para>playbook: playbook.</para>
                /// </description></item>
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
            /// <para>The status of the dataset. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>0: deleted.</para>
            /// </description></item>
            /// <item><description><para>1: enabled.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("DataSetStatus")]
            [Validation(Required=false)]
            public int? DataSetStatus { get; set; }

            /// <summary>
            /// <para>The type of the dataset. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>custom: custom.</para>
            /// </description></item>
            /// <item><description><para>preset: predefined.</para>
            /// </description></item>
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
                /// <para>The status of automatic detection. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para>enabled: enabled.</para>
                /// </description></item>
                /// <item><description><para>disabled: disabled.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>enabled</para>
                /// </summary>
                [NameInMap("AutoRecognizeStatus")]
                [Validation(Required=false)]
                public string AutoRecognizeStatus { get; set; }

                /// <summary>
                /// <para>The type of IP address that the recognizer detects. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para>sas_vulnerability_scanner_ip: Security Center web vulnerability scanner IP address.</para>
                /// </description></item>
                /// <item><description><para>waf_back_source_ip: Web Application Firewall back-to-origin IP address.</para>
                /// </description></item>
                /// <item><description><para>ddos_back_source_ip: Anti-DDoS back-to-origin IP address.</para>
                /// </description></item>
                /// <item><description><para>esa_back_source_ip: Edge Security Acceleration (ESA) back-to-origin node IP address.</para>
                /// </description></item>
                /// <item><description><para>ecs_public_ip: Elastic Compute Service (ECS) public IP address.</para>
                /// </description></item>
                /// <item><description><para>slb_public_ip: Server Load Balancer (SLB) public IP address.</para>
                /// </description></item>
                /// <item><description><para>vpc_eip: Elastic IP Address (EIP).</para>
                /// </description></item>
                /// <item><description><para>cdn_back_source_ip: Alibaba Cloud CDN back-to-origin IP address.</para>
                /// </description></item>
                /// <item><description><para>ga_back_source_ip: Global Accelerator (GA) back-to-origin IP address.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>waf_back_source_ip</para>
                /// </summary>
                [NameInMap("IpWhitelistRecognizerType")]
                [Validation(Required=false)]
                public string IpWhitelistRecognizerType { get; set; }

                /// <summary>
                /// <para>The detection scope. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para>current_account: current account only.</para>
                /// </description></item>
                /// <item><description><para>rd_accounts: multiple accounts.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>current_account</para>
                /// </summary>
                [NameInMap("RecognizeScope")]
                [Validation(Required=false)]
                public string RecognizeScope { get; set; }

                /// <summary>
                /// <para>The time when the dataset was updated.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1713787368000</para>
                /// </summary>
                [NameInMap("UpdateTime")]
                [Validation(Required=false)]
                public long? UpdateTime { get; set; }

            }

            /// <summary>
            /// <para>The time when the dataset was updated.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1713787368000</para>
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public long? UpdateTime { get; set; }

        }

        /// <summary>
        /// <para>The maximum number of results to return for the request. This parameter is used for queries that use NextToken. Valid values: 1 to 100. Default value: 50.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The token that is used to start the next query.</para>
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
        /// <para>The total number of entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>57</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
