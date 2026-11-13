// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class ListResourceGroupsResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of resource groups.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListResourceGroupsResponseBodyData> Data { get; set; }
        public class ListResourceGroupsResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The category of the resource group. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>default: Public resource group.</description></item>
            /// <item><description>single: Exclusive resource group.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>default</para>
            /// </summary>
            [NameInMap("BizExtKey")]
            [Validation(Required=false)]
            public string BizExtKey { get; set; }

            /// <summary>
            /// <para>The name of the cluster. This parameter takes effect only for MaxCompute and PAI resource groups.</para>
            /// 
            /// <b>Example:</b>
            /// <para>AY18G</para>
            /// </summary>
            [NameInMap("Cluster")]
            [Validation(Required=false)]
            public string Cluster { get; set; }

            /// <summary>
            /// <para>The time when the cluster was created. Example format: <c>Jul 9, 2018 2:43:37 PM</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Jul 9, 2018 2:43:37 PM</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>Indicates whether Key Person (KP) access is used. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true: The MaxCompute engine uses the Alibaba Cloud account UID as the display name of the access account.</description></item>
            /// <item><description>false: The MaxCompute engine uses the Alibaba Cloud account name as the display name of the access account.
            /// This parameter is meaningless for other types and takes effect only for the MaxCompute engine.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("EnableKp")]
            [Validation(Required=false)]
            public bool? EnableKp { get; set; }

            /// <summary>
            /// <para>The ID of the resource group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1234567</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <para>The identifier of the resource group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>e1815577-2f4e-4c5e-b29****</para>
            /// </summary>
            [NameInMap("Identifier")]
            [Validation(Required=false)]
            public string Identifier { get; set; }

            /// <summary>
            /// <para>Indicates whether the resource group is the default resource group. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true: The resource group is the default resource group.</description></item>
            /// <item><description>false: The resource group is not the default resource group.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("IsDefault")]
            [Validation(Required=false)]
            public bool? IsDefault { get; set; }

            /// <summary>
            /// <para>The mode of the resource group. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>ISOLATE: Subscription exclusive resource group.</description></item>
            /// <item><description>SHARE: Pay-as-you-go public resource group.</description></item>
            /// <item><description>DEVELOP: Developer edition.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>SHARE</para>
            /// </summary>
            [NameInMap("Mode")]
            [Validation(Required=false)]
            public string Mode { get; set; }

            /// <summary>
            /// <para>The name of the resource group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>abc</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The type of the resource group. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>0: DataWorks.</description></item>
            /// <item><description>2: MaxCompute.</description></item>
            /// <item><description>3: PAI.</description></item>
            /// <item><description>4: Data Integration.</description></item>
            /// <item><description>7: Scheduling.</description></item>
            /// <item><description>9: dataService.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("ResourceGroupType")]
            [Validation(Required=false)]
            public string ResourceGroupType { get; set; }

            /// <summary>
            /// <para>The ID of the resource group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rg-acfmzbn7pti3zfa</para>
            /// </summary>
            [NameInMap("ResourceManagerResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceManagerResourceGroupId { get; set; }

            /// <summary>
            /// <para>The sequence field. This field is used to sort the created resource groups in ascending order based on their creation sequence numbers.</para>
            /// 
            /// <b>Example:</b>
            /// <para>300</para>
            /// </summary>
            [NameInMap("Sequence")]
            [Validation(Required=false)]
            public int? Sequence { get; set; }

            /// <summary>
            /// <para>The detailed information of the resource group. The content in {} indicates the detailed information of the resource group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{}</para>
            /// </summary>
            [NameInMap("Specs")]
            [Validation(Required=false)]
            public Dictionary<string, object> Specs { get; set; }

            /// <summary>
            /// <para>The status of the resource group. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>NORMAL(0): The resource group is normal and is running or in service.</description></item>
            /// <item><description>STOP(1): The resource group has expired and is frozen.</description></item>
            /// <item><description>DELETED(2): The resource group is released or destroyed.</description></item>
            /// <item><description>CREATING(3): The resource group is being created or started.</description></item>
            /// <item><description>CREATE_FAILED(4): The resource group fails to be created or started.</description></item>
            /// <item><description>UPDATING(5): The resource group is being scaled out or upgraded.</description></item>
            /// <item><description>UPDATE_FAILED(6): The resource group fails to be scaled out or upgraded.</description></item>
            /// <item><description>DELETING(7): The resource group is being released or destroyed.</description></item>
            /// <item><description>DELETE_FAILED(8): The resource group fails to be released or destroyed.</description></item>
            /// <item><description>TIMEOUT(9): The operation on the resource group times out. All modification operations may time out. This value is temporarily provided only for Data Service.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            /// <summary>
            /// <para>The list of tags.</para>
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<ListResourceGroupsResponseBodyDataTags> Tags { get; set; }
            public class ListResourceGroupsResponseBodyDataTags : TeaModel {
                /// <summary>
                /// <para>The tag key.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Env</para>
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <para>The tag value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Test</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// <para>The tenant ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1234567</para>
            /// </summary>
            [NameInMap("TenantId")]
            [Validation(Required=false)]
            public long? TenantId { get; set; }

            /// <summary>
            /// <para>The time when the resource group was last updated. The format is <c>MMM d, yyyy h:mm:ss a</c>, such as <c>Jul 9, 2018 2:43:37 PM</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Jul 9, 2018 2:43:37 PM</para>
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

        }

        /// <summary>
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0bc1411515937635973****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
