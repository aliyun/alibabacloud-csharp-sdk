// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vs20181212.Models
{
    public class ContinuousMoveRequest : TeaModel {
        /// <summary>
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
        /// <b>Example:</b>
        /// <para>0.5</para>
        /// </summary>
        [NameInMap("Pan")]
        [Validation(Required=false)]
        public string Pan { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0.5</para>
        /// </summary>
        [NameInMap("Tilt")]
        [Validation(Required=false)]
        public string Tilt { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0.5</para>
        /// </summary>
        [NameInMap("Zoom")]
        [Validation(Required=false)]
        public string Zoom { get; set; }

    }

}
