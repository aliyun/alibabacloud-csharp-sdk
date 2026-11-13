// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class SetDataSourceShareRequest : TeaModel {
        /// <summary>
        /// <para>The name of the target data source to be shared.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>mysql_name</para>
        /// </summary>
        [NameInMap("DatasourceName")]
        [Validation(Required=false)]
        public string DatasourceName { get; set; }

        /// <summary>
        /// <para>The environment to which the target data source belongs. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>0: development environment.</description></item>
        /// <item><description>1: production environment.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("EnvType")]
        [Validation(Required=false)]
        public string EnvType { get; set; }

        /// <summary>
        /// <para>The ID of the DataWorks workspace to which the target data source belongs. You can call the <a href="https://help.aliyun.com/document_detail/178393.html">ListProjects</a> operation to obtain the workspace ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10000</para>
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public long? ProjectId { get; set; }

        /// <summary>
        /// <para>The DataWorks workspace with which you want to share the target data source. After the data source is shared, all members of the workspace can view or use the target data source. Use the JSON array format. Example: [{&quot;projectId&quot;:1000,&quot;permission&quot;:&quot;WRITE&quot;,&quot;sharedName&quot;:&quot;PX_DATAHUB1.shared_name&quot;}].
        /// Parameter description:</para>
        /// <list type="bullet">
        /// <item><description>projectId: the ID of the workspace with which you want to share the target data source.</description></item>
        /// <item><description>permission: the permission mode. Valid values: READ and WRITE. READ indicates that all members of the specified workspace can only read data from the target data source but cannot modify the data. WRITE indicates that all members of the specified workspace can modify data in the target data source.</description></item>
        /// <item><description>sharedName: the name of the data source to be shared.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;projectId&quot;:1000,&quot;permission&quot;:&quot;WRITE&quot;,&quot;sharedName&quot;:&quot;PX_DATAHUB1.shared_name&quot;}]</para>
        /// </summary>
        [NameInMap("ProjectPermissions")]
        [Validation(Required=false)]
        public string ProjectPermissions { get; set; }

        /// <summary>
        /// <para>The users with whom you want to share the target data source. After the data source is shared, the specified users can view or use the target data source. Use the JSON array format. Example: [{&quot;projectId&quot;:10000,&quot;users&quot;:[{&quot;userId&quot;:&quot;276184575345452131&quot;,&quot;permission&quot;:&quot;WRITE&quot;}],&quot;sharedName&quot;:&quot;PX_DATAHUB1.shared_name&quot;}].
        /// Parameter description:</para>
        /// <list type="bullet">
        /// <item><description>projectId: the ID of the DataWorks workspace. This indicates that the users with whom you want to share the target data source can view or use the target data source only in this workspace.</description></item>
        /// <item><description>userId: the ID of the user with whom you want to share the target data source.</description></item>
        /// <item><description>permission: the permission mode. Valid values: READ and WRITE. READ indicates that the specified user can only read data from the target data source but cannot modify the data. WRITE indicates that the specified user can modify data in the target data source.</description></item>
        /// <item><description>sharedName: the name of the data source to be shared.</description></item>
        /// </list>
        /// <para>If both ProjectPermissions and UserPermissions are empty, this operation does not make any modifications. If neither is empty, both UserPermissions and ProjectPermissions take effect.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;projectId&quot;:10000,&quot;users&quot;:[{&quot;userId&quot;:&quot;276184575345452131&quot;,&quot;permission&quot;:&quot;WRITE&quot;}],&quot;sharedName&quot;:&quot;PX_DATAHUB1.shared_name&quot;}]</para>
        /// </summary>
        [NameInMap("UserPermissions")]
        [Validation(Required=false)]
        public string UserPermissions { get; set; }

    }

}
