// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class GetImageInfosRequest : TeaModel {
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
        /// <item><description>The image URL expires only if the storage permission is set to private. Otherwise, the URL is permanently valid.</description></item>
        /// <item><description>Minimum value: 1.</description></item>
        /// <item><description>Maximum value: To reduce security risks to the origin server, the maximum value is <b>2592000</b> (30 days) if the image is stored in a bucket managed by ApsaraVideo VOD, and <b>129600</b> (36 hours) if the image is stored in your own OSS bucket.</description></item>
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
        /// <para>The list of image IDs. Separate multiple IDs with commas (,). A maximum of 20 IDs are supported. You can obtain image IDs by using the following methods:</para>
        /// <list type="bullet">
        /// <item><description>Log on to the <a href="https://vod.console.aliyun.com/">ApsaraVideo VOD console</a> and choose <b>Media Files &gt; Images</b> to view the IDs.</description></item>
        /// <item><description>Obtain the IDs from the response when you call <a href="~~CreateUploadImage~~">CreateUploadImage</a> to obtain the upload URL and credential.</description></item>
        /// <item><description>Obtain the IDs from the response when you call <a href="~~SearchMedia~~">SearchMedia</a> to query images.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>bbc65bba53fed90de118a7849****,594228cdd14b4d069fc17a8c4a****</para>
        /// </summary>
        [NameInMap("ImageIds")]
        [Validation(Required=false)]
        public string ImageIds { get; set; }

        /// <summary>
        /// <para>The type of the image access URL to return. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>oss: the storage address.</description></item>
        /// <item><description>cdn (default): the CDN-accelerated URL.</description></item>
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
