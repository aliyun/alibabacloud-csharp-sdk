// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imageenhan20190930.Models
{
    public class ChangeImageSizeResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ChangeImageSizeResponseBodyData Data { get; set; }
        public class ChangeImageSizeResponseBodyData : TeaModel {
            [NameInMap("RetainLocation")]
            [Validation(Required=false)]
            public ChangeImageSizeResponseBodyDataRetainLocation RetainLocation { get; set; }
            public class ChangeImageSizeResponseBodyDataRetainLocation : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>224</para>
                /// </summary>
                [NameInMap("Height")]
                [Validation(Required=false)]
                public int? Height { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>298</para>
                /// </summary>
                [NameInMap("Width")]
                [Validation(Required=false)]
                public int? Width { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("X")]
                [Validation(Required=false)]
                public int? X { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Y")]
                [Validation(Required=false)]
                public int? Y { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="http://ivpd-cn-shanghai.oss-cn-shanghai.aliyuncs.com/upload/result_filter/2019-11-21/invi_filter_015743271470661000112_NVKmET.png?Expires=1574586347&OSSAccessKeyId=LTAI4FeJ8qKkYn6SrHhQ****&Signature=QqRAiqvyXsVlZ77M8yFc5QKJDE">http://ivpd-cn-shanghai.oss-cn-shanghai.aliyuncs.com/upload/result_filter/2019-11-21/invi_filter_015743271470661000112_NVKmET.png?Expires=1574586347&amp;OSSAccessKeyId=LTAI4FeJ8qKkYn6SrHhQ****&amp;Signature=QqRAiqvyXsVlZ77M8yFc5QKJDE</a>****</para>
            /// </summary>
            [NameInMap("Url")]
            [Validation(Required=false)]
            public string Url { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2833446F-A431-40EB-A502-6EC9DFEEEEB0</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
