// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ListCheckInstanceResultResponseBody : TeaModel {
        /// <summary>
        /// <para>The basic information about the affected instances.</para>
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
            /// <para>The information about the instance on which the check item is used.</para>
            /// </summary>
            [NameInMap("InstanceInfo")]
            [Validation(Required=false)]
            public ListCheckInstanceResultResponseBodyBasicDataInstanceInfo InstanceInfo { get; set; }
            public class ListCheckInstanceResultResponseBodyBasicDataInstanceInfo : TeaModel {
                /// <summary>
                /// <para>The information about the configuration item whose risks are fixed for the instance.</para>
                /// </summary>
                [NameInMap("Config")]
                [Validation(Required=false)]
                public List<ListCheckInstanceResultResponseBodyBasicDataInstanceInfoConfig> Config { get; set; }
                public class ListCheckInstanceResultResponseBodyBasicDataInstanceInfoConfig : TeaModel {
                    /// <summary>
                    /// <para>The name of the configuration item, which is unique.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>prot</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <para>The display name of the configuration item for internationalization.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>prot</para>
                    /// </summary>
                    [NameInMap("ShowName")]
                    [Validation(Required=false)]
                    public string ShowName { get; set; }

                    /// <summary>
                    /// <para>The value of the configuration item specified for the instance.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>8080</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                /// <summary>
                /// <para>The time of the first check.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1716447535531</para>
                /// </summary>
                [NameInMap("FirstUpdateTime")]
                [Validation(Required=false)]
                public long? FirstUpdateTime { get; set; }

                /// <summary>
                /// <para>The time of the last check.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1716447535531</para>
                /// </summary>
                [NameInMap("LastUpdateTime")]
                [Validation(Required=false)]
                public long? LastUpdateTime { get; set; }

            }

            /// <summary>
            /// <para>The instance name of the server.</para>
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
            /// <para>The states of check items. Multiple states are separated with commas (,). Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>PASS</b>: passed</description></item>
            /// <item><description><b>NOT_PASS</b>: failed</description></item>
            /// <item><description><b>CHECKING</b>: being checked</description></item>
            /// <item><description><b>NOT_CHECK</b>: not checked</description></item>
            /// <item><description><b>WHITELIST</b>: added to the whitelist</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>NOT_PASS</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The exception message of the check item.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Task is failed.</para>
            /// </summary>
            [NameInMap("StatusMessage")]
            [Validation(Required=false)]
            public string StatusMessage { get; set; }

        }

        /// <summary>
        /// <para>The extended information about the instances.</para>
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
        /// <para>The metadata information about the search conditions that can be used to filter instances.</para>
        /// </summary>
        [NameInMap("Columns")]
        [Validation(Required=false)]
        public List<ListCheckInstanceResultResponseBodyColumns> Columns { get; set; }
        public class ListCheckInstanceResultResponseBodyColumns : TeaModel {
            /// <summary>
            /// <para>The metadata information about the details of the instance.</para>
            /// </summary>
            [NameInMap("Grids")]
            [Validation(Required=false)]
            public List<ListCheckInstanceResultResponseBodyColumnsGrids> Grids { get; set; }
            public class ListCheckInstanceResultResponseBodyColumnsGrids : TeaModel {
                /// <summary>
                /// <para>The search condition.</para>
                /// 
                /// <b>Example:</b>
                /// <para>RegionIdShow</para>
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <para>The display name of the search condition.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Region</para>
                /// </summary>
                [NameInMap("ShowName")]
                [Validation(Required=false)]
                public string ShowName { get; set; }

                /// <summary>
                /// <para>The format of the check result for the instance. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>text</b></description></item>
                /// <item><description><b>link</b></description></item>
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
            /// <para>The search condition.</para>
            /// 
            /// <b>Example:</b>
            /// <para>RegionIdShow</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>Indicates whether the search condition is used. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b></description></item>
            /// <item><description><b>false</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Search")]
            [Validation(Required=false)]
            public bool? Search { get; set; }

            /// <summary>
            /// <para>The search key.</para>
            /// 
            /// <b>Example:</b>
            /// <para>InstanceIdKey</para>
            /// </summary>
            [NameInMap("SearchKey")]
            [Validation(Required=false)]
            public string SearchKey { get; set; }

            /// <summary>
            /// <para>The display name of the search condition.</para>
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
            /// <item><description><b>text</b></description></item>
            /// <item><description><b>link</b></description></item>
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
        /// <para>The pagination information.</para>
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
            /// <para>The page number of the returned page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public int? CurrentPage { get; set; }

            /// <summary>
            /// <para>The number of entries returned per page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The total number of entries returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request, which is used to locate and troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3AB18264-8A1B-52A6-A9AF-A886556E0F2E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
