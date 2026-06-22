// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ListBaselineCheckWhiteRecordResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of whitelist rules.</para>
        /// </summary>
        [NameInMap("List")]
        [Validation(Required=false)]
        public List<ListBaselineCheckWhiteRecordResponseBodyList> List { get; set; }
        public class ListBaselineCheckWhiteRecordResponseBodyList : TeaModel {
            /// <summary>
            /// <para>The check item ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>696</para>
            /// </summary>
            [NameInMap("CheckId")]
            [Validation(Required=false)]
            public long? CheckId { get; set; }

            /// <summary>
            /// <para>The description of the check item.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Config the Event Audit policys</para>
            /// </summary>
            [NameInMap("CheckItem")]
            [Validation(Required=false)]
            public string CheckItem { get; set; }

            /// <summary>
            /// <para>The category of the check item.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Security audit</para>
            /// </summary>
            [NameInMap("CheckType")]
            [Validation(Required=false)]
            public string CheckType { get; set; }

            /// <summary>
            /// <para>The display name of the check item type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Security audit</para>
            /// </summary>
            [NameInMap("CheckTypeDisName")]
            [Validation(Required=false)]
            public string CheckTypeDisName { get; set; }

            /// <summary>
            /// <para>The list of whitelisted container names in the check item.</para>
            /// </summary>
            [NameInMap("ContainerItems")]
            [Validation(Required=false)]
            public List<ListBaselineCheckWhiteRecordResponseBodyListContainerItems> ContainerItems { get; set; }
            public class ListBaselineCheckWhiteRecordResponseBodyListContainerItems : TeaModel {
                /// <summary>
                /// <para>The whitelisted container names for the current asset, separated by commas.</para>
                /// 
                /// <b>Example:</b>
                /// <para>&quot;anythingllm,ChuanhuChat&quot;</para>
                /// </summary>
                [NameInMap("ContainerNames")]
                [Validation(Required=false)]
                public string ContainerNames { get; set; }

                /// <summary>
                /// <para>The UUID of the server.</para>
                /// 
                /// <b>Example:</b>
                /// <para>beeea5c2-1857-4b2b-a794-7d21eae*****</para>
                /// </summary>
                [NameInMap("Uuid")]
                [Validation(Required=false)]
                public string Uuid { get; set; }

            }

            /// <summary>
            /// <para>The language type for requests and responses. Default value: <b>zh</b>. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>zh</b>: Chinese</description></item>
            /// <item><description><b>en</b>: English.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>en</para>
            /// </summary>
            [NameInMap("Lang")]
            [Validation(Required=false)]
            public string Lang { get; set; }

            /// <summary>
            /// <para>The reason for adding to the whitelist.</para>
            /// 
            /// <b>Example:</b>
            /// <para>暂时忽略</para>
            /// </summary>
            [NameInMap("Reason")]
            [Validation(Required=false)]
            public string Reason { get; set; }

            /// <summary>
            /// <para>The ID of the whitelist record.</para>
            /// 
            /// <b>Example:</b>
            /// <para>79412</para>
            /// </summary>
            [NameInMap("RecordId")]
            [Validation(Required=false)]
            public long? RecordId { get; set; }

            /// <summary>
            /// <para>The data source. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>default</b>: host</description></item>
            /// <item><description><b>agentless</b>: agentless.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>agentless</para>
            /// </summary>
            [NameInMap("Source")]
            [Validation(Required=false)]
            public string Source { get; set; }

            /// <summary>
            /// <para>The whitelisted target.</para>
            /// 
            /// <b>Example:</b>
            /// <para>HOST_BASELINE_WHITE_LIST_21</para>
            /// </summary>
            [NameInMap("Target")]
            [Validation(Required=false)]
            public string Target { get; set; }

            /// <summary>
            /// <para>The type of the effective target. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>all_instance</b>: all hosts</description></item>
            /// <item><description><b>instance</b>: specific hosts.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>instance</para>
            /// </summary>
            [NameInMap("TargetType")]
            [Validation(Required=false)]
            public string TargetType { get; set; }

        }

        /// <summary>
        /// <para>The pagination information.</para>
        /// </summary>
        [NameInMap("PageInfo")]
        [Validation(Required=false)]
        public ListBaselineCheckWhiteRecordResponseBodyPageInfo PageInfo { get; set; }
        public class ListBaselineCheckWhiteRecordResponseBodyPageInfo : TeaModel {
            /// <summary>
            /// <para>The number of entries on the current page when using paging.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("Count")]
            [Validation(Required=false)]
            public int? Count { get; set; }

            /// <summary>
            /// <para>The page number of the current page when using paging.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public int? CurrentPage { get; set; }

            /// <summary>
            /// <para>The maximum number of entries per page when using paging.</para>
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
            /// <para>45</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The request ID, which is a unique identifier generated by Alibaba Cloud for the request. You can use this ID to troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9F4E6157-9600-5588-86B9-38F09067****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
