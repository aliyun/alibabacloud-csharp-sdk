// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class CreateProjectShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request. This parameter can be left empty.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ABFUOEUOTRTRJKE</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>Specifies whether to disable the Develop role. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>false</b> (default)</description></item>
        /// <item><description><b>true</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DisableDevelopment")]
        [Validation(Required=false)]
        public bool? DisableDevelopment { get; set; }

        /// <summary>
        /// <para>Specifies whether to allow you to download the query result from DataStudio. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>1</b> (default): allows you to download the query result from DataStudio.</description></item>
        /// <item><description><b>0</b>: does not allow you to download the query result from DataStudio.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("IsAllowDownload")]
        [Validation(Required=false)]
        public int? IsAllowDownload { get; set; }

        /// <summary>
        /// <para>The description of the workspace.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test_describe</para>
        /// </summary>
        [NameInMap("ProjectDescription")]
        [Validation(Required=false)]
        public string ProjectDescription { get; set; }

        /// <summary>
        /// <para>The name of the workspace. The name can contain only letters, digits, and underscores (_) and must start with a letter or digit.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test_project</para>
        /// </summary>
        [NameInMap("ProjectIdentifier")]
        [Validation(Required=false)]
        public string ProjectIdentifier { get; set; }

        /// <summary>
        /// <para>The mode of the workspace. For more information about the differences between the modes of workspaces, see <a href="https://help.aliyun.com/document_detail/85772.html">Differences between workspaces in basic mode and workspaces in standard mode</a>.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>2</b> (default): basic mode</description></item>
        /// <item><description><b>3</b>: standard mode</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("ProjectMode")]
        [Validation(Required=false)]
        public int? ProjectMode { get; set; }

        /// <summary>
        /// <para>The display name of the workspace.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test_project</para>
        /// </summary>
        [NameInMap("ProjectName")]
        [Validation(Required=false)]
        public string ProjectName { get; set; }

        /// <summary>
        /// <para>The resource group ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfmzbn7pti3****</para>
        /// </summary>
        [NameInMap("ResourceManagerResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceManagerResourceGroupId { get; set; }

        /// <summary>
        /// <para>The tags added to the workspace.</para>
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public string TagsShrink { get; set; }

    }

}
