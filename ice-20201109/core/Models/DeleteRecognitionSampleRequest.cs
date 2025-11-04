// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class DeleteRecognitionSampleRequest : TeaModel {
        /// <summary>
        /// <para>The type of recognition algorithm. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>landmark</description></item>
        /// <item><description>object</description></item>
        /// <item><description>logo</description></item>
        /// <item><description>face</description></item>
        /// <item><description>label</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>landmark</para>
        /// </summary>
        [NameInMap("Algorithm")]
        [Validation(Required=false)]
        public string Algorithm { get; set; }

        /// <summary>
        /// <para>The ID of the entity.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>**<b><b><b><b><b><b>544cb84754</b></b></b></b></b></b></para>
        /// </summary>
        [NameInMap("EntityId")]
        [Validation(Required=false)]
        public string EntityId { get; set; }

        /// <summary>
        /// <para>The ID of the recognition library.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para><em><b><b><b><b><b><b>24b47865c6</b></b></b></b></b></b></em>*</para>
        /// </summary>
        [NameInMap("LibId")]
        [Validation(Required=false)]
        public string LibId { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The ID of the sample that you want to delete.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para><b><b><b><b><b><b><b>4d2ba728e2f</b></b></b></b></b></b></b></para>
        /// </summary>
        [NameInMap("SampleId")]
        [Validation(Required=false)]
        public string SampleId { get; set; }

    }

}
