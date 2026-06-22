// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class PageImageRegistryRequest : TeaModel {
        /// <summary>
        /// <para>The page number of the current page in a paged query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <para>The maximum number of entries per page in a paged query. Default value: 20.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The image repository name. Fuzzy match is supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>asa</para>
        /// </summary>
        [NameInMap("RegistryNameLike")]
        [Validation(Required=false)]
        public string RegistryNameLike { get; set; }

        /// <summary>
        /// <para>The list of image repository types to include.</para>
        /// </summary>
        [NameInMap("RegistryTypeInList")]
        [Validation(Required=false)]
        public List<string> RegistryTypeInList { get; set; }

        /// <summary>
        /// <para>The list of image repository types to exclude.</para>
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
