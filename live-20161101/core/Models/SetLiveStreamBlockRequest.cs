// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class SetLiveStreamBlockRequest : TeaModel {
        /// <summary>
        /// <para>The name of the application to which the live stream belongs. You can view the application name on the <a href="https://help.aliyun.com/document_detail/197397.html">Stream Management</a> page of the ApsaraVideo Live console.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>liveApp****</para>
        /// </summary>
        [NameInMap("AppName")]
        [Validation(Required=false)]
        public string AppName { get; set; }

        /// <summary>
        /// <para>The blocking type. Valid values: blacklist and whitelist.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>blacklist</para>
        /// </summary>
        [NameInMap("BlockType")]
        [Validation(Required=false)]
        public string BlockType { get; set; }

        /// <summary>
        /// <para>The streaming domain.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example.com</para>
        /// </summary>
        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        /// <summary>
        /// <para>The blocked region. If you specify multiple regions, such as CN and AS, separate them with commas (,).</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CN</para>
        /// </summary>
        [NameInMap("LocationList")]
        [Validation(Required=false)]
        public string LocationList { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The time when the blocking ends. The time must be in UTC. If you do not specify this parameter, the blocking is valid for 7 days by default.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2016-06-29T19:00:00Z</para>
        /// </summary>
        [NameInMap("ReleaseTime")]
        [Validation(Required=false)]
        public string ReleaseTime { get; set; }

        /// <summary>
        /// <para>The name of the live stream. You can view the stream name on the <a href="https://help.aliyun.com/document_detail/197397.html">Stream Management</a> page of the ApsaraVideo Live console.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>liveStream****</para>
        /// </summary>
        [NameInMap("StreamName")]
        [Validation(Required=false)]
        public string StreamName { get; set; }

    }

}
