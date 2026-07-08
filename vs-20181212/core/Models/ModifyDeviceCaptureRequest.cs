// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vs20181212.Models
{
    public class ModifyDeviceCaptureRequest : TeaModel {
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
        /// <para>Image capture control. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>0 (shutdown)</para>
        /// </description></item>
        /// <item><description><para>1 (enable)</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("Image")]
        [Validation(Required=false)]
        public int? Image { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>Video recording control. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>0 (shutdown)</para>
        /// </description></item>
        /// <item><description><para>1 (enable short recording)</para>
        /// </description></item>
        /// <item><description><para>2 (enable long recording)</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Video")]
        [Validation(Required=false)]
        public int? Video { get; set; }

    }

}
