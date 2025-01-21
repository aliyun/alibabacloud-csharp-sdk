// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class UpdateLivePackageChannelGroupResponseBody : TeaModel {
        [NameInMap("LivePackageChannelGroup")]
        [Validation(Required=false)]
        public UpdateLivePackageChannelGroupResponseBodyLivePackageChannelGroup LivePackageChannelGroup { get; set; }
        public class UpdateLivePackageChannelGroupResponseBodyLivePackageChannelGroup : TeaModel {
            /// <summary>
            /// <para>创建时间</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-04-01T12:00:00Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>描述</para>
            /// 
            /// <b>Example:</b>
            /// <para>Updated description of the channel group.</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>频道组名称</para>
            /// 
            /// <b>Example:</b>
            /// <para>example-group-name</para>
            /// </summary>
            [NameInMap("GroupName")]
            [Validation(Required=false)]
            public string GroupName { get; set; }

            /// <summary>
            /// <para>修改时间</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-04-01T12:00:00Z</para>
            /// </summary>
            [NameInMap("LastModified")]
            [Validation(Required=false)]
            public string LastModified { get; set; }

            /// <summary>
            /// <para>源站域名</para>
            /// 
            /// <b>Example:</b>
            /// <para>example-origin.com</para>
            /// </summary>
            [NameInMap("OriginDomain")]
            [Validation(Required=false)]
            public string OriginDomain { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>request-1234567890</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
