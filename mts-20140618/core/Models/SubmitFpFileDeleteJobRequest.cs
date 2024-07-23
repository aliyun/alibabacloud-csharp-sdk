// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mts20140618.Models
{
    public class SubmitFpFileDeleteJobRequest : TeaModel {
        /// <summary>
        /// <para>The IDs of the media files that you want to delete. Separate multiple file IDs with commas (,). You can delete up to 200 media files at a time. You can obtain media file IDs from the response parameters of the <a href="https://help.aliyun.com/document_detail/209266.html">ListFpShotFiles</a> operation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>41e6536e4f2250e2e9bf26cdea19****</para>
        /// </summary>
        [NameInMap("FileIds")]
        [Validation(Required=false)]
        public string FileIds { get; set; }

        /// <summary>
        /// <para>The ID of the media fingerprint library. You can obtain the library ID from the response parameters of the <a href="https://help.aliyun.com/document_detail/170149.html">CreateFpShotDB</a> operation.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>88c6ca184c0e432bbf5b665e2a15****</para>
        /// </summary>
        [NameInMap("FpDBId")]
        [Validation(Required=false)]
        public string FpDBId { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The ID of the ApsaraVideo Media Processing (MPS) queue to which the job is submitted. The MPS queue is bound with a notification method. To view the MPS queue ID, log on to the <b>MPS console</b> and choose <b>Global Settings</b> &gt; <b>MPS queue and Callback</b> in the left-side navigation pane.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ed450ea0bfbd41e29f80a401fb4d****</para>
        /// </summary>
        [NameInMap("PipelineId")]
        [Validation(Required=false)]
        public string PipelineId { get; set; }

        /// <summary>
        /// <para>The primary keys of the files to be deleted. Separate multiple primary keys with commas (,). You can delete up to 200 primary keys at a time. You can obtain the primary keys of media files from the response parameters of the <a href="https://help.aliyun.com/document_detail/209266.html">ListFpShotFiles</a> operation.</para>
        /// <remarks>
        /// <para> This parameter is available only in the China (Beijing), China (Hangzhou), and China (Shanghai) regions.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>24e0fba7188fae707e146esa54****</para>
        /// </summary>
        [NameInMap("PrimaryKeys")]
        [Validation(Required=false)]
        public string PrimaryKeys { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The custom data. The value can contain letters and digits and can be up to 128 bytes in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example data</para>
        /// </summary>
        [NameInMap("UserData")]
        [Validation(Required=false)]
        public string UserData { get; set; }

    }

}
