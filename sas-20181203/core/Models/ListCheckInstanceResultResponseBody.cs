// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ListCheckInstanceResultResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of basic information about the affected instances.</para>
        /// </summary>
        [NameInMap("BasicData")]
        [Validation(Required=false)]
        public List<ListCheckInstanceResultResponseBodyBasicData> BasicData { get; set; }
        public class ListCheckInstanceResultResponseBodyBasicData : TeaModel {
            /// <summary>
            /// <para>The ID of the check result for the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>300054</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <para>The instance ID of the server.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rm-m5es7ch1s62i4****</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The instance information displayed for the check item.</para>
            /// </summary>
            [NameInMap("InstanceInfo")]
            [Validation(Required=false)]
            public ListCheckInstanceResultResponseBodyBasicDataInstanceInfo InstanceInfo { get; set; }
            public class ListCheckInstanceResultResponseBodyBasicDataInstanceInfo : TeaModel {
                /// <summary>
                /// <para>The current instance information displayed for the remediation configuration.</para>
                /// </summary>
                [NameInMap("Config")]
                [Validation(Required=false)]
                public List<ListCheckInstanceResultResponseBodyBasicDataInstanceInfoConfig> Config { get; set; }
                public class ListCheckInstanceResultResponseBodyBasicDataInstanceInfoConfig : TeaModel {
                    /// <summary>
                    /// <para>The unique name of the configuration.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>prot</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <para>The localized name of the configuration item.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>prot</para>
                    /// </summary>
                    [NameInMap("ShowName")]
                    [Validation(Required=false)]
                    public string ShowName { get; set; }

                    /// <summary>
                    /// <para>The value of the configuration for the current asset.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>8080</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                /// <summary>
                /// <para>The time of the first check. The value is a UNIX timestamp in milliseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1716447535531</para>
                /// </summary>
                [NameInMap("FirstUpdateTime")]
                [Validation(Required=false)]
                public long? FirstUpdateTime { get; set; }

                /// <summary>
                /// <para>The time of the latest check. The value is a UNIX timestamp in milliseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1716447535531</para>
                /// </summary>
                [NameInMap("LastUpdateTime")]
                [Validation(Required=false)]
                public long? LastUpdateTime { get; set; }

            }

            /// <summary>
            /// <para>The name of the server instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sg-t4nbk2aodzio52xv****</para>
            /// </summary>
            [NameInMap("InstanceName")]
            [Validation(Required=false)]
            public string InstanceName { get; set; }

            /// <summary>
            /// <para>The region ID of the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ap-southeast-1</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>The statuses of the check item. Multiple statuses are separated by commas (,). Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>PASS</b>: Passed.</description></item>
            /// <item><description><b>NOT_PASS</b>: Not passed.</description></item>
            /// <item><description><b>CHECKING</b>: Checking.</description></item>
            /// <item><description><b>NOT_CHECK</b>: Not checked.</description></item>
            /// <item><description><b>WHITELIST</b>: Whitelisted.</description></item>
            /// <item><description><b>FAILED</b>: Failed.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>NOT_PASS</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The status exception message for the check item.</para>
            /// 
            /// <b>Example:</b>
            /// <para>The check task failed</para>
            /// </summary>
            [NameInMap("StatusMessage")]
            [Validation(Required=false)]
            public string StatusMessage { get; set; }

            /// <summary>
            /// <para>The multi-cloud vendor account name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("VendorUserName")]
            [Validation(Required=false)]
            public string VendorUserName { get; set; }

        }

        /// <summary>
        /// <para>The list of extended information about the affected instances.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{
        ///     &quot;SecurityGroupNameShow&quot;: {
        ///         &quot;value&quot;: &quot;Sas_Malicious_Ip_Security_Group&quot;
        ///     },
        ///     &quot;InstanceIdShow&quot;: {
        ///         &quot;link&quot;: &quot;<a href="https://ecs.console.aliyun.com/#/securityGroupDetail/region/ap-southeast-1/groupId/sg-t4nbk2aodzio52xvj00s/rule/intranetIngress">https://ecs.console.aliyun.com/#/securityGroupDetail/region/ap-southeast-1/groupId/sg-t4nbk2aodzio52xvj00s/rule/intranetIngress</a>&quot;,
        ///         &quot;value&quot;: &quot;sg-t4nbk2aodzio52xv****&quot;
        ///     }
        /// }]</para>
        /// </summary>
        [NameInMap("Checks")]
        [Validation(Required=false)]
        public List<Dictionary<string, object>> Checks { get; set; }

        /// <summary>
        /// <para>The metadata for the affected instances display list.</para>
        /// </summary>
        [NameInMap("Columns")]
        [Validation(Required=false)]
        public List<ListCheckInstanceResultResponseBodyColumns> Columns { get; set; }
        public class ListCheckInstanceResultResponseBodyColumns : TeaModel {
            /// <summary>
            /// <para>The metadata list for the list type.</para>
            /// </summary>
            [NameInMap("Grids")]
            [Validation(Required=false)]
            public List<ListCheckInstanceResultResponseBodyColumnsGrids> Grids { get; set; }
            public class ListCheckInstanceResultResponseBodyColumnsGrids : TeaModel {
                /// <summary>
                /// <para>The search value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>RegionIdShow</para>
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <para>The display name for search.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Region</para>
                /// </summary>
                [NameInMap("ShowName")]
                [Validation(Required=false)]
                public string ShowName { get; set; }

                /// <summary>
                /// <para>The type of the check result for the instance. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>text</b>: Text.</description></item>
                /// <item><description><b>link</b>: Link.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>text</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <para>The key of the list property.</para>
            /// 
            /// <b>Example:</b>
            /// <para>RegionIdShow</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>Specifies whether search is supported. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: Supported.</description></item>
            /// <item><description><b>false</b>: Not supported.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Search")]
            [Validation(Required=false)]
            public bool? Search { get; set; }

            /// <summary>
            /// <para>The key used for search.</para>
            /// 
            /// <b>Example:</b>
            /// <para>InstanceIdKey</para>
            /// </summary>
            [NameInMap("SearchKey")]
            [Validation(Required=false)]
            public string SearchKey { get; set; }

            /// <summary>
            /// <para>The display name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Region</para>
            /// </summary>
            [NameInMap("ShowName")]
            [Validation(Required=false)]
            public string ShowName { get; set; }

            /// <summary>
            /// <para>The property type of the check result for the instance. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>text</b>: Text.</description></item>
            /// <item><description><b>link</b>: Link.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>text</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>The paging information displayed for a paging query.</para>
        /// </summary>
        [NameInMap("PageInfo")]
        [Validation(Required=false)]
        public ListCheckInstanceResultResponseBodyPageInfo PageInfo { get; set; }
        public class ListCheckInstanceResultResponseBodyPageInfo : TeaModel {
            /// <summary>
            /// <para>The number of entries returned on the current page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("Count")]
            [Validation(Required=false)]
            public string Count { get; set; }

            /// <summary>
            /// <para>The page number of the current page for a paging query.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public int? CurrentPage { get; set; }

            /// <summary>
            /// <para>The maximum number of entries returned per page for a paging query.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The total number of entries.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request. The ID is a unique identifier generated by Alibaba Cloud for the request and can be used for troubleshooting.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3AB18264-8A1B-52A6-A9AF-A886556E0F2E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
