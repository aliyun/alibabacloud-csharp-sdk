// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appstream_center20210901.Models
{
    public class QueryAppInstanceGroupReportListResponseBody : TeaModel {
        /// <summary>
        /// <para>The business status code. A value of <c>200</c> indicates that the request is processed. Other values indicate that the processing failed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The list of delivery group report data.</para>
        /// </summary>
        [NameInMap("IndexData")]
        [Validation(Required=false)]
        public List<QueryAppInstanceGroupReportListResponseBodyIndexData> IndexData { get; set; }
        public class QueryAppInstanceGroupReportListResponseBodyIndexData : TeaModel {
            /// <summary>
            /// <para>The delivery group ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>aig-9ciijz60n4xsv****</para>
            /// </summary>
            [NameInMap("AppInstanceGroupId")]
            [Validation(Required=false)]
            public string AppInstanceGroupId { get; set; }

            /// <summary>
            /// <para>The delivery group name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>R&amp;D workstation group</para>
            /// </summary>
            [NameInMap("AppInstanceGroupName")]
            [Validation(Required=false)]
            public string AppInstanceGroupName { get; set; }

            /// <summary>
            /// <para>The current status of the delivery group. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><c>DEPLOYING</c>: deploying</description></item>
            /// <item><description><c>DEPLOYED</c>: deployed but not published</description></item>
            /// <item><description><c>PUBLISHED</c>: published and available to provide services based on the current configuration</description></item>
            /// <item><description><c>STOPPING</c>: stopping</description></item>
            /// <item><description><c>STOPPED</c>: stopped</description></item>
            /// <item><description><c>MAINTAINING</c>: maintaining</description></item>
            /// <item><description><c>FAILED</c>: deployment or execution failed</description></item>
            /// <item><description><c>MAINTAIN_FAILED</c>: maintenance failed</description></item>
            /// <item><description><c>DELETING</c>: deleting</description></item>
            /// <item><description><c>DELETED</c>: deleted</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>PUBLISHED</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// <para>The description of the request processing result. If the request is successful, <c>success</c> is usually returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The page number corresponding to the current response.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page used in the current response.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The unique identifier of the current request, which can be used to troubleshoot request issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1CBAFFAB-B697-4049-A9B1-67E1FC5F****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
