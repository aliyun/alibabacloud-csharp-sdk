// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class CreateUploadStreamRequest : TeaModel {
        /// <summary>
        /// <para>The quality of the media stream. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>FD: low definition.</para>
        /// </description></item>
        /// <item><description><para>LD: standard definition.</para>
        /// </description></item>
        /// <item><description><para>SD: high definition.</para>
        /// </description></item>
        /// <item><description><para>HD: ultra-high definition.</para>
        /// </description></item>
        /// <item><description><para>OD: original quality.</para>
        /// </description></item>
        /// <item><description><para>2K: 2K resolution.</para>
        /// </description></item>
        /// <item><description><para>4K: 4K resolution.</para>
        /// </description></item>
        /// <item><description><para>SQ: standard sound quality.</para>
        /// </description></item>
        /// <item><description><para>HQ: high sound quality.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>HD</para>
        /// </summary>
        [NameInMap("Definition")]
        [Validation(Required=false)]
        public string Definition { get; set; }

        /// <summary>
        /// <para>The file name extension of the media stream.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MP4</para>
        /// </summary>
        [NameInMap("FileExtension")]
        [Validation(Required=false)]
        public string FileExtension { get; set; }

        /// <summary>
        /// <para>The high dynamic range (HDR) format of the transcoded stream. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>HDR</para>
        /// </description></item>
        /// <item><description><para>HDR10</para>
        /// </description></item>
        /// <item><description><para>HLG</para>
        /// </description></item>
        /// <item><description><para>DolbyVision</para>
        /// </description></item>
        /// <item><description><para>HDRVivid</para>
        /// </description></item>
        /// <item><description><para>SDR+</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description><para>The value is not case-sensitive,</para>
        /// </description></item>
        /// <item><description><para>You can leave this parameter empty for non-HDR streams.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>HDR10</para>
        /// </summary>
        [NameInMap("HDRType")]
        [Validation(Required=false)]
        public string HDRType { get; set; }

        /// <summary>
        /// <para>The ID of the media asset.</para>
        /// 
        /// <b>Example:</b>
        /// <para><b><b>20b48fb04483915d4f2cd8ac</b></b></para>
        /// </summary>
        [NameInMap("MediaId")]
        [Validation(Required=false)]
        public string MediaId { get; set; }

        /// <summary>
        /// <para>The user data.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;MessageCallback&quot;:{&quot;CallbackURL&quot;:&quot;<a href="http://aliyundoc.com%22%7D">http://aliyundoc.com&quot;}</a>, &quot;Extend&quot;:{&quot;localId&quot;:&quot;xxx&quot;,&quot;test&quot;:&quot;www&quot;}}</para>
        /// </summary>
        [NameInMap("UserData")]
        [Validation(Required=false)]
        public string UserData { get; set; }

    }

}
