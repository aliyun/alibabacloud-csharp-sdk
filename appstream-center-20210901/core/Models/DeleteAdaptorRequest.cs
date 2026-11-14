// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appstream_center20210901.Models
{
    public class DeleteAdaptorRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the application adaptation to be processed. <b>Required</b>. It must point to the same application adaptation as AppId and AppVersionId.</para>
        /// 
        /// <b>Example:</b>
        /// <para>adt-bp1example****</para>
        /// </summary>
        [NameInMap("AdaptorId")]
        [Validation(Required=false)]
        public string AdaptorId { get; set; }

        /// <summary>
        /// <para>The application ID. <b>Required</b>. It must correspond to the same application as AdaptorId.</para>
        /// 
        /// <b>Example:</b>
        /// <para>app-bp1example****</para>
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// <para>The application version ID. <b>Required</b>. It must correspond to the same application version as AdaptorId. This parameter is not the image version ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>apv-bp1example****</para>
        /// </summary>
        [NameInMap("AppVersionId")]
        [Validation(Required=false)]
        public string AppVersionId { get; set; }

        /// <summary>
        /// <para>The ID of the image to be dissociated. <b>Must be provided together with VersionId</b>. If they are not both specified, the adaptation deletion process is initiated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>imgc-bp1example****</para>
        /// </summary>
        [NameInMap("ImageId")]
        [Validation(Required=false)]
        public string ImageId { get; set; }

        /// <summary>
        /// <para>The ID of the image version to be dissociated. It must be provided together with ImageId and belong to the image.</para>
        /// 
        /// <b>Example:</b>
        /// <para>iv-bp1example****</para>
        /// </summary>
        [NameInMap("VersionId")]
        [Validation(Required=false)]
        public string VersionId { get; set; }

    }

}
