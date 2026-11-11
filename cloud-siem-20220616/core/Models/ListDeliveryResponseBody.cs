// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20220616.Models
{
    public class ListDeliveryResponseBody : TeaModel {
        /// <summary>
        /// <para>The detailed response data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListDeliveryResponseBodyData Data { get; set; }
        public class ListDeliveryResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The URL for dashboard display on the log analysis page.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://sls4service.console.aliyun.com/lognext/project/aliyun-cloudsiem-data-127608589417****-cn-shanghai">https://sls4service.console.aliyun.com/lognext/project/aliyun-cloudsiem-data-127608589417****-cn-shanghai</a>
            /// /dashboard/cloud-siem?isShare=true&amp;hideTopbar=true&amp;hideSidebar=true&amp;ignoreTabLocalStorage=true</para>
            /// </summary>
            [NameInMap("DashboardUrl")]
            [Validation(Required=false)]
            public string DashboardUrl { get; set; }

            /// <summary>
            /// <para>Specifies whether to display the delivery switch. Default value: true. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true: Display the delivery switch.</description></item>
            /// <item><description>false: Hide the delivery switch.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("DisplaySwitchOrNot")]
            [Validation(Required=false)]
            public bool? DisplaySwitchOrNot { get; set; }

            /// <summary>
            /// <para>The name of the Logstore on the user side of Threat Analysis. Format: cloud_siem.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cloud-siem</para>
            /// </summary>
            [NameInMap("LogStoreName")]
            [Validation(Required=false)]
            public string LogStoreName { get; set; }

            /// <summary>
            /// <para>The list of products.</para>
            /// </summary>
            [NameInMap("ProductList")]
            [Validation(Required=false)]
            public List<ListDeliveryResponseBodyDataProductList> ProductList { get; set; }
            public class ListDeliveryResponseBodyDataProductList : TeaModel {
                /// <summary>
                /// <para>The cloud services that do not have finer categories.</para>
                /// </summary>
                [NameInMap("LogList")]
                [Validation(Required=false)]
                public List<ListDeliveryResponseBodyDataProductListLogList> LogList { get; set; }
                public class ListDeliveryResponseBodyDataProductListLogList : TeaModel {
                    /// <summary>
                    /// <para>Specifies whether the log delivery switch can be operated. Only the delegated administrator of Threat Analysis can operate the log delivery switch. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>true: The switch can be operated.</description></item>
                    /// <item><description>false: The switch cannot be operated.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("CanOperateOrNot")]
                    [Validation(Required=false)]
                    public bool? CanOperateOrNot { get; set; }

                    /// <summary>
                    /// <para>The extended parameters.</para>
                    /// </summary>
                    [NameInMap("ExtraParameters")]
                    [Validation(Required=false)]
                    public List<ListDeliveryResponseBodyDataProductListLogListExtraParameters> ExtraParameters { get; set; }
                    public class ListDeliveryResponseBodyDataProductListLogListExtraParameters : TeaModel {
                        /// <summary>
                        /// <para>The identifier of the extended parameter.</para>
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
                    /// <para>The log code.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>cloud_siem_config_log</para>
                    /// </summary>
                    [NameInMap("LogCode")]
                    [Validation(Required=false)]
                    public string LogCode { get; set; }

                    /// <summary>
                    /// <para><b>[Deprecated]</b> This parameter is deprecated and can be ignored.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>audit log</para>
                    /// </summary>
                    [NameInMap("LogName")]
                    [Validation(Required=false)]
                    public string LogName { get; set; }

                    /// <summary>
                    /// <para><b>[Deprecated]</b> This parameter is deprecated and can be ignored.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>audit log</para>
                    /// </summary>
                    [NameInMap("LogNameEn")]
                    [Validation(Required=false)]
                    public string LogNameEn { get; set; }

                    /// <summary>
                    /// <para>The language code of the log, which is used to display multilingual names.</para>
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
                    /// <item><description>true: Delivery is in progress.  </description></item>
                    /// <item><description>false: Delivery is disabled.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("Status")]
                    [Validation(Required=false)]
                    public bool? Status { get; set; }

                    /// <summary>
                    /// <para>The topic of the log in the Logstore. It is an index field of the Logstore and can be used to distinguish different logs.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>sas_login_event</para>
                    /// </summary>
                    [NameInMap("Topic")]
                    [Validation(Required=false)]
                    public string Topic { get; set; }

                }

                /// <summary>
                /// <para>The list of logs that have categories. For example, Security Center has groups such as host and network. The group information is the key, and the logs included in the group are the value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{&quot;key&quot;:[{&quot;LogCode&quot;:&quot;cloud_siem_config_log&quot;,&quot;LogName&quot;:&quot;audit log&quot;,&quot;LogNameEn&quot;:&quot;audit log&quot;,&quot;LogNameKey&quot;:&quot;${sas.cloudsiem.prod.cloud_siem_aegis_crack_from_beaver}&quot;,&quot;Status&quot;:true,&quot;CanOperateOrNot&quot;:true,&quot;Topic&quot;:&quot;sas_login_event&quot;,&quot;ExtraParameters&quot;:[{&quot;Key&quot;:&quot;flag&quot;,&quot;Value&quot;:&quot;value&quot;}]}]}</para>
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
                /// <para><b>[Deprecated]</b> This parameter is deprecated and can be ignored.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Security Center</para>
                /// </summary>
                [NameInMap("ProductName")]
                [Validation(Required=false)]
                public string ProductName { get; set; }

            }

            /// <summary>
            /// <para>The name of the Log Service project on the user side of Threat Analysis. Format: aliyun-cloudsiem-data-${aliUid}-${region}.</para>
            /// 
            /// <b>Example:</b>
            /// <para>aliyun-cloudsiem-data-127608589417****-cn-shanghai</para>
            /// </summary>
            [NameInMap("ProjectName")]
            [Validation(Required=false)]
            public string ProjectName { get; set; }

            /// <summary>
            /// <para>The URL for query and analysis on the log analysis page.</para>
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
