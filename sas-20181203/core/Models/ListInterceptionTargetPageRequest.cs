// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ListInterceptionTargetPageRequest : TeaModel {
        /// <summary>
        /// <para>The application name of the network object.</para>
        /// 
        /// <b>Example:</b>
        /// <para>frontend</para>
        /// </summary>
        [NameInMap("AppName")]
        [Validation(Required=false)]
        public string AppName { get; set; }

        /// <summary>
        /// <para>The page number of the page to return. Default value: <b>1</b>, which indicates the first page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <para>The list of images included in the network object.</para>
        /// </summary>
        [NameInMap("ImageList")]
        [Validation(Required=false)]
        public List<string> ImageList { get; set; }

        /// <summary>
        /// <para>The namespace of the network object.</para>
        /// 
        /// <b>Example:</b>
        /// <para>default</para>
        /// </summary>
        [NameInMap("Namespace")]
        [Validation(Required=false)]
        public string Namespace { get; set; }

        /// <summary>
        /// <para>The maximum number of entries per page for paging. Default value: 20. If you leave this parameter empty, 20 entries are returned by default.</para>
        /// <remarks>
        /// <para>Do not leave PageSize empty.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The list of tags included in the network object.</para>
        /// </summary>
        [NameInMap("TagList")]
        [Validation(Required=false)]
        public List<string> TagList { get; set; }

        /// <summary>
        /// <para>The name of the network object.</para>
        /// 
        /// <b>Example:</b>
        /// <para>source-test-obj-0****</para>
        /// </summary>
        [NameInMap("TargetName")]
        [Validation(Required=false)]
        public string TargetName { get; set; }

        /// <summary>
        /// <para>The object type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>IMAGE: image.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>IMAGE</para>
        /// </summary>
        [NameInMap("TargetType")]
        [Validation(Required=false)]
        public string TargetType { get; set; }

    }

}
