// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Tdsr20200101.Models
{
    public class PredImageRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("CorrectVertical")]
        [Validation(Required=false)]
        public bool? CorrectVertical { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("CountDetectDoor")]
        [Validation(Required=false)]
        public long? CountDetectDoor { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("DetectDoor")]
        [Validation(Required=false)]
        public bool? DetectDoor { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2345****</para>
        /// </summary>
        [NameInMap("SubSceneId")]
        [Validation(Required=false)]
        public string SubSceneId { get; set; }

    }

}
