// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20220616.Models
{
    public class ListDeliveryResponseBody : TeaModel {
        /// <summary>
        /// <para>The response parameters.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListDeliveryResponseBodyData Data { get; set; }
        public class ListDeliveryResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The URL that is displayed in charts.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://sls4service.console.aliyun.com/lognext/project/aliyun-cloudsiem-data-127608589417****-cn-shanghai">https://sls4service.console.aliyun.com/lognext/project/aliyun-cloudsiem-data-127608589417****-cn-shanghai</a>
            /// /dashboard/cloud-siem?isShare=true&amp;hideTopbar=true&amp;hideSidebar=true&amp;ignoreTabLocalStorage=true</para>
            /// </summary>
            [NameInMap("DashboardUrl")]
            [Validation(Required=false)]
            public string DashboardUrl { get; set; }

            /// <summary>
            /// <para>Indicates whether the log delivery switch is displayed. Default value: true. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true</description></item>
            /// <item><description>false</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("DisplaySwitchOrNot")]
            [Validation(Required=false)]
            public bool? DisplaySwitchOrNot { get; set; }

            /// <summary>
            /// <para>The name of the Logstore for the threat analysis feature on the user side. The value is in the cloud_siem format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cloud-siem</para>
            /// </summary>
            [NameInMap("LogStoreName")]
            [Validation(Required=false)]
            public string LogStoreName { get; set; }

            /// <summary>
            /// <para>The cloud services.</para>
            /// </summary>
            [NameInMap("ProductList")]
            [Validation(Required=false)]
            public List<ListDeliveryResponseBodyDataProductList> ProductList { get; set; }
            public class ListDeliveryResponseBodyDataProductList : TeaModel {
                /// <summary>
                /// <para>The logs of the cloud services.</para>
                /// </summary>
                [NameInMap("LogList")]
                [Validation(Required=false)]
                public List<ListDeliveryResponseBodyDataProductListLogList> LogList { get; set; }
                public class ListDeliveryResponseBodyDataProductListLogList : TeaModel {
                    /// <summary>
                    /// <para>Indicates whether the log delivery feature can be enabled or disabled. The feature can be enabled or disabled only by the administrator of the threat analysis feature. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>true</description></item>
                    /// <item><description>false</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("CanOperateOrNot")]
                    [Validation(Required=false)]
                    public bool? CanOperateOrNot { get; set; }

                    /// <summary>
                    /// <para>The extended parameter.</para>
                    /// </summary>
                    [NameInMap("ExtraParameters")]
                    [Validation(Required=false)]
                    public List<ListDeliveryResponseBodyDataProductListLogListExtraParameters> ExtraParameters { get; set; }
                    public class ListDeliveryResponseBodyDataProductListLogListExtraParameters : TeaModel {
                        /// <summary>
                        /// <para>The ID of the extended parameter.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>flag</para>
                        /// </summary>
                        [NameInMap("Key")]
                        [Validation(Required=false)]
                        public string Key { get; set; }

                        /// <summary>
                        /// <para>The value of the extended parameter.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>value</para>
                        /// </summary>
                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                    /// <summary>
                    /// <para>The code of the log.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>cloud_siem_config_log</para>
                    /// </summary>
                    [NameInMap("LogCode")]
                    [Validation(Required=false)]
                    public string LogCode { get; set; }

                    /// <summary>
                    /// <para>This parameter is deprecated.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>audit log</para>
                    /// </summary>
                    [NameInMap("LogName")]
                    [Validation(Required=false)]
                    public string LogName { get; set; }

                    /// <summary>
                    /// <para>This parameter is deprecated.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>audit log</para>
                    /// </summary>
                    [NameInMap("LogNameEn")]
                    [Validation(Required=false)]
                    public string LogNameEn { get; set; }

                    /// <summary>
                    /// <para>The language code of the log that is used to indicate the language in which the log is displayed.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>${sas.cloudsiem.prod.cloud_siem_aegis_crack_from_beaver}</para>
                    /// </summary>
                    [NameInMap("LogNameKey")]
                    [Validation(Required=false)]
                    public string LogNameKey { get; set; }

                    /// <summary>
                    /// <para>The status of the log delivery. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>true: The logs are being delivered.</description></item>
                    /// <item><description>false: The log delivery feature is disabled.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("Status")]
                    [Validation(Required=false)]
                    public bool? Status { get; set; }

                    /// <summary>
                    /// <para>The topic of the log in the Logstore. The value is an index field in the Logstore that can be used to distinguish different logs.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>sas_login_event</para>
                    /// </summary>
                    [NameInMap("Topic")]
                    [Validation(Required=false)]
                    public string Topic { get; set; }

                }

                /// <summary>
                /// <para>The log group. For example, in Security Center, the logs of hosts and networks are stored in different groups. Key indicates the group information, and value indicates the logs in the group.</para>
                /// </summary>
                [NameInMap("LogMap")]
                [Validation(Required=false)]
                public Dictionary<string, List<DataProductListLogMapValue>> LogMap { get; set; }

                /// <summary>
                /// <para>The code of the cloud service. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>qcloud_waf</description></item>
                /// <item><description>qlcoud_cfw</description></item>
                /// <item><description>hcloud_waf</description></item>
                /// <item><description>hcloud_cfw</description></item>
                /// <item><description>ddos</description></item>
                /// <item><description>sas</description></item>
                /// <item><description>cfw</description></item>
                /// <item><description>config</description></item>
                /// <item><description>csk</description></item>
                /// <item><description>fc</description></item>
                /// <item><description>rds</description></item>
                /// <item><description>nas</description></item>
                /// <item><description>apigateway</description></item>
                /// <item><description>cdn</description></item>
                /// <item><description>mongodb</description></item>
                /// <item><description>eip</description></item>
                /// <item><description>slb</description></item>
                /// <item><description>vpc</description></item>
                /// <item><description>actiontrail</description></item>
                /// <item><description>waf</description></item>
                /// <item><description>bastionhost</description></item>
                /// <item><description>oss</description></item>
                /// <item><description>polardb</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>sas</para>
                /// </summary>
                [NameInMap("ProductCode")]
                [Validation(Required=false)]
                public string ProductCode { get; set; }

                /// <summary>
                /// <para>This parameter is deprecated.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Security Center</para>
                /// </summary>
                [NameInMap("ProductName")]
                [Validation(Required=false)]
                public string ProductName { get; set; }

            }

            /// <summary>
            /// <para>The name of the project for the threat analysis feature in Simple Log service on the user side. The value is in the aliyun-cloudsiem-data-${aliUid}-${region} format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>aliyun-cloudsiem-data-127608589417****-cn-shanghai</para>
            /// </summary>
            [NameInMap("ProjectName")]
            [Validation(Required=false)]
            public string ProjectName { get; set; }

            /// <summary>
            /// <para>The URL that is used for log analysis.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://sls4service.console.aliyun.com/lognext/project/aliyun-cloudsiem-data-127608589417****-cn-shanghai">https://sls4service.console.aliyun.com/lognext/project/aliyun-cloudsiem-data-127608589417****-cn-shanghai</a>
            /// /logsearch/cloud-siem?isShare=true&amp;hideTopbar=true&amp;hideSidebar=true&amp;ignoreTabLocalStorage=true</para>
            /// </summary>
            [NameInMap("SearchUrl")]
            [Validation(Required=false)]
            public string SearchUrl { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6276D891-58D4-55B2-87B9-74D413F7****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
