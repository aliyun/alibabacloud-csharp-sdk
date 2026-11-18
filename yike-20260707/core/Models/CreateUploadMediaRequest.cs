// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yike20260707.Models
{
    public class CreateUploadMediaRequest : TeaModel {
        /// <summary>
        /// <para>The type of the upload credential. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>STS_TOKEN</c>: the default value. Direct upload by using the OSS SDK.</description></item>
        /// <item><description><c>POST_POLICY</c>: form-based upload.</description></item>
        /// <item><description><c>PRESIGNED_URL</c>: pre-signed PUT URL.</description></item>
        /// <item><description><c>UPLOAD_TICKET</c>: ticket mode. A real credential is issued only when the ticket is exchanged.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>STS_TOKEN</para>
        /// </summary>
        [NameInMap("CredentialType")]
        [Validation(Required=false)]
        public string CredentialType { get; set; }

        /// <summary>
        /// <para>The entity ID. The default value is AiSaasMediaAsset. You can ignore this parameter in common calls.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AiSaasMediaAsset</para>
        /// </summary>
        [NameInMap("EntityId")]
        [Validation(Required=false)]
        public string EntityId { get; set; }

        /// <summary>
        /// <para>The file information, which is a JSON string. This parameter is required when you create a media asset. The <b>Type</b> field is required and can be set to video, audio, or image. The <b>Name</b> (file name), <b>Ext</b> (file name extension without the period), and <b>Size</b> (file size in bytes) fields are optional. This parameter can be omitted when you overwrite an existing media asset (Overwrite=true). If this parameter is omitted, the original media asset type and source file name extension are used.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;Type&quot;:&quot;video&quot;,&quot;Name&quot;:&quot;demo.mp4&quot;,&quot;Ext&quot;:&quot;mp4&quot;,&quot;Size&quot;:10485760}</para>
        /// </summary>
        [NameInMap("FileInfo")]
        [Validation(Required=false)]
        public string FileInfo { get; set; }

        /// <summary>
        /// <para>The ID of the existing media asset. This parameter is required when Overwrite is set to true (overwrite mode). If CredentialType is set to UPLOAD_TICKET, this parameter indicates a ticket exchange. This parameter is not required in other credential modes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>b7e94fc0e*****6e7c5486601</para>
        /// </summary>
        [NameInMap("MediaId")]
        [Validation(Required=false)]
        public string MediaId { get; set; }

        /// <summary>
        /// <para>The metadata of the media asset, which is a JSON string. This parameter is required when you create a media asset. It can contain the following fields: <b>Title</b> (the title; if not specified, FileInfo.Name is used), <b>Description</b>, <b>CateId</b> (the category ID), <b>Tags</b> (comma-separated tags), <b>BusinessType</b> (falls back to general if an invalid value is provided), <b>CoverURL</b>, <b>DynamicMetaData</b> (a JSON string, such as ProductionId), <b>ReferenceId</b> (the external reference ID), and <b>RegisterConfig</b> (an object that contains SearchLibName to specify the search library). This parameter can be omitted when you overwrite an existing media asset.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;Title&quot;:&quot;demo&quot;,&quot;Description&quot;:&quot;test&quot;,&quot;Tags&quot;:&quot;test,demo&quot;,&quot;BusinessType&quot;:&quot;general&quot;,&quot;DynamicMetaData&quot;:&quot;{\&quot;ProductionId\&quot;:\&quot;pd_123456\&quot;}&quot;}</para>
        /// </summary>
        [NameInMap("MediaMetaData")]
        [Validation(Required=false)]
        public string MediaMetaData { get; set; }

        /// <summary>
        /// <para>Specifies whether to overwrite the existing media asset. Default value: false. If this parameter is set to true, you must specify MediaId. The original media asset is reset (old files, snapshots, and analysis results are cleared, and the status is set to uploading), and a new credential is issued as if it were the first upload.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Overwrite")]
        [Validation(Required=false)]
        public bool? Overwrite { get; set; }

        /// <summary>
        /// <para>The project ID. This parameter has the highest priority and is written to dynamicMetaData.ProductionId, overwriting the value with the same name in DynamicMetaData. It is automatically paired with the default folder <c>fd__default</c>. This parameter is supported only by the default entity. If you specify this parameter for a non-default entity, an <c>InvalidParameter</c> error is returned. If this parameter is not specified, <c>ProductionId</c> is obtained from the existing fallback chain.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pd_123456</para>
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public string ProjectId { get; set; }

        /// <summary>
        /// <para>The specified storage location. The format is <c>bucket.endpoint</c>. If this parameter is not specified, the default bucket selection policy is used.</para>
        /// 
        /// <b>Example:</b>
        /// <para>yike-shared-ap-southeast-1-1.oss-ap-southeast-1.aliyuncs.com</para>
        /// </summary>
        [NameInMap("StorageLocation")]
        [Validation(Required=false)]
        public string StorageLocation { get; set; }

        /// <summary>
        /// <para>The custom user data, which is a JSON string.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;bizId&quot;:&quot;order-123&quot;}</para>
        /// </summary>
        [NameInMap("UserData")]
        [Validation(Required=false)]
        public string UserData { get; set; }

    }

}
