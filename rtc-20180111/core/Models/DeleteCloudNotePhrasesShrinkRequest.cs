// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rtc20180111.Models
{
    public class DeleteCloudNotePhrasesShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the application. You can create and query application IDs in the console. Only a single ID is supported.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ac7N****</para>
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// <para>The hot word table parameters.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Phrase")]
        [Validation(Required=false)]
        public string PhraseShrink { get; set; }

    }

}
