// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class GetProjectRoleResponseBody : TeaModel {
        /// <summary>
        /// <para>The role in the DataWorks workspace.</para>
        /// </summary>
        [NameInMap("ProjectRole")]
        [Validation(Required=false)]
        public GetProjectRoleResponseBodyProjectRole ProjectRole { get; set; }
        public class GetProjectRoleResponseBodyProjectRole : TeaModel {
            /// <summary>
            /// <para>The code of the role in the DataWorks workspace.</para>
            /// 
            /// <b>Example:</b>
            /// <para>role_project_guest</para>
            /// </summary>
            [NameInMap("Code")]
            [Validation(Required=false)]
            public string Code { get; set; }

            /// <summary>
            /// <para>The name of the role in the DataWorks workspace.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Visitors</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The DataWorks workspace ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10002</para>
            /// </summary>
            [NameInMap("ProjectId")]
            [Validation(Required=false)]
            public long? ProjectId { get; set; }

            /// <summary>
            /// <para>The type of the role in the DataWorks workspace. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>UserCustom: user-defined role</description></item>
            /// <item><description>System: system role</description></item>
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
