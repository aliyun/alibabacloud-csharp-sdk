// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eds_aic20230930.Models
{
    public class DistributeImageRequest : TeaModel {
        /// <summary>
        /// <para>The regions to which you want to distribute an image.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("DistributeRegionList")]
        [Validation(Required=false)]
        public List<string> DistributeRegionList { get; set; }

        /// <summary>
        /// <para>The ID of the image that you want to distribute.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>imgc-075cllfeuazh0****</para>
        /// </summary>
        [NameInMap("ImageId")]
        [Validation(Required=false)]
        public string ImageId { get; set; }

    }

}
