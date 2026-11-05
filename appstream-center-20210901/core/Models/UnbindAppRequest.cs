// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appstream_center20210901.Models
{
    public class UnbindAppRequest : TeaModel {
        /// <summary>
        /// <para>The list of application IDs to dissociate from the specified image version. Verify that each application is associated with the selected image version.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("AppIdList")]
        [Validation(Required=false)]
        public List<string> AppIdList { get; set; }

        /// <summary>
        /// <para>The ID of the image from which to dissociate the applications. The image must be a custom image or a community image that the current account can manage.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>imgc-bp1example****</para>
        /// </summary>
        [NameInMap("ImageId")]
        [Validation(Required=false)]
        public string ImageId { get; set; }

        /// <summary>
        /// <para>The ID of the image version from which to dissociate the applications. If you omit this parameter, the current effective version of the image is used. If you specify this parameter, it must belong to the image specified by ImageId.</para>
        /// 
        /// <b>Example:</b>
        /// <para>iv-bp1example****</para>
        /// </summary>
        [NameInMap("VersionId")]
        [Validation(Required=false)]
        public string VersionId { get; set; }

    }

}
