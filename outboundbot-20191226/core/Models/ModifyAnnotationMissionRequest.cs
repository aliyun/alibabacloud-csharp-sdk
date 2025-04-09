// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OutboundBot20191226.Models
{
    public class ModifyAnnotationMissionRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>c88cc004-de69-4eee-aa5f-2efed533a54e</para>
        /// </summary>
        [NameInMap("AnnotationMissionId")]
        [Validation(Required=false)]
        public string AnnotationMissionId { get; set; }

        [NameInMap("AnnotationMissionName")]
        [Validation(Required=false)]
        public string AnnotationMissionName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("AnnotationStatus")]
        [Validation(Required=false)]
        public int? AnnotationStatus { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("Delete")]
        [Validation(Required=false)]
        public bool? Delete { get; set; }

    }

}
