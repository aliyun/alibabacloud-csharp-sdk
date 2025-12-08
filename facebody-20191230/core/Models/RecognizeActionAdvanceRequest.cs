// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Facebody20191230.Models
{
    public class RecognizeActionAdvanceRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public int? Type { get; set; }

        [NameInMap("URLList")]
        [Validation(Required=false)]
        public List<RecognizeActionAdvanceRequestURLList> URLList { get; set; }
        public class RecognizeActionAdvanceRequestURLList : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="http://viapi-test.oss-cn-shanghai.aliyuncs.com/viapi-3.0domepic/facebody/RecognizeAction/1RecognizeAction1.png">http://viapi-test.oss-cn-shanghai.aliyuncs.com/viapi-3.0domepic/facebody/RecognizeAction/1RecognizeAction1.png</a></para>
            /// </summary>
            [NameInMap("URL")]
            [Validation(Required=false)]
            public Stream URLObject { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>/9j/4AAQSkZJRgABAQAAAQABAAD/2wBDAAgGBgcGBQgHBwcJCQgQ****</para>
            /// </summary>
            [NameInMap("imageData")]
            [Validation(Required=false)]
            public string ImageData { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>iVBORw0KGgoAAAANSUhEUgAAAoAAAAHJCAIAAACaEB9NAAEAAElEQVR4nNT9Wb****</para>
        /// </summary>
        [NameInMap("VideoData")]
        [Validation(Required=false)]
        public string VideoData { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para><a href="http://viapi-test.oss-cn-shanghai.aliyuncs.com/viapi-3.0domepic/facebody/RecognizeAction/RecognizeAction-video1.mp4">http://viapi-test.oss-cn-shanghai.aliyuncs.com/viapi-3.0domepic/facebody/RecognizeAction/RecognizeAction-video1.mp4</a></para>
        /// </summary>
        [NameInMap("VideoUrl")]
        [Validation(Required=false)]
        public Stream VideoUrlObject { get; set; }

    }

}
