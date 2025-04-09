// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OutboundBot20191226.Models
{
    public class ListAnnotationMissionSessionRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>8434a4b0-41fc-41b1-aa75-bbd1f2ab0c8d</para>
        /// </summary>
        [NameInMap("AnnotationMissionId")]
        [Validation(Required=false)]
        public string AnnotationMissionId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>8434a4b0-41fc-41b1-aa75-bbd1f2ab0c8d</para>
        /// </summary>
        [NameInMap("AnnotationMissionSessionId")]
        [Validation(Required=false)]
        public string AnnotationMissionSessionId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("Environment")]
        [Validation(Required=false)]
        public int? Environment { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>[1]</para>
        /// </summary>
        [NameInMap("IncludeStatusListJsonString")]
        [Validation(Required=false)]
        public string IncludeStatusListJsonString { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("PageIndex")]
        [Validation(Required=false)]
        public int? PageIndex { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

    }

}
