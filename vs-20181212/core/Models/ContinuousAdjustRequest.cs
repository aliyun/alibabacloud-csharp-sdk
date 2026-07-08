// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vs20181212.Models
{
    public class ContinuousAdjustRequest : TeaModel {
        /// <summary>
        /// <para>Zoom speed parameter. A positive value increases the focal length.<br>Value range: -1.0 to 1.0<br></para>
        /// 
        /// <b>Example:</b>
        /// <para>0.5</para>
        /// </summary>
        [NameInMap("Focus")]
        [Validation(Required=false)]
        public string Focus { get; set; }

        /// <summary>
        /// <para>Device ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>348*****380-cn-qingdao</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        /// <summary>
        /// <para>Aperture speed parameter. A positive value increases the aperture.<br>Value range: -1.0 to 1.0<br></para>
        /// 
        /// <b>Example:</b>
        /// <para>0.5</para>
        /// </summary>
        [NameInMap("Iris")]
        [Validation(Required=false)]
        public string Iris { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

    }

}
