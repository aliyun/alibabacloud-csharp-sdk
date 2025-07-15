// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class AddCasterEpisodeGroupContentRequest : TeaModel {
        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request.</para>
        /// <para>You can use the client to generate a token, but you must make sure that the token is unique among different requests. The token can contain only ASCII characters and cannot exceed 64 characters in length.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8751ad99-2ddb-4aac-ad44-84b21102****</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The information about the episode list. The value is a JSON string. Use upper camel case for fields of the string. This parameter contains the following fields:</para>
        /// <list type="bullet">
        /// <item><description><para><b>CallbackUrl</b>: the callback URL.</para>
        /// </description></item>
        /// <item><description><para><b>SideOutputUrl</b>: the custom standby URL.</para>
        /// </description></item>
        /// <item><description><para><b>RepeatNum</b>: the number of times the episode list repeats after the first playback is complete. A value of 0 indicates that the episode list is played only once. A value of -1 indicates that the episode list is played in loop mode.</para>
        /// </description></item>
        /// <item><description><para><b>DomainName</b>: the domain name.</para>
        /// </description></item>
        /// <item><description><para><b>StartTime</b>: the time when the episode list starts to play. Specify the time in the ISO 8601 standard in the <em>yyyy-MM-dd</em>T<em>HH:mm:ss</em>Z format. The time must be in UTC.</para>
        /// </description></item>
        /// <item><description><para><b>Items</b>: the information about the episode list. It is an array of ItemName and VodUrl.</para>
        /// <list type="bullet">
        /// <item><description><b>ItemName</b>: the name of the episode.</description></item>
        /// <item><description><b>VodUrl</b>: the URL of the VOD file. This field takes effect only when the video resource is a video file that is not from the media library. The video file must be in the MP4, FLV, or TS format.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CallbackUrl</para>
        /// </summary>
        [NameInMap("Content")]
        [Validation(Required=false)]
        public string Content { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
