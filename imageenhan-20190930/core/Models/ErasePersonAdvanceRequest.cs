// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imageenhan20190930.Models
{
    public class ErasePersonAdvanceRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://viapi-test.oss-cn-shanghai.aliyuncs.com/viapi-3.0domepic/imageenhan/ErasePerson/ErasePerson1.jpg">http://viapi-test.oss-cn-shanghai.aliyuncs.com/viapi-3.0domepic/imageenhan/ErasePerson/ErasePerson1.jpg</a></para>
        /// </summary>
        [NameInMap("ImageURL")]
        [Validation(Required=false)]
        public Stream ImageURLObject { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://viapi-test.oss-cn-shanghai.aliyuncs.com/viapi-3.0domepic/imageenhan/ErasePerson/ErasePerson6.jpg">http://viapi-test.oss-cn-shanghai.aliyuncs.com/viapi-3.0domepic/imageenhan/ErasePerson/ErasePerson6.jpg</a></para>
        /// </summary>
        [NameInMap("UserMask")]
        [Validation(Required=false)]
        public Stream UserMaskObject { get; set; }

    }

}
