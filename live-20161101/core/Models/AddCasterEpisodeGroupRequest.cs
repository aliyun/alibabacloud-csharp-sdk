// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class AddCasterEpisodeGroupRequest : TeaModel {
        /// <summary>
        /// <para>The callback URL.</para>
        /// <para>If you query the configurations of the production studio by calling the <a href="https://help.aliyun.com/document_detail/2848011.html">DescribeCasterConfig</a> operation, check the value of the response parameter CallbackUrl to obtain the URL.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://developer.aliyundoc.com/caster/4a82a3d1b7f0462ea37348366201****?auth_key=1608953344-0-0-53f0758162964516ac850f2ddc3f">http://developer.aliyundoc.com/caster/4a82a3d1b7f0462ea37348366201****?auth_key=1608953344-0-0-53f0758162964516ac850f2ddc3f</a>****</para>
        /// </summary>
        [NameInMap("CallbackUrl")]
        [Validation(Required=false)]
        public string CallbackUrl { get; set; }

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
        /// <para>The main streaming domain.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example.com</para>
        /// </summary>
        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        /// <summary>
        /// <para>The list of episodes.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Item")]
        [Validation(Required=false)]
        public List<AddCasterEpisodeGroupRequestItem> Item { get; set; }
        public class AddCasterEpisodeGroupRequestItem : TeaModel {
            /// <summary>
            /// <para>The name of the episode.</para>
            /// 
            /// <b>Example:</b>
            /// <para>episode1</para>
            /// </summary>
            [NameInMap("ItemName")]
            [Validation(Required=false)]
            public string ItemName { get; set; }

            /// <summary>
            /// <para>The URL of the VOD file.</para>
            /// <para>If you query the input sources of the production studio by calling the <a href="https://help.aliyun.com/document_detail/2848023.html">DescribeCasterVideoResources</a> operation, check the value of the response parameter VodUrl to obtain the URL.</para>
            /// <remarks>
            /// <para> This parameter takes effect only when the input source is a video file that is not from the media library.\
            /// The video file can be in the MP4, FLV, or TS format.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para><a href="http://learn.aliyundoc.com/caster/4a82a3d1b7f0462ea37348366201****.flv?auth_key=1608953344-0-0-53f0758162964516ac850f2ddc3f">http://learn.aliyundoc.com/caster/4a82a3d1b7f0462ea37348366201****.flv?auth_key=1608953344-0-0-53f0758162964516ac850f2ddc3f</a>****</para>
            /// </summary>
            [NameInMap("VodUrl")]
            [Validation(Required=false)]
            public string VodUrl { get; set; }

        }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The number of times the episode list repeats after the first playback is complete. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: indicates that the episode list is played only once.</description></item>
        /// <item><description><b>-1</b>: indicates that the episode list is played in loop mode.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("RepeatNum")]
        [Validation(Required=false)]
        public int? RepeatNum { get; set; }

        /// <summary>
        /// <para>The custom standby URL.</para>
        /// <para>If this parameter is empty, the ingest address corresponding to the output address automatically generated by Alibaba Cloud will be used by default.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rtmp://guide.aliyundoc.com/caster/4a82a3d1b7f0462ea37348366201****?auth_key=1608953344-0-0-53f0758162964516ac850f2ddc3f****</para>
        /// </summary>
        [NameInMap("SideOutputUrl")]
        [Validation(Required=false)]
        public string SideOutputUrl { get; set; }

        /// <summary>
        /// <para>The time when the episode list starts to play. Specify the time in the ISO 8601 standard in the <em>yyyy-MM-dd</em>T<em>HH:mm:ss</em>Z format. The time must be in UTC.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2018-03-06T19:00:00Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
