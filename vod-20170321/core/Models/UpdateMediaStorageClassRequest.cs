// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class UpdateMediaStorageClassRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to change the storage class of a media asset that is stored for less than the minimum storage duration. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b></description></item>
        /// <item><description><b>false</b></description></item>
        /// </list>
        /// <remarks>
        /// <para> If you forcibly change the storage class of a media asset that is stored for less than the minimum storage duration, additional data retrieval fees are incurred.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("AllowUpdateWithoutTimeLimit")]
        [Validation(Required=false)]
        public bool? AllowUpdateWithoutTimeLimit { get; set; }

        /// <summary>
        /// <para>The media asset ID. You can specify a maximum of 20 IDs. Separate multiple IDs with commas (,). You can use one of the following methods to obtain the ID:</para>
        /// <list type="bullet">
        /// <item><description>Log on to the <a href="https://vod.console.aliyun.com">ApsaraVideo VOD</a> console. In the left-side navigation pane, choose <b>Media Files</b> &gt; <b>Audio/Video</b>. On the Video and Audio page, you can view the ID of the media asset. This method is applicable to files that are uploaded by using the ApsaraVideo VOD console.</description></item>
        /// <item><description>Obtain the value of the VideoId parameter from the response to the <a href="https://help.aliyun.com/document_detail/55407.html">CreateUploadVideo</a> operation that you call to upload media assets.</description></item>
        /// <item><description>Obtain the value of the VideoId parameter from the response to the <a href="https://help.aliyun.com/document_detail/86044.html">SearchMedia</a> operation that you call to query the media ID after the media asset is uploaded.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>d56c2ac0cee271ed80004710b5ba****</para>
        /// </summary>
        [NameInMap("MediaIds")]
        [Validation(Required=false)]
        public string MediaIds { get; set; }

        /// <summary>
        /// <para>The restoration priority. This parameter is required only when you restore a Cold Archive media asset. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Expedited</b></description></item>
        /// <item><description><b>Standard</b></description></item>
        /// <item><description><b>Bulk</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Standard</para>
        /// </summary>
        [NameInMap("RestoreTier")]
        [Validation(Required=false)]
        public string RestoreTier { get; set; }

        /// <summary>
        /// <para>The modification range. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>All</b>: modifies the storage classes of all resources including the source files and transcoded streams.</description></item>
        /// <item><description><b>SourceFile</b>: modifies the storage classes of only the source files. The storage class of other resources is Standard.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>All</para>
        /// </summary>
        [NameInMap("Scope")]
        [Validation(Required=false)]
        public string Scope { get; set; }

        /// <summary>
        /// <para>The storage class. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Standard</b></description></item>
        /// <item><description><b>IA</b></description></item>
        /// <item><description><b>Archive</b></description></item>
        /// <item><description><b>ColdArchive</b></description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Archive</para>
        /// </summary>
        [NameInMap("StorageClass")]
        [Validation(Required=false)]
        public string StorageClass { get; set; }

    }

}
