// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class GetEditingProjectMaterialsRequest : TeaModel {
        /// <summary>
        /// <para>The type of the material. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>video</b></description></item>
        /// <item><description><b>audio</b></description></item>
        /// <item><description><b>image</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>video</para>
        /// </summary>
        [NameInMap("MaterialType")]
        [Validation(Required=false)]
        public string MaterialType { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public string OwnerId { get; set; }

        /// <summary>
        /// <para>The ID of the online editing project. You can use one of the following methods to obtain the ID of the online editing project:</para>
        /// <list type="bullet">
        /// <item><description>Log on to the <a href="https://vod.console.aliyun.com">ApsaraVideo VOD console</a>. In the left-side navigation pane, choose <b>Production Center</b> &gt; <b>Video Editing</b> to obtain the ID of the specified online editing project.</description></item>
        /// <item><description>Call the <b>AddEditingProject</b> operation. The value of the response parameter ProjectId is the ID of the specified online editing project.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1982361011093374****</para>
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public string ProjectId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public string ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The type of the material. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>video</b></description></item>
        /// <item><description><b>audio</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>video</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
