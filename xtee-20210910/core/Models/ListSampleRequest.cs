// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Xtee20210910.Models
{
    public class ListSampleRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegId")]
        [Validation(Required=false)]
        public string RegId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>SampleTest</para>
        /// </summary>
        [NameInMap("SampleName")]
        [Validation(Required=false)]
        public string SampleName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>FINANCE</para>
        /// </summary>
        [NameInMap("Tab")]
        [Validation(Required=false)]
        public string Tab { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>SAF_CONSOLE</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2023-03-09 14:45:26</para>
        /// </summary>
        [NameInMap("UploadTimeEnd")]
        [Validation(Required=false)]
        public string UploadTimeEnd { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2023-03-09 14:45:23</para>
        /// </summary>
        [NameInMap("UploadTimeStart")]
        [Validation(Required=false)]
        public string UploadTimeStart { get; set; }

    }

}
