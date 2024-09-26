// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class ListResourceGroupsRequest : TeaModel {
        /// <summary>
        /// <para>The category of the resource group. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>default (default): shared resource group</description></item>
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
        /// <para>The keyword that is used for fuzzy match by resource group name and identifier.</para>
        /// 
        /// <b>Example:</b>
        /// <para>abc</para>
        /// </summary>
        [NameInMap("Keyword")]
        [Validation(Required=false)]
        public string Keyword { get; set; }

        /// <summary>
        /// <para>The type of the resource group that you want to query. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>0: DataWorks</description></item>
        /// <item><description>1: scheduling</description></item>
        /// <item><description>2: MaxCompute</description></item>
        /// <item><description>3: Platform for AI (PAI)</description></item>
        /// <item><description>4: Data Integration</description></item>
        /// <item><description>7: exclusive resource group for scheduling (An ID is generated for the purchased resource when you purchase an exclusive resource group for scheduling.)</description></item>
        /// <item><description>9: DataService Studio</description></item>
        /// <item><description>Default value: 1</description></item>
        /// </list>
        /// <para>If the value indicates a compute engine, the resource groups to query are the ones that were created when you purchased the compute engine.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("ResourceGroupType")]
        [Validation(Required=false)]
        public int? ResourceGroupType { get; set; }

        /// <summary>
        /// <para>The resource group ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfmzbn7pti3zfa</para>
        /// </summary>
        [NameInMap("ResourceManagerResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceManagerResourceGroupId { get; set; }

        /// <summary>
        /// <para>The tags.</para>
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public List<ListResourceGroupsRequestTags> Tags { get; set; }
        public class ListResourceGroupsRequestTags : TeaModel {
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

    }

}
