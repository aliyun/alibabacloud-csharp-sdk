// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class HeadPose : TeaModel {
        /// <summary>
        /// <para>The angel of elevation or depression of the head. Unit: degree. Valid values: -180 to 180. A recommended range for reliable results is from -30 to 30.</para>
        /// 
        /// <b>Example:</b>
        /// <para>18.385589599609375</para>
        /// </summary>
        [NameInMap("Pitch")]
        [Validation(Required=false)]
        public float? Pitch { get; set; }

        /// <summary>
        /// <para>The angle of the tilt to the side. Unit: degree. Valid values: -180 to 180. A recommended range for reliable results is from -45 to 45.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4.204030513763428</para>
        /// </summary>
        [NameInMap("Roll")]
        [Validation(Required=false)]
        public float? Roll { get; set; }

        /// <summary>
        /// <para>The angle of leftward or rightward rotation of the head. Unit: degree. Valid values: -180 to 180. A recommended range for reliable results is from -80 to 80.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2.4945924282073975</para>
        /// </summary>
        [NameInMap("Yaw")]
        [Validation(Required=false)]
        public float? Yaw { get; set; }

    }

}
