// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class PageImageRegistryRequest : TeaModel {
        /// <summary>
        /// <para>The number of the page to return.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <para>The number of entries to return on each page. Default value: 20.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The name of the image repository. Fuzzy match is supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>asa</para>
        /// </summary>
        [NameInMap("RegistryNameLike")]
        [Validation(Required=false)]
        public string RegistryNameLike { get; set; }

        /// <summary>
        /// <para>The types of image repositories.</para>
        /// </summary>
        [NameInMap("RegistryTypeInList")]
        [Validation(Required=false)]
        public List<string> RegistryTypeInList { get; set; }

        /// <summary>
        /// <para>The types of excluded image repositories.</para>
        /// </summary>
        [NameInMap("RegistryTypeNotInList")]
        [Validation(Required=false)]
        public List<string> RegistryTypeNotInList { get; set; }

        /// <summary>
        /// <para>The source IP address of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>140.207.XXX.XXX</para>
        /// </summary>
        [NameInMap("SourceIp")]
        [Validation(Required=false)]
        public string SourceIp { get; set; }

    }

}
