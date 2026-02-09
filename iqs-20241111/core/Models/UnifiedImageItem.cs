// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IQS20241111.Models
{
    public class UnifiedImageItem : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>1330</para>
        /// </summary>
        [NameInMap("height")]
        [Validation(Required=false)]
        public int? Height { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para><a href="http://mbd.baidu.com/newspage/data/dtlandingsuper?nid=dt_4541580238898912926">http://mbd.baidu.com/newspage/data/dtlandingsuper?nid=dt_4541580238898912926</a></para>
        /// </summary>
        [NameInMap("hostPageUrl")]
        [Validation(Required=false)]
        public string HostPageUrl { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para><a href="http://pic.rmb.bdstatic.com/bjh/bb87f566c0c/241218/f7936f25837b20211e5ef88d7980c143.jpeg">http://pic.rmb.bdstatic.com/bjh/bb87f566c0c/241218/f7936f25837b20211e5ef88d7980c143.jpeg</a></para>
        /// </summary>
        [NameInMap("imageUrl")]
        [Validation(Required=false)]
        public string ImageUrl { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2022-07-05T00:54:42+08:00</para>
        /// </summary>
        [NameInMap("publishedTime")]
        [Validation(Required=false)]
        public string PublishedTime { get; set; }

        [NameInMap("title")]
        [Validation(Required=false)]
        public string Title { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1000</para>
        /// </summary>
        [NameInMap("width")]
        [Validation(Required=false)]
        public int? Width { get; set; }

    }

}
