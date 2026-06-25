// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AIWorkSpace20210204.Models
{
    public class UpdateDatasetRequest : TeaModel {
        /// <summary>
        /// <para>The visibility of the dataset in the workspace. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>PRIVATE</c> (default): The dataset is visible only to its owner and administrators.</para>
        /// </description></item>
        /// <item><description><para><c>PUBLIC</c>: The dataset is visible to all users in the workspace.</para>
        /// </description></item>
        /// <item><description><para><c>ROLE_PUBLIC</c>: The dataset is visible to users in specific workspace roles. You must specify the roles in the <c>AccessibleRoleIdList</c> parameter. The dataset owner and administrators can always view the dataset.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>PRIVATE</para>
        /// </summary>
        [NameInMap("Accessibility")]
        [Validation(Required=false)]
        public string Accessibility { get; set; }

        /// <summary>
        /// <para>This parameter takes effect only when <c>Accessibility</c> is set to <c>ROLE_PUBLIC</c>. It specifies the list of workspace roles that can view the dataset. Role IDs that start with <c>PAI</c> are basic role IDs, and role IDs that start with <c>role-</c> are custom role IDs.</para>
        /// </summary>
        [NameInMap("AccessibleRoleIdList")]
        [Validation(Required=false)]
        public List<string> AccessibleRoleIdList { get; set; }

        /// <summary>
        /// <para>The description of the dataset.</para>
        /// 
        /// <b>Example:</b>
        /// <para>This is a description of the dataset.</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The dataset edition. You can upgrade a dataset from <c>BASIC</c> to <c>ADVANCED</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ADVANCED</para>
        /// </summary>
        [NameInMap("Edition")]
        [Validation(Required=false)]
        public string Edition { get; set; }

        /// <summary>
        /// <para>A list of workspace roles that have read and write permissions on the mounted dataset. Role IDs that start with <c>PAI</c> are basic role IDs, and role IDs that start with <c>role-</c> are custom role IDs. If the list contains an asterisk (<c>*</c>), all roles are granted read and write permissions.</para>
        /// <list type="bullet">
        /// <item><description><para>To specify roles: [&quot;PAI.AlgoOperator&quot;, &quot;role-hiuwpd01ncrokkgp21&quot;]</para>
        /// </description></item>
        /// <item><description><para>To specify all roles: [&quot;\*&quot;]</para>
        /// </description></item>
        /// <item><description><para>To specify only the dataset creator: []</para>
        /// </description></item>
        /// </list>
        /// </summary>
        [NameInMap("MountAccessReadWriteRoleIdList")]
        [Validation(Required=false)]
        public List<string> MountAccessReadWriteRoleIdList { get; set; }

        /// <summary>
        /// <para>The dataset name. For information about how to obtain the dataset name, see <a href="https://help.aliyun.com/document_detail/457222.html">ListDatasets</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>myName</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>An extended field in a JSON string format. When you use the dataset with Data Lake Compute (DLC), you can configure the <c>mountPath</c> field to specify the default mount path.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{
        ///   &quot;mountPath&quot;: &quot;/mnt/data/&quot;
        /// }</para>
        /// </summary>
        [NameInMap("Options")]
        [Validation(Required=false)]
        public string Options { get; set; }

        /// <summary>
        /// <para>The sharing configuration of the dataset.</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("SharingConfig")]
        [Validation(Required=false)]
        public UpdateDatasetRequestSharingConfig SharingConfig { get; set; }
        public class UpdateDatasetRequestSharingConfig : TeaModel {
            /// <summary>
            /// <para>The sharing relationships of the dataset.</para>
            /// </summary>
            [NameInMap("SharedTo")]
            [Validation(Required=false)]
            public List<DatasetShareRelationship> SharedTo { get; set; }

        }

    }

}
