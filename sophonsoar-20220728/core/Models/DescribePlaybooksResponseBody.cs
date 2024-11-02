// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sophonsoar20220728.Models
{
    public class DescribePlaybooksResponseBody : TeaModel {
        /// <summary>
        /// <para>The pagination information.</para>
        /// </summary>
        [NameInMap("Page")]
        [Validation(Required=false)]
        public DescribePlaybooksResponseBodyPage Page { get; set; }
        public class DescribePlaybooksResponseBodyPage : TeaModel {
            /// <summary>
            /// <para>The page number of the returned page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            /// <summary>
            /// <para>The number of entries returned per page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The total number of entries returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The playbooks.</para>
        /// </summary>
        [NameInMap("Playbooks")]
        [Validation(Required=false)]
        public List<DescribePlaybooksResponseBodyPlaybooks> Playbooks { get; set; }
        public class DescribePlaybooksResponseBodyPlaybooks : TeaModel {
            /// <summary>
            /// <para>The playbook status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>1</b>: The playbook is started.</description></item>
            /// <item><description><b>0</b>: The playbook is stopped.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Active")]
            [Validation(Required=false)]
            public int? Active { get; set; }

            /// <summary>
            /// <para>The display name of the playbook.</para>
            /// 
            /// <b>Example:</b>
            /// <para>demo_playbook</para>
            /// </summary>
            [NameInMap("DisplayName")]
            [Validation(Required=false)]
            public string DisplayName { get; set; }

            /// <summary>
            /// <para>The time when the playbook was created. The value is a 13-digit timestamp.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1683526277415</para>
            /// </summary>
            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public long? GmtCreate { get; set; }

            /// <summary>
            /// <para>The time when the playbook was modified.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1681396398000</para>
            /// </summary>
            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            /// <summary>
            /// <para>The time when the playbook was last run. The value is a 13-digit timestamp.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1683526277415</para>
            /// </summary>
            [NameInMap("LastRuntime")]
            [Validation(Required=false)]
            public long? LastRuntime { get; set; }

            /// <summary>
            /// <para>The type of the playbook. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>preset</b>: predefined playbook</description></item>
            /// <item><description><b>user</b>: custom playbook</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>user</para>
            /// </summary>
            [NameInMap("OwnType")]
            [Validation(Required=false)]
            public string OwnType { get; set; }

            [NameInMap("ParamType")]
            [Validation(Required=false)]
            public string ParamType { get; set; }

            /// <summary>
            /// <para>The UUID of the playbook.</para>
            /// 
            /// <b>Example:</b>
            /// <para>bb5a8640-a14f-44ef-8376-cxxxxx</para>
            /// </summary>
            [NameInMap("PlaybookUuid")]
            [Validation(Required=false)]
            public string PlaybookUuid { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>138B5AB7-7F2B-5814-87A3-E3ECFE1F207E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
