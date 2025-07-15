// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class CreateLiveMessageGroupResponseBody : TeaModel {
        /// <summary>
        /// <para>Indicates whether the group is deleted. If the group existed and is deleted, the group ID is unavailable. We recommend that you create a new group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("AlreadyDelete")]
        [Validation(Required=false)]
        public bool? AlreadyDelete { get; set; }

        /// <summary>
        /// <para>Indicates whether the group already exists.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("AlreadyExists")]
        [Validation(Required=false)]
        public bool? AlreadyExists { get; set; }

        /// <summary>
        /// <para>The ID of the group created.</para>
        /// 
        /// <b>Example:</b>
        /// <para>grouptest</para>
        /// </summary>
        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public string GroupId { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>A8C7B033-B339-1A58-B0E0-7B9197BA****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
