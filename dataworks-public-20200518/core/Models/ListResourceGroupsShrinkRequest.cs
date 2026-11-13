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
        /// <item><description>default: Public resource group. This is the default value.</description></item>
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
        /// <para>The keyword used to fuzzy match resource group names and identifiers.</para>
        /// 
        /// <b>Example:</b>
        /// <para>abc</para>
        /// </summary>
        [NameInMap("Keyword")]
        [Validation(Required=false)]
        public string Keyword { get; set; }

        /// <summary>
        /// <para>The ID of the resource group type to query. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>0: DataWorks.</description></item>
        /// <item><description>1: Scheduling.</description></item>
        /// <item><description>2: MaxCompute.</description></item>
        /// <item><description>3: PAI.</description></item>
        /// <item><description>4: Data Integration.</description></item>
        /// <item><description>7: The purchase resource ID generated when you purchase an exclusive scheduling resource group.</description></item>
        /// <item><description>9: dataService.
        /// Default value: 1.
        /// If the value represents an engine, the returned list contains resource groups created when you purchase the engine.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("ResourceGroupType")]
        [Validation(Required=false)]
        public int? ResourceGroupType { get; set; }

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
        /// <para>The list of tags.</para>
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public string TagsShrink { get; set; }

    }

}
