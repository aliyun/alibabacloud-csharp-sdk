// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribeBatchSlsDispatchStatusResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of Logstore details.</para>
        /// </summary>
        [NameInMap("InfoList")]
        [Validation(Required=false)]
        public List<DescribeBatchSlsDispatchStatusResponseBodyInfoList> InfoList { get; set; }
        public class DescribeBatchSlsDispatchStatusResponseBodyInfoList : TeaModel {
            /// <summary>
            /// <para>The log delivery configuration details.</para>
            /// </summary>
            [NameInMap("ItemList")]
            [Validation(Required=false)]
            public List<DescribeBatchSlsDispatchStatusResponseBodyInfoListItemList> ItemList { get; set; }
            public class DescribeBatchSlsDispatchStatusResponseBodyInfoListItemList : TeaModel {
                /// <summary>
                /// <para>The configuration status.</para>
                /// 
                /// <b>Example:</b>
                /// <para>success_finished</para>
                /// </summary>
                [NameInMap("ConfigStatus")]
                [Validation(Required=false)]
                public string ConfigStatus { get; set; }

                /// <summary>
                /// <para>The name of the delivery type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>internet-traffic-log</para>
                /// </summary>
                [NameInMap("DispatchName")]
                [Validation(Required=false)]
                public string DispatchName { get; set; }

                /// <summary>
                /// <para>The log classification key. Valid values:</para>
                /// <para><b>internet_log</b></para>
                /// <para><b>vpc_firewall_log</b></para>
                /// <para><b>nat_firewall_log</b></para>
                /// <para><b>ipv6_firewall_log</b></para>
                /// <para><b>dns_firewall_log</b></para>
                /// 
                /// <b>Example:</b>
                /// <para>ipv6_firewall_log</para>
                /// </summary>
                [NameInMap("DispatchValue")]
                [Validation(Required=false)]
                public string DispatchValue { get; set; }

                /// <summary>
                /// <para>The enablement status of the delivery type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("Enable")]
                [Validation(Required=false)]
                public bool? Enable { get; set; }

                /// <summary>
                /// <para>The detailed delivery configuration for the Internet and VPC firewalls.</para>
                /// </summary>
                [NameInMap("FilterKeys")]
                [Validation(Required=false)]
                public List<string> FilterKeys { get; set; }

                /// <summary>
                /// <para>The name of the search type. This parameter is fixed as log_type and can be ignored.</para>
                /// 
                /// <b>Example:</b>
                /// <para>log_type</para>
                /// </summary>
                [NameInMap("SearchName")]
                [Validation(Required=false)]
                public string SearchName { get; set; }

            }

            /// <summary>
            /// <para>The name of the Logstore in Simple Log Service.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cloudfirewall-logstore</para>
            /// </summary>
            [NameInMap("LogstoreName")]
            [Validation(Required=false)]
            public string LogstoreName { get; set; }

            /// <summary>
            /// <para>The name of the project in Simple Log Service.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cloudfirewall-project-1204872307283650-cn-hangzhou</para>
            /// </summary>
            [NameInMap("ProjectName")]
            [Validation(Required=false)]
            public string ProjectName { get; set; }

            /// <summary>
            /// <para>The site. A value of cn indicates the Chinese mainland, intl indicates regions outside the Chinese mainland, and global indicates global.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn</para>
            /// </summary>
            [NameInMap("Site")]
            [Validation(Required=false)]
            public string Site { get; set; }

        }

        /// <summary>
        /// <para>The list of log services.</para>
        /// </summary>
        [NameInMap("ItemList")]
        [Validation(Required=false)]
        public List<DescribeBatchSlsDispatchStatusResponseBodyItemList> ItemList { get; set; }
        public class DescribeBatchSlsDispatchStatusResponseBodyItemList : TeaModel {
            /// <summary>
            /// <para>The delivery configuration status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>success_finished</para>
            /// </summary>
            [NameInMap("ConfigStatus")]
            [Validation(Required=false)]
            public string ConfigStatus { get; set; }

            /// <summary>
            /// <para>The name of the delivery type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>internet-traffic-log</para>
            /// </summary>
            [NameInMap("DispatchName")]
            [Validation(Required=false)]
            public string DispatchName { get; set; }

            /// <summary>
            /// <para>The value of the log classification.</para>
            /// 
            /// <b>Example:</b>
            /// <para>internet_log</para>
            /// </summary>
            [NameInMap("DispatchValue")]
            [Validation(Required=false)]
            public string DispatchValue { get; set; }

            /// <summary>
            /// <para>The delivery status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Enable")]
            [Validation(Required=false)]
            public bool? Enable { get; set; }

            /// <summary>
            /// <para>The supported filter conditions for the Internet and VPC firewalls.</para>
            /// </summary>
            [NameInMap("FilterKeys")]
            [Validation(Required=false)]
            public List<string> FilterKeys { get; set; }

            /// <summary>
            /// <para>The name of the search type. This parameter is fixed as log_type and can be ignored.</para>
            /// 
            /// <b>Example:</b>
            /// <para>log_type</para>
            /// </summary>
            [NameInMap("SearchName")]
            [Validation(Required=false)]
            public string SearchName { get; set; }

        }

        /// <summary>
        /// <para>The log version. A value of 1 indicates one Logstore, and a value of 2 indicates two Logstores.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("LogVersion")]
        [Validation(Required=false)]
        public string LogVersion { get; set; }

        /// <summary>
        /// <para>The name of the Logstore in Simple Log Service.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rs-stats</para>
        /// </summary>
        [NameInMap("LogstoreName")]
        [Validation(Required=false)]
        public string LogstoreName { get; set; }

        /// <summary>
        /// <para>The name of the project in Simple Log Service.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cloudfirewallnew-project-199053910542****-cn-hangzhou</para>
        /// </summary>
        [NameInMap("ProjectName")]
        [Validation(Required=false)]
        public string ProjectName { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7036EBAB-F85F-5AAE-976F-C75AEE59****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
