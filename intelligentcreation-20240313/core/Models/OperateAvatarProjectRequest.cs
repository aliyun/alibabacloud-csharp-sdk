// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IntelligentCreation20240313.Models
{
    public class OperateAvatarProjectRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>DELETE</para>
        /// </summary>
        [NameInMap("operateType")]
        [Validation(Required=false)]
        public string OperateType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>812907463682949120</para>
        /// </summary>
        [NameInMap("projectId")]
        [Validation(Required=false)]
        public string ProjectId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("resChannelNumber")]
        [Validation(Required=false)]
        public int? ResChannelNumber { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>FREE</para>
        /// </summary>
        [NameInMap("resType")]
        [Validation(Required=false)]
        public string ResType { get; set; }

    }

}
