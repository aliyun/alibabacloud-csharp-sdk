// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class SetDataSourceShareRequest : TeaModel {
        /// <summary>
        /// <para>The name of the data source that you want to share.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>mysql_name</para>
        /// </summary>
        [NameInMap("DatasourceName")]
        [Validation(Required=false)]
        public string DatasourceName { get; set; }

        /// <summary>
        /// <para>The environment in which the data source is used. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>0: development environment</description></item>
        /// <item><description>1: production environment</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("EnvType")]
        [Validation(Required=false)]
        public string EnvType { get; set; }

        /// <summary>
        /// <para>The ID of the DataWorks workspace to which the data source belongs. You can call the <a href="https://help.aliyun.com/document_detail/178393.html">ListProjects</a> operation to query the ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10000</para>
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public long? ProjectId { get; set; }

        /// <summary>
        /// <para>The DataWorks workspace to which you want to share the data source. If you configure this parameter, all members of the specified DataWorks workspace can view and use the data source. The value of this parameter is a JSON array. Example: [{&quot;projectId&quot;:1000,&quot;permission&quot;:&quot;WRITE&quot;,&quot;sharedName&quot;:&quot;PX_DATAHUB1.shared_name&quot;}], Parameter description:</para>
        /// <list type="bullet">
        /// <item><description>projectId: the ID of the DataWorks workspace to which you want to share the data source.</description></item>
        /// <item><description>permission: the mode in which the data source is shared. Valid values: READ and WRITE. The value READ indicates that all members of the specified workspace can read data from the data source, but cannot modify the data. The value WRITE indicates that all members of the specified workspace can modify the data in the data source.</description></item>
        /// <item><description>sharedName: the name of the data source that you want to share.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;projectId&quot;:1000,&quot;permission&quot;:&quot;WRITE&quot;,&quot;sharedName&quot;:&quot;PX_DATAHUB1.shared_name&quot;}]</para>
        /// </summary>
        [NameInMap("ProjectPermissions")]
        [Validation(Required=false)]
        public string ProjectPermissions { get; set; }

        /// <summary>
        /// <para>The user to whom you want to share the data source. If you configure this parameter, the specified user can view or use the data source. The value of this parameter is a JSON array. Example: [{&quot;projectId&quot;:10000,&quot;users&quot;:[{&quot;userId&quot;:&quot;276184575345452131&quot;,&quot;permission&quot;:&quot;WRITE&quot;}],&quot;sharedName&quot;:&quot;PX_DATAHUB1.shared_name&quot;}], Parameter description:</para>
        /// <list type="bullet">
        /// <item><description>projectId: the ID of the DataWorks workspace. If you configure the UserPermissions parameter, the specified user can view or use the data source only in the specified DataWorks workspace.</description></item>
        /// <item><description>userId: the ID of the user to whom you want to share the data source.</description></item>
        /// <item><description>permission: the mode in which the data source is shared. Valid values: READ and WRITE. The value READ indicates that the specified user can read data from the data source, but cannot modify the data. The value WRITE indicates that the specified user can modify the data in the data source.</description></item>
        /// <item><description>sharedName: the name of the data source that you want to share.</description></item>
        /// </list>
        /// <para>If the ProjectPermissions and UserPermissions parameters are both left empty, the specified data source is not shared to any DataWorks workspace or user. If neither of the parameters is left empty, both parameters take effect.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;projectId&quot;:10000,&quot;users&quot;:[{&quot;userId&quot;:&quot;276184575345452131&quot;,&quot;permission&quot;:&quot;WRITE&quot;}],&quot;sharedName&quot;:&quot;PX_DATAHUB1.shared_name&quot;}]</para>
        /// </summary>
        [NameInMap("UserPermissions")]
        [Validation(Required=false)]
        public string UserPermissions { get; set; }

    }

}
