// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sophonsoar20220728.Models
{
    public class DescribeDistinctReleasesResponseBody : TeaModel {
        /// <summary>
        /// <para>The version records.</para>
        /// </summary>
        [NameInMap("Records")]
        [Validation(Required=false)]
        public List<DescribeDistinctReleasesResponseBodyRecords> Records { get; set; }
        public class DescribeDistinctReleasesResponseBodyRecords : TeaModel {
            /// <summary>
            /// <para>The description of the version.</para>
            /// 
            /// <b>Example:</b>
            /// <para>demo version</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The MD5 value of the version\&quot;s XML configuration.</para>
            /// 
            /// <b>Example:</b>
            /// <para>17cf53049bc8efa941207xxxxx</para>
            /// </summary>
            [NameInMap("TaskflowMd5")]
            [Validation(Required=false)]
            public string TaskflowMd5 { get; set; }

            /// <summary>
            /// <para>The configuration format of the playbook.</para>
            /// <list type="bullet">
            /// <item><description><para><b>xml</b>: XML format.</para>
            /// </description></item>
            /// <item><description><para><b>x6</b>: JSON format.</para>
            /// </description></item>
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
        /// <para>The ID of the request. This ID is unique to each request and is used to troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>145CACF6-D276-5197-8549-CB1AD76E2AC8</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
