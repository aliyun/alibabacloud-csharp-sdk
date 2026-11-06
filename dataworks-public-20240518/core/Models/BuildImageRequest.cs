// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class BuildImageRequest : TeaModel {
        /// <summary>
        /// <para>The compute units (CUs) for the build.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0.5</para>
        /// </summary>
        [NameInMap("Cu")]
        [Validation(Required=false)]
        public double? Cu { get; set; }

        /// <summary>
        /// <para>The image ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Custom_image_xxxx_xxxx</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        /// <summary>
        /// <para>Specifies the image build execution ID, which is used as an idempotence token.</para>
        /// 
        /// <b>Example:</b>
        /// <para>582d4896-d224-413b-b883-239eeebe0bc5</para>
        /// </summary>
        [NameInMap("ProcessId")]
        [Validation(Required=false)]
        public string ProcessId { get; set; }

        /// <summary>
        /// <para>The unique identifier of the resource group.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Serverless_res_group_****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

    }

}
