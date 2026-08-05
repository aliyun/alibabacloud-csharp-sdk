// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class AddCasterEpisodeGroupContentRequest : TeaModel {
        /// <summary>
        /// <para>A client-generated token that is used to ensure the idempotence of the request.</para>
        /// <remarks>
        /// <para>The client generates this value. Make sure that the value is unique among different requests. The value can be up to 64 ASCII characters in length.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8751ad99-2ddb-4aac-ad44-84b21102****</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The properties of the episode in the production studio. This parameter is a JSON string. The parameter names are in upper camel case. The properties are described as follows:</para>
        /// <list type="bullet">
        /// <item><description><para><b>CallbackUrl</b>: The webhook address.</para>
        /// </description></item>
        /// <item><description><para><b>SideOutputUrl</b>: The custom bypass output URL.</para>
        /// </description></item>
        /// <item><description><para><b>RepeatNum</b>: The number of times to loop the episode. A value of 0 means the episode does not loop. A value of -1 means the episode loops indefinitely.</para>
        /// </description></item>
        /// <item><description><para><b>StartTime</b>: The start time in UTC. The format is <em>yyyy-MM-dd</em>T<em>HH:mm:ss</em>Z.</para>
        /// </description></item>
        /// <item><description><para><b>DomainName</b>: The domain name.</para>
        /// </description></item>
        /// <item><description><para><b>Items</b></para>
        /// <para>: The list of items in the episode.</para>
        /// <list type="bullet">
        /// <item><description><para><b>ItemName</b>: The item name.</para>
        /// </description></item>
        /// <item><description><para><b>VodUrl</b>: The URL of the video-on-demand (VOD) file. This parameter is required only when the resource is a video file that has not been imported to the Material Library. The MP4, FLV, and TS formats are supported.</para>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;CallbackUrl&quot;:&quot;<a href="http://example.aliyundoc.com/callBackLive%22,%22SideOutputUrl%22:%22rtmp://guide.aliyundoc.com/caster/4a82a3d1b7f0462ea37348366201****?auth_key=1608953344-0-0-ac8c628078541d7055a170ec59a5****%22,%22DomainName%22:%22developer.aliyundoc.com">http://example.aliyundoc.com/callBackLive&quot;,&quot;SideOutputUrl&quot;:&quot;rtmp://guide.aliyundoc.com/caster/4a82a3d1b7f0462ea37348366201****?auth_key=1608953344-0-0-ac8c628078541d7055a170ec59a5****&quot;,&quot;DomainName&quot;:&quot;developer.aliyundoc.com</a> &quot;,&quot;StartTime&quot;:&quot;2018-03-26T16:00:00Z&quot;,&quot;RepeatNum&quot;:-1,&quot;Items&quot;:[{&quot;ItemName&quot;:&quot;program1&quot;,&quot;VodUrl&quot;:&quot;<a href="http://learn.aliyundoc.com%22%7D,%7B%22ItemName%22:%22program2%22,%22VodUrl%22:%22http://demo.aliyundoc.com%22%7D%5D%7D">http://learn.aliyundoc.com&quot;},{&quot;ItemName&quot;:&quot;program2&quot;,&quot;VodUrl&quot;:&quot;http://demo.aliyundoc.com&quot;}]}</a></para>
        /// </summary>
        [NameInMap("Content")]
        [Validation(Required=false)]
        public string Content { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
