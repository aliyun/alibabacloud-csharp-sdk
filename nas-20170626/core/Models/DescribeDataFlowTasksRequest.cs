// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.NAS20170626.Models
{
    public class DescribeDataFlowTasksRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cpfs-099394bd928c****</para>
        /// </summary>
        [NameInMap("FileSystemId")]
        [Validation(Required=false)]
        public string FileSystemId { get; set; }

        /// <summary>
        /// <b>if can be null:</b>
        /// <c>false</c>
        /// </summary>
        [NameInMap("Filters")]
        [Validation(Required=false)]
        public List<DescribeDataFlowTasksRequestFilters> Filters { get; set; }
        public class DescribeDataFlowTasksRequestFilters : TeaModel {
            /// <summary>
            /// <list type="bullet">
            /// <item><description></description></item>
            /// <item><description></description></item>
            /// <item><description></description></item>
            /// <item><description></description></item>
            /// <item><description></description></item>
            /// <item><description></description></item>
            /// <item><description></description></item>
            /// <item><description></description></item>
            /// <item><description></description></item>
            /// <item><description></description></item>
            /// <item><description></description></item>
            /// <item><description></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>DataFlowIds</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <list type="bullet">
            /// <item><description><pre><c>
            /// </c></pre>
            /// </description></item>
            /// <item><description><pre><c>
            /// </c></pre>
            /// </description></item>
            /// <item><description></description></item>
            /// <item><description></description></item>
            /// <item><description></description></item>
            /// <item><description></description></item>
            /// <item><description>``</description></item>
            /// <item><description>``</description></item>
            /// <item><description>``</description></item>
            /// <item><description>``</description></item>
            /// <item><description>``</description></item>
            /// <item><description>``</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>dfid-12345678</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public long? MaxResults { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>TGlzdFJlc291cmNlU****mVzJjE1MTI2NjY4NzY5MTAzOTEmMiZORnI4NDhVeEtrUT0=</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

    }

}
