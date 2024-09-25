// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth20190307.Models
{
    public class CompareFacesRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>FacePic</para>
        /// </summary>
        [NameInMap("SourceImageType")]
        [Validation(Required=false)]
        public string SourceImageType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>http%3A%2F%2Fjiangsu.china.com.cn%2Fuploadfile%2F2015%2F0114%2F1421221304095989.jpg</para>
        /// </summary>
        [NameInMap("SourceImageValue")]
        [Validation(Required=false)]
        public string SourceImageValue { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>FacePic</para>
        /// </summary>
        [NameInMap("TargetImageType")]
        [Validation(Required=false)]
        public string TargetImageType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>http%3A%2F%2Fjiangsu.china.com.cn%2Fuploadfile%2F2015%2F0114%2F1421221304095989.jpg</para>
        /// </summary>
        [NameInMap("TargetImageValue")]
        [Validation(Required=false)]
        public string TargetImageValue { get; set; }

    }

}
