// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class AddMediaMarksRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the media asset.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>53afdf003a2171ed9c6a16b5feac6402</para>
        /// </summary>
        [NameInMap("MediaId")]
        [Validation(Required=false)]
        public string MediaId { get; set; }

        /// <summary>
        /// <para>The mark information. The value must be a JSONArray.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("MediaMarks")]
        [Validation(Required=false)]
        public string MediaMarks { get; set; }

    }

}
