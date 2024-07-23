// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mts20140618.Models
{
    public class SubmitFpDBDeleteJobRequest : TeaModel {
        /// <summary>
        /// <para>The operation type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Purge</b>: clears the media fingerprint library. The content in the library is deleted, but the library is not deleted.</description></item>
        /// <item><description><b>Delete</b>: deletes the media fingerprint library. Both the library and its content are deleted.</description></item>
        /// <item><description>Default value: <b>Purge</b>.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Purge</para>
        /// </summary>
        [NameInMap("DelType")]
        [Validation(Required=false)]
        public string DelType { get; set; }

        /// <summary>
        /// <para>The ID of the media fingerprint library. You can obtain the library ID from the response parameters of the <a href="https://help.aliyun.com/document_detail/170149.html">CreateFpShotDB</a> operation.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>88c6ca184c0e47098a5b665e2a12****</para>
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
        /// <para>The ID of the ApsaraVideo Media Processing (MPS) queue. This ID can be used to associate the job with a notification method. To view the MPS queue ID, log on to the <b>MPS console</b> and choose <b>Global Settings</b> &gt; <b>Pipelines</b> in the left-side navigation pane.</para>
        /// 
        /// <b>Example:</b>
        /// <para>fb712a6890464059b1b2ea7c8647****</para>
        /// </summary>
        [NameInMap("PipelineId")]
        [Validation(Required=false)]
        public string PipelineId { get; set; }

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
