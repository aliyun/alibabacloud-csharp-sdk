// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eds_aic20230930.Models
{
    public class UpdateInstanceImageRequest : TeaModel {
        [NameInMap("IgnoreParamValidation")]
        [Validation(Required=false)]
        public bool? IgnoreParamValidation { get; set; }

        /// <summary>
        /// <para>The ID of the image. Call <a href="t2730769.xdita#"></a>to query the list of images for cloud phones.</para>
        /// 
        /// <b>Example:</b>
        /// <para>imgc-075cllfeuazh0****</para>
        /// </summary>
        [NameInMap("ImageId")]
        [Validation(Required=false)]
        public string ImageId { get; set; }

        /// <summary>
        /// <para>The list of instances.</para>
        /// </summary>
        [NameInMap("InstanceIdList")]
        [Validation(Required=false)]
        public List<string> InstanceIdList { get; set; }

        /// <summary>
        /// <para>Specifies whether to reset the instance. If you reset the instance, all user data on the instance is cleared.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("Reset")]
        [Validation(Required=false)]
        public bool? Reset { get; set; }

    }

}
