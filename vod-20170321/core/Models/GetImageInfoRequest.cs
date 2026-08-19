// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class GetImageInfoRequest : TeaModel {
        /// <summary>
        /// <para>The validity period of the image access URL. Unit: seconds.</para>
        /// <list type="bullet">
        /// <item><description>If OutputType is set to cdn:<list type="bullet">
        /// <item><description>The image URL expires only if URL signing is enabled. Otherwise, the URL is permanently valid.</description></item>
        /// <item><description>Minimum value: 1.</description></item>
        /// <item><description>Maximum value: unlimited.</description></item>
        /// <item><description>Default value: If this parameter is not specified, the default validity period specified in URL signing is used.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>If OutputType is set to oss:<list type="bullet">
        /// <item><description>The playback URL expires only if the storage permission is set to private. Otherwise, the URL is permanently valid.</description></item>
        /// <item><description>Minimum value: 1.</description></item>
        /// <item><description>Maximum value: To reduce security risks to the origin server, the maximum value is <b>2592000</b> (30 days) if the image is stored in a VOD system bucket, and <b>129600</b> (36 hours) if the image is stored in your own OSS bucket.</description></item>
        /// <item><description>Default value: If this parameter is not specified, the value is 3600.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>3600</para>
        /// </summary>
        [NameInMap("AuthTimeout")]
        [Validation(Required=false)]
        public long? AuthTimeout { get; set; }

        /// <summary>
        /// <para>The image ID. You can obtain the image ID by using one of the following methods:</para>
        /// <list type="bullet">
        /// <item><description>Log on to the <a href="https://vod.console.aliyun.com/">ApsaraVideo VOD console</a> and choose <b>Media Files &gt; Images</b> to view the ID.</description></item>
        /// <item><description>Obtain the ID from the response of the <a href="~~CreateUploadImage~~">CreateUploadImage</a> operation when you retrieve the upload URL and credential.</description></item>
        /// <item><description>Obtain the ID from the response of the <a href="~~SearchMedia~~">SearchMedia</a> operation when you query images.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3e34733b40b9a96ccf5c1ff6f69****</para>
        /// </summary>
        [NameInMap("ImageId")]
        [Validation(Required=false)]
        public string ImageId { get; set; }

        /// <summary>
        /// <para>The type of the image access URL to return. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>oss: the origin URL.</description></item>
        /// <item><description>cdn (default): the accelerated URL.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>cdn</para>
        /// </summary>
        [NameInMap("OutputType")]
        [Validation(Required=false)]
        public string OutputType { get; set; }

    }

}
