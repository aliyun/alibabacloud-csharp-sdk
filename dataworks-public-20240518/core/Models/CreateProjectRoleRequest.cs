// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class CreateProjectRoleRequest : TeaModel {
        /// <summary>
        /// <para>The client token.</para>
        /// 
        /// <b>Example:</b>
        /// <para>保留字段</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The list of DataWorks module permissions.</para>
        /// </summary>
        [NameInMap("ModulePermissions")]
        [Validation(Required=false)]
        public List<CreateProjectRoleRequestModulePermissions> ModulePermissions { get; set; }
        public class CreateProjectRoleRequestModulePermissions : TeaModel {
            /// <summary>
            /// <para>The DataWorks module ID. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>2: HoloStudio</para>
            /// </description></item>
            /// <item><description><para>3: StreamStudio</para>
            /// </description></item>
            /// <item><description><para>4: Deployment management</para>
            /// </description></item>
            /// <item><description><para>6: Data Security Guard</para>
            /// </description></item>
            /// <item><description><para>7: Data Map</para>
            /// </description></item>
            /// <item><description><para>8: Data Service</para>
            /// </description></item>
            /// <item><description><para>9: Data Integration</para>
            /// </description></item>
            /// <item><description><para>10: Data Modeling (DataBlau DDM)</para>
            /// </description></item>
            /// <item><description><para>11: Data Studio</para>
            /// </description></item>
            /// <item><description><para>12: Data Quality</para>
            /// </description></item>
            /// <item><description><para>13: Data Governance</para>
            /// </description></item>
            /// <item><description><para>14: Operation Center</para>
            /// </description></item>
            /// <item><description><para>15: Resource optimization</para>
            /// </description></item>
            /// <item><description><para>16: Migration Assistant</para>
            /// </description></item>
            /// <item><description><para>17: Data Analysis</para>
            /// </description></item>
            /// <item><description><para>18: Approval center</para>
            /// </description></item>
            /// <item><description><para>19: Security Center</para>
            /// </description></item>
            /// <item><description><para>20: Intelligent Data Modeling</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("ModuleId")]
            [Validation(Required=false)]
            public long? ModuleId { get; set; }

            /// <summary>
            /// <para>The permission type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>Write: Read-only</para>
            /// </description></item>
            /// <item><description><para>Read: Edit</para>
            /// </description></item>
            /// <item><description><para>NotSet: Not controlled</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Write</para>
            /// </summary>
            [NameInMap("PermissionType")]
            [Validation(Required=false)]
            public string PermissionType { get; set; }

        }

        /// <summary>
        /// <para>The role name.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>category_role</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The ID of the DataWorks workspace. You can log on to the <a href="https://dataworks.console.aliyun.com/workspace/list">DataWorks console</a> and go to the workspace management page to obtain the ID.</para>
        /// <para>This parameter specifies the DataWorks workspace on which the API operation is performed.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12345</para>
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public long? ProjectId { get; set; }

    }

}
