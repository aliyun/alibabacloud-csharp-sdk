// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eds_aic20230930.Models
{
    public class UpdateInstanceImageRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to skip parameter validation. A value of true indicates that validation is skipped. A value of false or an empty value indicates that validation is performed.</para>
        /// </summary>
        [NameInMap("IgnoreParamValidation")]
        [Validation(Required=false)]
        public bool? IgnoreParamValidation { get; set; }

        /// <summary>
        /// <para>The image ID. You can call the <a href="https://help.aliyun.com/document_detail/2807324.html">DescribeImageList</a> operation to query the image list of cloud phones.</para>
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
        /// <para>Specifies whether to reset the instance. A reset clears all user data on the instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("Reset")]
        [Validation(Required=false)]
        public bool? Reset { get; set; }

    }

}
