// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Facebody20191230.Models
{
    public class CompareFaceRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>/9j/4AAQSkZJRgABAQAAAQABAAD/2wBDAAgGBgcGBQgHBwcJCQgK****</para>
        /// </summary>
        [NameInMap("ImageDataA")]
        [Validation(Required=false)]
        public string ImageDataA { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>/9j/4AAQSkZJRgABAQAAAQABAAD/2wBDAAgGBgcGBQgHBwcJCQgQ****</para>
        /// </summary>
        [NameInMap("ImageDataB")]
        [Validation(Required=false)]
        public string ImageDataB { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para><a href="http://viapi-test.oss-cn-shanghai.aliyuncs.com/viapi-3.0domepic/facebody/CompareFace/CompareFace-right1.png">http://viapi-test.oss-cn-shanghai.aliyuncs.com/viapi-3.0domepic/facebody/CompareFace/CompareFace-right1.png</a></para>
        /// </summary>
        [NameInMap("ImageURLA")]
        [Validation(Required=false)]
        public string ImageURLA { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para><a href="http://viapi-test.oss-cn-shanghai.aliyuncs.com/viapi-3.0domepic/facebody/CompareFace/CompareFace-left1.png">http://viapi-test.oss-cn-shanghai.aliyuncs.com/viapi-3.0domepic/facebody/CompareFace/CompareFace-left1.png</a></para>
        /// </summary>
        [NameInMap("ImageURLB")]
        [Validation(Required=false)]
        public string ImageURLB { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>75.12</para>
        /// </summary>
        [NameInMap("QualityScoreThreshold")]
        [Validation(Required=false)]
        public float? QualityScoreThreshold { get; set; }

    }

}
