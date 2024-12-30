// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pds20220301.Models
{
    public class DeltaGetLastCursorRequest : TeaModel {
        /// <summary>
        /// <para>The drive ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("drive_id")]
        [Validation(Required=false)]
        public string DriveId { get; set; }

        /// <summary>
        /// <para>The ID of the root file of the synced folder.</para>
        /// 
        /// <b>Example:</b>
        /// <para>622fb09598ae66777c7040109a16f49381f6abe1</para>
        /// </summary>
        [NameInMap("sync_root_id")]
        [Validation(Required=false)]
        public string SyncRootId { get; set; }

    }

}
