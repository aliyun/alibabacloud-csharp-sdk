// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appstream_center20210901.Models
{
    public class SubmitImageRequest : TeaModel {
        /// <summary>
        /// <para>The list of destination regions to which the image is copied.</para>
        /// 
        /// <b>Example:</b>
        /// <para>List</para>
        /// </summary>
        [NameInMap("DestinationRegionList")]
        [Validation(Required=false)]
        public List<string> DestinationRegionList { get; set; }

        /// <summary>
        /// <para>The task ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>tid-be7jzm29wrrz5****</para>
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

    }

}
