// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class GetProjectRoleResponseBody : TeaModel {
        /// <summary>
        /// <para>The details of the workspace role.</para>
        /// </summary>
        [NameInMap("ProjectRole")]
        [Validation(Required=false)]
        public GetProjectRoleResponseBodyProjectRole ProjectRole { get; set; }
        public class GetProjectRoleResponseBodyProjectRole : TeaModel {
            /// <summary>
            /// <para>The code of the workspace role.</para>
            /// 
            /// <b>Example:</b>
            /// <para>role_project_guest</para>
            /// </summary>
            [NameInMap("Code")]
            [Validation(Required=false)]
            public string Code { get; set; }

            /// <summary>
            /// <para>The permissions for the modules in the workspace.</para>
            /// </summary>
            [NameInMap("ModulePermissions")]
            [Validation(Required=false)]
            public List<GetProjectRoleResponseBodyProjectRoleModulePermissions> ModulePermissions { get; set; }
            public class GetProjectRoleResponseBodyProjectRoleModulePermissions : TeaModel {
                /// <summary>
                /// <para>The module ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("ModuleId")]
                [Validation(Required=false)]
                public long? ModuleId { get; set; }

                /// <summary>
                /// <para>The module name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>HoloStudio</para>
                /// </summary>
                [NameInMap("ModuleName")]
                [Validation(Required=false)]
                public string ModuleName { get; set; }

                /// <summary>
                /// <para>The permission type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Read</para>
                /// </summary>
                [NameInMap("PermissionType")]
                [Validation(Required=false)]
                public string PermissionType { get; set; }

            }

            /// <summary>
            /// <para>The name of the workspace role.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Visitors</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The ID of the DataWorks workspace.</para>
            /// <para>Note: A fixed value of -1 is returned for a system role.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10002</para>
            /// </summary>
            [NameInMap("ProjectId")]
            [Validation(Required=false)]
            public long? ProjectId { get; set; }

            /// <summary>
            /// <para>The type of the workspace role. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>UserCustom: a custom role</para>
            /// </description></item>
            /// <item><description><para>System: a system role</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>System</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>82F28E60-CF48-5EDF-AB25-D806847B97D1</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
