// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class ListResourceGroupsResponseBody : TeaModel {
        /// <summary>
        /// <para>The resource groups.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListResourceGroupsResponseBodyData> Data { get; set; }
        public class ListResourceGroupsResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The category of the resource group. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>default: shared resource group</description></item>
            /// <item><description>single: exclusive resource group</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>default</para>
            /// </summary>
            [NameInMap("BizExtKey")]
            [Validation(Required=false)]
            public string BizExtKey { get; set; }

            /// <summary>
            /// <para>The name of the cluster. This parameter is returned only if the type of the resource group is MaxCompute or PAI.</para>
            /// 
            /// <b>Example:</b>
            /// <para>AY18G</para>
            /// </summary>
            [NameInMap("Cluster")]
            [Validation(Required=false)]
            public string Cluster { get; set; }

            /// <summary>
            /// <para>The time when the cluster was created. Example: Jul 9, 2018 2:43:37 PM.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Jul 9, 2018 2:43:37 PM</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>Indicates whether the UID of an Alibaba Cloud account is used for access. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true: The MaxCompute compute engine uses the UID of the Alibaba Cloud account as the display name of the account for access.</description></item>
            /// <item><description>false: The MaxCompute compute engine uses the name of the Alibaba Cloud account as the display name of the account for access. The remaining values are useless. This parameter is returned only if the type of the resource group is MaxCompute.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("EnableKp")]
            [Validation(Required=false)]
            public bool? EnableKp { get; set; }

            /// <summary>
            /// <para>The resource group ID.</para>
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
            /// <item><description>ISOLATE: exclusive resource group that adopts the subscription billing method</description></item>
            /// <item><description>SHARE: shared resource group that adopts the pay-as-you-go billing method</description></item>
            /// <item><description>DEVELOP: resource group for developers</description></item>
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
            /// <item><description>0: DataWorks</description></item>
            /// <item><description>2: MaxCompute</description></item>
            /// <item><description>3: PAI</description></item>
            /// <item><description>4: Data Integration</description></item>
            /// <item><description>7: scheduling</description></item>
            /// <item><description>9: DataService Studio</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("ResourceGroupType")]
            [Validation(Required=false)]
            public string ResourceGroupType { get; set; }

            /// <summary>
            /// <para>The ID of your Alibaba Cloud resource group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rg-acfmzbn7pti3zfa</para>
            /// </summary>
            [NameInMap("ResourceManagerResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceManagerResourceGroupId { get; set; }

            /// <summary>
            /// <para>The sequence number of the resource group. Created resource groups are sorted in ascending order by sequence number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>300</para>
            /// </summary>
            [NameInMap("Sequence")]
            [Validation(Required=false)]
            public int? Sequence { get; set; }

            /// <summary>
            /// <para>The details of the resource group. The content enclosed in braces {} is the details of the resource group.</para>
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
            /// <item><description>0: NORMAL, which indicates that the resource group is running or in service.</description></item>
            /// <item><description>1: STOP, which indicates that the resource group has expired and is frozen.</description></item>
            /// <item><description>2: DELETED, which indicates that the resource group is released or destroyed.</description></item>
            /// <item><description>3: CREATING, which indicates that the resource group is being created or started.</description></item>
            /// <item><description>4: CREATE_FAILED, which indicates that the resource group fails to be created or started.</description></item>
            /// <item><description>5: UPDATING, which indicates that the resource group is being scaled out or upgraded.</description></item>
            /// <item><description>6: UPDATE_FAILED, which indicates that the resource group fails to be scaled out or upgraded.</description></item>
            /// <item><description>7: DELETING, which indicates that the resource group is being released or destroyed.</description></item>
            /// <item><description>8: DELETE_FAILED, which indicates that the resource group fails to be released or destroyed.</description></item>
            /// <item><description>9: TIMEOUT, which indicates that the operation performed on the resource group times out. All operations may time out. This value is temporarily available only for DataService Studio.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            /// <summary>
            /// <para>The tags.</para>
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
            /// <para>The time when the resource group was last updated.</para>
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
        /// <para>Indicates whether the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
