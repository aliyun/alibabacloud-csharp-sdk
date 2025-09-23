// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Objectdet20191230.Models
{
    public class DetectKitchenAnimalsRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://viapi-test.oss-cn-shanghai.aliyuncs.com/viapi-3.0domepic/objectdet/DetectKitchenAnimals/DetectKitchenAnimals-left1.png">http://viapi-test.oss-cn-shanghai.aliyuncs.com/viapi-3.0domepic/objectdet/DetectKitchenAnimals/DetectKitchenAnimals-left1.png</a></para>
        /// </summary>
        [NameInMap("ImageURLA")]
        [Validation(Required=false)]
        public string ImageURLA { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://viapi-test.oss-cn-shanghai.aliyuncs.com/viapi-3.0domepic/objectdet/DetectKitchenAnimals/DetectKitchenAnimals-right1.png">http://viapi-test.oss-cn-shanghai.aliyuncs.com/viapi-3.0domepic/objectdet/DetectKitchenAnimals/DetectKitchenAnimals-right1.png</a></para>
        /// </summary>
        [NameInMap("ImageURLB")]
        [Validation(Required=false)]
        public string ImageURLB { get; set; }

    }

}
