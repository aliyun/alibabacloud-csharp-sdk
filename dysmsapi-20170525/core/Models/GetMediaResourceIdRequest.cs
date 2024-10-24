// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dysmsapi20170525.Models
{
    public class GetMediaResourceIdRequest : TeaModel {
        /// <summary>
        /// <para>The extended fields.</para>
        /// <remarks>
        /// <para>If you set the ResourceType parameter to <b>2</b>, this parameter is required.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>{\&quot;img_rate\&quot;:\&quot;oneToOne\&quot;}</para>
        /// </summary>
        [NameInMap("ExtendInfo")]
        [Validation(Required=false)]
        public string ExtendInfo { get; set; }

        /// <summary>
        /// <para>The size of the resource. Unit: bytes.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12</para>
        /// </summary>
        [NameInMap("FileSize")]
        [Validation(Required=false)]
        public long? FileSize { get; set; }

        /// <summary>
        /// <para>The description of the resource.</para>
        /// 
        /// <b>Example:</b>
        /// <para>remark</para>
        /// </summary>
        [NameInMap("Memo")]
        [Validation(Required=false)]
        public string Memo { get; set; }

        /// <summary>
        /// <para>The address of the resource.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>oss://alicom-fc-media/1947741454322274/alicom-fc-media/pic/202205191526575398603697152.png</para>
        /// </summary>
        [NameInMap("OssKey")]
        [Validation(Required=false)]
        public string OssKey { get; set; }

        /// <summary>
        /// <para>The type of the resource.</para>
        /// <list type="bullet">
        /// <item><description><b>1</b>: text.</description></item>
        /// <item><description><b>2</b>: image. A small image cannot exceed 100 KB in size, and a large image cannot exceed 2 MB in size. The image must be clear. Supported format: JPG, JPEG, and PNG.</description></item>
        /// <item><description><b>3</b>: audio.</description></item>
        /// <item><description><b>4</b>: video. Supported format: MP4.</description></item>
        /// </list>
        /// <remarks>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description><para>If you set the ResourceType parameter to 2, the <b>img_rate</b> required is required. Valid values:</para>
        /// </description></item>
        /// <item><description><para>1:1</para>
        /// </description></item>
        /// <item><description><para>16:9</para>
        /// </description></item>
        /// <item><description><para>3:1</para>
        /// </description></item>
        /// <item><description><para>48:65</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public int? ResourceType { get; set; }

    }

}
