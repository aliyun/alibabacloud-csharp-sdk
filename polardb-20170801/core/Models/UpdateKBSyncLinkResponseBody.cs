// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class UpdateKBSyncLinkResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the synchronization link.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pkbl-xxxxx</para>
        /// </summary>
        [NameInMap("LinkId")]
        [Validation(Required=false)]
        public string LinkId { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>EBEAA83D-1734-42E3-85E3-E25F6E******</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Returns the current configuration, which does not indicate that the synchronization is complete. This parameter may not be returned if it is not set.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SELECTED</para>
        /// </summary>
        [NameInMap("SelectionMode")]
        [Validation(Required=false)]
        public string SelectionMode { get; set; }

        /// <summary>
        /// <para>Returns the current configuration, which does not indicate that the synchronization is complete. This parameter may not be returned if it is not set.</para>
        /// </summary>
        [NameInMap("SelectionRules")]
        [Validation(Required=false)]
        public string SelectionRules { get; set; }

        /// <summary>
        /// <para>The scheduled time of the synchronization task.</para>
        /// </summary>
        [NameInMap("SyncSchedule")]
        [Validation(Required=false)]
        public string SyncSchedule { get; set; }

        /// <summary>
        /// <para>The ID of the asynchronous configuration task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123456</para>
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public int? TaskId { get; set; }

    }

}
