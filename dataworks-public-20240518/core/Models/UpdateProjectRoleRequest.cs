// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class UpdateProjectRoleRequest : TeaModel {
        /// <summary>
        /// <para>A reserved field.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0000-ABCD-EFG****</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The unique identifier of the custom role.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>base_role_xx</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The list of DataWorks module permissions.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("ModulePermissions")]
        [Validation(Required=false)]
        public List<UpdateProjectRoleRequestModulePermissions> ModulePermissions { get; set; }
        public class UpdateProjectRoleRequestModulePermissions : TeaModel {
            /// <summary>
            /// <para>The DataWorks module ID. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>2: HoloStudio</description></item>
            /// <item><description>3: StreamStudio</description></item>
            /// <item><description>4: Deploy Management</description></item>
            /// <item><description>6: Data Protection Umbrella</description></item>
            /// <item><description>7: Data Map</description></item>
            /// <item><description>8: DataService Studio</description></item>
            /// <item><description>9: Data Integration</description></item>
            /// <item><description>10: Data Modeling (DataBlau DDM)</description></item>
            /// <item><description>11: DataStudio</description></item>
            /// <item><description>12: Data Quality</description></item>
            /// <item><description>13: Data Governance Center</description></item>
            /// <item><description>14: Operation Center</description></item>
            /// <item><description>15: Resource Optimization</description></item>
            /// <item><description>16: Migration Assistant</description></item>
            /// <item><description>17: Data Analytics</description></item>
            /// <item><description>18: Approval Center</description></item>
            /// <item><description>19: Security Center</description></item>
            /// <item><description>20: Intelligent Data Modeling</description></item>
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
            /// <item><description>Write: Edit.</description></item>
            /// <item><description>Read: Read-only.</description></item>
            /// <item><description>NotSet: Not controlled.</description></item>
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
        /// <para>The ID of the DataWorks workspace. You can log on to the <a href="https://dataworks.console.aliyun.com/workspace/list">DataWorks console</a> and go to the Storage Management page to obtain the ID.</para>
        /// <para>This parameter specifies the DataWorks workspace for this API invocation.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>234</para>
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public long? ProjectId { get; set; }

    }

}
