// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class ListResourceGroupsShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The category of the resource group. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>default: public resource group.</description></item>
        /// <item><description>single: dedicated resource group.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>default</para>
        /// </summary>
        [NameInMap("BizExtKey")]
        [Validation(Required=false)]
        public string BizExtKey { get; set; }

        /// <summary>
        /// <para>The keyword. Used for fuzzy matching of resource group names and resource group identifiers.</para>
        /// 
        /// <b>Example:</b>
        /// <para>abc</para>
        /// </summary>
        [NameInMap("Keyword")]
        [Validation(Required=false)]
        public string Keyword { get; set; }

        /// <summary>
        /// <para>The type ID of the resource group to query. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>0: DataWorks</description></item>
        /// <item><description>1: scheduling</description></item>
        /// <item><description>2: MaxCompute</description></item>
        /// <item><description>3: PAI</description></item>
        /// <item><description>4: data integration</description></item>
        /// <item><description>7: the purchase resource ID generated when you purchase a dedicated schedule resource group</description></item>
        /// <item><description>9: dataService</description></item>
        /// <item><description>Default value: 1 (scheduling).</description></item>
        /// </list>
        /// <para>When the value represents an engine, the returned resource group list contains the resource groups created when you purchased that type of engine.</para>
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
        /// <para>The list of tags.</para>
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public string TagsShrink { get; set; }

    }

}
