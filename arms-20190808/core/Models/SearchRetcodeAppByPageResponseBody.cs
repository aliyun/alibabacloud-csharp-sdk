// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class SearchRetcodeAppByPageResponseBody : TeaModel {
        /// <summary>
        /// The returned page information.
        /// </summary>
        [NameInMap("PageBean")]
        [Validation(Required=false)]
        public SearchRetcodeAppByPageResponseBodyPageBean PageBean { get; set; }
        public class SearchRetcodeAppByPageResponseBodyPageBean : TeaModel {
            /// <summary>
            /// The page number of the returned page.
            /// </summary>
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            /// <summary>
            /// The number of entries returned per page.
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// The browser monitoring tasks that are returned.
            /// </summary>
            [NameInMap("RetcodeApps")]
            [Validation(Required=false)]
            public List<SearchRetcodeAppByPageResponseBodyPageBeanRetcodeApps> RetcodeApps { get; set; }
            public class SearchRetcodeAppByPageResponseBodyPageBeanRetcodeApps : TeaModel {
                /// <summary>
                /// The ID of the application. The parameter is an auto-increment parameter.
                /// </summary>
                [NameInMap("AppId")]
                [Validation(Required=false)]
                public long? AppId { get; set; }

                /// <summary>
                /// The name of the application.
                /// </summary>
                [NameInMap("AppName")]
                [Validation(Required=false)]
                public string AppName { get; set; }

                /// <summary>
                /// The time when the task was created.
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public long? CreateTime { get; set; }

                /// <summary>
                /// The alias of the application.
                /// </summary>
                [NameInMap("NickName")]
                [Validation(Required=false)]
                public string NickName { get; set; }

                /// <summary>
                /// The process identifier (PID) of the application.
                /// </summary>
                [NameInMap("Pid")]
                [Validation(Required=false)]
                public string Pid { get; set; }

                /// <summary>
                /// The region ID.
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// The ID of the resource group.
                /// </summary>
                [NameInMap("ResourceGroupId")]
                [Validation(Required=false)]
                public string ResourceGroupId { get; set; }

                /// <summary>
                /// The type of the application. Valid values:
                /// 
                /// *   `web`: web application
                /// *   `weex`: Weex mobile app
                /// *   `mini_dd`: DingTalk mini program
                /// *   `mini_alipay`: Alipay mini program
                /// *   `mini_wx`: WeChat mini program
                /// *   `mini_common`: mini program on other platforms
                /// </summary>
                [NameInMap("RetcodeAppType")]
                [Validation(Required=false)]
                public string RetcodeAppType { get; set; }

                /// <summary>
                /// The tag.
                /// </summary>
                [NameInMap("Tags")]
                [Validation(Required=false)]
                public List<SearchRetcodeAppByPageResponseBodyPageBeanRetcodeAppsTags> Tags { get; set; }
                public class SearchRetcodeAppByPageResponseBodyPageBeanRetcodeAppsTags : TeaModel {
                    /// <summary>
                    /// The tag key.
                    /// </summary>
                    [NameInMap("Key")]
                    [Validation(Required=false)]
                    public string Key { get; set; }

                    /// <summary>
                    /// The tag value.
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                /// <summary>
                /// The type of the monitoring task. Valid values:
                /// 
                /// *   `TRACE`: Application Monitoring
                /// *   `RETCODE`: Browser Monitoring
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                /// <summary>
                /// The time when the task was updated.
                /// </summary>
                [NameInMap("UpdateTime")]
                [Validation(Required=false)]
                public long? UpdateTime { get; set; }

                /// <summary>
                /// The user ID.
                /// </summary>
                [NameInMap("UserId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

            }

            /// <summary>
            /// The total number of returned entries.
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
