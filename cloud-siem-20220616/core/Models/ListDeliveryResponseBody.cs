// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20220616.Models
{
    public class ListDeliveryResponseBody : TeaModel {
        /// <summary>
        /// The response parameters.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListDeliveryResponseBodyData Data { get; set; }
        public class ListDeliveryResponseBodyData : TeaModel {
            /// <summary>
            /// The URL that is displayed in charts.
            /// </summary>
            [NameInMap("DashboardUrl")]
            [Validation(Required=false)]
            public string DashboardUrl { get; set; }

            /// <summary>
            /// Indicates whether the log delivery switch is displayed. Default value: true. Valid values:
            /// 
            /// *   true
            /// *   false
            /// </summary>
            [NameInMap("DisplaySwitchOrNot")]
            [Validation(Required=false)]
            public bool? DisplaySwitchOrNot { get; set; }

            /// <summary>
            /// The name of the Logstore for the threat analysis feature on the user side. The value is in the cloud_siem format.
            /// </summary>
            [NameInMap("LogStoreName")]
            [Validation(Required=false)]
            public string LogStoreName { get; set; }

            /// <summary>
            /// The cloud services.
            /// </summary>
            [NameInMap("ProductList")]
            [Validation(Required=false)]
            public List<ListDeliveryResponseBodyDataProductList> ProductList { get; set; }
            public class ListDeliveryResponseBodyDataProductList : TeaModel {
                /// <summary>
                /// The logs of the cloud services.
                /// </summary>
                [NameInMap("LogList")]
                [Validation(Required=false)]
                public List<ListDeliveryResponseBodyDataProductListLogList> LogList { get; set; }
                public class ListDeliveryResponseBodyDataProductListLogList : TeaModel {
                    /// <summary>
                    /// Indicates whether the log delivery feature can be enabled or disabled. The feature can be enabled or disabled only by the administrator of the threat analysis feature. Valid values:
                    /// 
                    /// *   true
                    /// *   false
                    /// </summary>
                    [NameInMap("CanOperateOrNot")]
                    [Validation(Required=false)]
                    public bool? CanOperateOrNot { get; set; }

                    /// <summary>
                    /// The extended parameter.
                    /// </summary>
                    [NameInMap("ExtraParameters")]
                    [Validation(Required=false)]
                    public List<ListDeliveryResponseBodyDataProductListLogListExtraParameters> ExtraParameters { get; set; }
                    public class ListDeliveryResponseBodyDataProductListLogListExtraParameters : TeaModel {
                        /// <summary>
                        /// The ID of the extended parameter.
                        /// </summary>
                        [NameInMap("Key")]
                        [Validation(Required=false)]
                        public string Key { get; set; }

                        /// <summary>
                        /// The value of the extended parameter.
                        /// </summary>
                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                    /// <summary>
                    /// The code of the log.
                    /// </summary>
                    [NameInMap("LogCode")]
                    [Validation(Required=false)]
                    public string LogCode { get; set; }

                    /// <summary>
                    /// This parameter is deprecated.
                    /// </summary>
                    [NameInMap("LogName")]
                    [Validation(Required=false)]
                    public string LogName { get; set; }

                    /// <summary>
                    /// This parameter is deprecated.
                    /// </summary>
                    [NameInMap("LogNameEn")]
                    [Validation(Required=false)]
                    public string LogNameEn { get; set; }

                    /// <summary>
                    /// The language code of the log that is used to indicate the language in which the log is displayed.
                    /// </summary>
                    [NameInMap("LogNameKey")]
                    [Validation(Required=false)]
                    public string LogNameKey { get; set; }

                    /// <summary>
                    /// The status of the log delivery. Valid values:
                    /// 
                    /// *   true: The logs are being delivered.
                    /// *   false: The log delivery feature is disabled.
                    /// </summary>
                    [NameInMap("Status")]
                    [Validation(Required=false)]
                    public bool? Status { get; set; }

                    /// <summary>
                    /// The topic of the log in the Logstore. The value is an index field in the Logstore that can be used to distinguish different logs.
                    /// </summary>
                    [NameInMap("Topic")]
                    [Validation(Required=false)]
                    public string Topic { get; set; }

                }

                /// <summary>
                /// The log group. For example, in Security Center, the logs of hosts and networks are stored in different groups. Key indicates the group information, and value indicates the logs in the group.
                /// </summary>
                [NameInMap("LogMap")]
                [Validation(Required=false)]
                public Dictionary<string, List<DataProductListLogMapValue>> LogMap { get; set; }

                /// <summary>
                /// The code of the cloud service. Valid values:
                /// 
                /// *   qcloud_waf
                /// *   qlcoud_cfw
                /// *   hcloud_waf
                /// *   hcloud_cfw
                /// *   ddos
                /// *   sas
                /// *   cfw
                /// *   config
                /// *   csk
                /// *   fc
                /// *   rds
                /// *   nas
                /// *   apigateway
                /// *   cdn
                /// *   mongodb
                /// *   eip
                /// *   slb
                /// *   vpc
                /// *   actiontrail
                /// *   waf
                /// *   bastionhost
                /// *   oss
                /// *   polardb
                /// </summary>
                [NameInMap("ProductCode")]
                [Validation(Required=false)]
                public string ProductCode { get; set; }

                /// <summary>
                /// This parameter is deprecated.
                /// </summary>
                [NameInMap("ProductName")]
                [Validation(Required=false)]
                public string ProductName { get; set; }

            }

            /// <summary>
            /// The name of the project for the threat analysis feature in Simple Log service on the user side. The value is in the aliyun-cloudsiem-data-${aliUid}-${region} format.
            /// </summary>
            [NameInMap("ProjectName")]
            [Validation(Required=false)]
            public string ProjectName { get; set; }

            /// <summary>
            /// The URL that is used for log analysis.
            /// </summary>
            [NameInMap("SearchUrl")]
            [Validation(Required=false)]
            public string SearchUrl { get; set; }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
