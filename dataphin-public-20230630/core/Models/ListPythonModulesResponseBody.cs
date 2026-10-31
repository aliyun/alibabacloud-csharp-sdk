// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class ListPythonModulesResponseBody : TeaModel {
        /// <summary>
        /// <para>The backend response code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The backend exception details.</para>
        /// 
        /// <b>Example:</b>
        /// <para>internal error</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The paged query result with paging details.</para>
        /// </summary>
        [NameInMap("PageResult")]
        [Validation(Required=false)]
        public ListPythonModulesResponseBodyPageResult PageResult { get; set; }
        public class ListPythonModulesResponseBodyPageResult : TeaModel {
            /// <summary>
            /// <para>The paginated list of Python third-party packages.</para>
            /// </summary>
            [NameInMap("PythonModuleList")]
            [Validation(Required=false)]
            public List<ListPythonModulesResponseBodyPageResultPythonModuleList> PythonModuleList { get; set; }
            public class ListPythonModulesResponseBodyPageResultPythonModuleList : TeaModel {
                /// <summary>
                /// <para>The creation time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2026-01-01 10:00:00</para>
                /// </summary>
                [NameInMap("GmtCreated")]
                [Validation(Required=false)]
                public string GmtCreated { get; set; }

                /// <summary>
                /// <para>The last update time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2026-01-01 10:00:00</para>
                /// </summary>
                [NameInMap("GmtModified")]
                [Validation(Required=false)]
                public string GmtModified { get; set; }

                /// <summary>
                /// <para>The ID of the Python third-party package.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1001</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// <para>The installation time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2026-01-01 10:00:00</para>
                /// </summary>
                [NameInMap("InstallTime")]
                [Validation(Required=false)]
                public string InstallTime { get; set; }

                /// <summary>
                /// <para>The installation method. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>UPLOAD_INSTALL: upload installation package</description></item>
                /// <item><description>ONLINE_INSTALL: online installation</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>UPLOAD_INSTALL</para>
                /// </summary>
                [NameInMap("InstallType")]
                [Validation(Required=false)]
                public string InstallType { get; set; }

                /// <summary>
                /// <para>The installer.</para>
                /// 
                /// <b>Example:</b>
                /// <para>30001011</para>
                /// </summary>
                [NameInMap("Installer")]
                [Validation(Required=false)]
                public string Installer { get; set; }

                /// <summary>
                /// <para>The name of the Python third-party package.</para>
                /// 
                /// <b>Example:</b>
                /// <para>numpy</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The Python version. Valid values: PYTHON_2_7, PYTHON_3_7, and PYTHON_3_11.</para>
                /// 
                /// <b>Example:</b>
                /// <para>PYTHON_3_7</para>
                /// </summary>
                [NameInMap("PythonVersion")]
                [Validation(Required=false)]
                public string PythonVersion { get; set; }

                /// <summary>
                /// <para>The status of the third-party package. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>INSTALL_SUCCESS: installation succeeded</description></item>
                /// <item><description>INSTALL_FAILED: installation failed</description></item>
                /// <item><description>INSTALLING: installing</description></item>
                /// <item><description>UPGRADE_SUCCESS: upgrade succeeded</description></item>
                /// <item><description>UPGRADE_FAILED: upgrade failed</description></item>
                /// <item><description>UPGRADING: upgrading</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>INSTALL_SUCCESS</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>The version of the third-party package.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1.0.1</para>
                /// </summary>
                [NameInMap("Version")]
                [Validation(Required=false)]
                public string Version { get; set; }

            }

            /// <summary>
            /// <para>The total number of entries.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public long? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>82E78D6B-AA8F-1FEF-8AA3-5C9DA2A79140</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request is successful.</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
