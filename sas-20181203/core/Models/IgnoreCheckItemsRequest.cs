// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class IgnoreCheckItemsRequest : TeaModel {
        /// <summary>
        /// <para>The information about check items.</para>
        /// </summary>
        [NameInMap("CheckAndRiskTypeList")]
        [Validation(Required=false)]
        public List<IgnoreCheckItemsRequestCheckAndRiskTypeList> CheckAndRiskTypeList { get; set; }
        public class IgnoreCheckItemsRequestCheckAndRiskTypeList : TeaModel {
            /// <summary>
            /// <para>The ID of the check item.</para>
            /// 
            /// <b>Example:</b>
            /// <para>52</para>
            /// </summary>
            [NameInMap("CheckId")]
            [Validation(Required=false)]
            public long? CheckId { get; set; }

            /// <summary>
            /// <para>The baseline type of the check item.</para>
            /// 
            /// <b>Example:</b>
            /// <para>weak_password</para>
            /// </summary>
            [NameInMap("RiskType")]
            [Validation(Required=false)]
            public string RiskType { get; set; }

        }

        /// <summary>
        /// <para>The IDs of check items.</para>
        /// </summary>
        [NameInMap("CheckIds")]
        [Validation(Required=false)]
        public List<long?> CheckIds { get; set; }

        /// <summary>
        /// <para>List of container names that need to be whitelisted.</para>
        /// </summary>
        [NameInMap("ContainerItems")]
        [Validation(Required=false)]
        public List<IgnoreCheckItemsRequestContainerItems> ContainerItems { get; set; }
        public class IgnoreCheckItemsRequestContainerItems : TeaModel {
            /// <summary>
            /// <para>The names of the containers that need to be whitelisted for the current asset, separated by English commas.</para>
            /// 
            /// <b>Example:</b>
            /// <para>&quot;anythingllm,ChuanhuChat&quot;</para>
            /// </summary>
            [NameInMap("ContainerNames")]
            [Validation(Required=false)]
            public string ContainerNames { get; set; }

            /// <summary>
            /// <para>The UUID of the server.</para>
            /// <remarks>
            /// <para>You can call the <a href="https://help.aliyun.com/document_detail/141932.html">DescribeCloudCenterInstances</a> operation to query the UUIDs of servers.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>14eb2fb6-ab02-4869-a1e1-2cdb0f7*****</para>
            /// </summary>
            [NameInMap("Uuid")]
            [Validation(Required=false)]
            public string Uuid { get; set; }

        }

        /// <summary>
        /// <para>The language of the content within the request and response. Default value: <b>zh</b>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>zh</b>: Chinese</description></item>
        /// <item><description><b>en</b>: English</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The reason why you add the risk item to the whitelist.</para>
        /// 
        /// <b>Example:</b>
        /// <para>already config in another way</para>
        /// </summary>
        [NameInMap("Reason")]
        [Validation(Required=false)]
        public string Reason { get; set; }

        /// <summary>
        /// <para>The data source. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>default</b>: host baseline</description></item>
        /// <item><description><b>agentless</b>: agentless baseline</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>agentless</para>
        /// </summary>
        [NameInMap("Source")]
        [Validation(Required=false)]
        public string Source { get; set; }

        /// <summary>
        /// <para>The operation that you want to perform on the risk item.Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>1</b>: adds the risk item to the whitelist</description></item>
        /// <item><description><b>2</b>: removes the risk item from the whitelist</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public int? Type { get; set; }

        /// <summary>
        /// <para>The UUIDs of the servers.</para>
        /// <remarks>
        /// <para>You can call the <a href="~~DescribeCloudCenterInstances~~">DescribeCloudCenterInstances</a> operation to query the UUIDs of servers.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("UuidList")]
        [Validation(Required=false)]
        public List<string> UuidList { get; set; }

    }

}
