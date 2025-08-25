// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imageenhan20190930.Models
{
    public class GenerateCartoonizedImageAdvanceRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>girl</para>
        /// </summary>
        [NameInMap("ImageType")]
        [Validation(Required=false)]
        public string ImageType { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://viapi-test.oss-cn-shanghai.aliyuncs.com/test-team/zhangchaorun/1025.jpg">https://viapi-test.oss-cn-shanghai.aliyuncs.com/test-team/zhangchaorun/1025.jpg</a></para>
        /// </summary>
        [NameInMap("ImageUrl")]
        [Validation(Required=false)]
        public Stream ImageUrlObject { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("Index")]
        [Validation(Required=false)]
        public string Index { get; set; }

    }

}
