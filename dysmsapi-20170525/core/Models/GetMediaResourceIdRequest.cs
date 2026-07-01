// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dysmsapi20170525.Models
{
    public class GetMediaResourceIdRequest : TeaModel {
        /// <summary>
        /// <para>The extended field.</para>
        /// <remarks>
        /// <para>Required when the resource type is <b>image</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>{\&quot;img_rate\&quot;:\&quot;oneToOne\&quot;}</para>
        /// </summary>
        [NameInMap("ExtendInfo")]
        [Validation(Required=false)]
        public string ExtendInfo { get; set; }

        /// <summary>
        /// <para>The file size. Unit: bytes.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12</para>
        /// </summary>
        [NameInMap("FileSize")]
        [Validation(Required=false)]
        public long? FileSize { get; set; }

        /// <summary>
        /// <para>The description of the uploaded resource.</para>
        /// 
        /// <b>Example:</b>
        /// <para>图片信息</para>
        /// </summary>
        [NameInMap("Memo")]
        [Validation(Required=false)]
        public string Memo { get; set; }

        /// <summary>
        /// <para>The address of the resource to retrieve.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>oss://alicom-fc-media/1947741454322274/alicom-fc-media/pic/202205191526575398603697152.png</para>
        /// </summary>
        [NameInMap("OssKey")]
        [Validation(Required=false)]
        public string OssKey { get; set; }

        /// <summary>
        /// <para>The resource type.</para>
        /// <list type="bullet">
        /// <item><description><b>1</b>: Text</description></item>
        /// <item><description><b>2</b>: Image. Small images must not exceed 100 KB. Large images must not exceed 2 MB. Images must be clear. Supported formats: JPG, JPEG, PNG.</description></item>
        /// <item><description><b>3</b>: Audio</description></item>
        /// <item><description><b>4</b>: Video. Supported format: MP4.<remarks>
        /// <list type="bullet">
        /// <item><description>If the resource type is image, <b>img_rate</b> is required.</description></item>
        /// <item><description>1:1 ratio: oneToOne</description></item>
        /// <item><description>16:9 ratio: sixteenToNine</description></item>
        /// <item><description>3:1 ratio: threeToOne</description></item>
        /// <item><description>48:65 ratio: fortyEightToSixtyFiv.</description></item>
        /// </list>
        /// </remarks>
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
