// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class GetAttachedMediaInfoRequest : TeaModel {
        /// <summary>
        /// <para>The validity period of the auxiliary media asset URL. Unit: seconds.</para>
        /// <list type="bullet">
        /// <item><description>If OutputType is set to <b>cdn</b>:<list type="bullet">
        /// <item><description>The URL expires only if URL authentication is enabled. Otherwise, the URL is permanently valid.</description></item>
        /// <item><description>Minimum value: <b>1</b>.</description></item>
        /// <item><description>Maximum value: unlimited.</description></item>
        /// <item><description>Default value: If you do not specify this parameter, the default validity period specified in URL authentication is used.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>If OutputType is set to <b>oss</b>:<list type="bullet">
        /// <item><description>The URL expires only if the storage permission is set to private. Otherwise, the URL is permanently valid.</description></item>
        /// <item><description>Minimum value: <b>1</b>.</description></item>
        /// <item><description>Maximum value: To reduce security risks to the origin server, the maximum value is <b>2592000</b> (30 days) if the auxiliary media asset is stored in a bucket managed by ApsaraVideo VOD, and <b>129600</b> (36 hours) if the auxiliary media asset is stored in your own OSS bucket.</description></item>
        /// <item><description>Default value: If you do not specify this parameter, the value is <b>3600</b>.</description></item>
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
        /// <para>The auxiliary media asset IDs.</para>
        /// <list type="bullet">
        /// <item><description>Separate multiple IDs with commas (,). You can specify up to 20 IDs.</description></item>
        /// <item><description>The IDs are returned after you call the <a href="~~CreateUploadAttachedMedia~~">CreateUploadAttachedMedia</a> operation to obtain the upload URL and credential for the auxiliary media asset.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>eb1861d2c9a842340e989dd56****,0222e203cf80f9c22870a4d2c****</para>
        /// </summary>
        [NameInMap("MediaIds")]
        [Validation(Required=false)]
        public string MediaIds { get; set; }

        /// <summary>
        /// <para>The type of the output URL. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>oss</b>: the back-to-origin URL.</description></item>
        /// <item><description><b>cdn</b> (default): the CDN-accelerated URL.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>oss</para>
        /// </summary>
        [NameInMap("OutputType")]
        [Validation(Required=false)]
        public string OutputType { get; set; }

    }

}
