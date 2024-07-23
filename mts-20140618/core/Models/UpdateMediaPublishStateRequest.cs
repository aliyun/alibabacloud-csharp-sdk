// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mts20140618.Models
{
    public class UpdateMediaPublishStateRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the media file whose publishing status you want to update. You can obtain the ID of a media file from the response of the <a href="https://help.aliyun.com/document_detail/44458.html">AddMedia</a> operation. Alternatively, perform the following operations in the ApsaraVideo Media Processing (MPS) console: In the left-side navigation pane, choose <b>Media Management</b> &gt; <b>Media List</b>. Find the required video and click <b>Manage</b>. The ID of the video is displayed on the Basics tab.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3e6149d5a8c944c09b1a8d2dc3e4****</para>
        /// </summary>
        [NameInMap("MediaId")]
        [Validation(Required=false)]
        public string MediaId { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The publishing status. Default value: <b>Initialed</b>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: published.</description></item>
        /// <item><description><b>false</b>: unpublished.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Publish")]
        [Validation(Required=false)]
        public bool? Publish { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

    }

}
