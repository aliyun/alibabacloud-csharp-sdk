// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DFS20180620.Models
{
    public class DescribeMountPointsVscAttachInfoRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("InputRegionId")]
        [Validation(Required=false)]
        public string InputRegionId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>MYR6sz6qkmauspAy8oxjHP-tOLtD4KSv3DzI7G6iywTx1ZCExO50GtSuiTB9z0JppvYQ2iUa8s4HbcFanMQfDIlds4da87_Ax4UJMva****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("QueryInfos")]
        [Validation(Required=false)]
        public List<DescribeMountPointsVscAttachInfoRequestQueryInfos> QueryInfos { get; set; }
        public class DescribeMountPointsVscAttachInfoRequestQueryInfos : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>i-2zehyz70ednszl6rrfj6</para>
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
            /// <para>vsc-bp19yqmujug2r18z0h9qal</para>
            /// </summary>
            [NameInMap("VscId")]
            [Validation(Required=false)]
            public string VscId { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("UseAssumeRoleChkServerPerm")]
        [Validation(Required=false)]
        public bool? UseAssumeRoleChkServerPerm { get; set; }

    }

}
