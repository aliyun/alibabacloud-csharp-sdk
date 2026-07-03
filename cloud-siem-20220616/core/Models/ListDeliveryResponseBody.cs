// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20220616.Models
{
    public class ListDeliveryResponseBody : TeaModel {
        /// <summary>
        /// <para>The returned data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListDeliveryResponseBodyData Data { get; set; }
        public class ListDeliveryResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The URL of the dashboard on the log analysis page.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://sls4service.console.aliyun.com/lognext/project/aliyun-cloudsiem-data-127608589417****-cn-shanghai">https://sls4service.console.aliyun.com/lognext/project/aliyun-cloudsiem-data-127608589417****-cn-shanghai</a>
            /// /dashboard/cloud-siem?isShare=true&amp;hideTopbar=true&amp;hideSidebar=true&amp;ignoreTabLocalStorage=true</para>
            /// </summary>
            [NameInMap("DashboardUrl")]
            [Validation(Required=false)]
            public string DashboardUrl { get; set; }

            /// <summary>
            /// <para>Indicates whether to display the delivery switch. The default value is true. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>true: The delivery switch is displayed.</para>
            /// </description></item>
            /// <item><description><para>false: The delivery switch is hidden.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("DisplaySwitchOrNot")]
            [Validation(Required=false)]
            public bool? DisplaySwitchOrNot { get; set; }

            /// <summary>
            /// <para>The name of your LogStore for threat analysis. The format is \<c>cloud_siem\\</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cloud-siem</para>
            /// </summary>
            [NameInMap("LogStoreName")]
            [Validation(Required=false)]
            public string LogStoreName { get; set; }

            /// <summary>
            /// <para>A list of products.</para>
            /// </summary>
            [NameInMap("ProductList")]
            [Validation(Required=false)]
            public List<ListDeliveryResponseBodyDataProductList> ProductList { get; set; }
            public class ListDeliveryResponseBodyDataProductList : TeaModel {
                /// <summary>
                /// <para>A list of logs for cloud products that do not have subcategories.</para>
                /// </summary>
                [NameInMap("LogList")]
                [Validation(Required=false)]
                public List<ListDeliveryResponseBodyDataProductListLogList> LogList { get; set; }
                public class ListDeliveryResponseBodyDataProductListLogList : TeaModel {
                    /// <summary>
                    /// <para>Indicates whether the log delivery switch can be operated. Only the delegated administrator for threat analysis can operate the switch. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><para>true: The switch can be operated.</para>
                    /// </description></item>
                    /// <item><description><para>false: The switch cannot be operated.</para>
                    /// </description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("CanOperateOrNot")]
                    [Validation(Required=false)]
                    public bool? CanOperateOrNot { get; set; }

                    /// <summary>
                    /// <para>Additional parameters.</para>
                    /// </summary>
                    [NameInMap("ExtraParameters")]
                    [Validation(Required=false)]
                    public List<ListDeliveryResponseBodyDataProductListLogListExtraParameters> ExtraParameters { get; set; }
                    public class ListDeliveryResponseBodyDataProductListLogListExtraParameters : TeaModel {
                        /// <summary>
                        /// <para>The key of the additional parameter.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>flag</para>
                        /// </summary>
                        [NameInMap("Key")]
                        [Validation(Required=false)]
                        public string Key { get; set; }

                        /// <summary>
                        /// <para>The value of the additional parameter.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>value</para>
                        /// </summary>
                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                    /// <summary>
                    /// <para>The log code.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>cloud_siem_config_log</para>
                    /// </summary>
                    [NameInMap("LogCode")]
                    [Validation(Required=false)]
                    public string LogCode { get; set; }

                    /// <summary>
                    /// <para>This parameter is deprecated. You can ignore it.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>audit log</para>
                    /// </summary>
                    [NameInMap("LogName")]
                    [Validation(Required=false)]
                    public string LogName { get; set; }

                    /// <summary>
                    /// <para>This parameter is deprecated. You can ignore it.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>audit log</para>
                    /// </summary>
                    [NameInMap("LogNameEn")]
                    [Validation(Required=false)]
                    public string LogNameEn { get; set; }

                    /// <summary>
                    /// <para>The language key of the log name. This key is used to display the log name in different languages.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>${sas.cloudsiem.prod.cloud_siem_aegis_crack_from_beaver}</para>
                    /// </summary>
                    [NameInMap("LogNameKey")]
                    [Validation(Required=false)]
                    public string LogNameKey { get; set; }

                    /// <summary>
                    /// <para>The log delivery status. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><para>true: Delivery is in progress.</para>
                    /// </description></item>
                    /// <item><description><para>false: Delivery is disabled.</para>
                    /// </description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("Status")]
                    [Validation(Required=false)]
                    public bool? Status { get; set; }

                    /// <summary>
                    /// <para>The topic of the log in the LogStore. This parameter is an index field in the LogStore and is used to differentiate logs.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>sas_login_event</para>
                    /// </summary>
                    [NameInMap("Topic")]
                    [Validation(Required=false)]
                    public string Topic { get; set; }

                }

                /// <summary>
                /// <para>A list of logs that are categorized. For example, Security Center logs are categorized into groups such as Host and Network. The group is the key, and the logs in the group are the value.</para>
                /// </summary>
                [NameInMap("LogMap")]
                [Validation(Required=false)]
                public Dictionary<string, List<DataProductListLogMapValue>> LogMap { get; set; }

                /// <summary>
                /// <para>The code of the cloud product. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para>qcloud_waf</para>
                /// </description></item>
                /// <item><description><para>qcloud_cfw</para>
                /// </description></item>
                /// <item><description><para>hcloud_waf</para>
                /// </description></item>
                /// <item><description><para>hcloud_cfw</para>
                /// </description></item>
                /// <item><description><para>ddos</para>
                /// </description></item>
                /// <item><description><para>sas</para>
                /// </description></item>
                /// <item><description><para>cfw</para>
                /// </description></item>
                /// <item><description><para>config</para>
                /// </description></item>
                /// <item><description><para>csk</para>
                /// </description></item>
                /// <item><description><para>fc</para>
                /// </description></item>
                /// <item><description><para>rds</para>
                /// </description></item>
                /// <item><description><para>nas</para>
                /// </description></item>
                /// <item><description><para>apigateway</para>
                /// </description></item>
                /// <item><description><para>cdn</para>
                /// </description></item>
                /// <item><description><para>mongodb</para>
                /// </description></item>
                /// <item><description><para>eip</para>
                /// </description></item>
                /// <item><description><para>slb</para>
                /// </description></item>
                /// <item><description><para>vpc</para>
                /// </description></item>
                /// <item><description><para>actiontrail</para>
                /// </description></item>
                /// <item><description><para>waf</para>
                /// </description></item>
                /// <item><description><para>bastionhost</para>
                /// </description></item>
                /// <item><description><para>oss</para>
                /// </description></item>
                /// <item><description><para>polardb</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>sas</para>
                /// </summary>
                [NameInMap("ProductCode")]
                [Validation(Required=false)]
                public string ProductCode { get; set; }

                /// <summary>
                /// <para>This parameter is deprecated. You can ignore it.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Security Center</para>
                /// </summary>
                [NameInMap("ProductName")]
                [Validation(Required=false)]
                public string ProductName { get; set; }

            }

            /// <summary>
            /// <para>The name of your Simple Log Service (SLS) project for threat analysis. The format is \<c>aliyun-cloudsiem-data-${aliUid}-${region}\\</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>aliyun-cloudsiem-data-127608589417****-cn-shanghai</para>
            /// </summary>
            [NameInMap("ProjectName")]
            [Validation(Required=false)]
            public string ProjectName { get; set; }

            /// <summary>
            /// <para>The URL of the Search &amp; Analysis page in the SLS console.</para>
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
