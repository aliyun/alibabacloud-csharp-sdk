// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class CreateProjectRequest : TeaModel {
        /// <summary>
        /// <para>The disaster recovery type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>LRS: locally redundant storage</description></item>
        /// <item><description>ZRS: zone-redundant storage</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>LRS</para>
        /// </summary>
        [NameInMap("dataRedundancyType")]
        [Validation(Required=false)]
        public string DataRedundancyType { get; set; }

        /// <summary>
        /// <para>The description of the project.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>this is test</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The project name must be unique in a region. You cannot change the name after you create the project. The name must meet the following requirements:</para>
        /// <list type="bullet">
        /// <item><description>The name must be globally unique.</description></item>
        /// <item><description>The name can contain only lowercase letters, digits, and hyphens (-).</description></item>
        /// <item><description>The name must start and end with a lowercase letter or a digit.</description></item>
        /// <item><description>The name must be 3 to 63 characters in length.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test-project</para>
        /// </summary>
        [NameInMap("projectName")]
        [Validation(Required=false)]
        public string ProjectName { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the recycle bin feature.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true</description></item>
        /// <item><description>false</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("recycleBinEnabled")]
        [Validation(Required=false)]
        public bool? RecycleBinEnabled { get; set; }

        /// <summary>
        /// <para>The ID of the resource group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-aekzf******sxby</para>
        /// </summary>
        [NameInMap("resourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

    }

}
