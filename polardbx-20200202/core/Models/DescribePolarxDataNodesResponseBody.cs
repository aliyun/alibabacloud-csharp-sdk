// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardbx20200202.Models
{
    public class DescribePolarxDataNodesResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of node information.</para>
        /// </summary>
        [NameInMap("DBInstanceDataNodes")]
        [Validation(Required=false)]
        public List<DescribePolarxDataNodesResponseBodyDBInstanceDataNodes> DBInstanceDataNodes { get; set; }
        public class DescribePolarxDataNodesResponseBodyDBInstanceDataNodes : TeaModel {
            /// <summary>
            /// <para>The description of the node instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>pxc-z****nfxsxy728 : PROD-OMS-Auto-生产库克隆实例</para>
            /// </summary>
            [NameInMap("DBInstanceDescription")]
            [Validation(Required=false)]
            public string DBInstanceDescription { get; set; }

            /// <summary>
            /// <para>The instance ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>pxc-hzrlcjc****sz9</para>
            /// </summary>
            [NameInMap("DBInstanceId")]
            [Validation(Required=false)]
            public string DBInstanceId { get; set; }

            /// <summary>
            /// <para>The instance ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>pxc-hzrp5m****04w4</para>
            /// </summary>
            [NameInMap("DBInstanceName")]
            [Validation(Required=false)]
            public string DBInstanceName { get; set; }

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
        /// <para>0</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>BD99340C-4A45-548B-****-27584B0BCFFF</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of nodes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("TotalNumber")]
        [Validation(Required=false)]
        public int? TotalNumber { get; set; }

    }

}
