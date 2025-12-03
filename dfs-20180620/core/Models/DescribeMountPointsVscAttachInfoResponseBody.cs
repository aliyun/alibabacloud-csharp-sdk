// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DFS20180620.Models
{
    public class DescribeMountPointsVscAttachInfoResponseBody : TeaModel {
        [NameInMap("AttachInfos")]
        [Validation(Required=false)]
        public List<DescribeMountPointsVscAttachInfoResponseBodyAttachInfos> AttachInfos { get; set; }
        public class DescribeMountPointsVscAttachInfoResponseBodyAttachInfos : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>vsc-agent-f5a9bb4b041541f595a0c239c9e0f971-cn-shanghai</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>f-9dd3c6bajmy110.cn-zhangjiakou.dfs.aliyuncs.com</para>
            /// </summary>
            [NameInMap("MountPointId")]
            [Validation(Required=false)]
            public string MountPointId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>vsc-bp18fhqie89loyqixyieal</para>
            /// </summary>
            [NameInMap("VscId")]
            [Validation(Required=false)]
            public string VscId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>cxc</para>
            /// </summary>
            [NameInMap("VscName")]
            [Validation(Required=false)]
            public string VscName { get; set; }

            [NameInMap("VscStatus")]
            [Validation(Required=false)]
            public string VscStatus { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Primary</para>
            /// </summary>
            [NameInMap("VscType")]
            [Validation(Required=false)]
            public string VscType { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>asd0daj****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>55C5FFD6-BF99-41BD-9C66-FFF39189****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public string TotalCount { get; set; }

    }

}
