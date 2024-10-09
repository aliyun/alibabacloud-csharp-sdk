// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SWAS_OPEN20200601.Models
{
    public class ListInstanceStatusResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the simple application server.</para>
        /// </summary>
        [NameInMap("InstanceStatuses")]
        [Validation(Required=false)]
        public List<ListInstanceStatusResponseBodyInstanceStatuses> InstanceStatuses { get; set; }
        public class ListInstanceStatusResponseBodyInstanceStatuses : TeaModel {
            /// <summary>
            /// <para>The ID of the simple application server.</para>
            /// 
            /// <b>Example:</b>
            /// <para>a9a6474b935d41bcb531250bb5d****</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The status of the simple application server. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Pending</description></item>
            /// <item><description>Starting</description></item>
            /// <item><description>Running</description></item>
            /// <item><description>Stopping</description></item>
            /// <item><description>Stopped</description></item>
            /// <item><description>Resetting</description></item>
            /// <item><description>Upgrading</description></item>
            /// <item><description>Disabled</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Running</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30637AD6-D977-4833-A54C-CC89483E****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>54</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
