// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vs20181212.Models
{
    public class StopMoveRequest : TeaModel {
        /// <summary>
        /// <para>The device ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>348*****380-cn-qingdao</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>Specifies whether to stop panning. The default value is false.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Pan")]
        [Validation(Required=false)]
        public bool? Pan { get; set; }

        /// <summary>
        /// <para>Specifies whether to stop tilting. The default value is false.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Tilt")]
        [Validation(Required=false)]
        public bool? Tilt { get; set; }

        /// <summary>
        /// <para>Specifies whether to stop zooming. The default value is false.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Zoom")]
        [Validation(Required=false)]
        public bool? Zoom { get; set; }

    }

}
