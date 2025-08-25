// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imageaudit20191230.Models
{
    public class ScanImageRequest : TeaModel {
        /// <summary>
        /// <para>1</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>porn</para>
        /// </summary>
        [NameInMap("Scene")]
        [Validation(Required=false)]
        public List<string> Scene { get; set; }

        /// <summary>
        /// <para>1</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Task")]
        [Validation(Required=false)]
        public List<ScanImageRequestTask> Task { get; set; }
        public class ScanImageRequestTask : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>uuid-xxxx-xxxx-1234</para>
            /// </summary>
            [NameInMap("DataId")]
            [Validation(Required=false)]
            public string DataId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("ImageTimeMillisecond")]
            [Validation(Required=false)]
            public long? ImageTimeMillisecond { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="http://xxx.xxx.com/xxx.jpg">http://xxx.xxx.com/xxx.jpg</a></para>
            /// </summary>
            [NameInMap("ImageURL")]
            [Validation(Required=false)]
            public string ImageURL { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Interval")]
            [Validation(Required=false)]
            public int? Interval { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("MaxFrames")]
            [Validation(Required=false)]
            public int? MaxFrames { get; set; }

        }

    }

}
