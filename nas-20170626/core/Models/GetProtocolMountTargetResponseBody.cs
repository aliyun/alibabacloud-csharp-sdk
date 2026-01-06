// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.NAS20170626.Models
{
    public class GetProtocolMountTargetResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>M18xMA==</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("ProtocolMountTarget")]
        [Validation(Required=false)]
        public GetProtocolMountTargetResponseBodyProtocolMountTarget ProtocolMountTarget { get; set; }
        public class GetProtocolMountTargetResponseBodyProtocolMountTarget : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>DEFAULT_VPC_GROUP_NAME</para>
            /// </summary>
            [NameInMap("AccessGroupName")]
            [Validation(Required=false)]
            public string AccessGroupName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2025-12-22 17:49:25</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>exp-19abf5beab8d****</para>
            /// </summary>
            [NameInMap("ExportId")]
            [Validation(Required=false)]
            public string ExportId { get; set; }

            /// <summary>
            /// <para>Fileset ID。</para>
            /// 
            /// <b>Example:</b>
            /// <para>fset-299b4ca04de8****</para>
            /// </summary>
            [NameInMap("FsetId")]
            [Validation(Required=false)]
            public string FsetId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>/</para>
            /// </summary>
            [NameInMap("Path")]
            [Validation(Required=false)]
            public string Path { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>cpfs-0229cb80bcc0****-x******.cn-*****.cpfs.aliyuncs.com</para>
            /// </summary>
            [NameInMap("ProtocolMountTargetDomain")]
            [Validation(Required=false)]
            public string ProtocolMountTargetDomain { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>NFS</para>
            /// </summary>
            [NameInMap("ProtocolType")]
            [Validation(Required=false)]
            public string ProtocolType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>AVAILABLE</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>vsw-8vb2qjnxs6hiobzve****</para>
            /// </summary>
            [NameInMap("VSwitchId")]
            [Validation(Required=false)]
            public string VSwitchId { get; set; }

            [NameInMap("VSwitchIds")]
            [Validation(Required=false)]
            public List<string> VSwitchIds { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>vpc-bp1h5mxoqfuo3xurf****</para>
            /// </summary>
            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>6299428C-3861-435D-AE54-9B330A00****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
