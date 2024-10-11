// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class GetImageInfoRequest : TeaModel {
        /// <summary>
        /// <para>The time when the image URL expires. Unit: seconds.</para>
        /// <list type="bullet">
        /// <item><description><para>If you set OutputType to cdn:</para>
        /// <list type="bullet">
        /// <item><description>This parameter takes effect only if URL authentication is enabled. Otherwise, the image URL does not expire.</description></item>
        /// <item><description>Minimum value: 1.</description></item>
        /// <item><description>Maximum value: unlimited.</description></item>
        /// <item><description>Default value: If you leave this parameter empty, the default validity period that is specified in URL signing is used.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>If you set OutputType to oss:</para>
        /// <list type="bullet">
        /// <item><description>This parameter takes effect only when the ACL of the Object Storage Service (OSS) bucket is private. Otherwise, the image URL does not expire.</description></item>
        /// <item><description>Minimum value: 1.</description></item>
        /// <item><description>If you store the image in the VOD bucket, the maximum value of this parameter is <b>2592000</b> (30 days). If you store the image in an OSS bucket, the maximum value of this parameter is <b>129600</b> (36 hours). The maximum value is limited to reduce security risks of the origin.</description></item>
        /// <item><description>Default value: 3600.</description></item>
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
        /// <para>The ID of the image. You can use one of the following methods to obtain the ID:</para>
        /// <list type="bullet">
        /// <item><description>Log on to the <a href="https://vod.console.aliyun.com/">ApsaraVideo VOD console</a>. In the left-side navigation pane, choose Media Files &gt; Image. On the Image page, view the image ID.</description></item>
        /// <item><description>Obtain the image ID from the response to the <a href="~~CreateUploadImage~~">CreateUploadImage</a> operation that you call to obtain the upload URL and credential.</description></item>
        /// <item><description>Obtain the image ID from the response to the <a href="~~SearchMedia~~">SearchMedia</a> operation that you call to query the image.</description></item>
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
        /// <para>The type of the output image URL. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>oss: OSS URL</description></item>
        /// <item><description>cdn: CDN URL</description></item>
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
