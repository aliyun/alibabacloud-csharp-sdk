// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class UmountDirectoryRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the directory that you want to remove from the left-side navigation pane of DataAnalysis. This parameter is used together with the TargetType parameter. For example, if you set the TargetType parameter to META_ALBUM, you must set the TargetId parameter to the ID of the metadata data album. You can call the <a href="https://help.aliyun.com/document_detail/469938.html">ListMetaCollections</a> operation to obtain the ID of the data album. The ID is indicated by the QualifiedName parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>album.339</para>
        /// </summary>
        [NameInMap("TargetId")]
        [Validation(Required=false)]
        public string TargetId { get; set; }

        /// <summary>
        /// <para>The type of the directory that you want to remove from the left-side navigation pane of DataAnalysis. Example: META_ALBUM, which indicates the metadata data album.</para>
        /// 
        /// <b>Example:</b>
        /// <para>META_ALBUM</para>
        /// </summary>
        [NameInMap("TargetType")]
        [Validation(Required=false)]
        public string TargetType { get; set; }

        /// <summary>
        /// <para>The ID of the user in the tenant.</para>
        /// <list type="bullet">
        /// <item><description>If you do not configure TargetUserId, the directory belongs to you.</description></item>
        /// <item><description>If you configure TargetUserId, the directory belongs to the user specified by using TargetUserId.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1234567890</para>
        /// </summary>
        [NameInMap("TargetUserId")]
        [Validation(Required=false)]
        public string TargetUserId { get; set; }

    }

}
