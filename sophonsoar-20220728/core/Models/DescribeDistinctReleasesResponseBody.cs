// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sophonsoar20220728.Models
{
    public class DescribeDistinctReleasesResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about versions.</para>
        /// </summary>
        [NameInMap("Records")]
        [Validation(Required=false)]
        public List<DescribeDistinctReleasesResponseBodyRecords> Records { get; set; }
        public class DescribeDistinctReleasesResponseBodyRecords : TeaModel {
            /// <summary>
            /// <para>The version description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>demo version</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The MD5 value of the version XML configuration.</para>
            /// 
            /// <b>Example:</b>
            /// <para>17cf53049bc8efa941207xxxxx</para>
            /// </summary>
            [NameInMap("TaskflowMd5")]
            [Validation(Required=false)]
            public string TaskflowMd5 { get; set; }

            /// <summary>
            /// <para>The format of the playbook. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>xml</b>: XML format.</description></item>
            /// <item><description><b>x6</b>: JSON format.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>x6</para>
            /// </summary>
            [NameInMap("TaskflowType")]
            [Validation(Required=false)]
            public string TaskflowType { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>145CACF6-D276-5197-8549-CB1AD76E2AC8</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
