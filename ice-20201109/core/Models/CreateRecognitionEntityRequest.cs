// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class CreateRecognitionEntityRequest : TeaModel {
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
        /// <para>The extra information about the custom entity, provided as a JSON string. Max length: 256 bytes.</para>
        /// </summary>
        [NameInMap("EntityInfo")]
        [Validation(Required=false)]
        public string EntityInfo { get; set; }

        /// <summary>
        /// <para>The name of the custom entity. Max length: 64 bytes.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("EntityName")]
        [Validation(Required=false)]
        public string EntityName { get; set; }

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

    }

}
