// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth20190307.Models
{
    public class DetectFaceAttributesRequest : TeaModel {
        /// <summary>
        /// <para>The business scenario identifier for the ID Verification service.</para>
        /// 
        /// <b>Example:</b>
        /// <para>RPBasicTest</para>
        /// </summary>
        [NameInMap("BizType")]
        [Validation(Required=false)]
        public string BizType { get; set; }

        /// <summary>
        /// <para>The photo to be detected. For format details, see the notes on uploading image addresses. A maximum of 5 faces can be detected in a single image.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://image-demo.img-cn-hangzhou.aliyuncs.com/example.jpg">http://image-demo.img-cn-hangzhou.aliyuncs.com/example.jpg</a></para>
        /// </summary>
        [NameInMap("MaterialValue")]
        [Validation(Required=false)]
        public string MaterialValue { get; set; }

    }

}
