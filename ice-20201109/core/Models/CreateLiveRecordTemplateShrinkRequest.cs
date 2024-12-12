// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class CreateLiveRecordTemplateShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The name of the template.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The list of recording formats.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("RecordFormat")]
        [Validation(Required=false)]
        public string RecordFormatShrink { get; set; }

    }

}
