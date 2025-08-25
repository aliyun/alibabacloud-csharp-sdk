// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imageenhan20190930.Models
{
    public class ExtendImageStyleAdvanceRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://viapi-test.oss-cn-shanghai.aliyuncs.com/viapi-3.0domepic/imageenhan/ExtendImageStyle/ExtendImageStyle1.jpg">http://viapi-test.oss-cn-shanghai.aliyuncs.com/viapi-3.0domepic/imageenhan/ExtendImageStyle/ExtendImageStyle1.jpg</a></para>
        /// </summary>
        [NameInMap("MajorUrl")]
        [Validation(Required=false)]
        public Stream MajorUrlObject { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://viapi-test.oss-cn-shanghai.aliyuncs.com/viapi-3.0domepic/imageenhan/ExtendImageStyle/ExtendImageStyle6.jpg">http://viapi-test.oss-cn-shanghai.aliyuncs.com/viapi-3.0domepic/imageenhan/ExtendImageStyle/ExtendImageStyle6.jpg</a></para>
        /// </summary>
        [NameInMap("StyleUrl")]
        [Validation(Required=false)]
        public Stream StyleUrlObject { get; set; }

    }

}
