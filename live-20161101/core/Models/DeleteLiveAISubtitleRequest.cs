// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DeleteLiveAISubtitleRequest : TeaModel {
        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the subtitle template.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>445409ec-7eaa-461d-8f29-4bec2eb9****</para>
        /// </summary>
        [NameInMap("SubtitleId")]
        [Validation(Required=false)]
        public string SubtitleId { get; set; }

        /// <summary>
        /// <para>The name of the subtitle template. The name can contain only digits, letters, and hyphens (-). The name cannot start with a hyphen.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sub01</para>
        /// </summary>
        [NameInMap("SubtitleName")]
        [Validation(Required=false)]
        public string SubtitleName { get; set; }

    }

}
