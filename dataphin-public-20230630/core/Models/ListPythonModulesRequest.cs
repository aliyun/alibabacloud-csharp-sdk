// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class ListPythonModulesRequest : TeaModel {
        /// <summary>
        /// <para>The paging conditions for the paged query.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("ListQuery")]
        [Validation(Required=false)]
        public ListPythonModulesRequestListQuery ListQuery { get; set; }
        public class ListPythonModulesRequestListQuery : TeaModel {
            /// <summary>
            /// <para>The keyword of the third-party package name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>numpy</para>
            /// </summary>
            [NameInMap("Keyword")]
            [Validation(Required=false)]
            public string Keyword { get; set; }

            /// <summary>
            /// <para>The page number. Default value: 1.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageNum")]
            [Validation(Required=false)]
            public int? PageNum { get; set; }

            /// <summary>
            /// <para>The number of entries per page. Default value: 20.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The ID of the Python third-party package.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1001</para>
            /// </summary>
            [NameInMap("PythonModuleId")]
            [Validation(Required=false)]
            public long? PythonModuleId { get; set; }

            /// <summary>
            /// <para>The Python version. Valid values: PYTHON_2_7, PYTHON_3_7, and PYTHON_3_11.</para>
            /// 
            /// <b>Example:</b>
            /// <para>PYTHON_3_7</para>
            /// </summary>
            [NameInMap("PythonVersion")]
            [Validation(Required=false)]
            public string PythonVersion { get; set; }

        }

        /// <summary>
        /// <para>The tenant ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30001011</para>
        /// </summary>
        [NameInMap("OpTenantId")]
        [Validation(Required=false)]
        public long? OpTenantId { get; set; }

        /// <summary>
        /// <para>The ID of the operator.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30001011</para>
        /// </summary>
        [NameInMap("OpUserId")]
        [Validation(Required=false)]
        public string OpUserId { get; set; }

    }

}
