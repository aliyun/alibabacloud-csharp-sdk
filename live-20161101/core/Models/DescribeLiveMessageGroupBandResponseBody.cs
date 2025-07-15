// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeLiveMessageGroupBandResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of users that were muted separately, but not by muting the entire group.</para>
        /// </summary>
        [NameInMap("BannedUserList")]
        [Validation(Required=false)]
        public List<string> BannedUserList { get; set; }

        /// <summary>
        /// <para>The group ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>grouptest</para>
        /// </summary>
        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public string GroupId { get; set; }

        /// <summary>
        /// <para>Indicates whether all users in the interactive messaging group are muted.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("IsbannedAll")]
        [Validation(Required=false)]
        public bool? IsbannedAll { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>021D1FE7-2E87-16AC-9364-4E7EA47C****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The list of users who were not muted when the entire group was muted.</para>
        /// </summary>
        [NameInMap("UnbannedUserList")]
        [Validation(Required=false)]
        public List<string> UnbannedUserList { get; set; }

    }

}
