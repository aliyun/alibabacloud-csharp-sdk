// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Tdsr20200101.Models
{
    public class RectVerticalRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("CountDetectDoor")]
        [Validation(Required=false)]
        public int? CountDetectDoor { get; set; }

        /// <summary>
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
        /// <para>1234****</para>
        /// </summary>
        [NameInMap("SubSceneId")]
        [Validation(Required=false)]
        public string SubSceneId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;844946777965268992&quot;:[[0.42418407210144654,0.33625107620738004,0.42620819117478337,0.635753199572695],[0.5158627587152769,0.3071978991900134,0.5177513758740194,0.6312118011104786],[0.582693212445534,0.3733969265933281,0.5807612760319687,0.6139402811250833]]}</para>
        /// </summary>
        [NameInMap("VerticalRect")]
        [Validation(Required=false)]
        public string VerticalRect { get; set; }

    }

}
