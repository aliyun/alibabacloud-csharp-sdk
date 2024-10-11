// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class GetAttachedMediaInfoRequest : TeaModel {
        /// <summary>
        /// <para>The validity period of the URL. Unit: seconds.</para>
        /// <list type="bullet">
        /// <item><description><para>If you set the OutputType parameter to <b>cdn</b>:</para>
        /// <list type="bullet">
        /// <item><description>The URL of the auxiliary media asset has a validity period only if URL signing is enabled. Otherwise, the URL of the auxiliary media asset is permanently valid.</description></item>
        /// <item><description>Minimum value: <b>1</b>.</description></item>
        /// <item><description>Maximum value: unlimited.</description></item>
        /// <item><description>Default value: If you do not set this parameter, the default validity period that is specified in URL signing is used.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>If you set the OutputType parameter to <b>oss</b>:</para>
        /// <list type="bullet">
        /// <item><description>The URL of the auxiliary media asset has a validity period only if the permissions on the Object Storage Service (OSS) bucket are private. Otherwise, the URL of the auxiliary media asset is permanently valid.</description></item>
        /// <item><description>Minimum value: <b>1</b>.</description></item>
        /// <item><description>The maximum value for a media asset stored in the VOD bucket is <b>2592000</b> (30 days) and the maximum value for a media asset stored in an OSS bucket is <b>129600</b> (36 hours). The maximum value is limited to reduce security risks of the origin.</description></item>
        /// <item><description>Default value: If you do not set this parameter, the default value <b>3600</b> is used.</description></item>
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
        /// <para>The ID of the auxiliary media asset.</para>
        /// <list type="bullet">
        /// <item><description>Separate multiple IDs with commas (,). You can specify up to 20 IDs.</description></item>
        /// <item><description>You can obtain the ID from the response to the <a href="~~CreateUploadAttachedMedia~~">CreateUploadAttachedMedia</a> operation that you call to obtain the upload URL and credential.</description></item>
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
        /// <para>The type of the media asset URL. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>oss</b></description></item>
        /// <item><description><b>cdn</b> (default)</description></item>
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
