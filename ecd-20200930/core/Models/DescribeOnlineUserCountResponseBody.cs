// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class DescribeOnlineUserCountResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("AdAssignedUserCount")]
        [Validation(Required=false)]
        public long? AdAssignedUserCount { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("AssignedUserCount")]
        [Validation(Required=false)]
        public long? AssignedUserCount { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("OnlineUserCount")]
        [Validation(Required=false)]
        public long? OnlineUserCount { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>269BDB16-2CD8-4865-84BD-11C40BC21DB0</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>8</para>
        /// </summary>
        [NameInMap("SimpleAssignedUserCount")]
        [Validation(Required=false)]
        public long? SimpleAssignedUserCount { get; set; }

    }

}
