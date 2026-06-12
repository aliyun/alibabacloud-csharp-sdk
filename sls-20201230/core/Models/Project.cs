// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class Project : TeaModel {
        /// <summary>
        /// <para>The time when the project was created.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-07-07 14:08:09</para>
        /// </summary>
        [NameInMap("createTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        /// <summary>
        /// <para>The data redundancy type.</para>
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
        /// <para>Description of my-project</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The time when the project was last modified.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2022-04-18 13:30:19</para>
        /// </summary>
        [NameInMap("lastModifyTime")]
        [Validation(Required=false)]
        public string LastModifyTime { get; set; }

        /// <summary>
        /// <para>The Alibaba Cloud account that owns the project.</para>
        /// 
        /// <b>Example:</b>
        /// <para>&quot;&quot;</para>
        /// </summary>
        [NameInMap("owner")]
        [Validation(Required=false)]
        public string Owner { get; set; }

        /// <summary>
        /// <para>The name of the project. The name is a part of the endpoint. The project name must be unique in a region of Alibaba Cloud. After a project is created, its name cannot be changed.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ali-test-project</para>
        /// </summary>
        [NameInMap("projectName")]
        [Validation(Required=false)]
        public string ProjectName { get; set; }

        /// <summary>
        /// <para>The quota of the project.</para>
        /// </summary>
        [NameInMap("quota")]
        [Validation(Required=false)]
        public Dictionary<string, object> Quota { get; set; }

        /// <summary>
        /// <para>Indicates whether the recycle bin is enabled.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("recycleBinEnabled")]
        [Validation(Required=false)]
        public bool? RecycleBinEnabled { get; set; }

        /// <summary>
        /// <para>The region where the project resides.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("region")]
        [Validation(Required=false)]
        public string Region { get; set; }

        /// <summary>
        /// <para>The ID of the resource group to which the project belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acf******sq</para>
        /// </summary>
        [NameInMap("resourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The status of the project.</para>
        /// <list type="bullet">
        /// <item><description><para>Normal: The project is in the normal state.</para>
        /// </description></item>
        /// <item><description><para>Disable: The project is disabled.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Normal</para>
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
