// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DeleteSnapshotFilesRequest : TeaModel {
        /// <summary>
        /// <para>The name of the application to which the live stream belongs.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>liveApp****</para>
        /// </summary>
        [NameInMap("AppName")]
        [Validation(Required=false)]
        public string AppName { get; set; }

        /// <summary>
        /// <para>The timestamps when the snapshots that you want to delete were captured.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1653641526637</para>
        /// </summary>
        [NameInMap("CreateTimestampList")]
        [Validation(Required=false)]
        public List<long?> CreateTimestampList { get; set; }

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

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>Specifies whether to also delete the corresponding file in Object Storage Service (OSS) at the same time. Value values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: deletes the corresponding file in OSS.</description></item>
        /// <item><description><b>false</b>: does not delete the corresponding file in OSS.</description></item>
        /// </list>
        /// <remarks>
        /// <para> To delete the corresponding file in OSS, you must have the permissions on the OSS bucket.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("RemoveFile")]
        [Validation(Required=false)]
        public bool? RemoveFile { get; set; }

        /// <summary>
        /// <para>The name of the live stream.</para>
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
